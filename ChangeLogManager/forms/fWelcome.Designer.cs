using ChangeLogManager.classes;

namespace ChangeLogManager.forms
{
    partial class fWelcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fWelcome));
            this.pMenu = new System.Windows.Forms.Panel();
            this.pRecentCount = new System.Windows.Forms.Panel();
            this.lRecentCount = new System.Windows.Forms.Label();
            this.bOpen = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.pMain = new System.Windows.Forms.Panel();
            this.lChangelog = new System.Windows.Forms.Label();
            this.pHLine = new System.Windows.Forms.Panel();
            this.lVersion = new System.Windows.Forms.Label();
            this.rtbChangelog = new System.Windows.Forms.RichTextBox();
            this.pMenu.SuspendLayout();
            this.pRecentCount.SuspendLayout();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.AutoScroll = true;
            this.pMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.pMenu.Controls.Add(this.pRecentCount);
            this.pMenu.Controls.Add(this.bOpen);
            this.pMenu.Controls.Add(this.bNew);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(167, 424);
            this.pMenu.TabIndex = 0;
            // 
            // pRecentCount
            // 
            this.pRecentCount.BackColor = System.Drawing.Color.DarkGray;
            this.pRecentCount.Controls.Add(this.lRecentCount);
            this.pRecentCount.Location = new System.Drawing.Point(0, 116);
            this.pRecentCount.Name = "pRecentCount";
            this.pRecentCount.Size = new System.Drawing.Size(167, 37);
            this.pRecentCount.TabIndex = 2;
            // 
            // lRecentCount
            // 
            this.lRecentCount.BackColor = System.Drawing.Color.DarkGray;
            this.lRecentCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lRecentCount.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRecentCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lRecentCount.Location = new System.Drawing.Point(0, 0);
            this.lRecentCount.Name = "lRecentCount";
            this.lRecentCount.Size = new System.Drawing.Size(167, 37);
            this.lRecentCount.TabIndex = 0;
            this.lRecentCount.Text = "You have 0 recent files";
            this.lRecentCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bOpen
            // 
            this.bOpen.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOpen.FlatAppearance.BorderSize = 0;
            this.bOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOpen.ForeColor = System.Drawing.Color.White;
            this.bOpen.Location = new System.Drawing.Point(0, 58);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(167, 58);
            this.bOpen.TabIndex = 1;
            this.bOpen.Text = "Open a change-log";
            this.bOpen.UseVisualStyleBackColor = false;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // bNew
            // 
            this.bNew.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNew.FlatAppearance.BorderSize = 0;
            this.bNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNew.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNew.ForeColor = System.Drawing.Color.White;
            this.bNew.Location = new System.Drawing.Point(0, 0);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(167, 58);
            this.bNew.TabIndex = 0;
            this.bNew.Text = "New change-log";
            this.bNew.UseVisualStyleBackColor = false;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.lChangelog);
            this.pMain.Controls.Add(this.pHLine);
            this.pMain.Controls.Add(this.lVersion);
            this.pMain.Controls.Add(this.rtbChangelog);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(167, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(457, 424);
            this.pMain.TabIndex = 1;
            // 
            // lChangelog
            // 
            this.lChangelog.AutoSize = true;
            this.lChangelog.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lChangelog.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lChangelog.ForeColor = System.Drawing.Color.White;
            this.lChangelog.Location = new System.Drawing.Point(8, 45);
            this.lChangelog.Name = "lChangelog";
            this.lChangelog.Size = new System.Drawing.Size(92, 16);
            this.lChangelog.TabIndex = 3;
            this.lChangelog.Text = "Change-log";
            // 
            // pHLine
            // 
            this.pHLine.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pHLine.Location = new System.Drawing.Point(8, 26);
            this.pHLine.Name = "pHLine";
            this.pHLine.Size = new System.Drawing.Size(442, 5);
            this.pHLine.TabIndex = 2;
            // 
            // lVersion
            // 
            this.lVersion.AutoSize = true;
            this.lVersion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVersion.Location = new System.Drawing.Point(6, 8);
            this.lVersion.Name = "lVersion";
            this.lVersion.Size = new System.Drawing.Size(206, 16);
            this.lVersion.TabIndex = 1;
            this.lVersion.Text = Config.name + " - " + Config.version;
            // 
            // rtbChangelog
            // 
            this.rtbChangelog.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rtbChangelog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbChangelog.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbChangelog.ForeColor = System.Drawing.Color.White;
            this.rtbChangelog.Location = new System.Drawing.Point(8, 61);
            this.rtbChangelog.Name = "rtbChangelog";
            this.rtbChangelog.ReadOnly = true;
            this.rtbChangelog.Size = new System.Drawing.Size(442, 351);
            this.rtbChangelog.TabIndex = 0;
            this.rtbChangelog.Text = resources.GetString("rtbChangelog.Text");
            // 
            // fWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 424);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.pMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = Config.name;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fWelcome_FormClosed);
            this.pMenu.ResumeLayout(false);
            this.pRecentCount.ResumeLayout(false);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.Label lVersion;
        private System.Windows.Forms.RichTextBox rtbChangelog;
        private System.Windows.Forms.Panel pHLine;
        private System.Windows.Forms.Label lChangelog;
        private System.Windows.Forms.Panel pRecentCount;
        private System.Windows.Forms.Label lRecentCount;
    }
}