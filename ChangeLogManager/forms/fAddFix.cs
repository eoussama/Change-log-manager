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
    public partial class fAddFix : Form
    {
        // Form ------------------------------------------------------------------------
        public fAddFix()
        {
            InitializeComponent();
        }


        // Textbox ---------------------------------------------------------------------
        private void tbAdd_TextChanged(object sender, EventArgs e)
        {
            bAdd.Enabled = (tbAdd.Text.Length > 0);
        }


        // Button ----------------------------------------------------------------------
        private void bAdd_Click(object sender, EventArgs e)
        {
            fMain.fixes.Items.Add(tbAdd.Text);
            fMain.UpdateStatusStrip("Entry added");
            tbAdd.Clear();
        }
    }
}
