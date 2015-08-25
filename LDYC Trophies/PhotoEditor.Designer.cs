namespace LDYC_Trophies {
  partial class PhotoEditor {
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
      this.tblClassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.trophyDataSet = new LDYC_Trophies.TrophyDataSet();
      this.tblClassesTableAdapter = new LDYC_Trophies.TrophyDataSetTableAdapters.tblClassesTableAdapter();
      this.picImage = new System.Windows.Forms.PictureBox();
      this.txtDescription = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.tblClassesBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trophyDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
      this.SuspendLayout();
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
      // tblClassesTableAdapter
      // 
      this.tblClassesTableAdapter.ClearBeforeFill = true;
      // 
      // picImage
      // 
      this.picImage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.picImage.Location = new System.Drawing.Point(0, 0);
      this.picImage.Name = "picImage";
      this.picImage.Size = new System.Drawing.Size(400, 300);
      this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.picImage.TabIndex = 2;
      this.picImage.TabStop = false;
      // 
      // txtDescription
      // 
      this.txtDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.txtDescription.Location = new System.Drawing.Point(0, 250);
      this.txtDescription.MaxLength = 4000;
      this.txtDescription.Multiline = true;
      this.txtDescription.Name = "txtDescription";
      this.txtDescription.Size = new System.Drawing.Size(400, 50);
      this.txtDescription.TabIndex = 3;
      this.txtDescription.TextChanged += new System.EventHandler(this.txt_TextChanged);
      // 
      // PhotoEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.txtDescription);
      this.Controls.Add(this.picImage);
      this.MinimumSize = new System.Drawing.Size(400, 300);
      this.Name = "PhotoEditor";
      this.Size = new System.Drawing.Size(400, 300);
      ((System.ComponentModel.ISupportInitialize)(this.tblClassesBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trophyDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.BindingSource tblClassesBindingSource;
    private TrophyDataSet trophyDataSet;
    private LDYC_Trophies.TrophyDataSetTableAdapters.tblClassesTableAdapter tblClassesTableAdapter;
    private System.Windows.Forms.PictureBox picImage;
    private System.Windows.Forms.TextBox txtDescription;
  }
}
