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
        // Form --------------------------------------------------------------------------
        public fWelcome()
        {
            InitializeComponent();

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
                            recent.Top = (bNew.Height * 2) + (recent.Height * pMenu.Controls.OfType<ucRecent>().Count());
                            recent.Left = bNew.Left;
                            pMenu.Controls.Add(recent);
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
                }
            }
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
            cLog.OpenLog(this);
        }    
    }
}
