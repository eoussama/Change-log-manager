using System;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ChangeLogManager.forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChangeLogManager.classes
{
    public enum SaveType { Text = 1, BBCode, HTML, Markdown, Pawn }

    public static class cLog
    {
        public static void OpenLog(Form currentForm, bool openForm = true)
        {
            OpenFileDialog openF = new OpenFileDialog() { Title = "Change-log open", Filter = "Change-log Files (*.log)|*.log" };
            if (openF.ShowDialog() == DialogResult.OK)
            {
                if(openForm == true)
                {
                    fMain form = new fMain();
                    form.Show();
                    currentForm.Hide();
                }

                StreamReader streamR = new StreamReader(openF.FileName);
                try
                {
                    while (!streamR.EndOfStream)
                    {
                        string line = streamR.ReadLine();

                        if (Regex.IsMatch(line, @"^\[Title: (.)*\]$"))
                            fMain.changelogTitle.Text = line.Substring(8, line.Length - 9);
                        else if (Regex.IsMatch(line, @"^\[Version: (.)*\]$"))
                            fMain.changelogVersion.Text = line.Substring(10, line.Length - 11);
                        else if (Regex.IsMatch(line, @"^\[New feature: (.)*\]$"))
                            fMain.newFeatures.Items.Add(line.Substring(14, line.Length - 15));
                        else if (Regex.IsMatch(line, @"^\[Change: (.)*\]$"))
                            fMain.changes.Items.Add(line.Substring(9, line.Length - 10));
                        else if (Regex.IsMatch(line, @"^\[Fix: (.)*\]$"))
                            fMain.fixes.Items.Add(line.Substring(6, line.Length - 7));
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

        public static void NewLog(string title, string version)
        {
            fMain.changelogTitle.Text = title;
            fMain.changelogVersion.Text = "Version " + version;
            fMain.newFeatures.Items.Clear();
            fMain.changes.Items.Clear();
            fMain.fixes.Items.Clear();
        }

        public static void SaveLog()
        {
            SaveFileDialog saveF = new SaveFileDialog() { Title = "Change-log save", Filter = "Change-log Files (*.log)|*.log", FileName = fMain.changelogTitle.Text + " - " + fMain.changelogVersion.Text };
            if (saveF.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamW = new StreamWriter(saveF.FileName);

                try
                {
                    streamW.WriteLine("[Title: " + fMain.changelogTitle.Text.Trim() + " ]");
                    streamW.WriteLine("[Version: " + fMain.changelogVersion.Text.Trim() + " ]");

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

                    MessageBox.Show("You have successfully saved your changelog under “" + Path.GetFileName(saveF.FileName) + "”");
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
        
        public static void ExportLog(SaveType type)
        {
            switch (type)
            {
                case SaveType.Text:
                {
                    SaveFileDialog saveF = new SaveFileDialog() { Title = "Change-log export as text file", Filter = "Change-log Files (*.txt)|*.txt", FileName = fMain.changelogTitle.Text + " - " + fMain.changelogVersion.Text };
                    if (saveF.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter streamW = new StreamWriter(saveF.FileName);

                        try
                        {
                            streamW.WriteLine("Title: " + fMain.changelogTitle.Text.Trim());
                            streamW.WriteLine("Version: " + fMain.changelogVersion.Text.Trim());

                            // New features
                            streamW.WriteLine("\r\n\r\n* New features");
                            foreach (var line in fMain.newFeatures.Items)
                                streamW.WriteLine("\t-" + line.ToString());

                            // Changes
                            streamW.WriteLine("\r\n\r\n* Changes");
                            foreach (var line in fMain.changes.Items)
                                streamW.WriteLine("\t-" + line.ToString());

                            // Fixes
                            streamW.WriteLine("\r\n\r\n* Fixes");
                            foreach (var line in fMain.fixes.Items)
                                streamW.WriteLine("\t-" + line.ToString());

                            streamW.WriteLine("\r\n\r\n\r\nExported on " + DateTime.Now);
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        finally
                        {
                            streamW.Close();
                        }
                    }

                    break;
                }

                case SaveType.BBCode:
                {
                    SaveFileDialog saveF = new SaveFileDialog() { Title = "Change-log export in BBCode", Filter = "Change-log Files (*.txt)|*.txt", FileName = fMain.changelogTitle.Text + " - " + fMain.changelogVersion.Text };
                    if (saveF.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter streamW = new StreamWriter(saveF.FileName);

                        try
                        {
                            streamW.WriteLine("[B][SIZE=6][CENTER] " + fMain.changelogTitle.Text.Trim() + " [/CENTER][/SIZE][/B]");
                            streamW.WriteLine("[B][SIZE=2][CENTER]" + fMain.changelogVersion.Text.Trim() + "[/CENTER][/SIZE][/B]");

                            // New features
                            streamW.WriteLine("\r\n\r\n[B]New features[/B][CODE][LIST]");
                            foreach (var line in fMain.newFeatures.Items)
                                streamW.WriteLine("[*]" + line.ToString());
                            streamW.WriteLine("[/LIST][/CODE]");

                            // Changes
                            streamW.WriteLine("\r\n\r\n[B]Changes[/B][CODE][LIST]");
                            foreach (var line in fMain.changes.Items)
                                streamW.WriteLine("[*]" + line.ToString());
                            streamW.WriteLine("[/LIST][/CODE]");

                            // Fixes
                            streamW.WriteLine("\r\n\r\n[B]Fixes[/B][CODE][LIST]");
                            foreach (var line in fMain.fixes.Items)
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

                    break;
                }

                case SaveType.HTML:
                {
                    SaveFileDialog saveF = new SaveFileDialog() { Title = "Change-log export in HTML format", Filter = "Change-log Files (*.html)|*.html", FileName = fMain.changelogTitle.Text + " - " + fMain.changelogVersion.Text };
                    if (saveF.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter streamW = new StreamWriter(saveF.FileName);

                        try
                        {
                            streamW.WriteLine("<!DOCTYPE html><html lang=\"en\"><head><meta charset=\"utf-8\"><meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\"><meta name=\"author\" content=\"Eoussama\"><meta name=\"description\" content=\"A simple change log exported using ChangeLog Manager by Eoussama\"><meta name=\"keywords\" content=\"Changelog, fixed, changes, new features\"><meta name=\"application-name\" content=\"" + fMain.changelogTitle + "\">");
                            streamW.WriteLine("<style>*{margin: 0px;padding: 0px;}body main{font-family: \"Arial\", sans-serif;background: linear-gradient(to bottom, #f4f4f4, grey);}body header h1{text-align: center;font-family: verdana, sans-serif;font-size: 60px;color: white;text-shadow: 2px 2px 5px black;background-color: #f4f4f4;border-bottom: 10px solid #403c36;}body header h1 #ver{position: relative;top: -25px;font-size: 18px;color: orange;}body main{padding: 10px;min-height: 100vh;}body main #content{position: relative;top: 40px;left: 50%;max-width: 600px;transform: translate(-50%, 0px);}body main #content h4{width: 150px;font-size: 20px;margin-top: 50px;color: #a9afaf;padding: 5px 5px 5px 10px;border-left: 5px solid #403c36;background-color: #403c36;border-radius: 6px 6px 0px 0px;cursor: pointer;transition-property: background-color, border-color;transition-duration: .5s;}body main #content h4 input{display: none;}body main #content h4:hover{background-color: #625d56;border-color: #625d56;}#content ul{padding: 10px 0px 10px 10px;width: 97%;list-style-position: inside;background-color: #a9afaf;border-radius: 0px 6px 6px 0px;border-left: 5px solid #403c36;box-shadow: 2px 2px 5px #403c36;color: #403c36;}body main #content i{position: relative;top: 20px;color: white;text-shadow: 1px 1px 1px black;}.listCont{position: relative;width: 600px;padding: 0px 0px 10px 0px;overflow-y: hidden;transition-property: height, opacity;transition-duration: .5s;opacity: 1;}</style>");
                            streamW.WriteLine("<title>" + fMain.changelogTitle.Text + " - " + fMain.changelogVersion.Text + "</title>");
                            streamW.WriteLine("</head>");
                            streamW.WriteLine("<body>");
                            streamW.WriteLine("<header><h1>" + fMain.changelogTitle.Text.Trim() + "<br><span id=\"ver\">" + fMain.changelogVersion.Text.Trim() + "</span></h1></header>");
                            streamW.WriteLine("<main><div id=\"content\">");
                            // New features
                            streamW.WriteLine("\r\n\r\n<label id=\"new\"><h4><input type=\"checkbox\" id=\"newCB\" checked><b>New features</b></h4></label>");
                            streamW.WriteLine("<div class=\"listCont\" id=\"newList\"><ul>");
                            foreach (var line in fMain.newFeatures.Items)
                                streamW.WriteLine("<li>" + line.ToString() + "</li>");
                            streamW.WriteLine("</ul></div>");

                            // Changes
                            streamW.WriteLine("\r\n\r\n<label id=\"changes\"><h4><input type=\"checkbox\" id=\"changesCB\" checked><b>Changes</b></h4></label>");
                            streamW.WriteLine("<div class=\"listCont\" id=\"changesList\"><ul>");
                            foreach (var line in fMain.changes.Items)
                                streamW.WriteLine("<li>" + line.ToString() + "</li>");
                            streamW.WriteLine("</ul></div>");

                            // Fixes
                            streamW.WriteLine("\r\n\r\n<label id=\"fixes\"><h4><input type=\"checkbox\"id=\"fixesCB\" checked><b>Fixes</b></h4></label>");
                            streamW.WriteLine("<div class=\"listCont\" id=\"fixesList\"><ul>");
                            foreach (var line in fMain.fixes.Items)
                                streamW.WriteLine("<li>" + line.ToString() + "</li>");
                            streamW.WriteLine("</ul></div>");
                            streamW.WriteLine("\r\n\r\n\r\n<i>Exported on " + DateTime.Now + "</i>");
                            streamW.WriteLine("</div></main><script type=\"text/javascript\">var _new=document.getElementById('new');var newCB=document.getElementById('newCB');var newList=document.getElementById('newList');var newLineCount=document.querySelectorAll('#newList ul li').length;var changes=document.getElementById('changes');var changesCB=document.getElementById('changesCB');var changesList=document.getElementById('changesList');var changesLineCount=document.querySelectorAll('#changesList ul li').length;var fixes=document.getElementById('fixes');var fixesCB=document.getElementById('fixesCB');var fixesList=document.getElementById('fixesList');var fixesLineCount=document.querySelectorAll('#fixesList ul li').length;_new.addEventListener('click', function(){if(newCB.checked==true){newList.style.height='0px';newList.style.opacity='0';}else{newList.style.opacity='1';newList.style.height=(newLineCount/1 * 23.3) + 'px';}});changes.addEventListener('click', function(){if(changesCB.checked==true){changesList.style.height='0px';changesList.style.opacity='0';}else{changesList.style.opacity='1';changesList.style.height=(changesLineCount/1 * 23.3) + 'px';}});fixes.onclick=addEventListener('click', function(){if(fixesCB.checked==true){fixesList.style.height='0px';fixesList.style.opacity='0';}else{fixesList.style.opacity='1';fixesList.style.height=(fixesLineCount/1 * 23.3) + 'px';}});</script></body></html>");
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

                    break;
                }

                case SaveType.Markdown:
                {
                    SaveFileDialog saveF = new SaveFileDialog() { Title = "Change-log export in markdown format", Filter = "Change-log Files (*.txt)|*.txt", FileName = fMain.changelogTitle.Text + " - " + fMain.changelogVersion.Text };
                    if (saveF.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter streamW = new StreamWriter(saveF.FileName);

                        try
                        {
                            streamW.WriteLine("# **" + fMain.changelogTitle.Text.Trim() + "**");
                            streamW.WriteLine("##### *" + fMain.changelogVersion.Text.Trim() + "*");

                            // New features
                            streamW.WriteLine("\r\n\r\n>#### **New features**");
                            foreach (var line in fMain.newFeatures.Items)
                                streamW.WriteLine("- " + line.ToString());

                            // Changes
                            streamW.WriteLine("\r\n\r\n>#### **Changes**");
                            foreach (var line in fMain.changes.Items)
                                streamW.WriteLine("- " + line.ToString());

                            // Fixes
                            streamW.WriteLine("\r\n\r\n>#### **Fixes**");
                            foreach (var line in fMain.fixes.Items)
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

                    break;
                }

                case SaveType.Pawn:
                {
                    fPawnExport form = new fPawnExport();
                    form.Show();
                    break;
                }
            }
        }

        public static void ResetLog()
        {
            fMain.newFeatures.Items.Clear();
            fMain.changes.Items.Clear();
            fMain.fixes.Items.Clear();
        }

        public static bool IsLogEmpty()
        {
            return fMain.newFeatures.Items.Count == 0 && fMain.changes.Items.Count == 0 && fMain.fixes.Items.Count == 0;
        }
    }
}
