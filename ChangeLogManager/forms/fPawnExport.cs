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

namespace ChangeLogManager.forms
{
    public partial class fPawnExport : Form
    {
        public fPawnExport()
        {
            InitializeComponent();
        }

        private void bCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbExport.Text);
        }

        private void bExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveF = new SaveFileDialog() { Title = "Change-log export in pawn syntax", Filter = "Change-log Files (*.pwn)|*.pwn" };
            if (saveF.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamW = new StreamWriter(saveF.FileName);

                try
                {
                    streamW.WriteLine(rtbExport.Text);
                    streamW.WriteLine("\r\n\r\n\r\n//Exported on " + DateTime.Now);
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

        private void rbCommand_CheckedChanged(object sender, EventArgs e)
        {
            tbCommandName.Enabled = rbCommand.Checked;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            rtbExport.Clear();
            cmDialogStyle.SelectedIndex = -1;
            tbDialogName.Clear();
            rbCommand.Checked = rbDialog.Checked = false;
        }

        private void bGenerate_Click(object sender, EventArgs e)
        {
            string outPut = string.Empty, body = string.Empty;
            Random rand = new Random();

            if(rbCommand.Checked)
            {
                outPut += "CMD:" + tbCommandName.Text + "(playerid)\n{\n";
                if (cmDialogStyle.SelectedIndex == 0)
                {
                    body += fMain.changelogTitle.Text.Trim() + " - " + fMain.changelogVersion.Text.Trim() + "\\n\\n";

                    body += "\\n\\n* New features\\n";
                    foreach (var line in fMain.newFeatures.Items)
                        body += "-" + line.ToString() + "\\n";

                    body += "\\n\\n* Changes\\n";
                    foreach (var line in fMain.changes.Items)
                        body += "-" + line.ToString() + "\\n";
                    body += "\\n\\n* Fixes\\n";
                    foreach (var line in fMain.fixes.Items)
                        body += "-" + line.ToString() + "\\n\\";
                }
                else if (cmDialogStyle.SelectedIndex == 1)
                {
                    outPut += "CMD:" + tbCommandName.Text + "(playerid)\n{\n";
                    if (cmDialogStyle.SelectedIndex == 0)
                    {
                        body += "\\n\\n* New features\\n";
                        foreach (var line in fMain.newFeatures.Items)
                            body += "-" + line.ToString() + "\\n";

                        body += "\\n\\n* Changes\\n";
                        foreach (var line in fMain.changes.Items)
                            body += "-" + line.ToString() + "\\n";
                        body += "\\n\\n* Fixes\\n";
                        foreach (var line in fMain.fixes.Items)
                            body += "-" + line.ToString() + "\\n\\";
                    }
                }
                outPut += "\tShowPlayerDialog(playerid, "+rand.Next(1000, 5000)+", "+cmDialogStyle.Text+", \""+tbDialogName.Text+"\", \""+body+"\", \"Close\", \"\");";
                outPut += "\n\treturn 1;\n}";
            }

            else
            {
                if (cmDialogStyle.SelectedIndex == 0)
                {
                    body += fMain.changelogTitle.Text.Trim() + " - " + fMain.changelogVersion.Text.Trim() + "\\n\\n";

                    body += "\\n\\n* New features\\n";
                    foreach (var line in fMain.newFeatures.Items)
                        body += "-" + line.ToString() + "\\n";

                    body += "\\n\\n* Changes\\n";
                    foreach (var line in fMain.changes.Items)
                        body += "-" + line.ToString() + "\\n";
                    body += "\\n\\n* Fixes\\n";
                    foreach (var line in fMain.fixes.Items)
                        body += "-" + line.ToString() + "\\n\\";
                }
                else if (cmDialogStyle.SelectedIndex == 1)
                {
                    outPut += "CMD:" + tbCommandName.Text + "(playerid)\n{\n";
                    if (cmDialogStyle.SelectedIndex == 0)
                    {
                        body += "\\n\\n* New features\\n";
                        foreach (var line in fMain.newFeatures.Items)
                            body += "-" + line.ToString() + "\\n";

                        body += "\\n\\n* Changes\\n";
                        foreach (var line in fMain.changes.Items)
                            body += "-" + line.ToString() + "\\n";
                        body += "\\n\\n* Fixes\\n";
                        foreach (var line in fMain.fixes.Items)
                            body += "-" + line.ToString() + "\\n\\";
                    }
                }
                outPut += "\tShowPlayerDialog(playerid, " + rand.Next(1000, 5000) + ", " + cmDialogStyle.Text + ", \"" + tbDialogName.Text + "\", \"" + body + "\", \"Close\", \"\");";
            }

            rtbExport.Text = outPut;
        }
    }
}
