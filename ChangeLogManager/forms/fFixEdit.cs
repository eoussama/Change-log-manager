﻿using System;
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
    public partial class fFixEdit : Form
    {
        public fFixEdit()
        {
            InitializeComponent();
        }

        private void tbEdit_TextChanged(object sender, EventArgs e)
        {
            bEdit.Enabled = (tbEdit.Text.Length > 0);
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            fMain.fixes.Items[fMain.fixes.SelectedIndex] = tbEdit.Text;
        }
    }
}