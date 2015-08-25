using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Design;

namespace LDYC_Trophies {
  class ImageListBox : ListBox {
    #region Fields
    private CurrencyManager dataManager;

    private string imageMember = "";

    private readonly Dictionary<object, Image> ImageCache;
    #endregion

    #region Properties
    [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design")]
    [Category("Data")]
    [DefaultValue("")]
    [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", typeof(UITypeEditor))]
    public string ImageMember {
      get { return imageMember; }
      set {
        imageMember = value;
        TryDataBinding();
      }
    }
    #endregion

    #region Constructors
    public ImageListBox() {
      this.DrawMode = DrawMode.OwnerDrawVariable;
      this.ItemHeight = 80;
      ImageCache = new Dictionary<object, Image>();
    }
    #endregion

    #region Methods
    private Image GetImage(object item) {
      PropertyDescriptorCollection col = dataManager.GetItemProperties();

      PropertyDescriptor imageProperty = dataManager.GetItemProperties().Find(ImageMember, false);
      PropertyDescriptor valueProperty = dataManager.GetItemProperties().Find(ValueMember, false);

      object value = valueProperty.GetValue(item);

      if (ImageCache.ContainsKey(value))
        return ImageCache[value];

      object data = imageProperty.GetValue(item);
      if (data == null || data == DBNull.Value)
        return null;

      using (System.IO.MemoryStream ms = new System.IO.MemoryStream((byte[])data)) {
        using (Image img = Image.FromStream(ms)) {
          float scale = (float)ItemHeight / img.Height;
          Size s = new Size((int)(scale * img.Width), (int)(scale * img.Height));
          Image thumb = new Bitmap(img, s);

          ImageCache[value] = thumb;
          return thumb;
        }
      }
    }

    private void TryDataBinding() {
      if (this.DataSource == null || this.BindingContext == null)
        return;

      CurrencyManager cm;
      try {
        cm = (CurrencyManager)this.BindingContext[this.DataSource];

      } catch (ArgumentException) {
        return;

      }

      if (dataManager != cm) {
        if (dataManager != null) {
          dataManager.ListChanged -= new ListChangedEventHandler(dataManager_ListChanged);
          dataManager.PositionChanged -= new EventHandler(dataManager_PositionChanged);
        }

        dataManager = cm;
        if (dataManager != null) {
          dataManager.ListChanged += new ListChangedEventHandler(dataManager_ListChanged);
          dataManager.PositionChanged += new EventHandler(dataManager_PositionChanged);
        }
      }

      this.Invalidate();
    }
    #endregion

    #region Overrides
    protected override void OnBindingContextChanged(EventArgs e) {
      TryDataBinding();

      base.OnBindingContextChanged(e);
    }

    protected override void OnDataSourceChanged(EventArgs e) {
      base.OnDataSourceChanged(e);

      TryDataBinding();
    }

    protected override void OnDrawItem(DrawItemEventArgs e) {
      if (e.Index < 0 || e.Index >= this.Items.Count)
        return;

      object item = this.Items[e.Index];
      if (item == null)
        return;

      if ((e.State & DrawItemState.Selected) == DrawItemState.Selected) {
        e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);

      } else {
        e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
      }

      Image img = GetImage(item);
      if (img == null)
        return;

      RectangleF rect = new RectangleF(
        e.Bounds.Left + ((e.Bounds.Width - img.Width) / 2),
        e.Bounds.Top,
        img.Width, img.Height);
      e.Graphics.DrawImage(img, rect);
    }

    protected override void OnValueMemberChanged(EventArgs e) {
      base.OnValueMemberChanged(e);

      TryDataBinding();
    }
    #endregion

    #region Event handlers
    void dataManager_ListChanged(object sender, ListChangedEventArgs e) {
      this.Invalidate();
    }

    void dataManager_PositionChanged(object sender, EventArgs e) {
      //throw new NotImplementedException();
    }
    #endregion
  }
}
