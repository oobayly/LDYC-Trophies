using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LDYC_Trophies {
  public partial class EditWinnerDialog : Form {
    #region Properties
    [Category("Data")]
    public int ClassID {
      get { return (int)comboClassID.SelectedValue; }
      set { comboClassID.SelectedValue = value; }
    }

    [Category("Data")]
    public string Crew {
      get { return txtCrew.Text.Trim(); }
      set { txtCrew.Text = value; }
    }

    [Category("Data")]
    public string Helm {
      get { return txtHelm.Text.Trim(); }
      set { txtHelm.Text = value; }
    }

    [Category("Data")]
    public string Notes {
      get { return txtNotes.Text.Trim(); }
      set { txtNotes.Text = value; }
    }

    [Category("Data")]
    public string Owner {
      get { return txtOwner.Text.Trim(); }
      set { txtOwner.Text = value; }
    }

    [Category("Data")]
    public string SailNumber {
      get { return txtSailNumber.Text.Trim(); }
      set { txtSailNumber.Text = value; }
    }

    [Category("Data")]
    public short Year {
      get {
        short val;
        if (short.TryParse(txtYear.Text.Trim(), out val)) {
          return val;
        } else {
          return 0;
        }
      }
      set {
        txtYear.Text = value.ToString();
      }
    }
    #endregion

    #region Constructors
    public EditWinnerDialog() {
      InitializeComponent();

      this.tblClassesTableAdapter.Fill(this.trophyDataSet.tblClasses);
    }
    #endregion

    #region Methods
    #endregion

    #region Event handlers
    private void butOK_Click(object sender, EventArgs e) {
      if (Year == 0) {
        MessageBox.Show(this, "The year is required.", Application.ProductName,
          MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtYear.Focus();
        return;
      }

      if (Helm.Length == 0 && Owner.Length == 0) {
        MessageBox.Show(this, "Either the helm or the owner is required.", Application.ProductName,
          MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtHelm.Focus();
        return;
      }

      this.DialogResult = DialogResult.OK;
      this.Close();
    }
    #endregion
  }
}
