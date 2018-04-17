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

            tbEdit.Text = fMain.changelogTitle.Text.Trim();
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
            try
            {
                if (tbEdit.Text.Length > 30) throw new Exception("The change-log's title has to be shorter than 30 characters.");

                fMain.changelogTitle.Text = tbEdit.Text.Trim();
                fMain.UpdateStatusStrip("The change-log's title was successfully edited");
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
