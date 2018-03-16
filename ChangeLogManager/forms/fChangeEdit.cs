using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeLogManager.forms
{
    public partial class fChangeEdit : Form
    {
        // Form -------------------------------------------------------------------------
        public fChangeEdit(string textToEdit)
        {
            InitializeComponent();
            tbEdit.Text = textToEdit;
        }


        // Textbox ----------------------------------------------------------------------
        private void tbEdit_TextChanged(object sender, EventArgs e)
        {
            bEdit.Enabled = (tbEdit.Text.Length > 0);
        }


        // Button -----------------------------------------------------------------------
        private void bEdit_Click(object sender, EventArgs e)
        {
            fMain.changes.Items[fMain.changes.SelectedIndex] = tbEdit.Text;
            fMain.UpdateStatusStrip("Entry edited");
            this.Close();
        }
    }
}
