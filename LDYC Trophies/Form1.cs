using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LDYC_Trophies {
  public partial class Form1 : Form {
    #region Constants
    /// <summary>
    /// The list of tables contained in the database, in order of how data should be imported
    /// to avoid FK contraint problems.
    /// </summary>
    private static readonly string[] TableNames = new string[] {
      "tblClasses", "tblTrophies", "tblWinners", "tblPhotos"
    };
    #endregion

    #region Properties
    private int CurrentClassID {
      get {
        return ((tblTrophiesBindingSource.Current as DataRowView).Row as TrophyDataSet.tblTrophiesRow).fldCurrentClassID;
      }
    }
    
    private int CurrentTrophyID {
      get {
        return ((tblTrophiesBindingSource.Current as DataRowView).Row as TrophyDataSet.tblTrophiesRow).fldTrophyID;
      }
    }

    private string DatabaseLocation {
      get {
        string dataDir;
        try {
          dataDir = ApplicationDeployment.CurrentDeployment.DataDirectory;
        } catch {
          dataDir = AppDomain.CurrentDomain.BaseDirectory;
        }

        return tblClassesTableAdapter.Connection.Database.Replace("|DataDirectory|", dataDir);
      }
    }
    #endregion

    #region Constructors
    public Form1() {
      InitializeComponent();

      switch (Properties.Settings.Default.Form1WindowState) {
        case FormWindowState.Maximized:
          this.WindowState = FormWindowState.Maximized;
          break;

        case FormWindowState.Normal:
          Size s = Properties.Settings.Default.Form1Size;
          if (!s.IsEmpty) {
            this.Size = s;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = Properties.Settings.Default.Form1Location;
          }
          break;
      }

      float splitterRatio = Properties.Settings.Default.Form1SplitterRatio;
      if (splitterRatio != 0) {
        splitter.SplitterDistance = (int)(splitterRatio *splitter.Width);
      }
    }
    #endregion

    #region Methods
    private bool Backup() {
      dlgBackup.FileName = string.Format("LDYC Trophies - {0:yyyy-MM-dd}.sdf", DateTime.Today);
      if (dlgBackup.ShowDialog(this) == DialogResult.Cancel)
        return false;

      try {
        File.Copy(DatabaseLocation, dlgBackup.FileName, true);
        return true;

      } catch (System.IO.IOException ex) {
        MessageBox.Show(this,
          string.Format("An error occurred backuping up the database:\n\t{0}", ex.Message),
          Application.ProductName,
          MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;

      }
    }

    private void CreateReport() {
      CreateReport( -1);
    }

    private void CreateReport(int trophyID) {
      try {
        using (ReportCreator report = new ReportCreator()) {
          FileInfo fi = report.GenerateTrophyReport(trophyID);
          System.Diagnostics.Process.Start(fi.FullName);
        }
      } catch (IOException ex) {
        MessageBox.Show(this,
          string.Format("A problem occurred generating the report:\n{0}", ex.Message),
          Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

      } catch (System.ComponentModel.Win32Exception ex) {
        MessageBox.Show(this,
          string.Format("The PDF couldn't be opened:\n{0}", ex.Message),
          Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

      }
    }

    private object GetDefault(Type t) {
      if (t == typeof(string)) {
        return "";
      } else if (t.IsValueType) {
        return Activator.CreateInstance(t);
      } else {
        return t.GetConstructor(Type.EmptyTypes).Invoke(null);
      }
    }

    private int GetLastAutoIncrementID(string table, string pk) {
      /* This is messy, but seeing as there's no threading involved and there are no multiple connections
       * it's [probably] impossible that a concurrency issue will occur.
       */
      using (SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.ConnectionString)) {
        conn.Open();
        using (SqlCeCommand comm = new SqlCeCommand()) {
          comm.CommandText = string.Format("SELECT TOP(1) {0} FROM {1} ORDER BY [fldCreated] DESC", pk, table);
          comm.Connection = conn;
          int i = (int)comm.ExecuteScalar();
          return i;
        }
      }
    }

    private SqlCeCommand GetInsertCommand(DataTable table) {
      SqlCeCommand comm =new SqlCeCommand();

      System.Text.StringBuilder sb = new System.Text.StringBuilder();
      System.Text.StringBuilder sbParams = new System.Text.StringBuilder(" VALUES(");

      sb.AppendFormat("INSERT INTO {0}(", table.TableName);

      for (int i = 0; i < table.Columns.Count; i++) {
        DataColumn col = table.Columns[i];

        if (i > 0) {
          sb.Append(", ");
          sbParams.Append(", ");
        }

        sb.AppendFormat("{0}", col.ColumnName);
        sbParams.AppendFormat("@{0}", col.ColumnName);

        SqlCeParameter param = new SqlCeParameter(col.ColumnName, GetSqlDbType(col.DataType));
        param.IsNullable = col.AllowDBNull;
        param.SourceColumn = col.ColumnName;

        comm.Parameters.Add(param);
      }

      sb.Append(")");
      sbParams.Append(")");

      comm.CommandText = sb.ToString() + sbParams.ToString();

      return comm;
    }

    private SqlDbType GetSqlDbType(Type t) {
      if (t == typeof(string)) {
        return SqlDbType.NText;

      } else if (t == typeof(byte)) {
        return SqlDbType.TinyInt;

      }else if (t == typeof(short)) {
        return SqlDbType.SmallInt;

      } else if (t == typeof(int)) {
        return SqlDbType.Int;

      } else if (t == typeof(long)) {
        return SqlDbType.BigInt;

      } else if (t == typeof(byte[])) {
        return SqlDbType.Binary;

      } else if (t == typeof(DateTime)) {
        return SqlDbType.DateTime;
   
      }else {
        throw new ArgumentException(string.Format("Type {0} is not handled", t));

      }
    }

    private void OnEditCurrentWinner() {
      TrophyDataSet.tblWinnersRow row = ((tblWinnersBindingSource.Current as DataRowView).Row as TrophyDataSet.tblWinnersRow);

      using (EditWinnerDialog dlg = new EditWinnerDialog()) {
        dlg.ClassID = row.fldClassID;
        dlg.Crew = row.fldCrew;
        dlg.Helm = row.fldHelm;
        dlg.Notes = row.fldNotes;
        dlg.Owner = row.fldOwner;
        dlg.SailNumber = row.fldSailNumber;
        dlg.Year = row.fldYear;

        if (dlg.ShowDialog(this) != DialogResult.OK)
          return;

        row.fldClassID = dlg.ClassID;
        row.fldCrew = dlg.Crew;
        row.fldHelm = dlg.Helm;
        row.fldModified = DateTime.Now;
        row.fldOwner = dlg.Owner;
        row.fldNotes = dlg.Notes;
        row.fldSailNumber = dlg.SailNumber;
        row.fldYear = dlg.Year;

        tblWinnersBindingSource.CurrencyManager.EndCurrentEdit();
        tblWinnersTableAdapter.Update(trophyDataSet.tblWinners);
      }
    }

    private void OnTrophyFilter() {
      tblTrophiesBindingSource.PositionChanged -= tblTrophiesBindingSource_PositionChanged;
      trophyEditor1.IsDirtyChanged -= trophyEditor1_IsDirtyChanged;

      tblTrophiesBindingSource.Filter = string.Format("[fldName] LIKE '*{0}*'",
        txtFilterTrophies.Text.Trim().Replace("'", "''"));

      tblTrophiesBindingSource.PositionChanged -= tblTrophiesBindingSource_PositionChanged;
      trophyEditor1.IsDirtyChanged -= trophyEditor1_IsDirtyChanged;

      OnTrophyPositionChanged();
    }

    private void OnTrophyPositionChanged() {
      trophyEditor1.IsDirty = false;

      int trophyID = (tblTrophiesBindingSource.Position != -1) ? CurrentTrophyID : -1;
      this.tblWinnersTableAdapter.FillByTrophy(this.trophyDataSet.tblWinners, trophyID);

      SetTrophyState();
      OnWinnerPositionChanged();

      /* The grid loses focus due to its enabled state being changed, so reset focus to it
       * This however will fail if a new row has been added, if so, the set focus to the trophy editor
       */
      BeginInvoke(new MethodInvoker(delegate {
        try {
          gridTrophies.Focus();
        } catch {
          trophyEditor1.Focus();
        }
      }));
    }

    private void OnWinnerPositionChanged() {
      SetWinnerState();
    }

//    private void RestoreDatabase(SqlCeConnection srcConn, SqlCeConnection trgConn) {
//      //using (SqlCeTransaction trans = trgConn.BeginTransaction()) {
//      SqlCeTransaction trans = null;
//        // Each of the tables should be cleared in reverse order to avoid FK issues
//        for (int i = TableNames.Length - 1; i >= 0; i--) {
//          using (SqlCeCommand comm = new SqlCeCommand(string.Format("DELETE FROM {0}", TableNames[i]), trgConn)) {
//            comm.Transaction = trans;
//            int changed = comm.ExecuteNonQuery();
//#if DEBUG
//            System.Diagnostics.Debug.WriteLine(string.Format("{0} records deleted from {1}", changed, TableNames[i]));
//#endif
//          }
//        }

//        foreach (string table in TableNames) {
//          RestoreTable(srcConn, trgConn, trans, table);
//        }

//      //  trans.Commit();
//      //}
//    }

//    private void RestoreTable(SqlCeConnection srcConn, SqlCeConnection trgConn, SqlCeTransaction trans, string table) {
//      // Fetch all the backed up data
//      DataTable sourceData = new DataTable();
//      using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(string.Format("SELECT * FROM {0}", table), srcConn)) {
//        adapter.Fill(sourceData);
//      }

//      // Target data
//      DataTable targetData = new DataTable(table);
//      using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(string.Format("SELECT * FROM {0}", table), trgConn)) {
//        adapter.Fill(targetData);

//        // Build the insert command
//        adapter.InsertCommand = GetInsertCommand(targetData);
//        adapter.InsertCommand.Connection = trgConn;
//        adapter.InsertCommand.Transaction = trans;

//        foreach (DataRow src in sourceData.Rows) {
//          DataRow trg = targetData.NewRow();

//          foreach (DataColumn col in targetData.Columns) {
//            if (sourceData.Columns.Contains(col.ColumnName)) {
//              trg[col] = src[col.ColumnName];

//            }else {
//              trg[col] = GetDefault(col.DataType);

//            }
//          }
//          targetData.Rows.Add(trg);
//        }

//        // We need to be allowed to insert the record with the original auto incremented PK
//        using (SqlCeCommand comm = new SqlCeCommand(string.Format("SET IDENTITY_INSERT {0} ON", table), trgConn)) {
//          comm.Transaction = trans;
//          comm.ExecuteNonQuery();
//        }

//        int changed = adapter.Update(targetData);
//#if DEBUG
//        System.Diagnostics.Debug.WriteLine(string.Format("{0} records inserted into {1}", changed, table));
//#endif

//        using (SqlCeCommand comm = new SqlCeCommand(string.Format("SET IDENTITY_INSERT {0} OFF", table), trgConn)) {
//          comm.Transaction = trans;
//          comm.ExecuteNonQuery();
//        }
//      }

//    }

    private void SetTrophyState() {
      bool dirty = trophyEditor1.IsDirty;
      bool hasTrophy = (tblTrophiesBindingSource.Position != -1);

      groupTrophyInfo.Enabled = hasTrophy;

      // Cannot filter, add or select another trophy when dirty
      gridTrophies.Enabled = !dirty;
      txtFilterTrophies.Enabled = !dirty;
      butAddTrophy.Enabled = !dirty;

      // Can only commit or reject changes when dirty
      butCommitChanges.Enabled = butRejectChanges.Enabled = dirty;

      // Can't delete or edit photos when dirty
      butDeleteTrophy.Enabled = butTrophyPhotos.Enabled = !dirty;

    }

    private void SetWinnerState() {
      bool hasTrophy = (tblTrophiesBindingSource.Position != -1);
      bool hasWinner = (tblWinnersBindingSource.Position != -1);
      bool dirty = trophyEditor1.IsDirty;

      // Winner group is only enabled when a trophy is selected and not being edited
      groupWinners.Enabled = hasTrophy && !dirty;

      // Can only edit or delete when a winner is selected
      butEditWinner.Enabled = butDeleteWinner.Enabled = hasWinner;
    }
    #endregion

    #region Event handlers
    private void butAbout_Click(object sender, EventArgs e) {
      using (AboutBox1 dlg = new AboutBox1()) {
        dlg.ShowDialog(this);
      }
    }
    
    private void butAddTrophy_Click(object sender, EventArgs e) {
      // Filter needs to be removed so that the new trophy is sure to be displayed
      txtFilterTrophies.Clear();

      // Defaults need to be set as they may stay null if not changed in the editor
      TrophyDataSet.tblTrophiesRow row = ((tblTrophiesBindingSource.AddNew() as DataRowView).Row as TrophyDataSet.tblTrophiesRow);
      row.fldConditions = string.Empty;
      row.fldCreated = DateTime.Now;
      row.fldCurrentClassID = 1;
      row.fldDetails = string.Empty;
      row.fldDonor = string.Empty;
      row.fldName = string.Empty;
      row.fldRedBookPage = 0;
      row.fldYearDonated = (short)DateTime.Now.Year;

      trophyEditor1.IsDirty = true;
    }

    private void butAddWinner_Click(object sender, EventArgs e) {
      using (EditWinnerDialog dlg = new EditWinnerDialog()) {
        dlg.ClassID = CurrentClassID;
        dlg.Year = (short)DateTime.Now.Year;

        if (dlg.ShowDialog(this) != DialogResult.OK)
          return;

        TrophyDataSet.tblWinnersRow row = ((tblWinnersBindingSource.AddNew() as DataRowView).Row as TrophyDataSet.tblWinnersRow);
        row.fldClassID = dlg.ClassID;
        row.fldCreated = DateTime.Now;
        row.fldCrew = dlg.Crew;
        row.fldHelm = dlg.Helm;
        row.fldNotes = dlg.Notes;
        row.fldOwner = dlg.Owner;
        row.fldSailNumber = dlg.SailNumber;
        row.fldTrophyID = CurrentTrophyID;
        row.fldYear = dlg.Year;

        tblWinnersBindingSource.CurrencyManager.EndCurrentEdit();
        tblWinnersTableAdapter.Update(trophyDataSet.tblWinners);

        row.fldWinnerID = GetLastAutoIncrementID("tblWinners", "fldWinnerID");
        row.AcceptChanges();
      }
    }

    private void butBackup_Click(object sender, EventArgs e) {
      Backup();
    }

    private void butCommitChanges_Click(object sender, EventArgs e) {
      // Validation
      if (trophyEditor1.TrophyName.Length == 0) {
        MessageBox.Show(this, "The trophy name is required.",
          Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (trophyEditor1.Donor.Length == 0) {
        MessageBox.Show(this, "The donor is required.",
          Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (trophyEditor1.YearDonated.Length == 0) {
        MessageBox.Show(this, "The donation year is required.",
          Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      TrophyDataSet.tblTrophiesRow row = ((tblTrophiesBindingSource.Current as DataRowView).Row as TrophyDataSet.tblTrophiesRow);
      this.tblTrophiesBindingSource.CurrencyManager.EndCurrentEdit();

      bool isNew = (row.RowState == DataRowState.Added);

      if (!isNew) {
        row.fldModified = DateTime.Now;
      }

      this.tblTrophiesTableAdapter.Update(this.trophyDataSet.tblTrophies);

      if (isNew) {
        row.fldTrophyID = GetLastAutoIncrementID("tblTrophies", "fldTrophyID");
        row.AcceptChanges();

        int i = 0;
        foreach (DataRowView r in tblTrophiesBindingSource.List) {
          if ((r.Row as TrophyDataSet.tblTrophiesRow).fldTrophyID == row.fldTrophyID) {
            tblTrophiesBindingSource.Position = i;
            break;
          }
          i++;
        }
      }

      OnTrophyPositionChanged();
    }

    private void butDeleteTrophy_Click(object sender, EventArgs e) {
      int trophyID = CurrentTrophyID;

      // Cannot delete if there are winners
      if ((int)tblWinnersTableAdapter.GetWinnerCountByTrophy(trophyID) > 0) {
        MessageBox.Show(this, "A trophy cannot be deleted if it has any winners.",
          Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      // Cannot delete if there are photos
      using (TrophyDataSetTableAdapters.tblPhotosTableAdapter adapter = new LDYC_Trophies.TrophyDataSetTableAdapters.tblPhotosTableAdapter()) {
        if ((int)adapter.GetPhotoCountByTrophy(trophyID) > 0) {
          MessageBox.Show(this, "A trophy cannot be deleted if it has any photos.",
            Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }
      }

      DialogResult res = MessageBox.Show(this, "Are you sure you want to delete this trophy?",
        Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.No)
        return;

      this.tblTrophiesBindingSource.RemoveCurrent();
      this.tblTrophiesTableAdapter.Update(this.trophyDataSet.tblTrophies);

      OnTrophyPositionChanged();
    }

    private void butDeleteWinner_Click(object sender, EventArgs e) {
      DialogResult res = MessageBox.Show(this, "Are you sure you want to delete this winner?",
        Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.No)
        return;

      this.tblWinnersBindingSource.RemoveCurrent();
      this.tblWinnersTableAdapter.Update(this.trophyDataSet.tblWinners);

      OnWinnerPositionChanged();
    }

    private void butEditClasses_Click(object sender, EventArgs e) {
      if (trophyEditor1.IsDirty) {
        MessageBox.Show(this, "Classes cannot be modified while a Trophy is being edited.", Application.ProductName,
          MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      using (EditClassesDialog dlg = new EditClassesDialog()) {
        if (dlg.ShowDialog(this) == DialogResult.Cancel)
          return;

        tblClassesTableAdapter.Fill(trophyDataSet.tblClasses);
        trophyEditor1.ReloadClasses();
      }
    }

    private void butEditWinner_Click(object sender, EventArgs e) {
      OnEditCurrentWinner();
    }

    private void butRejectChanges_Click(object sender, EventArgs e) {
      DialogResult res = MessageBox.Show(this, "Are you sure you want to reject any changes made to the trophy?",
        Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.No)
        return;

      this.tblTrophiesBindingSource.CurrencyManager.CancelCurrentEdit();

      OnTrophyPositionChanged();
    }

    private void butReport_Click(object sender, EventArgs e) {
      CreateReport();
    }

    private void butRestore_Click(object sender, EventArgs e) {
      DialogResult res = MessageBox.Show(this,
        "All existing data will be replaced. Are you sure you want to continue?",
        Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
      if (res == DialogResult.No)
        return;

      if (dlgRestore.ShowDialog(this) == DialogResult.Cancel)
        return;

      try {
        File.Copy(dlgRestore.FileName, DatabaseLocation, true);
        //using (SqlCeConnection trg = new SqlCeConnection(tblTrophiesTableAdapter.Connection.ConnectionString)) {
        //  trg.Open();
        //  using (SqlCeConnection src = new SqlCeConnection(string.Format("Data Source=\"{0}\"", dlgRestore.FileName))) {
        //    src.Open();

        //    RestoreDatabase(src, trg);
        //  }
        //}

      } catch (IOException ex) {
        MessageBox.Show(this,
          string.Format("An error occurred opening the database:\n\t{0}", ex.Message),
          Application.ProductName,
          MessageBoxButtons.OK, MessageBoxIcon.Error);

      } catch (SqlCeException ex) {
        MessageBox.Show(this,
          string.Format("An error occurred opening the database:\n\t{0}", ex.Message),
          Application.ProductName,
          MessageBoxButtons.OK, MessageBoxIcon.Error);

      }

      tblTrophiesBindingSource.PositionChanged -= tblTrophiesBindingSource_PositionChanged;
      tblWinnersBindingSource.PositionChanged -= tblWinnersBindingSource_PositionChanged;

      this.tblClassesTableAdapter.Fill(this.trophyDataSet.tblClasses);
      this.tblTrophiesTableAdapter.Fill(this.trophyDataSet.tblTrophies);
      this.tblWinnersTableAdapter.FillByTrophy(this.trophyDataSet.tblWinners, -1);

      tblTrophiesBindingSource.PositionChanged += tblTrophiesBindingSource_PositionChanged;
      tblWinnersBindingSource.PositionChanged += tblWinnersBindingSource_PositionChanged;

      OnTrophyPositionChanged();
    }

    private void butTrophyPhotos_Click(object sender, EventArgs e) {
      using (PhotoDialog dlg = new PhotoDialog() { TrophyID = CurrentTrophyID }) {
        dlg.ShowDialog(this);
      }
    }

    private void butTrophyReport_Click(object sender, EventArgs e) {
      CreateReport(CurrentTrophyID);
    }

    private void butUpdate_Click(object sender, EventArgs e) {
      if (!ApplicationDeployment.IsNetworkDeployed)
        return;

      UpdateCheckInfo info = null;
      ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

      try {
        info = ad.CheckForDetailedUpdate();

      } catch (DeploymentDownloadException ex) {
        MessageBox.Show(this,
          string.Format(@"The new version of this application couldn't be downloaded:
{0}

Please check your network connection and try again.", ex.Message),
          Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;

      } catch (InvalidDeploymentException ex) {
        MessageBox.Show(this,
          string.Format(@"Couldn't check for a new version of the application:
{0}

Please try again.", ex.Message),
          Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;

      } catch (InvalidOperationException ex) {
        MessageBox.Show(this,
          string.Format(@"The application couldn't be updated:
{0}

Please try again.", ex.Message),
          Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;

      }

      if (info.UpdateAvailable) {
        bool doUpdate = true;

        if (info.IsUpdateRequired) {
          MessageBox.Show(this,@"This application has detected a mandataory update.
The application will now install the update and restart.",
            Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

        } else {
          DialogResult res = MessageBox.Show(this,
            "An update is available. Would you like to update this application now?",
            Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          doUpdate = (res == DialogResult.Yes);

        }

        if (!doUpdate)
          return;

        // A backup is required before updating
        MessageBox.Show(this, "You must backup the database before updating.", Application.ProductName,
          MessageBoxButtons.OK, MessageBoxIcon.Warning);
        if (!Backup())
          return;

        try {
          ad.Update();
          MessageBox.Show(this, "The application has been updated and will now resstart",
            Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
          Application.Restart();

        } catch (DeploymentDownloadException ex) {
          MessageBox.Show(this,
            string.Format(@"The new version of this application couldn't be downloaded:
{0}

Please check your network connection and try again.", ex.Message),
            Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;

        }
      }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
      /* This is needed as per "Datagridview error: DataGridViewComboBoxCell Value is not valid"
       * http://social.msdn.microsoft.com/Forums/is/Vsexpressvb/thread/33a87afd-6e7d-428a-b439-76eec83f137a
       * The datasource are being disposed of before the datagridview, so disassociate the datasrouce first
       */
      //gridTrophies.DataSource = null;

      if (this.WindowState != FormWindowState.Minimized) {
        Properties.Settings.Default.Form1Size = this.Size;
        Properties.Settings.Default.Form1WindowState = this.WindowState;
        Properties.Settings.Default.Form1Location = this.Location;
        Properties.Settings.Default.Form1SplitterRatio = (float)splitter.SplitterDistance / splitter.Width;
        Properties.Settings.Default.Save();
      }
    }

    private void Form1_Load(object sender, EventArgs e) {
      dlgRestore.InitialDirectory = dlgBackup.InitialDirectory = 
        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

      this.tblWinnersTableAdapter.FillByTrophy(this.trophyDataSet.tblWinners, -1);
      this.tblClassesTableAdapter.Fill(this.trophyDataSet.tblClasses);
      this.tblTrophiesTableAdapter.Fill(this.trophyDataSet.tblTrophies);
      
      OnTrophyPositionChanged();
    }

    private void gridTrophies_DataError(object sender, DataGridViewDataErrorEventArgs e) {
      e.ThrowException = (e.Context != DataGridViewDataErrorContexts.Display);
    }

    private void gridTrophies_Sorted(object sender, EventArgs e) {
      OnTrophyPositionChanged();
    }

    private void gridWinners_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e) {
      if (e.RowIndex == -1)
        return;

      DataRowView rv = (DataRowView)gridWinners.Rows[e.RowIndex].DataBoundItem;
      TrophyDataSet.tblWinnersRow row = (TrophyDataSet.tblWinnersRow)rv.Row;

      mnuTrophiesWonBySailNumber.Enabled = (row.fldSailNumber.Length != 0);
      mnuTrophiesWonBySailNumber.Tag = row.fldSailNumber;
      e.ContextMenuStrip = mnuWinnersContext;
    }

    private void gridWinners_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
      OnEditCurrentWinner();
    }

    private void mnuTrophiesWonBySailNumber_Click(object sender, EventArgs e) {
      try {
        using (ReportCreator report = new ReportCreator()) {
          FileInfo fi = report.GenerateWinnerReport((string)mnuTrophiesWonBySailNumber.Tag);
          System.Diagnostics.Process.Start(fi.FullName);
        }
      } catch (IOException ex) {
        MessageBox.Show(this,
          string.Format("A problem occurred generating the report:\n{0}", ex.Message),
          Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

      } catch (System.ComponentModel.Win32Exception ex) {
        MessageBox.Show(this,
          string.Format("The PDF couldn't be opened:\n{0}", ex.Message),
          Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

      }
    }

    private void tblTrophiesBindingSource_PositionChanged(object sender, EventArgs e) {
      OnTrophyPositionChanged();
    }

    private void tblWinnersBindingSource_PositionChanged(object sender, EventArgs e) {
      OnWinnerPositionChanged();
    }

    private void trophyEditor1_IsDirtyChanged(object sender, EventArgs e) {
      SetTrophyState();
      SetWinnerState();
    }

    private void txtFilterTrophies_TextChanged(object sender, EventArgs e) {
      OnTrophyFilter();
    }
    #endregion
  }
}
