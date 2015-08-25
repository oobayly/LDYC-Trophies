using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LDYC_Trophies {
  [Docking( DockingBehavior.Ask)]
  public partial class TrophyEditor : EditControl {
    #region Properties
    [Bindable(true)]
    [Category("Data")]
    [DefaultValue(1)]
    public int ClassID {
      get {
        if (comboClassID.SelectedValue != null && comboClassID.SelectedValue is int) {
          return (int)comboClassID.SelectedValue;
        } else {
          return 1;
        }
      }
      set { 
        comboClassID.SelectedValue = value;
        OnClassIDChanged();
      }
    }

    [Bindable(true)]
    [Category("Data")]
    [DefaultValue("")]
    public string Conditions {
      get { return txtConditions.Text.Trim(); }
      set { txtConditions.Text = value; }
    }

    [Bindable(true)]
    [Category("Data")]
    [DefaultValue("")]
    public string Details {
      get { return txtDetails.Text.Trim(); }
      set { txtDetails.Text = value; }
    }

    [Bindable(true)]
    [Category("Data")]
    [DefaultValue("")]
    public string Donor {
      get { return txtDonor.Text.Trim(); }
      set { txtDonor.Text = value; }
    }

    [Bindable(true)]
    [Category("Data")]
    [DefaultValue("")]
    public string RedBookPage {
      get { return txtRedBookPage.Text.Trim(); }
      set { txtRedBookPage.Text = value; }
    }

    [Bindable(true)]
    [Category("Data")]
    [DefaultValue("")]
    public string TrophyName {
      get { return txtTrophyName.Text.Trim(); }
      set { txtTrophyName.Text = value; }
    }

    [Bindable(true)]
    [Category("Data")]
    [DefaultValue("")]
    public string YearDonated {
      get { return txtYearDonated.Text.Trim(); }
      set { txtYearDonated.Text = value; }
    }
    #endregion

    #region Constructors
    public TrophyEditor() {
      InitializeComponent();

      ReadOnly = false;
    }
    #endregion

    #region Methods
    private void OnClassIDChanged() {
      txtClass.Text = comboClassID.Text;
    }

    protected override void OnReadOnlyChanged() {
      txtTrophyName.ReadOnly = txtDonor.ReadOnly = txtYearDonated.ReadOnly = txtClass.ReadOnly = 
        txtConditions.ReadOnly = txtDetails.ReadOnly = txtRedBookPage.ReadOnly = ReadOnly;

      txtClass.Visible = ReadOnly;
      comboClassID.Visible = !ReadOnly;
    }

    public void ReloadClasses() {
      bool isDirty = IsDirty;
      int classID = ClassID;
      tblClassesTableAdapter.Fill(trophyDataSet.tblClasses);
      ClassID = classID;
      IsDirty = isDirty;
    }
    #endregion

    #region Event handlers
    private void comboClassID_SelectedValueChanged(object sender, EventArgs e) {
      OnClassIDChanged();
      OnPropertyChanged("ClassID");
      IsDirty = true;
    }

    private void TrophyEditor_Load(object sender, EventArgs e) {
      if (!this.DesignMode)
        this.tblClassesTableAdapter.Fill(this.trophyDataSet.tblClasses);
    }

    private void txt_TextChanged(object sender, EventArgs e) {
      OnPropertyChanged((sender as TextBoxBase).Name.Remove(0, 3));
      IsDirty = true;
    }
    #endregion
  }
}
