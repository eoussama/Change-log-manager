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

namespace ChangeLogManager
{
    public partial class fMain : Form
    {
        public static Label changelogTitle, changelogVersion;
        public static ListBox newFeatures, changes, fixes;

        public fMain()
        {
            InitializeComponent();

            changelogTitle = lTitle;
            changelogVersion = lVersion;
            newFeatures = lbNew;
            changes = lbChanges;
            fixes = lbFixes;
            ssInfo.Items.Add("Change-log manager - version 0.1");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application is mainly focused on creating and managing change-logs,\nIt might not look that professional, but it's still better than having a bunch of files here and there.\n\nCreated on 1/1/2018 - 4:30 PM by Eoussama", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNewChangeLog form = new fNewChangeLog();
            form.ShowDialog();
        }

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

        private void fMain_Shown(object sender, EventArgs e)
        {
            fNewChangeLog form = new fNewChangeLog();
            form.ShowDialog();
        }

        private void selectedNewFeatureToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (lbNew.Items.Count > 0 && lbNew.SelectedItem != null)
                Clipboard.SetText(lbNew.Text);
        }

        private void selectedChangeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (lbChanges.Items.Count > 0 && lbChanges.SelectedItem != null)
                Clipboard.SetText(lbChanges.Text);
        }

        private void selectedFixToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (lbFixes.Items.Count > 0 && lbFixes.SelectedItem != null)
                Clipboard.SetText(lbFixes.Text);
        }

        private void selectedNewFeatureToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lbNew.Items.Count > 0 && lbNew.SelectedItem != null)
                lbNew.Items.RemoveAt(lbNew.SelectedIndex);
        }

        private void selectedChangeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lbChanges.Items.Count > 0 && lbChanges.SelectedItem != null)
                lbChanges.Items.RemoveAt(lbChanges.SelectedIndex);
        }

        private void selectedFixToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lbFixes.Items.Count > 0 && lbFixes.SelectedItem != null)
                lbFixes.Items.RemoveAt(lbFixes.SelectedIndex);
        }

        private void selectedNewFeatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbNew.Items.Count > 0 && lbNew.SelectedItem != null)
            {
                fNewEdit form = new fNewEdit();
                form.ShowDialog();
            }
        }

        private void selectedChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbChanges.Items.Count > 0 && lbChanges.SelectedItem != null)
            {
                fChangeEdit form = new fChangeEdit();
                form.ShowDialog();
            }
        }

        private void selectedFixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbFixes.Items.Count > 0 && lbFixes.SelectedItem != null)
            {
                fFixEdit form = new fFixEdit();
                form.ShowDialog();
            }
        }

        private void textFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveF = new SaveFileDialog() { Title = "Change-log export as text file", Filter = "Change-log Files (*.txt)|*.txt" };
            if (saveF.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamW = new StreamWriter(saveF.FileName);

                try
                {
                    streamW.WriteLine("Title: " + lTitle.Text.Trim());
                    streamW.WriteLine("Version: " + lVersion.Text.Trim());

                    // New features
                    streamW.WriteLine("\r\n\r\n* New feature");
                    foreach (var line in lbNew.Items)
                        streamW.WriteLine("\t-" + line.ToString());

                    // Changes
                    streamW.WriteLine("\r\n\r\n* Changes");
                    foreach (var line in lbChanges.Items)
                        streamW.WriteLine("\t-" + line.ToString());

                    // Fixes
                    streamW.WriteLine("\r\n\r\n* Fixes");
                    foreach (var line in lbFixes.Items)
                        streamW.WriteLine("\t-"+line.ToString());

                    streamW.WriteLine("\r\n\r\n\r\nExported on " + DateTime.Now);
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

        private void markdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveF = new SaveFileDialog() { Title = "Change-log export in markdown format", Filter = "Change-log Files (*.txt)|*.txt" };
            if (saveF.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamW = new StreamWriter(saveF.FileName);

                try
                {
                    streamW.WriteLine("#**" + lTitle.Text.Trim() + "**");
                    streamW.WriteLine("###*" + lVersion.Text.Trim() + "*");

                    // New features
                    streamW.WriteLine("\r\n\r\n>####**New feature**");
                    foreach (var line in lbNew.Items)
                        streamW.WriteLine("- " + line.ToString());

                    // Changes
                    streamW.WriteLine("\r\n\r\n>####**Changes**");
                    foreach (var line in lbChanges.Items)
                        streamW.WriteLine("- " + line.ToString());

                    // Fixes
                    streamW.WriteLine("\r\n\r\n>####**Fixes**");
                    foreach (var line in lbFixes.Items)
                        streamW.WriteLine("- " + line.ToString());

                    streamW.WriteLine("\r\n\r\n\r\n*Exported on " + DateTime.Now + "*");
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

        private void bBCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveF = new SaveFileDialog() { Title = "Change-log export in BBCode", Filter = "Change-log Files (*.txt)|*.txt" };
            if (saveF.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamW = new StreamWriter(saveF.FileName);

                try
                {
                    streamW.WriteLine("[B][SIZE=6][CENTER] "+ lTitle.Text.Trim() +" [/CENTER][/SIZE][/B]");
                    streamW.WriteLine("[B][SIZE=2][CENTER]"+ lVersion.Text.Trim() +"[/CENTER][/SIZE][/B]");

                    // New features
                    streamW.WriteLine("\r\n\r\n[B]New feature[/B][CODE][LIST]");
                    foreach (var line in lbNew.Items)
                        streamW.WriteLine("[*]" + line.ToString());
                    streamW.WriteLine("[/LIST][/CODE]");

                    // Changes
                    streamW.WriteLine("\r\n\r\n[B]Changes[/B][CODE][LIST]");
                    foreach (var line in lbChanges.Items)
                        streamW.WriteLine("[*]" + line.ToString());
                    streamW.WriteLine("[/LIST][/CODE]");

                    // Fixes
                    streamW.WriteLine("\r\n\r\n[B]Fixes[/B][CODE][LIST]");
                    foreach (var line in lbFixes.Items)
                        streamW.WriteLine("[*]" + line.ToString());
                    streamW.WriteLine("[/LIST][/CODE]");

                    streamW.WriteLine("\r\n\r\n\r\n[I]Exported on " + DateTime.Now + "[/I]");
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

        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveF = new SaveFileDialog() { Title = "Change-log export in HTML format", Filter = "Change-log Files (*.html)|*.html" };
            if (saveF.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamW = new StreamWriter(saveF.FileName);

                try
                {
                    streamW.WriteLine("<!DOCTYPE html>");
                    streamW.WriteLine("<html>");
                    streamW.WriteLine("</head>");
                    streamW.WriteLine("<style>");
                    streamW.WriteLine("div{margin-left: 350px;}\r\nh1{font-family: arial;text-align: center;font-weight: weight;font-size: 3em;}\r\n.ver{font-size: .5em;color: orange;}\r\nh4{border-spacing:10px;border-left: 5px solid black;border-color: gray;border-radius: 2px;font-weight: bold;color: gray;font-family: arial;}\r\nul{width: 700px;border-radius: 5px;background-color: gray;color: white;padding: 20px;font-family: arial;}");
                    streamW.WriteLine("</style>");
                    streamW.WriteLine("</head>");
                    streamW.WriteLine("<body>");
                    streamW.WriteLine("<h1>" + lTitle.Text.Trim() + "  <span class=\"ver\">" + lVersion.Text.Trim() + "</span></h1>");
                    streamW.WriteLine("<div>");
                    // New features
                    streamW.WriteLine("\r\n\r\n<h4><b>New feature</b></h4>");
                    streamW.WriteLine("<ul>");
                    foreach (var line in lbNew.Items)
                        streamW.WriteLine("<li>" + line.ToString() + "</li>");
                    streamW.WriteLine("</ul>");

                    // Changes
                    streamW.WriteLine("\r\n\r\n<h4><b>Changes</b></h4>");
                    streamW.WriteLine("<ul>");
                    foreach (var line in lbChanges.Items)
                        streamW.WriteLine("<li>" + line.ToString() + "</li>");
                    streamW.WriteLine("</ul>");

                    // Fixes
                    streamW.WriteLine("\r\n\r\n<h4><b>Fixes</b></h4>");
                    streamW.WriteLine("<ul>");
                    foreach (var line in lbFixes.Items)
                        streamW.WriteLine("<li>" + line.ToString() + "</li>");
                    streamW.WriteLine("</ul>");

                    streamW.WriteLine("\r\n\r\n\r\n<i>Exported on " + DateTime.Now + "<i>");
                    streamW.WriteLine("</div>");
                    streamW.WriteLine("</body>");
                    streamW.WriteLine("</html>");
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

        private void pawnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPawnExport form = new fPawnExport();
            form.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openF = new OpenFileDialog() { Title = "Change-log open", Filter = "Change-log Files (*.log)|*.log" };
            if (openF.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamR = new StreamReader(openF.FileName);

                try
                {
                    while(!streamR.EndOfStream)
                    {
                        string line = streamR.ReadLine();

                        if (Regex.IsMatch(line, @"^\[Title: (.)*\]$"))
                            lTitle.Text = line.Substring(8, line.Length - 9);
                        else if (Regex.IsMatch(line, @"^\[Version: (.)*\]$"))
                            lVersion.Text = line.Substring(10, line.Length - 11);
                        else if (Regex.IsMatch(line, @"^\[New feature: (.)*\]$"))
                            lbNew.Items.Add(line.Substring(14, line.Length - 15));
                        else if (Regex.IsMatch(line, @"^\[Change: (.)*\]$"))
                            lbChanges.Items.Add(line.Substring(9, line.Length - 10));
                        else if (Regex.IsMatch(line, @"^\[Fix: (.)*\]$"))
                            lbFixes.Items.Add(line.Substring(6, line.Length - 7));
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    streamR.Close();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveF = new SaveFileDialog() { Title = "Change-log save", Filter = "Change-log Files (*.log)|*.log"};
            if(saveF.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamW = new StreamWriter(saveF.FileName);

                try
                {
                    streamW.WriteLine("[Title: " + lTitle.Text.Trim() + " ]");
                    streamW.WriteLine("[Version: " + lVersion.Text.Trim() + " ]");

                    // New features
                    foreach (var line in lbNew.Items)
                        streamW.WriteLine("[New feature: " + line.ToString() + "]");

                    // Changes
                    foreach (var line in lbChanges.Items)
                        streamW.WriteLine("[Change: " + line.ToString() + "]");

                    // Fixes
                    foreach (var line in lbFixes.Items)
                        streamW.WriteLine("[Fix: " + line.ToString() + "]");

                    streamW.WriteLine("\nLast saved on " + DateTime.Now);
                }
                
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    streamW.Close();
                }
            }  
        }
    }
}
