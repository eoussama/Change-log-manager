using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeLogManager
{
    public partial class ucRecent : UserControl
    {
        public static Label title, version, date;
        public static string path;

        public ucRecent()
        {
            InitializeComponent();

            title = lTitle;
            version = lVersion;
            date = lDate;
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
