using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;
using ChangeLogManager.classes;

namespace ChangeLogManager.forms
{
    public partial class fPawnExport : Form
    {
        public static RichTextBox rtbCode;
        //Form -------------------------------------------------------------------------
        public fPawnExport()
        {
            InitializeComponent();
            rtbCode = rtbExport;

            rtbExport.Clear();
            rbCommand.Checked = rbDialog.Checked = false;
            nudDialogId.Value = nudDialogId.Minimum;
            cbDialogStyle.SelectedIndex = -1;
            cbRandomId.Checked = false;
            tbCommandName.Clear();
            cbDialogStyle.SelectedIndex = 0;
            cbProcessor.SelectedIndex = 0;
            tbCaption.Text = fMain.changelogTitle.Text.Trim() + " - " + fMain.changelogVersion.Text.Trim();
        }


        // Radio Buttons ---------------------------------------------------------------
        private void rbCommand_CheckedChanged(object sender, EventArgs e)
        {
            gbCommand.Visible = rbCommand.Checked;
        }


        // Buttons ---------------------------------------------------------------------
        private void bClear_Click(object sender, EventArgs e)
        {
            rtbExport.Clear();
            rbCommand.Checked = rbDialog.Checked = false;
            nudDialogId.Value = nudDialogId.Minimum;
            cbDialogStyle.SelectedIndex = -1;
            cbRandomId.Checked = false;
            tbCommandName.Clear();
            cbProcessor.SelectedIndex = 0;
            tbCaption.Text = fMain.changelogTitle.Text.Trim() + " - " + fMain.changelogVersion.Text.Trim();
        }

