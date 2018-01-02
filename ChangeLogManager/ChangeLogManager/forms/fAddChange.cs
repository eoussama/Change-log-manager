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
    public partial class fAddChange : Form
    {
        public fAddChange()
        {
            InitializeComponent();
        }

        private void tbAdd_TextChanged(object sender, EventArgs e)
        {
            bAdd.Enabled = (tbAdd.Text.Length > 0);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            fMain.changes.Items.Add(tbAdd.Text);
            tbAdd.Clear();
        }
    }
}
