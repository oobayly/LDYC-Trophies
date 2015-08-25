using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace LDYC_Trophies {
  public partial class PhotoDialog : Form {
    #region Fields
    private int trophyID;
    #endregion

    #region Properties
    public int TrophyID {
      get { return trophyID; }
      set {
        trophyID = value;
        OnTrophyIDChanged();
      }
    }
    #endregion

    #region Constructors
    public PhotoDialog() {
      InitializeComponent();

      openPhotoDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
    }
    #endregion

    #region Methods
    private void AddPhotos(IEnumerable<Image> images) {
      TrophyDataSet.tblPhotosRow row;

      foreach (Image img in images) {
        row = (tblPhotosBindingSource.AddNew() as DataRowView).Row as TrophyDataSet.tblPhotosRow;
        row.fldCreated = DateTime.Now;
        using (MemoryStream ms = new MemoryStream()) {
          img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
          row.fldData = ms.ToArray();
        }
        row.fldDescription = "";
        row.fldTrophyID = TrophyID;
        tblPhotosBindingSource.CurrencyManager.EndCurrentEdit();

        int changed = tblPhotosTableAdapter.Update(row);
        row.fldPhotoID = GetLastAutoIncrementID("tblPhotos", "fldPhotoID");
        row.AcceptChanges();
      }
    }

    private bool GetImageData(IDataObject data, List<Image> images) {
      if (data.GetDataPresent(DataFormats.Bitmap)) {
        // May simply contain some image data
        if (images != null)
          images.Add((Image)data.GetData(DataFormats.Bitmap));
        return true;

      } else if (data.GetDataPresent(DataFormats.FileDrop)) {
        // May be a list of files
        if (images != null) {
          string[] files = (string[])data.GetData(DataFormats.FileDrop);
          foreach (string f in files) {
            using (Image img = Image.FromFile(f)) {
              images.Add((Image)img.Clone());
            }
          }
        }
        return true;

      } else if (data.GetDataPresent(DataFormats.Text)) {
        // The text data may be a URI
        Uri uri = null;
        try {
          uri = new Uri((string)data.GetData(DataFormats.Text));
        } catch { }

        if (images != null) {
          string tempFile = Path.GetTempFileName();
          try {
            using (WebClient client = new WebClient()) {
              client.DownloadFile(uri, tempFile);
            }

            // Verify that the file is a valid image
            using (Image img = Image.FromFile(tempFile)) {
              images.Add((Image)img.Clone());
            }

          } catch {
            // Tidy up the temp file used to store the image
            File.Delete(tempFile);
            throw;

          }

        }
        return true;

      }

      return false;
    }

    private int GetLastAutoIncrementID(string table, string pk) {
      /* This is messy, but seeing as there's no threading involved and there are no multiple connections
       * it's [probably] impossible that a concurrency issue will occur.
       */
      using (SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.ConnectionString)) {
        using (SqlCeCommand comm = new SqlCeCommand(string.Format("SELECT MAX({0}) FROM {1}", pk, table), conn)) {
          conn.Open();
          int i = (int)comm.ExecuteScalar();
          return i;
        }
      }
    }

    private void OnPhotoPositionChanged() {
      photoEditor.IsDirty = false;

      SetPhotoState();
    }

    private void OnTrophyIDChanged() {
      tblPhotosTableAdapter.FillByTrophy(trophyDataSet.tblPhotos, TrophyID);
    }

    private void SetPhotoState() {
      bool isDirty = photoEditor.IsDirty;
      bool hasPhoto = (tblPhotosBindingSource.Position != -1);

      photoEditor.Enabled = hasPhoto;

      butCommit.Enabled = butReject.Enabled = hasPhoto && isDirty;
      butDelete.Enabled = hasPhoto && !isDirty;
    }
    #endregion

    #region Event handlers
    private void butDelete_Click(object sender, EventArgs e) {
      DialogResult res = MessageBox.Show(this, "Are you sure you want to delete this photo?",
        Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.No)
        return;

      this.tblPhotosBindingSource.RemoveCurrent();
      this.tblPhotosTableAdapter.Update(this.trophyDataSet.tblPhotos);

      OnPhotoPositionChanged();

    }

    private void butOpen_Click(object sender, EventArgs e) {
      if (openPhotoDialog.ShowDialog(this) != DialogResult.OK)
        return;

      List<Image> images = new List<Image>();
      foreach (string f in openPhotoDialog.FileNames) {
        try {
          images.Add(Image.FromFile(f));

        }catch (FileNotFoundException ex) {
          MessageBox.Show(this, ex.Message, Application.ProductName,
            MessageBoxButtons.OK, MessageBoxIcon.Error);

        } catch (OutOfMemoryException) {
          MessageBox.Show(this,
            string.Format("'{0}' is not a valid image.", f), Application.ProductName,
            MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
      }
      AddPhotos(images);

      foreach (Image img in images) {
        img.Dispose();
      }
    }

    private void butPaste_Click(object sender, EventArgs e) {
      if (!Clipboard.ContainsImage())
        return;

      using (Image img = Clipboard.GetImage()) {
        AddPhotos(new Image[] { img });
      }
    }

    private void listImages_DragEnter(object sender, DragEventArgs e) {
      if (GetImageData(e.Data, null))
        e.Effect = DragDropEffects.Copy;
    }

    private void listImages_DragDrop(object sender, DragEventArgs e) {
      List<Image> images = new List<Image>();
      try {
        GetImageData(e.Data, images);

      }catch (OutOfMemoryException) {
        MessageBox.Show(this, "The dropped file isn't a valid image.", Application.ProductName,
          MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;

      }catch (WebException ex) {
        string message;
        if (ex.Response == null) {
          message = "The file couldn't be downloaded.\n" + ex.Message;

        } else if (ex.Response is HttpWebResponse) {
          HttpWebResponse resp = ex.Response as HttpWebResponse;
          message = string.Format("The file couldn't be downloaded.\nThe remote server returned {0:d} - {1}",
            resp.StatusCode, resp.StatusDescription);

        } else {
          message = "The file couldn't be downloaded.\n" + ex.Message;

        }
        MessageBox.Show(this, message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;

      } catch (Exception ex) {
        MessageBox.Show(this,
          "An unexpected error occurred retrieving the image.\n" + ex.Message,
          Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;

      }

      AddPhotos(images);

      foreach (Image img in images) {
        img.Dispose();
      }
    }

    private void PhotoDialog_Load(object sender, EventArgs e) {
      OnPhotoPositionChanged();
    }

    private void photoEditor_IsDirtyChanged(object sender, EventArgs e) {
      SetPhotoState();
    }

    private void tblPhotosBindingSource_PositionChanged(object sender, EventArgs e) {
      OnPhotoPositionChanged();
    }
    #endregion
  }
}
