using System;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ChangeLogManager.forms;
using System.Linq;
using System.Xml;

namespace ChangeLogManager.classes
{
    public enum SaveType { Text = 1, BBCode, HTML, Markdown, Pawn, JSON, XML, YMAL }

    public static class cLog
    {
        public static void NewLog(string title, string version)
        {
            fMain.changelogTitle.Text = title;
            fMain.changelogVersion.Text = "Version " + version;
            fMain.newFeatures.Items.Clear();
            fMain.changes.Items.Clear();
            fMain.fixes.Items.Clear();
        }

        public static void OpenLog(Form currentForm, bool openForm = true, string path = "")
        {
            if(openForm == true)
            {
                fMain form = new fMain(path);
                form.Show();
                currentForm.Hide();
            }

            StreamReader streamR = new StreamReader(path);
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
                AddLogToRecent(path);
            }
        }

        public static void SaveLog()
        {
            SaveFileDialog saveF = new SaveFileDialog() { Title = "Change-log save", Filter = "Change-log Files (*.log)|*.log", FileName = fMain.changelogTitle.Text + " - " + fMain.changelogVersion.Text };
            if (saveF.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamW = new StreamWriter(saveF.FileName);

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

                    MessageBox.Show("You have successfully saved your changelog under “" + Path.GetFileName(saveF.FileName) + "”", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    streamW.Close();
                    AddLogToRecent(saveF.FileName);
                    fMain.currentFile = saveF.FileName;
                }
            }
        }
        
