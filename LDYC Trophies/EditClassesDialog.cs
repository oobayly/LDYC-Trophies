using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LDYC_Trophies {
  public partial class EditClassesDialog : Form {
    #region Constructors
    public EditClassesDialog() {
      InitializeComponent();
    }
    #endregion

    #region Event handlers
    private void butCancel_Click(object sender, EventArgs e) {
      DataTable changes = trophyDataSet.tblClasses.GetChanges();

      if (changes != null && changes.Rows.Count != 0) {
        DialogResult res = MessageBox.Show(this,
          string.Format("{0} change(s) have been made, are you sure you want to reject them?", changes.Rows.Count),
          Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.No)
          return;
      }

      this.DialogResult = DialogResult.Cancel;
    }
    
    private void butOK_Click(object sender, EventArgs e) {
      tblClassesTableAdapter.Update(trophyDataSet.tblClasses);
      this.DialogResult = DialogResult.OK;
    }

    private void EditClassesDialog_Load(object sender, EventArgs e) {
      this.tblClassesTableAdapter.Fill(this.trophyDataSet.tblClasses);
    }

    private void gridClasses_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
      gridClasses.Rows[e.RowIndex].ErrorText = string.Empty;
    }

    private void gridClasses_CellValidating(object sender, DataGridViewCellValidatingEventArgs e) {
      // Only if the Class name is being edited
      if (gridClasses.Columns[e.ColumnIndex].DataPropertyName != "fldName")
        return;

      string className = string.Format("{0}", e.FormattedValue).Trim();
      if (className.Length == 0) {
        gridClasses.Rows[e.RowIndex].ErrorText = "Class name is required.";
        e.Cancel = true;

      }
    }

    private void gridClasses_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e) {
      e.Row.Cells["fldNameDataGridViewTextBoxColumn"].Value = string.Empty;
      e.Row.Cells["fldCreatedDataGridViewTextBoxColumn"].Value = DateTime.Now;
    }

    private void gridClasses_RowValidated(object sender, DataGridViewCellEventArgs e) {
      DataGridViewRow row = gridClasses.Rows[e.RowIndex];

      // No databound item if this is a new row
      if (row.DataBoundItem == null)
        return;

      // Underlying row must have been edited
      DataRow r = (row.DataBoundItem as DataRowView).Row;
      if (r.RowState == DataRowState.Modified)
        row.Cells["fldModifiedDataGridViewTextBoxColumn"].Value = DateTime.Now;
    }

    private void gridClasses_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) {
      // Underlying row must have been edited
      TrophyDataSet.tblClassesRow r = ((e.Row.DataBoundItem as DataRowView).Row as TrophyDataSet.tblClassesRow);

      long count;

      using (TrophyDataSetTableAdapters.tblTrophiesTableAdapter adapter = new LDYC_Trophies.TrophyDataSetTableAdapters.tblTrophiesTableAdapter()) {
        count = (long)adapter.GetTrophyCountByClass(r.fldClassID);
        if (count > 0) {
          MessageBox.Show(this,
            string.Format("'{0}' cannot be deleted as it's being used by {1} trophies.", r.fldName, count),
            Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
          e.Cancel = true;
          return;
        }
      }

      using (TrophyDataSetTableAdapters.tblWinnersTableAdapter adapter = new LDYC_Trophies.TrophyDataSetTableAdapters.tblWinnersTableAdapter()) {
        count = (long)adapter.GetWinnerCountByClass(r.fldClassID);
        if (count > 0) {
          MessageBox.Show(this,
            string.Format("'{0}' cannot be deleted as it's being used by {1} winners.", r.fldName, count),
            Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
          e.Cancel = true;
          return;
        }
      }
    }
    #endregion

    private void gridClasses_DataError(object sender, DataGridViewDataErrorEventArgs e) {
      ConstraintException ex = e.Exception as ConstraintException;
      if (ex != null) {
        MessageBox.Show(this, "The name has already been used. Please use a unique Class Name.",
          Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        e.ThrowException = false;

      } else {
        e.ThrowException = true;

      }
    }
  }
}
