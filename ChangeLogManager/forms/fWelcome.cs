using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using ChangeLogManager.classes;

namespace ChangeLogManager.forms
{
    public partial class fWelcome : Form
    {
        public static Panel menu;

        // Form --------------------------------------------------------------------------
        public fWelcome()
        {
            InitializeComponent();

            menu = this.pMenu;

            if (!File.Exists("config.cfg"))
            {
                StreamWriter streamW = new StreamWriter("config.cfg", false);
                streamW.WriteLine("\t\t\t-[Change-log manager config]-");
                streamW.Flush();
                streamW.Close();
            }

            else
            {
                StreamReader streamR = new StreamReader("config.cfg");

                try
                {
                    while (!streamR.EndOfStream)
                    {
                        string line = streamR.ReadLine();

                        if (Regex.IsMatch(line, @"^\[Recent: (.)*\]$"))
                        {
                            ucRecent recent = new ucRecent();
                            recent.Top = (bNew.Height * 2) + pRecentCount.Size.Height + (recent.Height * pMenu.Controls.OfType<ucRecent>().Count());
                            recent.Left = bNew.Left;
                            recent.path = line.Substring(9, line.Length - 10);

                            if (File.Exists(recent.path))
                            {
                                recent.title.Text = cLog.getLogTitle(recent.path);
                                recent.version.Text = "Version " + cLog.getLogVersion(recent.path);
                                recent.date.Text = cLog.getLogDate(recent.path);
                                pMenu.Controls.Add(recent);
                            }
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    streamR.Close();
                    cLog.Flush();
                }
            }

            int recentCount = pMenu.Controls.OfType<ucRecent>().Count();
            lRecentCount.Text = "You have " + recentCount + " recent file" + (recentCount == 1 ? "" : "s");
        }

        private void fWelcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        // Buttons -----------------------------------------------------------------------
        private void bNew_Click(object sender, EventArgs e)
        {
            fNewChangeLog form = new fNewChangeLog(this);
            form.ShowDialog();
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openF = new OpenFileDialog() { Title = "Change-log open", Filter = "Change-log Files (*.log)|*.log" };
            if (openF.ShowDialog() == DialogResult.OK)
                cLog.OpenLog(currentForm:this, path:openF.FileName);
        }    
    }
}