        public static void ExportLog(SaveType type)
        {
            switch (type)
            {
                case SaveType.Text:
                {
                    SaveFileDialog saveF = new SaveFileDialog() { Title = "Change-log export as text file", Filter = "Change-log Files (*.log)|*.log", FileName = fMain.changelogTitle.Text + " - " + fMain.changelogVersion.Text };
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
                            fMain.UpdateStatusStrip("Change-log was successfully exported in plain text");
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
                            fMain.UpdateStatusStrip("Change-log was successfully exported in BBCode");
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

                case SaveType.HTML:
                {
                    SaveFileDialog saveF = new SaveFileDialog() { Title = "Change-log export in HTML format", Filter = "Change-log Files (*.html)|*.html", FileName = fMain.changelogTitle.Text + " - " + fMain.changelogVersion.Text };
                    if (saveF.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter streamW = new StreamWriter(saveF.FileName);

                        try
                        {
                            streamW.WriteLine("<!DOCTYPE html><html lang=\"en\"><head><meta charset=\"utf-8\"><meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\"><meta name=\"author\" content=\"Eoussama\"><meta name=\"description\" content=\"A simple change log exported using ChangeLog Manager by Eoussama\"><meta name=\"keywords\" content=\"Changelog, fixes, changes, new features\"><meta name=\"application-name\" content=\"" + fMain.changelogTitle.Text + "\">");
                            streamW.WriteLine("<style>:root{--lightColor:#ddd;--darkColor:#1f2931;--grayColor:gray}*{margin:0;padding:0;font-family:\"Arial\",sans-serif}main::selection{background-color:var(--darkColor);color:var(--lightColor)}main{margin:auto;padding:50px;background:linear-gradient(to bottom,var(--lightColor),#f1f1f1)}h1{padding:10vh;background-color:var(--darkColor);color:var(--lightColor);text-align:center;font-size:50px}h1 small{color:var(--grayColor);font-size:20px}div.list{margin:auto;width:650px;overflow:hidden}div.list label{cursor: pointer;position:relative;display:block;padding:5px;width:150px;border-radius:3px 3px 0 0;background-color:var(--darkColor);color:var(--lightColor);font-size:20px;transition-property:background-color;transition-duration:0.3s;}div.list label:hover{background-color:#35434f;}div.list input{display:none}div.list input:checked+ul{opacity:0;padding:0;list-style-type:none}div.list ul{padding:20px 40px;color:var(--darkColor);border:2px solid var(--darkColor);border-radius:0 3px 3px 3px;transition-property:padding,opacity;transition-duration:.5s}div.list:not(:last-child){margin-bottom:50px}p{text-align:center}</style>");
                            streamW.WriteLine("<title>" + fMain.changelogTitle.Text + " - " + fMain.changelogVersion.Text + "</title>");
                            streamW.WriteLine("</head>");
                            streamW.WriteLine("<body>");
                            streamW.WriteLine("<header><h1>" + fMain.changelogTitle.Text.Trim() + "<br><small>" + fMain.changelogVersion.Text.Trim() + "</small></h1></header>");
                            streamW.WriteLine("<main>");
                            // New features
                            streamW.WriteLine("\r\n\r\n<div class=\"list\"><label for=\"new\"><h4><b>New features</b></h4></label><input type=\"checkbox\" id=\"new\"><ul>");
                            foreach (var line in fMain.newFeatures.Items)
                                streamW.WriteLine("<li>" + line.ToString() + "</li>");
                            streamW.WriteLine("</ul></div>");

                            // Changes
                            streamW.WriteLine("\r\n\r\n<div class=\"list\"><label for=\"changes\"><h4><b>Changes</b></h4></label><input type=\"checkbox\" id=\"changes\"><ul>");
                            foreach (var line in fMain.changes.Items)
                                streamW.WriteLine("<li>" + line.ToString() + "</li>");
                            streamW.WriteLine("</ul></div>");

                            // Fixes
                            streamW.WriteLine("\r\n\r\n<div class=\"list\"><label for=\"fixes\"><h4><b>Fixes</b></h4></label><input type=\"checkbox\" id=\"fixes\"><ul>");
                            foreach (var line in fMain.fixes.Items)
                                streamW.WriteLine("<li>" + line.ToString() + "</li>");
                            streamW.WriteLine("</ul></div>");
                            streamW.WriteLine("\r\n\r\n\r\n<p><small><i>Exported on " + DateTime.Now + "</i></small></p></main></body></html>");
                            fMain.UpdateStatusStrip("Change-log was successfully exported in HTML format");
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

                case SaveType.Markdown:
                {
                    SaveFileDialog saveF = new SaveFileDialog() { Title = "Change-log export in markdown format", Filter = "Change-log Files (*.md)|*.md", FileName = fMain.changelogTitle.Text + " - " + fMain.changelogVersion.Text };
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
                            fMain.UpdateStatusStrip("Change-log was successfully exported in Markdown format");
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

                case SaveType.Pawn:
                {
                    SaveFileDialog saveF = new SaveFileDialog() { Title = "Change-log export in pawn syntax", Filter = "Change-log Files (*.pwn)|*.pwn", FileName = fMain.changelogTitle.Text + " - " + fMain.changelogVersion.Text };
                    if (saveF.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter streamW = new StreamWriter(saveF.FileName);

                        try
                        {
                            streamW.WriteLine(fPawnExport.rtbCode.Text);
                            streamW.WriteLine("\r\n\r\n//Exported on " + DateTime.Now);
                            fMain.UpdateStatusStrip("Change-log was successfully exported as a PAWN snippet");
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

                case SaveType.JSON:
                {
                    SaveFileDialog saveF = new SaveFileDialog() { Title = "Change-log export in JSON format", Filter = "Change-log Files (*.json)|*.json", FileName = fMain.changelogTitle.Text + " - " + fMain.changelogVersion.Text };
                    if (saveF.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter streamW = new StreamWriter(saveF.FileName);

                        try
                        {
                            streamW.WriteLine("{");
                            streamW.WriteLine("\t\"Head\" : {");
                            streamW.WriteLine("\t\t\"Title\" : \"" + fMain.changelogTitle.Text.Trim() + "\",");
                            streamW.WriteLine("\t\t\"Version\" : \"" + fMain.changelogVersion.Text.Trim() + "\"");
                            streamW.WriteLine("\t},\r\n");

                            streamW.WriteLine("\t\"Body\" : {");
                            // New features
                            streamW.WriteLine("\t\t\"New features\" : [");
                            foreach (var line in fMain.newFeatures.Items)
                                streamW.WriteLine("\t\t\t\"" + line.ToString().Replace("\"", "\\\"") + "\"" + (line.Equals(fMain.newFeatures.Items[fMain.newFeatures.Items.Count - 1].ToString()) ? "" : ","));
                            streamW.WriteLine("\t\t],\r\n");

                            // Changes
                            streamW.WriteLine("\t\t\"Changes\" : [");
                            foreach (var line in fMain.changes.Items)
                                streamW.WriteLine("\t\t\t\"" + line.ToString().Replace("\"", "\\\"") + "\"" + (line.Equals(fMain.changes.Items[fMain.changes.Items.Count - 1].ToString()) ? "" : ","));
                            streamW.WriteLine("\t\t],\r\n");

                            // Fixes
                            streamW.WriteLine("\t\t\"Fixes\" : [");
                            foreach (var line in fMain.fixes.Items)
                                streamW.WriteLine("\t\t\t\"" + line.ToString().Replace("\"", "\\\"") + "\"" + (line.Equals(fMain.fixes.Items[fMain.fixes.Items.Count - 1].ToString()) ? "" : ","));
                            streamW.WriteLine("\t\t]");
                            streamW.WriteLine("\t},\r\n");

                            streamW.WriteLine("\t\"Footer\" : {");
                            streamW.WriteLine("\t\t\"Export date\" : \"" + DateTime.Now + "\"");
                            fMain.UpdateStatusStrip("Change-log was successfully exported in plain text");
                            streamW.WriteLine("\t}");
                            streamW.WriteLine("}");

                            fMain.UpdateStatusStrip("Change-log was successfully exported in JSON format");
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

                case SaveType.XML:
                {
                    SaveFileDialog saveF = new SaveFileDialog() { Title = "Change-log export in XML format", Filter = "Change-log Files (*.xml)|*.xml", FileName = fMain.changelogTitle.Text + " - " + fMain.changelogVersion.Text };
                    if (saveF.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            XmlDocument doc = new XmlDocument();
                            XmlNode dec = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                            doc.AppendChild(dec);

                            XmlNode root = doc.CreateElement("changelog");
                            doc.AppendChild(root);
                            XmlAttribute attr = doc.CreateAttribute("version");
                            attr.Value = fMain.changelogVersion.Text.Trim();
                            root.Attributes.Append(attr);

                            XmlNode head = doc.CreateElement("head");
                            root.AppendChild(head);
                            XmlNode titleNode = doc.CreateElement("title");
                            head.AppendChild(titleNode);
                            titleNode.AppendChild(doc.CreateTextNode(fMain.changelogTitle.Text.Trim()));

                            XmlNode body = doc.CreateElement("body");
                            root.AppendChild(body);

                            XmlNode newFNode = doc.CreateElement("new_features");
                            body.AppendChild(newFNode);
                            foreach(var line in fMain.newFeatures.Items)
                            {
                                XmlNode newFeatureNode = doc.CreateElement("feature");
                                newFNode.AppendChild(newFeatureNode);
                                newFeatureNode.AppendChild(doc.CreateTextNode(line.ToString()));
                            }

                            XmlNode changesNodes = doc.CreateElement("changes");
                            body.AppendChild(changesNodes);
                            foreach (var line in fMain.changes.Items)
                            {
                                XmlNode changeNode = doc.CreateElement("change");
                                changesNodes.AppendChild(changeNode);
                                changeNode.AppendChild(doc.CreateTextNode(line.ToString()));
                            }

                            XmlNode fixesNode = doc.CreateElement("fixes");
                            body.AppendChild(fixesNode);
                            foreach (var line in fMain.fixes.Items)
                            {
                                XmlNode fixNode = doc.CreateElement("fix");
                                fixesNode.AppendChild(fixNode);
                                fixNode.AppendChild(doc.CreateTextNode(line.ToString()));
                            }

                            XmlNode footer = doc.CreateElement("footer");
                            root.AppendChild(footer);
                            XmlNode dateNode = doc.CreateElement("export_date");
                            footer.AppendChild(dateNode);
                            dateNode.AppendChild(doc.CreateTextNode(DateTime.Now.ToString()));

                            doc.Save(saveF.FileName);
                            fMain.UpdateStatusStrip("Change-log was successfully exported in XML format");
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    break;
                }

                case SaveType.YMAL:
                {
                    SaveFileDialog saveF = new SaveFileDialog() { Title = "Change-log export in YAML format", Filter = "Change-log Files (*.yaml)|*.yaml", FileName = fMain.changelogTitle.Text + " - " + fMain.changelogVersion.Text };
                    if (saveF.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter streamW = new StreamWriter(saveF.FileName);

                        try
                        {
                            streamW.WriteLine("---");
                            streamW.WriteLine("Head:");
                            streamW.WriteLine("  Title: " + fMain.changelogTitle.Text.Trim());
                            streamW.WriteLine("  Version: " + fMain.changelogVersion.Text.Trim());

                            streamW.WriteLine("\r\nBody:");
                            streamW.WriteLine("  New features:");
                            foreach (var line in fMain.newFeatures.Items)
                                streamW.WriteLine($"    - {line.ToString()}");

                            streamW.WriteLine("\r\n  Changes:");
                            foreach (var line in fMain.changes.Items)
                                streamW.WriteLine($"    - {line.ToString()}");

                            streamW.WriteLine("\r\n  Fixes:");
                            foreach (var line in fMain.fixes.Items)
                                streamW.WriteLine($"    - {line.ToString()}");

                            streamW.WriteLine("\r\nFooter:");
                            streamW.WriteLine("  Export date: " + DateTime.Now);
                            streamW.WriteLine("...");

                            fMain.UpdateStatusStrip("Change-log was successfully exported in YAML format");
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
            }
        }

        public static void ResetLog()
        {
            fMain.newFeatures.Items.Clear();
            fMain.changes.Items.Clear();
            fMain.fixes.Items.Clear();
            fMain.UpdateStatusStrip("Change-log was successfully reset");
        }

        public static bool IsLogEmpty()
        {
            return fMain.newFeatures.Items.Count == 0 && fMain.changes.Items.Count == 0 && fMain.fixes.Items.Count == 0;
        }

        public static void AddLogToRecent(string path)
        {
            FileStream fileS = new FileStream("config.cfg", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            try
            {
                StreamReader streamR = new StreamReader(fileS);

                if(!streamR.ReadToEnd().Contains(path))
                {
                    StreamWriter streamW = new StreamWriter(fileS);
                    streamW.WriteLine("[Recent: " + path + "]");
                    streamW.Flush();
                    streamW.Close();
                }

                streamR.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                fileS.Close();
            }
        }

        public static string getLogTitle(string path)
        {
            string output = string.Empty, line = string.Empty;
            StreamReader streamR = new StreamReader(path);
            
            while ((line = streamR.ReadLine()) != null)
            {
                if (Regex.IsMatch(line, @"^\[Title: (.)*\]$"))
                    output = line.Substring(8, line.Length - 9);
            }

            streamR.Close();

            return output;
        }

        public static string getLogVersion(string path)
        {
            string output = string.Empty, line = string.Empty;
            StreamReader streamR = new StreamReader(path);

            while ((line = streamR.ReadLine()) != null)
            {
                if (Regex.IsMatch(line, @"^\[Version: (.)*\]$"))
                    output = line.Substring(10, line.Length - 11);
            }

            streamR.Close();

            return output;
        }

        public static string getLogDate(string path)
        {
            string output = string.Empty, line = string.Empty;
            StreamReader streamR = new StreamReader(path);

            while ((line = streamR.ReadLine()) != null)
            {
                if (Regex.IsMatch(line, @"^Last saved on .*$"))
                    output = line.Substring(14, line.Length - 14);
            }

            streamR.Close();

            return DateTime.Parse(output).ToShortDateString();
        }

        public static void Flush()
        {
            StreamWriter streamW = new StreamWriter("config.cfg", false);

            streamW.WriteLine("\t\t\t-[Change-log manager config]-");

            foreach (ucRecent recent in fWelcome.menu.Controls.OfType<ucRecent>())
            {
                if(File.Exists(recent.path))
                    streamW.WriteLine("[Recent: " + recent.path + "]");
            }

            streamW.Close();
        }
    }
}
