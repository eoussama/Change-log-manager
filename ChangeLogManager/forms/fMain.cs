using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using ChangeLogManager.forms;
using ChangeLogManager.classes;

namespace ChangeLogManager
{
    public partial class fMain : Form
    {
        public static Label changelogTitle, changelogVersion;
        public static ListBox newFeatures, changes, fixes;

        // Form ---------------------------------------------------------------------
        public fMain()
        {
            InitializeComponent();

            changelogTitle = lTitle;
            changelogVersion = lVersion;
            newFeatures = lbNew;
            changes = lbChanges;
            fixes = lbFixes;

            ssInfo.Items.Add("Change-log Manager - Version 0.2");
        }
        
        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            fWelcome form = new fWelcome();
            form.Show();
        }


        // MenuStrip - File ---------------------------------------------------------
        private void welcomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fWelcome form = new fWelcome();
            form.Show();
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cLog.OpenLog(this, false);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNewChangeLog form = new fNewChangeLog(this, false);
            form.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cLog.SaveLog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // MenuStrip - About --------------------------------------------------------
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application is mainly focused on creating and managing change-logs,\nIt might not look that professional, but it's still better than having a bunch of files here and there.\n\nCreated on 1/1/2018 - 4:30 PM by Eoussama", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // MenuStrip - Export -------------------------------------------------------
        private void textFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cLog.ExportLog(SaveType.Text);
        }

        private void bBCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cLog.ExportLog(SaveType.BBCode);
        }

        private void markdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cLog.ExportLog(SaveType.Markdown);
        }

        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cLog.ExportLog(SaveType.HTML);
        }

        private void pawnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cLog.ExportLog(SaveType.Pawn);
        }


        // MenuStrip - Edit ---------------------------------------------------------
        private void resetLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!cLog.IsLogEmpty())
            {
                if (MessageBox.Show("Are you sure you want to reset this log? pressing yes will clear all the listboxes.", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    cLog.ResetLog();
            }
            else
                MessageBox.Show("Your log is already empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void editChangelogTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTitleEdit form = new fTitleEdit();
            form.ShowDialog();
        }

        private void editChangelogVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fVersionEdit form = new fVersionEdit();
            form.ShowDialog();
        }


        // ListBox ------------------------------------------------------------------

        private void pbAddNew_Click(object sender, EventArgs e)
        {
            fAddNew form = new fAddNew();
            form.ShowDialog();
        }

        private void pbAddChanges_Click(object sender, EventArgs e)
        {
            fAddChange form = new fAddChange();
            form.ShowDialog();
        }

        private void pbAddFixes_Click(object sender, EventArgs e)
        {
            fAddFix form = new fAddFix();
            form.ShowDialog();
        }
    }
}
