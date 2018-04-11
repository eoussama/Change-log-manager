using System;
using System.Windows.Forms;

namespace ChangeLogManager.forms
{
    public partial class fTitleEdit : Form
    {
        // Form -------------------------------------------------------------------------
        public fTitleEdit()
        {
            InitializeComponent();
        }


        // Textbox ----------------------------------------------------------------------
        private void tbEdit_TextChanged(object sender, EventArgs e)
        {
            bEdit.Enabled = (tbEdit.Text.Length > 0);
        }

        private void tbEdit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                bEdit_Click(sender, e);
        }

        // Button -----------------------------------------------------------------------
        private void bEdit_Click(object sender, EventArgs e)
        {
            fMain.changelogTitle.Text = tbEdit.Text.Trim();
            fMain.UpdateStatusStrip("The change-log's title was successfully edited");
            this.Close();
        }
    }
}
