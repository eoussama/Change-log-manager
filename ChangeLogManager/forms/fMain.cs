using System;
using System.Windows.Forms;
using System.IO;
using ChangeLogManager.forms;
using ChangeLogManager.classes;

namespace ChangeLogManager
{
    public partial class fMain : Form
    {
        public static Label changelogTitle, changelogVersion;
        public static ListBox newFeatures, changes, fixes;
        public static StatusStrip StatusStrip;
        public static string currentFile = string.Empty;
        public static string mainTitle;

        // Form ---------------------------------------------------------------------
        public fMain(string path)
        {
            InitializeComponent();

            changelogTitle = lTitle;
            changelogVersion = lVersion;
            newFeatures = lbNew;
            changes = lbChanges;
            fixes = lbFixes;
            StatusStrip = ssInfo;
            mainTitle = this.Text;
            currentFile = path;

            UpdateStatusStrip("Hello, work hard and most importantly, keep being passionate about what you're doing");
        }

        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            fWelcome form = new fWelcome();
            form.Show();
        }

        // MenuStrip - File ---------------------------------------------------------
        private void welcomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All of your unsaved work might be lost due to opening another change-log, make sure you save your progress first.\nDo you want to open another change-log?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OpenFileDialog openF = new OpenFileDialog() { Title = "Change-log open", Filter = "Change-log Files (*.log)|*.log", Multiselect = false };
                if (openF.ShowDialog() == DialogResult.OK)
                    cLog.OpenLog(currentForm: this, path: openF.FileName);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNewChangeLog form = new fNewChangeLog(this, false);
            form.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFile == "")
                cLog.SaveLog();
            else
            {
                StreamWriter streamW = new StreamWriter(currentFile, false);

                try
                {
                    streamW.WriteLine("[Title: " + fMain.changelogTitle.Text.Trim() + "]");
                    streamW.WriteLine("[Version: " + fMain.changelogVersion.Text.Trim() + "]");

                    // New features
                    foreach (var line in fMain.newFeatures.Items)
                        streamW.WriteLine("[New feature: " + line.ToString() + "]");

                    // Changes
                    foreach (var line in fMain.changes.Items)
                        streamW.WriteLine("[Change: " + line.ToString() + "]");

                    // Fixes
                    foreach (var line in fMain.fixes.Items)
                        streamW.WriteLine("[Fix: " + line.ToString() + "]");

                    streamW.WriteLine("\nLast saved on " + DateTime.Now);
                    streamW.Flush();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    streamW.Close();
                }
            }
        }

        private void saveUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cLog.SaveLog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // MenuStrip - About ---------------------------------------------------------
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application is mainly focused on creating and managing change-logs,\nIt might not look that professional, but it's still better than having a bunch of files here and there.\n\nCreated on 1/1/2018 - 4:30 PM by Eoussama", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // MenuStrip - Export --------------------------------------------------------
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
            fPawnExport form = new fPawnExport();
            form.ShowDialog();
        }


        // MenuStrip - Edit ----------------------------------------------------------
        private void resetLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!cLog.IsLogEmpty())
            {
                if (MessageBox.Show("Are you sure you want to reset this log? pressing yes will clear all the listboxes.", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cLog.ResetLog();

                    pbNewCopy.Visible = false;
                    pbNewEdit.Visible = false;
                    pbNewDelete.Visible = false;

                    pbChangeCopy.Visible = false;
                    pbChangeEdit.Visible = false;
                    pbChangeDelete.Visible = false;

                    pbFixCopy.Visible = false;
                    pbFixEdit.Visible = false;
                    pbFixDelete.Visible = false;
                }
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


        // ListBox - Add -------------------------------------------------------------
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


        // ListBox - Delete ----------------------------------------------------------
        private void pbNewDelete_Click(object sender, EventArgs e)
        {
            if (lbNew.SelectedIndex >= 0)
            {
                lbNew.Items.RemoveAt(lbNew.SelectedIndex);
                UpdateStatusStrip("Entry deleted from the “New Features” listbox");
            }
        }

        private void pbChangeDelete_Click(object sender, EventArgs e)
        {
            if (lbChanges.SelectedIndex >= 0)
            {
                lbChanges.Items.RemoveAt(lbChanges.SelectedIndex);
                UpdateStatusStrip("Entry deleted from the “Changes” listbox");
            }
        }

        private void pbFixDelete_Click(object sender, EventArgs e)
        {
            if (lbFixes.SelectedIndex >= 0)
            {
                lbFixes.Items.RemoveAt(lbFixes.SelectedIndex);
                UpdateStatusStrip("Entry deleted from the “Fixes” listbox");
            }
        }


        // ListBox - Edit ------------------------------------------------------------
        private void pbNewEdit_Click(object sender, EventArgs e)
        {
            fNewEdit form = new fNewEdit(lbNew.SelectedItem.ToString());
            form.ShowDialog();
        }

        private void pbChangeEdit_Click(object sender, EventArgs e)
        {
            fChangeEdit form = new fChangeEdit(lbChanges.SelectedItem.ToString());
            form.ShowDialog();
        }

        private void pbFixEdit_Click(object sender, EventArgs e)
        {
            fFixEdit form = new fFixEdit(lbFixes.SelectedItem.ToString());
            form.ShowDialog();
        }


        // ListBox - Copy ------------------------------------------------------------
        private void pbNewCopy_Click(object sender, EventArgs e)
        {
            if (lbNew.SelectedIndex >= 0)
            {
                Clipboard.SetText(lbNew.SelectedItem.ToString());
                UpdateStatusStrip("Entry copied to your clipboard");
            }
        }

        private void pbChangeCopy_Click(object sender, EventArgs e)
        {
            if (lbChanges.SelectedIndex >= 0)
            {
                Clipboard.SetText(lbChanges.SelectedItem.ToString());
                UpdateStatusStrip("Entry copied to your clipboard");
            }
        }

        private void pbFixCopy_Click(object sender, EventArgs e)
        {
            if (lbFixes.SelectedIndex >= 0)
            {
                Clipboard.SetText(lbFixes.SelectedItem.ToString());
                UpdateStatusStrip("Entry copied to your clipboard");
            }
        }


        // ListBox -------------------------------------------------------------------
        private void lbNew_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbNew.SelectedIndex >= 0)
                pbNewCopy.Visible = pbNewEdit.Visible = pbNewDelete.Visible = true;

            else
                pbNewCopy.Visible = pbNewEdit.Visible = pbNewDelete.Visible = false;
        }

        private void lbChanges_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbChanges.SelectedIndex >= 0)
                pbChangeCopy.Visible = pbChangeEdit.Visible = pbChangeDelete.Visible = true;

            else
                pbChangeCopy.Visible = pbChangeEdit.Visible = pbChangeDelete.Visible = false;
        }

        private void lbFixes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFixes.SelectedIndex >= 0)
                pbFixCopy.Visible = pbFixEdit.Visible = pbFixDelete.Visible = true;

            else
                pbFixCopy.Visible = pbFixEdit.Visible = pbFixDelete.Visible = false;
        }

        // Status Strip --------------------------------------------------------------
        public static void UpdateStatusStrip(string text)
        {
            StatusStrip.Items.Clear();
            StatusStrip.Items.Add("Change-log Manager - Version 0.2     |     \t " + text);
        }
    }
}