        private void bCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbExport.Text);
        }

        private void bExport_Click(object sender, EventArgs e)
        {
            cLog.ExportLog(SaveType.Pawn);
        }

        private void bGenerate_Click(object sender, EventArgs e)
        {
            string output = string.Empty;

            try
            {
                if (rbCommand.Checked == true)
                {
                    if (tbCommandName.Text.Length <= 0) throw new Exception("Input a name for the command first");

                    switch (cbProcessor.SelectedIndex)
                    {
                        case 0:
                        {
                            output += "public OnPlayerCommandText(playerid, cmdtext[])\n{\n";
                            output += "\tif(!strcmp(cmdtext, \"/" + tbCommandName.Text + "\", true))\n\t{\n";
                            output += "\t\t" + "ShowPlayerDialog(playerid, " + nudDialogId.Value + ", " + cbDialogStyle.Text + ", \"" + tbCaption.Text.Trim() + "\", \"" + FormatDialog();
                            output += "\", \"Close\", \"\");\n";
                            output += "\t\treturn 1;\n";
                            output += "\t}\n";
                            output += "\treturn 0;\n}";
                            break;
                        }

                        case 1:
                        {
                            output += "CMD:" + tbCommandName.Text + "(playerid)\n{\n";
                            output += "\t" + "ShowPlayerDialog(playerid, " + nudDialogId.Value + ", " + cbDialogStyle.Text + ", \"" + tbCaption.Text.Trim() + "\", \"" + FormatDialog();
                            output += "\", \"Close\", \"\");\n";
                            output += "\treturn 1;\n}";
                            break;
                        }

                        case 2:
                        {
                            output += "CMD:" + tbCommandName.Text + "(playerid)\n{\n";
                            output += "\t" + "ShowPlayerDialog(playerid, " + nudDialogId.Value + ", " + cbDialogStyle.Text + ", \"" + tbCaption.Text.Trim() + "\", \"" + FormatDialog();
                            output += "\", \"Close\", \"\");\n";
                            output += "\treturn CMD_SUCCESS;\n}";
                            break;
                        }

                        case 3:
                        {
                            output += "cmd:" + tbCommandName.Text + "(playerid)\n{\n";
                            output += "\t" + "ShowPlayerDialog(playerid, " + nudDialogId.Value + ", " + cbDialogStyle.Text + ", \"" + tbCaption.Text.Trim() + "\", \"" + FormatDialog();
                            output += "\", \"Close\", \"\");\n";
                            output += "\treturn 1;\n}";
                            output += "\nalias:help(\"alias1\", \"alias2\", \"alias3\");";
                            break;
                        }

                        case 4:
                        {
                            output += "YCMD:" + tbCommandName.Text + "(playerid, params[], help)\n{\n";
                            output += "\tif(help)\n\t{\n\t\tSendClientMessage(playerid, -1, \"Insert a message here.\");\n\t}";
                            output += "\n\telse\n\t{\n\t\t" + "ShowPlayerDialog(playerid, " + nudDialogId.Value + ", " + cbDialogStyle.Text + ", \"" + tbCaption.Text.Trim() + "\", \"" + FormatDialog();
                            output += "\", \"Close\", \"\");\n\t}";
                            output += "\n\treturn 1;\n}";
                            break;
                        }
                    }
                }

                else
                {
                    if (cbDialogStyle.SelectedIndex < 0) throw new Exception("Choose a dialog style first");

                    output += "ShowPlayerDialog(playerid, " + nudDialogId.Value + ", " + cbDialogStyle.Text + ", \"" + tbCaption.Text.Trim() + "\", \"";
                    output += FormatDialog();
                    output += "\", \"Close\", \"\");";
                }

                rtbExport.Text = output;
            }

            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatDialog()
        {
            string output = string.Empty;

            switch (cbDialogStyle.SelectedIndex)
            {
                case 0:
                {
                    output += "{FFFFFF}* {FFFF00}New features{FFFFFF}\\n\\\n\t\t";
                    foreach (var item in fMain.newFeatures.Items)
                        output += "+ " + item.ToString() + "\\n\\\n\t\t";

                    output += "\\n* {FFFF00}Changes{FFFFFF}\\n\\\n\t\t";
                    foreach (var item in fMain.changes.Items)
                        output += "+ " + item.ToString() + "\\n\\\n\t\t";

                    output += "\\n* {FFFF00}Fixes{FFFFFF}\\n\\\n\t\t";
                    foreach (var item in fMain.fixes.Items)
                        output += "+ " + item.ToString() + "\\n\\\n\t\t";
                    break;
                }

                case 1:
                {
                    output += "{FFFFFF}* {FFFF00}New features{FFFFFF}\\n\\\n\t\t";
                    foreach (var item in fMain.newFeatures.Items)
                        output += "+ " + item.ToString() + "\\n\\\n\t\t";

                    output += "* {FFFF00}Changes{FFFFFF}\\n\\\n\t\t";
                    foreach (var item in fMain.changes.Items)
                        output += "+ " + item.ToString() + "\\n\\\n\t\t";

                    output += "* {FFFF00}Fixes{FFFFFF}\\n\\\n\t\t";
                    foreach (var item in fMain.fixes.Items)
                        output += "+ " + item.ToString() + "\\n\\\n\t\t";
                    break;
                }
            }

            return output;
        }


        // Checkbox ---------------------------------------------------------------------
        private void cbRandomId_CheckedChanged(object sender, EventArgs e)
        {
            if(cbRandomId.Checked == true)
            {
                nudDialogId.Enabled = false;
                Random rand = new Random();
                nudDialogId.Value = rand.Next((int)nudDialogId.Minimum, (int)nudDialogId.Maximum);
            }

            else
                nudDialogId.Enabled = true;
        }


        // RichTextBox ------------------------------------------------------------------
        private void rtbExport_TextChanged(object sender, EventArgs e)
        {
            bExport.Enabled = bCopy.Enabled = (rtbExport.Text.Length > 0);
            syntaxHighlight();
        }

        private void syntaxHighlight()
        {
            Regex syntax = new Regex("(if)|(public)|(return)");
            int index = rtbExport.SelectionStart;

            foreach(Match match in syntax.Matches(rtbExport.Text))
            {
                rtbExport.Select(match.Index, match.Value.Length);
                rtbExport.SelectionColor = Color.Blue;
                rtbExport.SelectionStart = index;
                rtbExport.SelectionColor = Color.Black;
            }
        }
    }
}
