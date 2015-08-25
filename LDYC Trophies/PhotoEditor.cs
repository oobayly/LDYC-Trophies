using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LDYC_Trophies {
  [Docking( DockingBehavior.Ask)]
  public partial class PhotoEditor : EditControl {
    #region Fields
    private byte[] imageData;
    #endregion

    #region Properties
    [Bindable(true)]
    [Category("Data")]
    [DefaultValue("")]
    public string Description {
      get { return txtDescription.Text.Trim(); }
      set { txtDescription.Text = value; }
    }

    [Bindable(true)]
    [Category("Data")]
    [DefaultValue(null)]
    public byte[] ImageData {
      get {
        return imageData;
      }
      set {
        imageData = value;
        OnImageDataChanged();
      }
    }
    #endregion

    #region Constructors
    public PhotoEditor() {
      InitializeComponent();

      ReadOnly = false;
    }
    #endregion

    #region Methods
    private void OnImageDataChanged() {
      if (ImageData == null) {
        if (picImage.Image != null) {
          Image img = picImage.Image;
          picImage.Image = null;
          img.Dispose();
        }
      }

      System.IO.MemoryStream ms = new System.IO.MemoryStream(imageData);
      picImage.Image = Image.FromStream(ms);
    }

    protected override void OnReadOnlyChanged() {
      txtDescription.ReadOnly = ReadOnly;
    }
    #endregion

    #region Event handlers
    private void txt_TextChanged(object sender, EventArgs e) {
      OnPropertyChanged((sender as TextBoxBase).Name.Remove(0, 3));
      IsDirty = true;
    }
    #endregion
  }
}
