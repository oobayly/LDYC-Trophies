namespace LDYC_Trophies {
  partial class EditWinnerDialog {
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.table = new System.Windows.Forms.TableLayoutPanel();
      this.txtOwner = new System.Windows.Forms.TextBox();
      this.lblOwner = new System.Windows.Forms.Label();
      this.lblNotes = new System.Windows.Forms.Label();
      this.lblHelm = new System.Windows.Forms.Label();
      this.txtYear = new System.Windows.Forms.MaskedTextBox();
      this.comboClassID = new System.Windows.Forms.ComboBox();
      this.tblClassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.trophyDataSet = new LDYC_Trophies.TrophyDataSet();
      this.lblClass = new System.Windows.Forms.Label();
      this.txtHelm = new System.Windows.Forms.TextBox();
      this.lblCrew = new System.Windows.Forms.Label();
      this.txtCrew = new System.Windows.Forms.TextBox();
      this.txtSailNumber = new System.Windows.Forms.TextBox();
      this.lblSailNumber = new System.Windows.Forms.Label();
      this.txtNotes = new System.Windows.Forms.TextBox();
      this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
      this.butCancel = new System.Windows.Forms.Button();
      this.butOK = new System.Windows.Forms.Button();
      this.tblClassesTableAdapter = new LDYC_Trophies.TrophyDataSetTableAdapters.tblClassesTableAdapter();
      this.table.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tblClassesBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trophyDataSet)).BeginInit();
      this.panelButtons.SuspendLayout();
      this.SuspendLayout();
      // 
      // table
      // 
      this.table.ColumnCount = 3;
      this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.table.Controls.Add(this.txtOwner, 1, 1);
      this.table.Controls.Add(this.lblOwner, 0, 1);
      this.table.Controls.Add(this.lblNotes, 0, 5);
      this.table.Controls.Add(this.lblHelm, 0, 2);
      this.table.Controls.Add(this.txtYear, 2, 0);
      this.table.Controls.Add(this.comboClassID, 1, 0);
      this.table.Controls.Add(this.lblClass, 0, 0);
      this.table.Controls.Add(this.txtHelm, 1, 2);
      this.table.Controls.Add(this.lblCrew, 0, 3);
      this.table.Controls.Add(this.txtCrew, 1, 3);
      this.table.Controls.Add(this.txtSailNumber, 1, 4);
      this.table.Controls.Add(this.lblSailNumber, 0, 4);
      this.table.Controls.Add(this.txtNotes, 1, 5);
      this.table.Controls.Add(this.panelButtons, 0, 6);
      this.table.Dock = System.Windows.Forms.DockStyle.Fill;
      this.table.Location = new System.Drawing.Point(0, 0);
      this.table.Name = "table";
      this.table.RowCount = 7;
      this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.table.Size = new System.Drawing.Size(445, 278);
      this.table.TabIndex = 0;
      // 
      // txtOwner
      // 
      this.table.SetColumnSpan(this.txtOwner, 2);
      this.txtOwner.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtOwner.Location = new System.Drawing.Point(78, 30);
      this.txtOwner.MaxLength = 100;
      this.txtOwner.Name = "txtOwner";
      this.txtOwner.Size = new System.Drawing.Size(364, 20);
      this.txtOwner.TabIndex = 4;
      // 
      // lblOwner
      // 
      this.lblOwner.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.lblOwner.AutoSize = true;
      this.lblOwner.Location = new System.Drawing.Point(3, 30);
      this.lblOwner.Name = "lblOwner";
      this.lblOwner.Size = new System.Drawing.Size(41, 13);
      this.lblOwner.TabIndex = 3;
      this.lblOwner.Text = "&Owner:";
      // 
      // lblNotes
      // 
      this.lblNotes.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.lblNotes.AutoSize = true;
      this.lblNotes.Location = new System.Drawing.Point(3, 177);
      this.lblNotes.Name = "lblNotes";
      this.lblNotes.Size = new System.Drawing.Size(38, 13);
      this.lblNotes.TabIndex = 11;
      this.lblNotes.Text = "&Notes:";
      // 
      // lblHelm
      // 
      this.lblHelm.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.lblHelm.AutoSize = true;
      this.lblHelm.Location = new System.Drawing.Point(3, 53);
      this.lblHelm.Name = "lblHelm";
      this.lblHelm.Size = new System.Drawing.Size(34, 13);
      this.lblHelm.TabIndex = 5;
      this.lblHelm.Text = "&Helm:";
      // 
      // txtYear
      // 
      this.txtYear.Location = new System.Drawing.Point(407, 3);
      this.txtYear.Mask = "0000";
      this.txtYear.Name = "txtYear";
      this.txtYear.Size = new System.Drawing.Size(35, 20);
      this.txtYear.TabIndex = 2;
      // 
      // comboClassID
      // 
      this.comboClassID.DataSource = this.tblClassesBindingSource;
      this.comboClassID.DisplayMember = "fldName";
      this.comboClassID.Dock = System.Windows.Forms.DockStyle.Fill;
      this.comboClassID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboClassID.FormattingEnabled = true;
      this.comboClassID.Location = new System.Drawing.Point(78, 3);
      this.comboClassID.MaxDropDownItems = 20;
      this.comboClassID.Name = "comboClassID";
      this.comboClassID.Size = new System.Drawing.Size(323, 21);
      this.comboClassID.TabIndex = 1;
      this.comboClassID.ValueMember = "fldClassID";
      // 
      // tblClassesBindingSource
      // 
      this.tblClassesBindingSource.DataMember = "tblClasses";
      this.tblClassesBindingSource.DataSource = this.trophyDataSet;
      // 
      // trophyDataSet
      // 
      this.trophyDataSet.DataSetName = "TrophyDataSet";
      this.trophyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // lblClass
      // 
      this.lblClass.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.lblClass.AutoSize = true;
      this.lblClass.ForeColor = System.Drawing.Color.Red;
      this.lblClass.Location = new System.Drawing.Point(3, 7);
      this.lblClass.Name = "lblClass";
      this.lblClass.Size = new System.Drawing.Size(69, 13);
      this.lblClass.TabIndex = 0;
      this.lblClass.Text = "&Class && Year:";
      // 
      // txtHelm
      // 
      this.table.SetColumnSpan(this.txtHelm, 2);
      this.txtHelm.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtHelm.Location = new System.Drawing.Point(78, 50);
      this.txtHelm.MaxLength = 100;
      this.txtHelm.Name = "txtHelm";
      this.txtHelm.Size = new System.Drawing.Size(364, 20);
      this.txtHelm.TabIndex = 6;
      // 
      // lblCrew
      // 
      this.lblCrew.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.lblCrew.AutoSize = true;
      this.lblCrew.Location = new System.Drawing.Point(3, 79);
      this.lblCrew.Name = "lblCrew";
      this.lblCrew.Size = new System.Drawing.Size(34, 13);
      this.lblCrew.TabIndex = 7;
      this.lblCrew.Text = "Cre&w:";
      // 
      // txtCrew
      // 
      this.table.SetColumnSpan(this.txtCrew, 2);
      this.txtCrew.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtCrew.Location = new System.Drawing.Point(78, 76);
      this.txtCrew.MaxLength = 100;
      this.txtCrew.Name = "txtCrew";
      this.txtCrew.Size = new System.Drawing.Size(364, 20);
      this.txtCrew.TabIndex = 8;
      // 
      // txtSailNumber
      // 
      this.table.SetColumnSpan(this.txtSailNumber, 2);
      this.txtSailNumber.Location = new System.Drawing.Point(78, 102);
      this.txtSailNumber.MaxLength = 20;
      this.txtSailNumber.Name = "txtSailNumber";
      this.txtSailNumber.Size = new System.Drawing.Size(107, 20);
      this.txtSailNumber.TabIndex = 10;
      // 
      // lblSailNumber
      // 
      this.lblSailNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.lblSailNumber.AutoSize = true;
      this.lblSailNumber.Location = new System.Drawing.Point(3, 105);
      this.lblSailNumber.Name = "lblSailNumber";
      this.lblSailNumber.Size = new System.Drawing.Size(67, 13);
      this.lblSailNumber.TabIndex = 9;
      this.lblSailNumber.Text = "&Sail Number:";
      // 
      // txtNotes
      // 
      this.table.SetColumnSpan(this.txtNotes, 2);
      this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtNotes.Location = new System.Drawing.Point(78, 128);
      this.txtNotes.MaxLength = 4000;
      this.txtNotes.Multiline = true;
      this.txtNotes.Name = "txtNotes";
      this.txtNotes.Size = new System.Drawing.Size(364, 112);
      this.txtNotes.TabIndex = 12;
      // 
      // panelButtons
      // 
      this.panelButtons.AutoSize = true;
      this.table.SetColumnSpan(this.panelButtons, 3);
      this.panelButtons.Controls.Add(this.butCancel);
      this.panelButtons.Controls.Add(this.butOK);
      this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
      this.panelButtons.Location = new System.Drawing.Point(3, 246);
      this.panelButtons.Name = "panelButtons";
      this.panelButtons.Size = new System.Drawing.Size(439, 29);
      this.panelButtons.TabIndex = 13;
      // 
      // butCancel
      // 
      this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.butCancel.Image = global::LDYC_Trophies.Properties.Resources.Red_Delete_16_n_p;
      this.butCancel.Location = new System.Drawing.Point(361, 3);
      this.butCancel.Name = "butCancel";
      this.butCancel.Size = new System.Drawing.Size(75, 23);
      this.butCancel.TabIndex = 1;
      this.butCancel.Text = "Cancel";
      this.butCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.butCancel.UseVisualStyleBackColor = true;
      // 
      // butOK
      // 
      this.butOK.Image = global::LDYC_Trophies.Properties.Resources.Green_Checkmark_16_n_p;
      this.butOK.Location = new System.Drawing.Point(280, 3);
      this.butOK.Name = "butOK";
      this.butOK.Size = new System.Drawing.Size(75, 23);
      this.butOK.TabIndex = 0;
      this.butOK.Text = "Save";
      this.butOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.butOK.UseVisualStyleBackColor = true;
      this.butOK.Click += new System.EventHandler(this.butOK_Click);
      // 
      // tblClassesTableAdapter
      // 
      this.tblClassesTableAdapter.ClearBeforeFill = true;
      // 
      // EditWinnerDialog
      // 
      this.AcceptButton = this.butOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.butCancel;
      this.ClientSize = new System.Drawing.Size(445, 278);
      this.Controls.Add(this.table);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EditWinnerDialog";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Edit Winner";
      this.table.ResumeLayout(false);
      this.table.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tblClassesBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trophyDataSet)).EndInit();
      this.panelButtons.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel table;
    private System.Windows.Forms.FlowLayoutPanel panelButtons;
    private System.Windows.Forms.Button butCancel;
    private System.Windows.Forms.Button butOK;
    private System.Windows.Forms.Label lblClass;
    private System.Windows.Forms.ComboBox comboClassID;
    private System.Windows.Forms.MaskedTextBox txtYear;
    private System.Windows.Forms.Label lblHelm;
    private System.Windows.Forms.TextBox txtHelm;
    private System.Windows.Forms.Label lblCrew;
    private System.Windows.Forms.TextBox txtCrew;
    private System.Windows.Forms.TextBox txtSailNumber;
    private System.Windows.Forms.Label lblSailNumber;
    private System.Windows.Forms.TextBox txtNotes;
    private System.Windows.Forms.Label lblNotes;
    private TrophyDataSet trophyDataSet;
    private System.Windows.Forms.BindingSource tblClassesBindingSource;
    private LDYC_Trophies.TrophyDataSetTableAdapters.tblClassesTableAdapter tblClassesTableAdapter;
    private System.Windows.Forms.TextBox txtOwner;
    private System.Windows.Forms.Label lblOwner;
  }
}