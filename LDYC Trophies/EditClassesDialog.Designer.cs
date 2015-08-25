namespace LDYC_Trophies {
  partial class EditClassesDialog {
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
      this.butCancel = new System.Windows.Forms.Button();
      this.butOK = new System.Windows.Forms.Button();
      this.gridClasses = new System.Windows.Forms.DataGridView();
      this.fldNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fldCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fldModifiedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tblClassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.trophyDataSet = new LDYC_Trophies.TrophyDataSet();
      this.tblClassesTableAdapter = new LDYC_Trophies.TrophyDataSetTableAdapters.tblClassesTableAdapter();
      this.tableLayoutPanel1.SuspendLayout();
      this.panelButtons.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridClasses)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tblClassesBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trophyDataSet)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.panelButtons, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.gridClasses, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.Size = new System.Drawing.Size(548, 403);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // panelButtons
      // 
      this.panelButtons.AutoSize = true;
      this.panelButtons.Controls.Add(this.butCancel);
      this.panelButtons.Controls.Add(this.butOK);
      this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
      this.panelButtons.Location = new System.Drawing.Point(3, 371);
      this.panelButtons.Name = "panelButtons";
      this.panelButtons.Size = new System.Drawing.Size(542, 29);
      this.panelButtons.TabIndex = 1;
      // 
      // butCancel
      // 
      this.butCancel.Image = global::LDYC_Trophies.Properties.Resources.Red_Delete_16_n_p;
      this.butCancel.Location = new System.Drawing.Point(464, 3);
      this.butCancel.Name = "butCancel";
      this.butCancel.Size = new System.Drawing.Size(75, 23);
      this.butCancel.TabIndex = 1;
      this.butCancel.Text = "Cancel";
      this.butCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.butCancel.UseVisualStyleBackColor = true;
      this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
      // 
      // butOK
      // 
      this.butOK.Image = global::LDYC_Trophies.Properties.Resources.Green_Checkmark_16_n_p;
      this.butOK.Location = new System.Drawing.Point(383, 3);
      this.butOK.Name = "butOK";
      this.butOK.Size = new System.Drawing.Size(75, 23);
      this.butOK.TabIndex = 0;
      this.butOK.Text = "Save";
      this.butOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.butOK.UseVisualStyleBackColor = true;
      this.butOK.Click += new System.EventHandler(this.butOK_Click);
      // 
      // gridClasses
      // 
      this.gridClasses.AllowUserToResizeRows = false;
      this.gridClasses.AutoGenerateColumns = false;
      this.gridClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fldNameDataGridViewTextBoxColumn,
            this.fldCreatedDataGridViewTextBoxColumn,
            this.fldModifiedDataGridViewTextBoxColumn});
      this.gridClasses.DataSource = this.tblClassesBindingSource;
      this.gridClasses.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridClasses.Location = new System.Drawing.Point(3, 3);
      this.gridClasses.Name = "gridClasses";
      this.gridClasses.Size = new System.Drawing.Size(542, 362);
      this.gridClasses.TabIndex = 0;
      this.gridClasses.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.gridClasses_UserDeletingRow);
      this.gridClasses.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.gridClasses_CellValidating);
      this.gridClasses.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClasses_CellEndEdit);
      this.gridClasses.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClasses_RowValidated);
      this.gridClasses.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.gridClasses_DefaultValuesNeeded);
      this.gridClasses.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gridClasses_DataError);
      // 
      // fldNameDataGridViewTextBoxColumn
      // 
      this.fldNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.fldNameDataGridViewTextBoxColumn.DataPropertyName = "fldName";
      this.fldNameDataGridViewTextBoxColumn.HeaderText = "Class Name";
      this.fldNameDataGridViewTextBoxColumn.Name = "fldNameDataGridViewTextBoxColumn";
      // 
      // fldCreatedDataGridViewTextBoxColumn
      // 
      this.fldCreatedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.fldCreatedDataGridViewTextBoxColumn.DataPropertyName = "fldCreated";
      dataGridViewCellStyle1.Format = "g";
      dataGridViewCellStyle1.NullValue = null;
      this.fldCreatedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
      this.fldCreatedDataGridViewTextBoxColumn.HeaderText = "Created";
      this.fldCreatedDataGridViewTextBoxColumn.Name = "fldCreatedDataGridViewTextBoxColumn";
      this.fldCreatedDataGridViewTextBoxColumn.ReadOnly = true;
      this.fldCreatedDataGridViewTextBoxColumn.Width = 69;
      // 
      // fldModifiedDataGridViewTextBoxColumn
      // 
      this.fldModifiedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.fldModifiedDataGridViewTextBoxColumn.DataPropertyName = "fldModified";
      dataGridViewCellStyle2.Format = "g";
      this.fldModifiedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
      this.fldModifiedDataGridViewTextBoxColumn.HeaderText = "Modified";
      this.fldModifiedDataGridViewTextBoxColumn.Name = "fldModifiedDataGridViewTextBoxColumn";
      this.fldModifiedDataGridViewTextBoxColumn.ReadOnly = true;
      this.fldModifiedDataGridViewTextBoxColumn.Width = 72;
      // 
      // tblClassesBindingSource
      // 
      this.tblClassesBindingSource.DataMember = "tblClasses";
      this.tblClassesBindingSource.DataSource = this.trophyDataSet;
      this.tblClassesBindingSource.Sort = "[fldName] ASC";
      // 
      // trophyDataSet
      // 
      this.trophyDataSet.DataSetName = "TrophyDataSet";
      this.trophyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // tblClassesTableAdapter
      // 
      this.tblClassesTableAdapter.ClearBeforeFill = true;
      // 
      // EditClassesDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(548, 403);
      this.Controls.Add(this.tableLayoutPanel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EditClassesDialog";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Edit Classes";
      this.Load += new System.EventHandler(this.EditClassesDialog_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.panelButtons.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridClasses)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tblClassesBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trophyDataSet)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.FlowLayoutPanel panelButtons;
    private System.Windows.Forms.Button butCancel;
    private System.Windows.Forms.Button butOK;
    private System.Windows.Forms.DataGridView gridClasses;
    private TrophyDataSet trophyDataSet;
    private System.Windows.Forms.BindingSource tblClassesBindingSource;
    private LDYC_Trophies.TrophyDataSetTableAdapters.tblClassesTableAdapter tblClassesTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn fldNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn fldCreatedDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn fldModifiedDataGridViewTextBoxColumn;
  }
}