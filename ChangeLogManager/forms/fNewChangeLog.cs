using System;
using System.Windows.Forms;
using ChangeLogManager.classes;

namespace ChangeLogManager
{
    public partial class fNewChangeLog : Form
    {
        private Form parent;
        private bool closeParent;

        // Form --------------------------------------------------------------------------
        public fNewChangeLog(Form parent, bool closeParent = true)
        {
            InitializeComponent();

            this.parent = parent;
            this.closeParent = closeParent;
        }


        // Textboxes ---------------------------------------------------------------------
        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void tbVersion_TextChanged(object sender, EventArgs e)
        {
            checkInputs();
        }


        // Button ------------------------------------------------------------------------
        public void checkInputs()
        {
            bNew.Enabled = (tbTitle.Text.Length > 0 && tbVersion.Text.Length > 0);
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            if (this.closeParent == true)
            {
                fMain form = new fMain();
                form.Show();
                this.parent.Hide();
            }

            cLog.NewLog(tbTitle.Text, tbVersion.Text);
            this.Close();
        }
    }
}
