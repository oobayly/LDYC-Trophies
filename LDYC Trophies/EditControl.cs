using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LDYC_Trophies {
  public partial class EditControl : UserControl, INotifyPropertyChanged {
    #region Fields
    private bool isDirty;

    private bool readOnly;
    #endregion

    #region Events
    /// <summary>
    /// Occurs when the control's dirty flag has changed.
    /// </summary>
    [Category("Property Changed")]
    [Description("Occurs when the Control's dirty flag has changed.")]
    public event EventHandler IsDirtyChanged;
    #endregion

    #region Properties
    /// <summary>
    /// Gets or sets whether the control's dirty flag is set.
    /// </summary>
    [Browsable(false)]
    public bool IsDirty {
      get { return isDirty; }
      set {
        if (isDirty == value)
          return;

        isDirty = value;
        OnIsDirtyChanged();
      }
    }

    /// <summary>
    /// Gets or sets whether the control is editable.
    /// </summary>
    [Category("Behavior")]
    [DefaultValue(false)]
    public bool ReadOnly {
      get { return readOnly; }
      set {
        readOnly = value;
        OnReadOnlyChanged();
      }
    }
    #endregion

    #region Constructors
    public EditControl() {
      InitializeComponent();
    }
    #endregion

    #region Methods
    private void OnIsDirtyChanged() {
      if (IsDirtyChanged != null)
        IsDirtyChanged(this, EventArgs.Empty);
    }

    protected void OnPropertyChanged(string propertyName) {
      if (PropertyChanged != null)
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }

    protected virtual void OnReadOnlyChanged() {
    }
    #endregion

    #region INotifyPropertyChanged Members
    public event PropertyChangedEventHandler PropertyChanged;
    #endregion
  }
}
