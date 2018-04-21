using System;
using System.Drawing;
using System.Windows.Forms;
using ChangeLogManager.classes;

namespace ChangeLogManager
{
    public partial class ucRecent : UserControl
    {
        public Label title, version, date;
        public string path;

        public ucRecent()
        {
            InitializeComponent();

            title = lTitle;
            version = lVersion;
            date = lDate;
        }

        private void lDate_MouseEnter(object sender, EventArgs e)
        {
            ucRecent_MouseEnter(this, e);
        }

        private void lDate_MouseLeave(object sender, EventArgs e)
        {
            ucRecent_MouseLeave(this, e);
        }

        private void ucRecent_Click(object sender, EventArgs e)
        {
            cLog.OpenLog(this.ParentForm, true, this.path);
        }

        private void lDate_Click(object sender, EventArgs e)
        {
            ucRecent_Click(this, e);
        }

        private void lClose_MouseEnter(object sender, EventArgs e)
        {
            this.lClose.ForeColor = Color.DimGray;
        }

        private void lClose_MouseLeave(object sender, EventArgs e)
        {
            this.lClose.ForeColor = Color.White;
        }

        private void lClose_Click(object sender, EventArgs e)
        {
            cLog.RemoveLogFromRecent(this.path);
        }

        private void ucRecent_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void ucRecent_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ScrollBar;
        }
    }
}
