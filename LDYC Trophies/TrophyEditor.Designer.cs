namespace LDYC_Trophies {
  partial class TrophyEditor {
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
      this.components = new System.ComponentModel.Container();
      this.table = new System.Windows.Forms.TableLayoutPanel();
      this.lblRedBookPage = new System.Windows.Forms.Label();
      this.txtTrophyName = new System.Windows.Forms.TextBox();
      this.txtDonor = new System.Windows.Forms.TextBox();
      this.txtConditions = new System.Windows.Forms.TextBox();
      this.txtDetails = new System.Windows.Forms.TextBox();
      this.txtRedBookPage = new System.Windows.Forms.MaskedTextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.lblTrophyName = new System.Windows.Forms.Label();
      this.lblDonated = new System.Windows.Forms.Label();
      this.lblClass = new System.Windows.Forms.Label();
      this.lblConditions = new System.Windows.Forms.Label();
      this.lblDetails = new System.Windows.Forms.Label();
      this.panelClass = new System.Windows.Forms.Panel();
      this.comboClassID = new System.Windows.Forms.ComboBox();
      this.txtClass = new System.Windows.Forms.TextBox();
      this.txtYearDonated = new System.Windows.Forms.MaskedTextBox();
      this.trophyDataSet = new LDYC_Trophies.TrophyDataSet();
      this.tblClassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.tblClassesTableAdapter = new LDYC_Trophies.TrophyDataSetTableAdapters.tblClassesTableAdapter();
      this.table.SuspendLayout();
      this.panelClass.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trophyDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tblClassesBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // table
      // 
      this.table.ColumnCount = 4;
      this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.table.Controls.Add(this.lblRedBookPage, 0, 5);
      this.table.Controls.Add(this.txtTrophyName, 1, 0);
      this.table.Controls.Add(this.txtDonor, 1, 1);
      this.table.Controls.Add(this.txtConditions, 1, 3);
      this.table.Controls.Add(this.txtDetails, 1, 4);
      this.table.Controls.Add(this.txtRedBookPage, 1, 5);
      this.table.Controls.Add(this.label3, 2, 1);
      this.table.Controls.Add(this.lblTrophyName, 0, 0);
      this.table.Controls.Add(this.lblDonated, 0, 1);
      this.table.Controls.Add(this.lblClass, 0, 2);
      this.table.Controls.Add(this.lblConditions, 0, 3);
      this.table.Controls.Add(this.lblDetails, 0, 4);
      this.table.Controls.Add(this.panelClass, 1, 2);
      this.table.Controls.Add(this.txtYearDonated, 3, 1);
      this.table.Dock = System.Windows.Forms.DockStyle.Fill;
      this.table.Location = new System.Drawing.Point(0, 0);
      this.table.Name = "table";
      this.table.RowCount = 6;
      this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.table.Size = new System.Drawing.Size(400, 300);
      this.table.TabIndex = 0;
      // 
      // lblRedBookPage
      // 
      this.lblRedBookPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.lblRedBookPage.AutoSize = true;
      this.lblRedBookPage.Location = new System.Drawing.Point(3, 280);
      this.lblRedBookPage.Name = "lblRedBookPage";
      this.lblRedBookPage.Size = new System.Drawing.Size(86, 13);
      this.lblRedBookPage.TabIndex = 12;
      this.lblRedBookPage.Text = "Red Book &Page:";
      // 
      // txtTrophyName
      // 
      this.table.SetColumnSpan(this.txtTrophyName, 3);
      this.txtTrophyName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtTrophyName.Location = new System.Drawing.Point(95, 3);
      this.txtTrophyName.MaxLength = 100;
      this.txtTrophyName.Name = "txtTrophyName";
      this.txtTrophyName.Size = new System.Drawing.Size(302, 20);
      this.txtTrophyName.TabIndex = 1;
      this.txtTrophyName.TextChanged += new System.EventHandler(this.txt_TextChanged);
      // 
      // txtDonor
      // 
      this.txtDonor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtDonor.Location = new System.Drawing.Point(95, 29);
      this.txtDonor.MaxLength = 100;
      this.txtDonor.Name = "txtDonor";
      this.txtDonor.Size = new System.Drawing.Size(240, 20);
      this.txtDonor.TabIndex = 3;
      this.txtDonor.TextChanged += new System.EventHandler(this.txt_TextChanged);
      // 
      // txtConditions
      // 
      this.table.SetColumnSpan(this.txtConditions, 3);
      this.txtConditions.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtConditions.Location = new System.Drawing.Point(95, 102);
      this.txtConditions.MaxLength = 4000;
      this.txtConditions.Multiline = true;
      this.txtConditions.Name = "txtConditions";
      this.txtConditions.Size = new System.Drawing.Size(302, 81);
      this.txtConditions.TabIndex = 9;
      this.txtConditions.TextChanged += new System.EventHandler(this.txt_TextChanged);
      // 
      // txtDetails
      // 
      this.table.SetColumnSpan(this.txtDetails, 3);
      this.txtDetails.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtDetails.Location = new System.Drawing.Point(95, 189);
      this.txtDetails.MaxLength = 4000;
      this.txtDetails.Multiline = true;
      this.txtDetails.Name = "txtDetails";
      this.txtDetails.Size = new System.Drawing.Size(302, 81);
      this.txtDetails.TabIndex = 11;
      this.txtDetails.TextChanged += new System.EventHandler(this.txt_TextChanged);
      // 
      // txtRedBookPage
      // 
      this.txtRedBookPage.Location = new System.Drawing.Point(95, 276);
      this.txtRedBookPage.Mask = "000";
      this.txtRedBookPage.Name = "txtRedBookPage";
      this.txtRedBookPage.Size = new System.Drawing.Size(33, 20);
      this.txtRedBookPage.TabIndex = 13;
      this.txtRedBookPage.TextChanged += new System.EventHandler(this.txt_TextChanged);
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(341, 32);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(15, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "in";
      // 
      // lblTrophyName
      // 
      this.lblTrophyName.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.lblTrophyName.AutoSize = true;
      this.lblTrophyName.ForeColor = System.Drawing.Color.Red;
      this.lblTrophyName.Location = new System.Drawing.Point(3, 6);
      this.lblTrophyName.Name = "lblTrophyName";
      this.lblTrophyName.Size = new System.Drawing.Size(38, 13);
      this.lblTrophyName.TabIndex = 0;
      this.lblTrophyName.Text = "&Name:";
      // 
      // lblDonated
      // 
      this.lblDonated.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.lblDonated.AutoSize = true;
      this.lblDonated.ForeColor = System.Drawing.Color.Red;
      this.lblDonated.Location = new System.Drawing.Point(3, 32);
      this.lblDonated.Name = "lblDonated";
      this.lblDonated.Size = new System.Drawing.Size(65, 13);
      this.lblDonated.TabIndex = 2;
      this.lblDonated.Text = "&Donated by:";
      // 
      // lblClass
      // 
      this.lblClass.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.lblClass.AutoSize = true;
      this.lblClass.ForeColor = System.Drawing.Color.Red;
      this.lblClass.Location = new System.Drawing.Point(3, 69);
      this.lblClass.Name = "lblClass";
      this.lblClass.Size = new System.Drawing.Size(72, 13);
      this.lblClass.TabIndex = 6;
      this.lblClass.Text = "&Current Class:";
      // 
      // lblConditions
      // 
      this.lblConditions.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.lblConditions.AutoSize = true;
      this.lblConditions.Location = new System.Drawing.Point(3, 136);
      this.lblConditions.Name = "lblConditions";
      this.lblConditions.Size = new System.Drawing.Size(59, 13);
      this.lblConditions.TabIndex = 8;
      this.lblConditions.Text = "C&onditions:";
      // 
      // lblDetails
      // 
      this.lblDetails.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.lblDetails.AutoSize = true;
      this.lblDetails.Location = new System.Drawing.Point(3, 223);
      this.lblDetails.Name = "lblDetails";
      this.lblDetails.Size = new System.Drawing.Size(42, 13);
      this.lblDetails.TabIndex = 10;
      this.lblDetails.Text = "De&tails:";
      // 
      // panelClass
      // 
      this.panelClass.AutoSize = true;
      this.panelClass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.table.SetColumnSpan(this.panelClass, 3);
      this.panelClass.Controls.Add(this.comboClassID);
      this.panelClass.Controls.Add(this.txtClass);
      this.panelClass.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelClass.Location = new System.Drawing.Point(95, 55);
      this.panelClass.Name = "panelClass";
      this.panelClass.Size = new System.Drawing.Size(302, 41);
      this.panelClass.TabIndex = 7;
      // 
      // comboClassID
      // 
      this.comboClassID.DataSource = this.tblClassesBindingSource;
      this.comboClassID.DisplayMember = "fldName";
      this.comboClassID.Dock = System.Windows.Forms.DockStyle.Top;
      this.comboClassID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboClassID.FormattingEnabled = true;
      this.comboClassID.Location = new System.Drawing.Point(0, 20);
      this.comboClassID.MaxDropDownItems = 20;
      this.comboClassID.Name = "comboClassID";
      this.comboClassID.Size = new System.Drawing.Size(302, 21);
      this.comboClassID.TabIndex = 1;
      this.comboClassID.ValueMember = "fldClassID";
      this.comboClassID.SelectedValueChanged += new System.EventHandler(this.comboClassID_SelectedValueChanged);
      // 
      // txtClass
      // 
      this.txtClass.Dock = System.Windows.Forms.DockStyle.Top;
      this.txtClass.Location = new System.Drawing.Point(0, 0);
      this.txtClass.Name = "txtClass";
      this.txtClass.Size = new System.Drawing.Size(302, 20);
      this.txtClass.TabIndex = 0;
      // 
      // txtYearDonated
      // 
      this.txtYearDonated.Location = new System.Drawing.Point(362, 29);
      this.txtYearDonated.Mask = "0000";
      this.txtYearDonated.Name = "txtYearDonated";
      this.txtYearDonated.Size = new System.Drawing.Size(35, 20);
      this.txtYearDonated.TabIndex = 5;
      this.txtYearDonated.TextChanged += new System.EventHandler(this.txt_TextChanged);
      // 
      // trophyDataSet
      // 
      this.trophyDataSet.DataSetName = "TrophyDataSet";
      this.trophyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // tblClassesBindingSource
      // 
      this.tblClassesBindingSource.DataMember = "tblClasses";
      this.tblClassesBindingSource.DataSource = this.trophyDataSet;
      // 
      // tblClassesTableAdapter
      // 
      this.tblClassesTableAdapter.ClearBeforeFill = true;
      // 
      // TrophyEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.table);
      this.MinimumSize = new System.Drawing.Size(400, 300);
      this.Name = "TrophyEditor";
      this.Size = new System.Drawing.Size(400, 300);
      this.Load += new System.EventHandler(this.TrophyEditor_Load);
      this.table.ResumeLayout(false);
      this.table.PerformLayout();
      this.panelClass.ResumeLayout(false);
      this.panelClass.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trophyDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tblClassesBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel table;
    private System.Windows.Forms.TextBox txtTrophyName;
    private System.Windows.Forms.TextBox txtDonor;
    private System.Windows.Forms.TextBox txtDetails;
    private System.Windows.Forms.MaskedTextBox txtRedBookPage;
    private System.Windows.Forms.MaskedTextBox txtYearDonated;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblTrophyName;
    private System.Windows.Forms.Label lblDonated;
    private System.Windows.Forms.Label lblClass;
    private System.Windows.Forms.Label lblConditions;
    private System.Windows.Forms.Label lblDetails;
    private System.Windows.Forms.Label lblRedBookPage;
    private System.Windows.Forms.TextBox txtConditions;
    private System.Windows.Forms.Panel panelClass;
    private System.Windows.Forms.TextBox txtClass;
    private System.Windows.Forms.ComboBox comboClassID;
    private System.Windows.Forms.BindingSource tblClassesBindingSource;
    private TrophyDataSet trophyDataSet;
    private LDYC_Trophies.TrophyDataSetTableAdapters.tblClassesTableAdapter tblClassesTableAdapter;
  }
}
