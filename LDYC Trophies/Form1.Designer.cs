namespace LDYC_Trophies {
  partial class Form1 {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.splitter = new System.Windows.Forms.SplitContainer();
      this.groupTrophies = new System.Windows.Forms.GroupBox();
      this.gridTrophies = new System.Windows.Forms.DataGridView();
      this.fldNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.tblClassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.trophyDataSet = new LDYC_Trophies.TrophyDataSet();
      this.tblTrophiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.tableTrophyOptions = new System.Windows.Forms.TableLayoutPanel();
      this.butAddTrophy = new System.Windows.Forms.Button();
      this.txtFilterTrophies = new System.Windows.Forms.TextBox();
      this.lblFilterTrophies = new System.Windows.Forms.Label();
      this.groupWinners = new System.Windows.Forms.GroupBox();
      this.gridWinners = new System.Windows.Forms.DataGridView();
      this.fldYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fldClassIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.fldSailNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fldHelmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fldCrewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tblWinnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.toolWinners = new System.Windows.Forms.ToolStrip();
      this.butAddWinner = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.butEditWinner = new System.Windows.Forms.ToolStripButton();
      this.butDeleteWinner = new System.Windows.Forms.ToolStripButton();
      this.groupTrophyInfo = new System.Windows.Forms.GroupBox();
      this.trophyEditor1 = new LDYC_Trophies.TrophyEditor();
      this.toolTrophy = new System.Windows.Forms.ToolStrip();
      this.butCommitChanges = new System.Windows.Forms.ToolStripButton();
      this.butRejectChanges = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.butDeleteTrophy = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.butTrophyPhotos = new System.Windows.Forms.ToolStripButton();
      this.butTrophyReport = new System.Windows.Forms.ToolStripButton();
      this.toolMain = new System.Windows.Forms.ToolStrip();
      this.butEditClasses = new System.Windows.Forms.ToolStripButton();
      this.butReport = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.butRestore = new System.Windows.Forms.ToolStripButton();
      this.butBackup = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.butUpdate = new System.Windows.Forms.ToolStripButton();
      this.butAbout = new System.Windows.Forms.ToolStripButton();
      this.dlgRestore = new System.Windows.Forms.OpenFileDialog();
      this.dlgBackup = new System.Windows.Forms.SaveFileDialog();
      this.tblTrophiesTableAdapter = new LDYC_Trophies.TrophyDataSetTableAdapters.tblTrophiesTableAdapter();
      this.tblClassesTableAdapter = new LDYC_Trophies.TrophyDataSetTableAdapters.tblClassesTableAdapter();
      this.tblWinnersTableAdapter = new LDYC_Trophies.TrophyDataSetTableAdapters.tblWinnersTableAdapter();
      this.mnuWinnersContext = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuTrophiesWonBySailNumber = new System.Windows.Forms.ToolStripMenuItem();
      this.splitter.Panel1.SuspendLayout();
      this.splitter.Panel2.SuspendLayout();
      this.splitter.SuspendLayout();
      this.groupTrophies.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridTrophies)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tblClassesBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trophyDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tblTrophiesBindingSource)).BeginInit();
      this.tableTrophyOptions.SuspendLayout();
      this.groupWinners.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridWinners)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tblWinnersBindingSource)).BeginInit();
      this.toolWinners.SuspendLayout();
      this.groupTrophyInfo.SuspendLayout();
      this.toolTrophy.SuspendLayout();
      this.toolMain.SuspendLayout();
      this.mnuWinnersContext.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitter
      // 
      this.splitter.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitter.Location = new System.Drawing.Point(0, 25);
      this.splitter.Name = "splitter";
      // 
      // splitter.Panel1
      // 
      this.splitter.Panel1.Controls.Add(this.groupTrophies);
      // 
      // splitter.Panel2
      // 
      this.splitter.Panel2.Controls.Add(this.groupWinners);
      this.splitter.Panel2.Controls.Add(this.groupTrophyInfo);
      this.splitter.Size = new System.Drawing.Size(887, 563);
      this.splitter.SplitterDistance = 337;
      this.splitter.TabIndex = 0;
      // 
      // groupTrophies
      // 
      this.groupTrophies.Controls.Add(this.gridTrophies);
      this.groupTrophies.Controls.Add(this.tableTrophyOptions);
      this.groupTrophies.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupTrophies.Location = new System.Drawing.Point(0, 0);
      this.groupTrophies.Name = "groupTrophies";
      this.groupTrophies.Size = new System.Drawing.Size(337, 563);
      this.groupTrophies.TabIndex = 0;
      this.groupTrophies.TabStop = false;
      this.groupTrophies.Text = "Trophies";
      // 
      // gridTrophies
      // 
      this.gridTrophies.AllowUserToAddRows = false;
      this.gridTrophies.AllowUserToDeleteRows = false;
      this.gridTrophies.AllowUserToResizeRows = false;
      this.gridTrophies.AutoGenerateColumns = false;
      this.gridTrophies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridTrophies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fldNameDataGridViewTextBoxColumn,
            this.dataGridViewComboBoxColumn1});
      this.gridTrophies.DataSource = this.tblTrophiesBindingSource;
      this.gridTrophies.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridTrophies.Location = new System.Drawing.Point(3, 45);
      this.gridTrophies.MultiSelect = false;
      this.gridTrophies.Name = "gridTrophies";
      this.gridTrophies.ReadOnly = true;
      this.gridTrophies.RowHeadersVisible = false;
      this.gridTrophies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gridTrophies.Size = new System.Drawing.Size(331, 515);
      this.gridTrophies.TabIndex = 1;
      this.gridTrophies.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gridTrophies_DataError);
      this.gridTrophies.Sorted += new System.EventHandler(this.gridTrophies_Sorted);
      // 
      // fldNameDataGridViewTextBoxColumn
      // 
      this.fldNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.fldNameDataGridViewTextBoxColumn.DataPropertyName = "fldName";
      this.fldNameDataGridViewTextBoxColumn.HeaderText = "Name";
      this.fldNameDataGridViewTextBoxColumn.Name = "fldNameDataGridViewTextBoxColumn";
      this.fldNameDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // dataGridViewComboBoxColumn1
      // 
      this.dataGridViewComboBoxColumn1.AutoComplete = false;
      this.dataGridViewComboBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.dataGridViewComboBoxColumn1.DataPropertyName = "fldCurrentClassID";
      this.dataGridViewComboBoxColumn1.DataSource = this.tblClassesBindingSource;
      this.dataGridViewComboBoxColumn1.DisplayMember = "fldName";
      this.dataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
      this.dataGridViewComboBoxColumn1.HeaderText = "Class";
      this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
      this.dataGridViewComboBoxColumn1.ReadOnly = true;
      this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.dataGridViewComboBoxColumn1.ValueMember = "fldClassID";
      this.dataGridViewComboBoxColumn1.Width = 57;
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
      // tblTrophiesBindingSource
      // 
      this.tblTrophiesBindingSource.DataMember = "tblTrophies";
      this.tblTrophiesBindingSource.DataSource = this.trophyDataSet;
      this.tblTrophiesBindingSource.Sort = "[fldName] ASC";
      this.tblTrophiesBindingSource.PositionChanged += new System.EventHandler(this.tblTrophiesBindingSource_PositionChanged);
      // 
      // tableTrophyOptions
      // 
      this.tableTrophyOptions.AutoSize = true;
      this.tableTrophyOptions.ColumnCount = 3;
      this.tableTrophyOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableTrophyOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableTrophyOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableTrophyOptions.Controls.Add(this.butAddTrophy, 2, 0);
      this.tableTrophyOptions.Controls.Add(this.txtFilterTrophies, 1, 0);
      this.tableTrophyOptions.Controls.Add(this.lblFilterTrophies, 0, 0);
      this.tableTrophyOptions.Dock = System.Windows.Forms.DockStyle.Top;
      this.tableTrophyOptions.Location = new System.Drawing.Point(3, 16);
      this.tableTrophyOptions.Name = "tableTrophyOptions";
      this.tableTrophyOptions.RowCount = 1;
      this.tableTrophyOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableTrophyOptions.Size = new System.Drawing.Size(331, 29);
      this.tableTrophyOptions.TabIndex = 0;
      // 
      // butAddTrophy
      // 
      this.butAddTrophy.AutoSize = true;
      this.butAddTrophy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.butAddTrophy.Image = ((System.Drawing.Image)(resources.GetObject("butAddTrophy.Image")));
      this.butAddTrophy.Location = new System.Drawing.Point(240, 3);
      this.butAddTrophy.Name = "butAddTrophy";
      this.butAddTrophy.Size = new System.Drawing.Size(88, 23);
      this.butAddTrophy.TabIndex = 2;
      this.butAddTrophy.Text = "Add Trophy";
      this.butAddTrophy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.butAddTrophy.UseVisualStyleBackColor = true;
      this.butAddTrophy.Click += new System.EventHandler(this.butAddTrophy_Click);
      // 
      // txtFilterTrophies
      // 
      this.txtFilterTrophies.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtFilterTrophies.Location = new System.Drawing.Point(41, 3);
      this.txtFilterTrophies.Name = "txtFilterTrophies";
      this.txtFilterTrophies.Size = new System.Drawing.Size(193, 20);
      this.txtFilterTrophies.TabIndex = 1;
      this.txtFilterTrophies.TextChanged += new System.EventHandler(this.txtFilterTrophies_TextChanged);
      // 
      // lblFilterTrophies
      // 
      this.lblFilterTrophies.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblFilterTrophies.AutoSize = true;
      this.lblFilterTrophies.Location = new System.Drawing.Point(3, 8);
      this.lblFilterTrophies.Name = "lblFilterTrophies";
      this.lblFilterTrophies.Size = new System.Drawing.Size(32, 13);
      this.lblFilterTrophies.TabIndex = 0;
      this.lblFilterTrophies.Text = "Filter:";
      // 
      // groupWinners
      // 
      this.groupWinners.Controls.Add(this.gridWinners);
      this.groupWinners.Controls.Add(this.toolWinners);
      this.groupWinners.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupWinners.Location = new System.Drawing.Point(0, 344);
      this.groupWinners.Name = "groupWinners";
      this.groupWinners.Size = new System.Drawing.Size(546, 219);
      this.groupWinners.TabIndex = 1;
      this.groupWinners.TabStop = false;
      this.groupWinners.Text = "Winners";
      // 
      // gridWinners
      // 
      this.gridWinners.AllowUserToAddRows = false;
      this.gridWinners.AllowUserToDeleteRows = false;
      this.gridWinners.AllowUserToOrderColumns = true;
      this.gridWinners.AllowUserToResizeRows = false;
      this.gridWinners.AutoGenerateColumns = false;
      this.gridWinners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridWinners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fldYearDataGridViewTextBoxColumn,
            this.fldClassIDDataGridViewTextBoxColumn,
            this.fldSailNumberDataGridViewTextBoxColumn,
            this.fldHelmDataGridViewTextBoxColumn,
            this.fldCrewDataGridViewTextBoxColumn});
      this.gridWinners.DataSource = this.tblWinnersBindingSource;
      this.gridWinners.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridWinners.Location = new System.Drawing.Point(3, 41);
      this.gridWinners.MultiSelect = false;
      this.gridWinners.Name = "gridWinners";
      this.gridWinners.ReadOnly = true;
      this.gridWinners.RowHeadersVisible = false;
      this.gridWinners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gridWinners.Size = new System.Drawing.Size(540, 175);
      this.gridWinners.TabIndex = 1;
      this.gridWinners.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.gridWinners_CellContextMenuStripNeeded);
      this.gridWinners.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridWinners_CellDoubleClick);
      // 
      // fldYearDataGridViewTextBoxColumn
      // 
      this.fldYearDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.fldYearDataGridViewTextBoxColumn.DataPropertyName = "fldYear";
      this.fldYearDataGridViewTextBoxColumn.HeaderText = "Year";
      this.fldYearDataGridViewTextBoxColumn.Name = "fldYearDataGridViewTextBoxColumn";
      this.fldYearDataGridViewTextBoxColumn.ReadOnly = true;
      this.fldYearDataGridViewTextBoxColumn.Width = 54;
      // 
      // fldClassIDDataGridViewTextBoxColumn
      // 
      this.fldClassIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.fldClassIDDataGridViewTextBoxColumn.DataPropertyName = "fldClassID";
      this.fldClassIDDataGridViewTextBoxColumn.DataSource = this.tblClassesBindingSource;
      this.fldClassIDDataGridViewTextBoxColumn.DisplayMember = "fldName";
      this.fldClassIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
      this.fldClassIDDataGridViewTextBoxColumn.HeaderText = "Class";
      this.fldClassIDDataGridViewTextBoxColumn.Name = "fldClassIDDataGridViewTextBoxColumn";
      this.fldClassIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.fldClassIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.fldClassIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.fldClassIDDataGridViewTextBoxColumn.ValueMember = "fldClassID";
      this.fldClassIDDataGridViewTextBoxColumn.Width = 57;
      // 
      // fldSailNumberDataGridViewTextBoxColumn
      // 
      this.fldSailNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.fldSailNumberDataGridViewTextBoxColumn.DataPropertyName = "fldSailNumber";
      this.fldSailNumberDataGridViewTextBoxColumn.HeaderText = "Sail #";
      this.fldSailNumberDataGridViewTextBoxColumn.Name = "fldSailNumberDataGridViewTextBoxColumn";
      this.fldSailNumberDataGridViewTextBoxColumn.ReadOnly = true;
      this.fldSailNumberDataGridViewTextBoxColumn.Width = 59;
      // 
      // fldHelmDataGridViewTextBoxColumn
      // 
      this.fldHelmDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.fldHelmDataGridViewTextBoxColumn.DataPropertyName = "fldHelm";
      this.fldHelmDataGridViewTextBoxColumn.HeaderText = "Helm";
      this.fldHelmDataGridViewTextBoxColumn.Name = "fldHelmDataGridViewTextBoxColumn";
      this.fldHelmDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // fldCrewDataGridViewTextBoxColumn
      // 
      this.fldCrewDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.fldCrewDataGridViewTextBoxColumn.DataPropertyName = "fldOwner";
      this.fldCrewDataGridViewTextBoxColumn.HeaderText = "Owner";
      this.fldCrewDataGridViewTextBoxColumn.Name = "fldCrewDataGridViewTextBoxColumn";
      this.fldCrewDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // tblWinnersBindingSource
      // 
      this.tblWinnersBindingSource.DataMember = "tblWinners";
      this.tblWinnersBindingSource.DataSource = this.trophyDataSet;
      this.tblWinnersBindingSource.Sort = "[fldYear] DESC";
      this.tblWinnersBindingSource.PositionChanged += new System.EventHandler(this.tblWinnersBindingSource_PositionChanged);
      // 
      // toolWinners
      // 
      this.toolWinners.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.toolWinners.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butAddWinner,
            this.toolStripSeparator3,
            this.butEditWinner,
            this.butDeleteWinner});
      this.toolWinners.Location = new System.Drawing.Point(3, 16);
      this.toolWinners.Name = "toolWinners";
      this.toolWinners.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
      this.toolWinners.Size = new System.Drawing.Size(540, 25);
      this.toolWinners.TabIndex = 0;
      // 
      // butAddWinner
      // 
      this.butAddWinner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.butAddWinner.Image = ((System.Drawing.Image)(resources.GetObject("butAddWinner.Image")));
      this.butAddWinner.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.butAddWinner.Name = "butAddWinner";
      this.butAddWinner.Size = new System.Drawing.Size(23, 22);
      this.butAddWinner.Text = "Add Winner";
      this.butAddWinner.Click += new System.EventHandler(this.butAddWinner_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
      // 
      // butEditWinner
      // 
      this.butEditWinner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.butEditWinner.Image = ((System.Drawing.Image)(resources.GetObject("butEditWinner.Image")));
      this.butEditWinner.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.butEditWinner.Name = "butEditWinner";
      this.butEditWinner.Size = new System.Drawing.Size(23, 22);
      this.butEditWinner.Text = "Edit Winner";
      this.butEditWinner.Click += new System.EventHandler(this.butEditWinner_Click);
      // 
      // butDeleteWinner
      // 
      this.butDeleteWinner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.butDeleteWinner.Image = ((System.Drawing.Image)(resources.GetObject("butDeleteWinner.Image")));
      this.butDeleteWinner.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.butDeleteWinner.Name = "butDeleteWinner";
      this.butDeleteWinner.Size = new System.Drawing.Size(23, 22);
      this.butDeleteWinner.Text = "Delete Winner";
      this.butDeleteWinner.Click += new System.EventHandler(this.butDeleteWinner_Click);
      // 
      // groupTrophyInfo
      // 
      this.groupTrophyInfo.AutoSize = true;
      this.groupTrophyInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.groupTrophyInfo.Controls.Add(this.trophyEditor1);
      this.groupTrophyInfo.Controls.Add(this.toolTrophy);
      this.groupTrophyInfo.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupTrophyInfo.Location = new System.Drawing.Point(0, 0);
      this.groupTrophyInfo.Name = "groupTrophyInfo";
      this.groupTrophyInfo.Size = new System.Drawing.Size(546, 344);
      this.groupTrophyInfo.TabIndex = 0;
      this.groupTrophyInfo.TabStop = false;
      this.groupTrophyInfo.Text = "Trophy Information";
      // 
      // trophyEditor1
      // 
      this.trophyEditor1.DataBindings.Add(new System.Windows.Forms.Binding("ClassID", this.tblTrophiesBindingSource, "fldCurrentClassID", true));
      this.trophyEditor1.DataBindings.Add(new System.Windows.Forms.Binding("Donor", this.tblTrophiesBindingSource, "fldDonor", true));
      this.trophyEditor1.DataBindings.Add(new System.Windows.Forms.Binding("TrophyName", this.tblTrophiesBindingSource, "fldName", true));
      this.trophyEditor1.DataBindings.Add(new System.Windows.Forms.Binding("Conditions", this.tblTrophiesBindingSource, "fldConditions", true));
      this.trophyEditor1.DataBindings.Add(new System.Windows.Forms.Binding("Details", this.tblTrophiesBindingSource, "fldDetails", true));
      this.trophyEditor1.DataBindings.Add(new System.Windows.Forms.Binding("YearDonated", this.tblTrophiesBindingSource, "fldYearDonated", true));
      this.trophyEditor1.DataBindings.Add(new System.Windows.Forms.Binding("RedBookPage", this.tblTrophiesBindingSource, "fldRedBookPage", true));
      this.trophyEditor1.Dock = System.Windows.Forms.DockStyle.Top;
      this.trophyEditor1.IsDirty = true;
      this.trophyEditor1.Location = new System.Drawing.Point(3, 41);
      this.trophyEditor1.MinimumSize = new System.Drawing.Size(400, 300);
      this.trophyEditor1.Name = "trophyEditor1";
      this.trophyEditor1.Size = new System.Drawing.Size(540, 300);
      this.trophyEditor1.TabIndex = 1;
      this.trophyEditor1.IsDirtyChanged += new System.EventHandler(this.trophyEditor1_IsDirtyChanged);
      // 
      // toolTrophy
      // 
      this.toolTrophy.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.toolTrophy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butCommitChanges,
            this.butRejectChanges,
            this.toolStripSeparator2,
            this.butDeleteTrophy,
            this.toolStripSeparator1,
            this.butTrophyPhotos,
            this.butTrophyReport});
      this.toolTrophy.Location = new System.Drawing.Point(3, 16);
      this.toolTrophy.Name = "toolTrophy";
      this.toolTrophy.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
      this.toolTrophy.Size = new System.Drawing.Size(540, 25);
      this.toolTrophy.TabIndex = 0;
      // 
      // butCommitChanges
      // 
      this.butCommitChanges.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.butCommitChanges.Image = ((System.Drawing.Image)(resources.GetObject("butCommitChanges.Image")));
      this.butCommitChanges.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.butCommitChanges.Name = "butCommitChanges";
      this.butCommitChanges.Size = new System.Drawing.Size(23, 22);
      this.butCommitChanges.Text = "Save Changes";
      this.butCommitChanges.Click += new System.EventHandler(this.butCommitChanges_Click);
      // 
      // butRejectChanges
      // 
      this.butRejectChanges.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.butRejectChanges.Image = ((System.Drawing.Image)(resources.GetObject("butRejectChanges.Image")));
      this.butRejectChanges.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.butRejectChanges.Name = "butRejectChanges";
      this.butRejectChanges.Size = new System.Drawing.Size(23, 22);
      this.butRejectChanges.Text = "Reject Changes";
      this.butRejectChanges.Click += new System.EventHandler(this.butRejectChanges_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // butDeleteTrophy
      // 
      this.butDeleteTrophy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.butDeleteTrophy.Image = ((System.Drawing.Image)(resources.GetObject("butDeleteTrophy.Image")));
      this.butDeleteTrophy.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.butDeleteTrophy.Name = "butDeleteTrophy";
      this.butDeleteTrophy.Size = new System.Drawing.Size(23, 22);
      this.butDeleteTrophy.Text = "Delete Trophy";
      this.butDeleteTrophy.Click += new System.EventHandler(this.butDeleteTrophy_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // butTrophyPhotos
      // 
      this.butTrophyPhotos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.butTrophyPhotos.Image = ((System.Drawing.Image)(resources.GetObject("butTrophyPhotos.Image")));
      this.butTrophyPhotos.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.butTrophyPhotos.Name = "butTrophyPhotos";
      this.butTrophyPhotos.Size = new System.Drawing.Size(23, 22);
      this.butTrophyPhotos.Text = "View Photos";
      this.butTrophyPhotos.Click += new System.EventHandler(this.butTrophyPhotos_Click);
      // 
      // butTrophyReport
      // 
      this.butTrophyReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.butTrophyReport.Image = ((System.Drawing.Image)(resources.GetObject("butTrophyReport.Image")));
      this.butTrophyReport.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.butTrophyReport.Name = "butTrophyReport";
      this.butTrophyReport.Size = new System.Drawing.Size(23, 22);
      this.butTrophyReport.Text = "Create Report";
      this.butTrophyReport.Click += new System.EventHandler(this.butTrophyReport_Click);
      // 
      // toolMain
      // 
      this.toolMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butEditClasses,
            this.butReport,
            this.toolStripSeparator5,
            this.butRestore,
            this.butBackup,
            this.toolStripSeparator4,
            this.butUpdate,
            this.butAbout});
      this.toolMain.Location = new System.Drawing.Point(0, 0);
      this.toolMain.Name = "toolMain";
      this.toolMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
      this.toolMain.Size = new System.Drawing.Size(887, 25);
      this.toolMain.TabIndex = 0;
      // 
      // butEditClasses
      // 
      this.butEditClasses.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.butEditClasses.Image = ((System.Drawing.Image)(resources.GetObject("butEditClasses.Image")));
      this.butEditClasses.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.butEditClasses.Name = "butEditClasses";
      this.butEditClasses.Size = new System.Drawing.Size(23, 22);
      this.butEditClasses.Text = "Edit Classes";
      this.butEditClasses.Click += new System.EventHandler(this.butEditClasses_Click);
      // 
      // butReport
      // 
      this.butReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.butReport.Image = ((System.Drawing.Image)(resources.GetObject("butReport.Image")));
      this.butReport.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.butReport.Name = "butReport";
      this.butReport.Size = new System.Drawing.Size(23, 22);
      this.butReport.Text = "Create Report";
      this.butReport.Click += new System.EventHandler(this.butReport_Click);
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
      // 
      // butRestore
      // 
      this.butRestore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.butRestore.Image = ((System.Drawing.Image)(resources.GetObject("butRestore.Image")));
      this.butRestore.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.butRestore.Name = "butRestore";
      this.butRestore.Size = new System.Drawing.Size(23, 22);
      this.butRestore.Text = "Restore from Backup";
      this.butRestore.Click += new System.EventHandler(this.butRestore_Click);
      // 
      // butBackup
      // 
      this.butBackup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.butBackup.Image = ((System.Drawing.Image)(resources.GetObject("butBackup.Image")));
      this.butBackup.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.butBackup.Name = "butBackup";
      this.butBackup.Size = new System.Drawing.Size(23, 22);
      this.butBackup.Text = "Backup database";
      this.butBackup.Click += new System.EventHandler(this.butBackup_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
      // 
      // butUpdate
      // 
      this.butUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.butUpdate.Image = ((System.Drawing.Image)(resources.GetObject("butUpdate.Image")));
      this.butUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.butUpdate.Name = "butUpdate";
      this.butUpdate.Size = new System.Drawing.Size(23, 22);
      this.butUpdate.Text = "Update";
      this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
      // 
      // butAbout
      // 
      this.butAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.butAbout.Image = ((System.Drawing.Image)(resources.GetObject("butAbout.Image")));
      this.butAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.butAbout.Name = "butAbout";
      this.butAbout.Size = new System.Drawing.Size(23, 22);
      this.butAbout.Text = "About";
      this.butAbout.Click += new System.EventHandler(this.butAbout_Click);
      // 
      // dlgRestore
      // 
      this.dlgRestore.DefaultExt = "sdf";
      this.dlgRestore.Filter = "Database files|*.sdf";
      this.dlgRestore.Title = "Restore Trophies database";
      // 
      // dlgBackup
      // 
      this.dlgBackup.DefaultExt = "sdf";
      this.dlgBackup.Filter = "Database files|*.sdf";
      this.dlgBackup.Title = "Backup Trophies database";
      // 
      // tblTrophiesTableAdapter
      // 
      this.tblTrophiesTableAdapter.ClearBeforeFill = true;
      // 
      // tblClassesTableAdapter
      // 
      this.tblClassesTableAdapter.ClearBeforeFill = true;
      // 
      // tblWinnersTableAdapter
      // 
      this.tblWinnersTableAdapter.ClearBeforeFill = true;
      // 
      // mnuWinnersContext
      // 
      this.mnuWinnersContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTrophiesWonBySailNumber});
      this.mnuWinnersContext.Name = "mnuWinnersContext";
      this.mnuWinnersContext.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
      this.mnuWinnersContext.ShowImageMargin = false;
      this.mnuWinnersContext.Size = new System.Drawing.Size(225, 26);
      // 
      // mnuTrophiesWonBySailNumber
      // 
      this.mnuTrophiesWonBySailNumber.Name = "mnuTrophiesWonBySailNumber";
      this.mnuTrophiesWonBySailNumber.Size = new System.Drawing.Size(224, 22);
      this.mnuTrophiesWonBySailNumber.Text = "Trophies won by this sail number";
      this.mnuTrophiesWonBySailNumber.Click += new System.EventHandler(this.mnuTrophiesWonBySailNumber_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(887, 588);
      this.Controls.Add(this.splitter);
      this.Controls.Add(this.toolMain);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "LDYC Trophies";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.splitter.Panel1.ResumeLayout(false);
      this.splitter.Panel2.ResumeLayout(false);
      this.splitter.Panel2.PerformLayout();
      this.splitter.ResumeLayout(false);
      this.groupTrophies.ResumeLayout(false);
      this.groupTrophies.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridTrophies)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tblClassesBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trophyDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tblTrophiesBindingSource)).EndInit();
      this.tableTrophyOptions.ResumeLayout(false);
      this.tableTrophyOptions.PerformLayout();
      this.groupWinners.ResumeLayout(false);
      this.groupWinners.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridWinners)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tblWinnersBindingSource)).EndInit();
      this.toolWinners.ResumeLayout(false);
      this.toolWinners.PerformLayout();
      this.groupTrophyInfo.ResumeLayout(false);
      this.groupTrophyInfo.PerformLayout();
      this.toolTrophy.ResumeLayout(false);
      this.toolTrophy.PerformLayout();
      this.toolMain.ResumeLayout(false);
      this.toolMain.PerformLayout();
      this.mnuWinnersContext.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitter;
    private System.Windows.Forms.GroupBox groupTrophies;
    private System.Windows.Forms.Button butAddTrophy;
    private TrophyDataSet trophyDataSet;
    private System.Windows.Forms.BindingSource tblTrophiesBindingSource;
    private LDYC_Trophies.TrophyDataSetTableAdapters.tblTrophiesTableAdapter tblTrophiesTableAdapter;
    private System.Windows.Forms.BindingSource tblClassesBindingSource;
    private LDYC_Trophies.TrophyDataSetTableAdapters.tblClassesTableAdapter tblClassesTableAdapter;
    private System.Windows.Forms.GroupBox groupTrophyInfo;
    private System.Windows.Forms.ToolStrip toolTrophy;
    private System.Windows.Forms.ToolStripButton butRejectChanges;
    private System.Windows.Forms.GroupBox groupWinners;
    private System.Windows.Forms.DataGridView gridWinners;
    private System.Windows.Forms.ToolStrip toolWinners;
    private System.Windows.Forms.ToolStripButton butAddWinner;
    private System.Windows.Forms.ToolStripButton butCommitChanges;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton butTrophyPhotos;
    private TrophyEditor trophyEditor1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton butDeleteTrophy;
    private System.Windows.Forms.BindingSource tblWinnersBindingSource;
    private LDYC_Trophies.TrophyDataSetTableAdapters.tblWinnersTableAdapter tblWinnersTableAdapter;
    private System.Windows.Forms.TextBox txtFilterTrophies;
    private System.Windows.Forms.Label lblFilterTrophies;
    private System.Windows.Forms.DataGridView gridTrophies;
    private System.Windows.Forms.DataGridViewTextBoxColumn fldNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
    private System.Windows.Forms.TableLayoutPanel tableTrophyOptions;
    private System.Windows.Forms.ToolStripButton butDeleteWinner;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripButton butEditWinner;
    private System.Windows.Forms.ToolStrip toolMain;
    private System.Windows.Forms.ToolStripButton butEditClasses;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripButton butAbout;
    private System.Windows.Forms.ToolStripButton butUpdate;
    private System.Windows.Forms.ToolStripButton butRestore;
    private System.Windows.Forms.ToolStripButton butBackup;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.OpenFileDialog dlgRestore;
    private System.Windows.Forms.SaveFileDialog dlgBackup;
    private System.Windows.Forms.ToolStripButton butTrophyReport;
    private System.Windows.Forms.ToolStripButton butReport;
    private System.Windows.Forms.ContextMenuStrip mnuWinnersContext;
    private System.Windows.Forms.ToolStripMenuItem mnuTrophiesWonBySailNumber;
    private System.Windows.Forms.DataGridViewTextBoxColumn fldYearDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewComboBoxColumn fldClassIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn fldSailNumberDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn fldHelmDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn fldCrewDataGridViewTextBoxColumn;

  }
}

