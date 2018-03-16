using System;
using System.Windows.Forms;

namespace ChangeLogManager.forms
{
    public partial class fVersionEdit : Form
    {
        // Form -------------------------------------------------------------------------
        public fVersionEdit()
        {
            InitializeComponent();
        }


        // Textbox ----------------------------------------------------------------------
        private void tbEdit_TextChanged(object sender, EventArgs e)
        {
            bEdit.Enabled = (tbEdit.Text.Length > 0);
        }


        // Button -----------------------------------------------------------------------
        private void bEdit_Click(object sender, EventArgs e)
        {
            fMain.changelogVersion.Text = "Version " + tbEdit.Text.Trim();
            fMain.UpdateStatusStrip("The change-log's version was successfully edited");
            this.Close();
        }
    }
}
