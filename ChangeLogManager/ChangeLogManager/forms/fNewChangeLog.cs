using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeLogManager
{
    public partial class fNewChangeLog : Form
    {
        public fNewChangeLog()
        {
            InitializeComponent();
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void tbVersion_TextChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        public void checkInputs()
        {
            bNew.Enabled = (tbTitle.Text.Length > 0 && tbVersion.Text.Length > 0);
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            fMain.changelogTitle.Text = tbTitle.Text;
            fMain.changelogVersion.Text = "Version " + tbVersion.Text;
            fMain.newFeatures.Items.Clear();
            fMain.changes.Items.Clear();
            fMain.fixes.Items.Clear();

            this.Close();
        }
    }
}
