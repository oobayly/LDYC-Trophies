namespace LDYC_Trophies {
  partial class PhotoDialog {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotoDialog));
      this.table = new System.Windows.Forms.TableLayoutPanel();
      this.listImages = new LDYC_Trophies.ImageListBox();
      this.tblPhotosBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.trophyDataSet = new LDYC_Trophies.TrophyDataSet();
      this.panelPhoto = new System.Windows.Forms.Panel();
      this.photoEditor = new LDYC_Trophies.PhotoEditor();
      this.tool = new System.Windows.Forms.ToolStrip();
      this.butOpen = new System.Windows.Forms.ToolStripButton();
      this.butPaste = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.butCommit = new System.Windows.Forms.ToolStripButton();
      this.butReject = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.butDelete = new System.Windows.Forms.ToolStripButton();
      this.tblPhotosTableAdapter = new LDYC_Trophies.TrophyDataSetTableAdapters.tblPhotosTableAdapter();
      this.openPhotoDialog = new System.Windows.Forms.OpenFileDialog();
      this.butClose = new System.Windows.Forms.Button();
      this.table.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tblPhotosBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trophyDataSet)).BeginInit();
      this.panelPhoto.SuspendLayout();
      this.tool.SuspendLayout();
      this.SuspendLayout();
      // 
      // table
      // 
      this.table.ColumnCount = 3;
      this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
      this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.table.Controls.Add(this.listImages, 0, 0);
      this.table.Controls.Add(this.panelPhoto, 1, 0);
      this.table.Controls.Add(this.butClose, 2, 1);
      this.table.Dock = System.Windows.Forms.DockStyle.Fill;
      this.table.Location = new System.Drawing.Point(0, 0);
      this.table.Name = "table";
      this.table.RowCount = 2;
      this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.table.Size = new System.Drawing.Size(772, 573);
      this.table.TabIndex = 0;
      // 
      // listImages
      // 
      this.listImages.AllowDrop = true;
      this.listImages.DataSource = this.tblPhotosBindingSource;
      this.listImages.DisplayMember = "fldPhotoID";
      this.listImages.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listImages.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
      this.listImages.FormattingEnabled = true;
      this.listImages.ImageMember = "fldData";
      this.listImages.IntegralHeight = false;
      this.listImages.ItemHeight = 100;
      this.listImages.Location = new System.Drawing.Point(3, 3);
      this.listImages.Name = "listImages";
      this.table.SetRowSpan(this.listImages, 2);
      this.listImages.Size = new System.Drawing.Size(194, 567);
      this.listImages.TabIndex = 0;
      this.listImages.ValueMember = "fldPhotoID";
      this.listImages.DragDrop += new System.Windows.Forms.DragEventHandler(this.listImages_DragDrop);
      this.listImages.DragEnter += new System.Windows.Forms.DragEventHandler(this.listImages_DragEnter);
      // 
      // tblPhotosBindingSource
      // 
      this.tblPhotosBindingSource.DataMember = "tblPhotos";
      this.tblPhotosBindingSource.DataSource = this.trophyDataSet;
      this.tblPhotosBindingSource.PositionChanged += new System.EventHandler(this.tblPhotosBindingSource_PositionChanged);
      // 
      // trophyDataSet
      // 
      this.trophyDataSet.DataSetName = "TrophyDataSet";
      this.trophyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // panelPhoto
      // 
      this.table.SetColumnSpan(this.panelPhoto, 2);
      this.panelPhoto.Controls.Add(this.photoEditor);
      this.panelPhoto.Controls.Add(this.tool);
      this.panelPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelPhoto.Location = new System.Drawing.Point(203, 3);
      this.panelPhoto.Name = "panelPhoto";
      this.panelPhoto.Size = new System.Drawing.Size(566, 538);
      this.panelPhoto.TabIndex = 1;
      // 
      // photoEditor
      // 
      this.photoEditor.DataBindings.Add(new System.Windows.Forms.Binding("Description", this.tblPhotosBindingSource, "fldDescription", true));
      this.photoEditor.DataBindings.Add(new System.Windows.Forms.Binding("ImageData", this.tblPhotosBindingSource, "fldData", true));
      this.photoEditor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.photoEditor.IsDirty = false;
      this.photoEditor.Location = new System.Drawing.Point(0, 25);
      this.photoEditor.MinimumSize = new System.Drawing.Size(400, 300);
      this.photoEditor.Name = "photoEditor";
      this.photoEditor.ReadOnly = true;
      this.photoEditor.Size = new System.Drawing.Size(566, 513);
      this.photoEditor.TabIndex = 1;
      this.photoEditor.IsDirtyChanged += new System.EventHandler(this.photoEditor_IsDirtyChanged);
      // 
      // tool
      // 
      this.tool.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butOpen,
            this.butPaste,
            this.toolStripSeparator2,
            this.butCommit,
            this.butReject,
            this.toolStripSeparator1,
            this.butDelete});
      this.tool.Location = new System.Drawing.Point(0, 0);
      this.tool.Name = "tool";
      this.tool.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
      this.tool.Size = new System.Drawing.Size(566, 25);
      this.tool.TabIndex = 0;
      // 
      // butOpen
      // 
      this.butOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.butOpen.Image = global::LDYC_Trophies.Properties.Resources.Open_File_or_Folder_16_n_m;
      this.butOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.butOpen.Name = "butOpen";
      this.butOpen.Size = new System.Drawing.Size(23, 22);
      this.butOpen.Text = "Add Photos";
      this.butOpen.Click += new System.EventHandler(this.butOpen_Click);
      // 
      // butPaste
      // 
      this.butPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.butPaste.Image = global::LDYC_Trophies.Properties.Resources.Paste_16_n_p;
      this.butPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.butPaste.Name = "butPaste";
      this.butPaste.Size = new System.Drawing.Size(23, 22);
      this.butPaste.Text = "Paste Photo";
      this.butPaste.Click += new System.EventHandler(this.butPaste_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // butCommit
      // 
      this.butCommit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.butCommit.Image = global::LDYC_Trophies.Properties.Resources.Green_Checkmark_16_n_p;
      this.butCommit.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.butCommit.Name = "butCommit";
      this.butCommit.Size = new System.Drawing.Size(23, 22);
      this.butCommit.Text = "Save Changes";
      // 
      // butReject
      // 
      this.butReject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.butReject.Image = global::LDYC_Trophies.Properties.Resources.Red_Delete_16_n_p;
      this.butReject.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.butReject.Name = "butReject";
      this.butReject.Size = new System.Drawing.Size(23, 22);
      this.butReject.Text = "Reject Changes";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // butDelete
      // 
      this.butDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.butDelete.Image = global::LDYC_Trophies.Properties.Resources.Red_Minus_16_n_p;
      this.butDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.butDelete.Name = "butDelete";
      this.butDelete.Size = new System.Drawing.Size(23, 22);
      this.butDelete.Text = "Delete Photo";
      this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
      // 
      // tblPhotosTableAdapter
      // 
      this.tblPhotosTableAdapter.ClearBeforeFill = true;
      // 
      // openPhotoDialog
      // 
      this.openPhotoDialog.Filter = "All Files|*.*|All Images|*.jpeg;*.jpg;*.gif;*.tiff;*.tif;*.bmp;*.png|JPEG Files|*" +
          ".jpeg;*.jpg|GIF Files|*.gif|PNG Files|*.png|Bitmap Files|*.bmp|TIFF Files|*.tiff" +
          ";*.tif";
      this.openPhotoDialog.FilterIndex = 2;
      this.openPhotoDialog.Multiselect = true;
      this.openPhotoDialog.Title = "Open Photos";
      // 
      // butClose
      // 
      this.butClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.butClose.Location = new System.Drawing.Point(694, 547);
      this.butClose.Name = "butClose";
      this.butClose.Size = new System.Drawing.Size(75, 23);
      this.butClose.TabIndex = 2;
      this.butClose.Text = "Close";
      this.butClose.UseVisualStyleBackColor = true;
      // 
      // PhotoDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.butClose;
      this.ClientSize = new System.Drawing.Size(772, 573);
      this.Controls.Add(this.table);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "PhotoDialog";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Photos";
      this.Load += new System.EventHandler(this.PhotoDialog_Load);
      this.DragDrop += new System.Windows.Forms.DragEventHandler(this.listImages_DragDrop);
      this.DragEnter += new System.Windows.Forms.DragEventHandler(this.listImages_DragEnter);
      this.table.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.tblPhotosBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trophyDataSet)).EndInit();
      this.panelPhoto.ResumeLayout(false);
      this.panelPhoto.PerformLayout();
      this.tool.ResumeLayout(false);
      this.tool.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel table;
    private ImageListBox listImages;
    private System.Windows.Forms.Panel panelPhoto;
    private System.Windows.Forms.ToolStrip tool;
    private System.Windows.Forms.ToolStripButton butOpen;
    private System.Windows.Forms.ToolStripButton butPaste;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton butDelete;
    private System.Windows.Forms.ToolStripButton butCommit;
    private System.Windows.Forms.ToolStripButton butReject;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private TrophyDataSet trophyDataSet;
    private System.Windows.Forms.BindingSource tblPhotosBindingSource;
    private LDYC_Trophies.TrophyDataSetTableAdapters.tblPhotosTableAdapter tblPhotosTableAdapter;
    private PhotoEditor photoEditor;
    private System.Windows.Forms.OpenFileDialog openPhotoDialog;
    private System.Windows.Forms.Button butClose;


  }
}