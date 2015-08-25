namespace LDYC_Trophies {
  partial class ReportCreator {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.tblTrophiesTableAdapter = new LDYC_Trophies.TrophyDataSetTableAdapters.tblTrophiesTableAdapter();
      this.trophyDataSet = new LDYC_Trophies.TrophyDataSet();
      this.tblWinnersTableAdapter = new LDYC_Trophies.TrophyDataSetTableAdapters.tblWinnersTableAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.trophyDataSet)).BeginInit();
      // 
      // tblTrophiesTableAdapter
      // 
      this.tblTrophiesTableAdapter.ClearBeforeFill = true;
      // 
      // trophyDataSet
      // 
      this.trophyDataSet.DataSetName = "TrophyDataSet";
      this.trophyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // tblWinnersTableAdapter
      // 
      this.tblWinnersTableAdapter.ClearBeforeFill = true;
      ((System.ComponentModel.ISupportInitialize)(this.trophyDataSet)).EndInit();

    }

    #endregion

    private LDYC_Trophies.TrophyDataSetTableAdapters.tblTrophiesTableAdapter tblTrophiesTableAdapter;
    private TrophyDataSet trophyDataSet;
    private LDYC_Trophies.TrophyDataSetTableAdapters.tblWinnersTableAdapter tblWinnersTableAdapter;
  }
}
