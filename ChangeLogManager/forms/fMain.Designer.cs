namespace ChangeLogManager
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.lTitle = new System.Windows.Forms.Label();
            this.lVersion = new System.Windows.Forms.Label();
            this.pTitle = new System.Windows.Forms.Panel();
            this.lbNew = new System.Windows.Forms.ListBox();
            this.lbChanges = new System.Windows.Forms.ListBox();
            this.lbFixes = new System.Windows.Forms.ListBox();
            this.lNew = new System.Windows.Forms.Label();
            this.lChanges = new System.Windows.Forms.Label();
            this.lFixes = new System.Windows.Forms.Label();
            this.ssInfo = new System.Windows.Forms.StatusStrip();
            this.pbAddFixes = new System.Windows.Forms.PictureBox();
            this.pbAddChanges = new System.Windows.Forms.PictureBox();
            this.pbAddNew = new System.Windows.Forms.PictureBox();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editChangelogTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editChangelogVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bBCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pawnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddFixes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddChanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNew)).BeginInit();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lTitle.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.White;
            this.lTitle.Location = new System.Drawing.Point(0, 0);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(182, 39);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "Change-log";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lVersion
            // 
            this.lVersion.BackColor = System.Drawing.SystemColors.GrayText;
            this.lVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lVersion.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVersion.ForeColor = System.Drawing.Color.White;
            this.lVersion.Location = new System.Drawing.Point(0, 49);
            this.lVersion.Name = "lVersion";
            this.lVersion.Size = new System.Drawing.Size(700, 21);
            this.lVersion.TabIndex = 2;
            this.lVersion.Text = "Version N/A";
            this.lVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.SystemColors.GrayText;
            this.pTitle.Controls.Add(this.lVersion);
            this.pTitle.Controls.Add(this.lTitle);
            this.pTitle.Location = new System.Drawing.Point(0, 24);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(700, 70);
            this.pTitle.TabIndex = 3;
            // 
            // lbNew
            // 
            this.lbNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNew.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNew.FormattingEnabled = true;
            this.lbNew.HorizontalScrollbar = true;
            this.lbNew.ItemHeight = 14;
            this.lbNew.Location = new System.Drawing.Point(12, 132);
            this.lbNew.Name = "lbNew";
            this.lbNew.Size = new System.Drawing.Size(223, 324);
            this.lbNew.TabIndex = 5;
            // 
            // lbChanges
            // 
            this.lbChanges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbChanges.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChanges.FormattingEnabled = true;
            this.lbChanges.HorizontalScrollbar = true;
            this.lbChanges.ItemHeight = 14;
            this.lbChanges.Location = new System.Drawing.Point(239, 132);
            this.lbChanges.Name = "lbChanges";
            this.lbChanges.Size = new System.Drawing.Size(223, 324);
            this.lbChanges.TabIndex = 6;
            // 
            // lbFixes
            // 
            this.lbFixes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFixes.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFixes.FormattingEnabled = true;
            this.lbFixes.HorizontalScrollbar = true;
            this.lbFixes.ItemHeight = 14;
            this.lbFixes.Location = new System.Drawing.Point(466, 132);
            this.lbFixes.Name = "lbFixes";
            this.lbFixes.Size = new System.Drawing.Size(223, 324);
            this.lbFixes.TabIndex = 7;
            // 
            // lNew
            // 
            this.lNew.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lNew.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNew.ForeColor = System.Drawing.Color.White;
            this.lNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lNew.Location = new System.Drawing.Point(12, 107);
            this.lNew.Name = "lNew";
            this.lNew.Size = new System.Drawing.Size(223, 25);
            this.lNew.TabIndex = 8;
            this.lNew.Text = "New features";
            this.lNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lChanges
            // 
            this.lChanges.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lChanges.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lChanges.ForeColor = System.Drawing.Color.White;
            this.lChanges.Location = new System.Drawing.Point(239, 107);
            this.lChanges.Name = "lChanges";
            this.lChanges.Size = new System.Drawing.Size(223, 25);
            this.lChanges.TabIndex = 9;
            this.lChanges.Text = "Changes";
            this.lChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lFixes
            // 
            this.lFixes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lFixes.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFixes.ForeColor = System.Drawing.Color.White;
            this.lFixes.Location = new System.Drawing.Point(466, 107);
            this.lFixes.Name = "lFixes";
            this.lFixes.Size = new System.Drawing.Size(223, 25);
            this.lFixes.TabIndex = 10;
            this.lFixes.Text = "Fixes";
            this.lFixes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ssInfo
            // 
            this.ssInfo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ssInfo.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssInfo.Location = new System.Drawing.Point(0, 474);
            this.ssInfo.Name = "ssInfo";
            this.ssInfo.Size = new System.Drawing.Size(700, 22);
            this.ssInfo.TabIndex = 14;
            this.ssInfo.Text = "Change-log manager - version 0.1";
            // 
            // pbAddFixes
            // 
            this.pbAddFixes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbAddFixes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddFixes.Image = global::ChangeLogManager.Properties.Resources.icon_add;
            this.pbAddFixes.Location = new System.Drawing.Point(466, 107);
            this.pbAddFixes.Name = "pbAddFixes";
            this.pbAddFixes.Size = new System.Drawing.Size(25, 25);
            this.pbAddFixes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddFixes.TabIndex = 13;
            this.pbAddFixes.TabStop = false;
            this.pbAddFixes.Click += new System.EventHandler(this.pbAddFixes_Click);
            // 
            // pbAddChanges
            // 
            this.pbAddChanges.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbAddChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddChanges.Image = global::ChangeLogManager.Properties.Resources.icon_add;
            this.pbAddChanges.Location = new System.Drawing.Point(239, 107);
            this.pbAddChanges.Name = "pbAddChanges";
            this.pbAddChanges.Size = new System.Drawing.Size(25, 25);
            this.pbAddChanges.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddChanges.TabIndex = 12;
            this.pbAddChanges.TabStop = false;
            this.pbAddChanges.Click += new System.EventHandler(this.pbAddChanges_Click);
            // 
            // pbAddNew
            // 
            this.pbAddNew.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddNew.Image = global::ChangeLogManager.Properties.Resources.icon_add;
            this.pbAddNew.Location = new System.Drawing.Point(12, 107);
            this.pbAddNew.Name = "pbAddNew";
            this.pbAddNew.Size = new System.Drawing.Size(25, 25);
            this.pbAddNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddNew.TabIndex = 11;
            this.pbAddNew.TabStop = false;
            this.pbAddNew.Click += new System.EventHandler(this.pbAddNew_Click);
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.msMenu.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(700, 24);
            this.msMenu.TabIndex = 15;
            this.msMenu.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomeToolStripMenuItem,
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // welcomeToolStripMenuItem
            // 
            this.welcomeToolStripMenuItem.Name = "welcomeToolStripMenuItem";
            this.welcomeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.welcomeToolStripMenuItem.Text = "Welcome";
            this.welcomeToolStripMenuItem.Click += new System.EventHandler(this.welcomeToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editChangelogTitleToolStripMenuItem,
            this.editChangelogVersionToolStripMenuItem,
            this.resetLogToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // editChangelogTitleToolStripMenuItem
            // 
            this.editChangelogTitleToolStripMenuItem.Name = "editChangelogTitleToolStripMenuItem";
            this.editChangelogTitleToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.editChangelogTitleToolStripMenuItem.Text = "Edit changelog title";
            this.editChangelogTitleToolStripMenuItem.Click += new System.EventHandler(this.editChangelogTitleToolStripMenuItem_Click);
            // 
            // editChangelogVersionToolStripMenuItem
            // 
            this.editChangelogVersionToolStripMenuItem.Name = "editChangelogVersionToolStripMenuItem";
            this.editChangelogVersionToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.editChangelogVersionToolStripMenuItem.Text = "Edit changelog version";
            this.editChangelogVersionToolStripMenuItem.Click += new System.EventHandler(this.editChangelogVersionToolStripMenuItem_Click);
            // 
            // resetLogToolStripMenuItem
            // 
            this.resetLogToolStripMenuItem.Name = "resetLogToolStripMenuItem";
            this.resetLogToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.resetLogToolStripMenuItem.Text = "Reset log";
            this.resetLogToolStripMenuItem.Click += new System.EventHandler(this.resetLogToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textFileToolStripMenuItem,
            this.bBCodeToolStripMenuItem,
            this.markdownToolStripMenuItem,
            this.hTMLToolStripMenuItem,
            this.pawnToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // textFileToolStripMenuItem
            // 
            this.textFileToolStripMenuItem.Name = "textFileToolStripMenuItem";
            this.textFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.textFileToolStripMenuItem.Text = "Text file";
            this.textFileToolStripMenuItem.Click += new System.EventHandler(this.textFileToolStripMenuItem_Click);
            // 
            // bBCodeToolStripMenuItem
            // 
            this.bBCodeToolStripMenuItem.Name = "bBCodeToolStripMenuItem";
            this.bBCodeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bBCodeToolStripMenuItem.Text = "BB Code";
            this.bBCodeToolStripMenuItem.Click += new System.EventHandler(this.bBCodeToolStripMenuItem_Click);
            // 
            // markdownToolStripMenuItem
            // 
            this.markdownToolStripMenuItem.Name = "markdownToolStripMenuItem";
            this.markdownToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.markdownToolStripMenuItem.Text = "Markdown";
            this.markdownToolStripMenuItem.Click += new System.EventHandler(this.markdownToolStripMenuItem_Click);
            // 
            // hTMLToolStripMenuItem
            // 
            this.hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
            this.hTMLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hTMLToolStripMenuItem.Text = "HTML";
            this.hTMLToolStripMenuItem.Click += new System.EventHandler(this.hTMLToolStripMenuItem_Click);
            // 
            // pawnToolStripMenuItem
            // 
            this.pawnToolStripMenuItem.Name = "pawnToolStripMenuItem";
            this.pawnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pawnToolStripMenuItem.Text = "Pawn";
            this.pawnToolStripMenuItem.Click += new System.EventHandler(this.pawnToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 496);
            this.Controls.Add(this.ssInfo);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.pbAddFixes);
            this.Controls.Add(this.pbAddChanges);
            this.Controls.Add(this.pbAddNew);
            this.Controls.Add(this.lFixes);
            this.Controls.Add(this.lChanges);
            this.Controls.Add(this.lNew);
            this.Controls.Add(this.lbFixes);
            this.Controls.Add(this.lbChanges);
            this.Controls.Add(this.lbNew);
            this.Controls.Add(this.pTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change-log Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMain_FormClosed);
            this.pTitle.ResumeLayout(false);
            this.pTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddFixes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddChanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNew)).EndInit();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lVersion;
        private System.Windows.Forms.Panel pTitle;
        private System.Windows.Forms.ListBox lbNew;
        private System.Windows.Forms.ListBox lbChanges;
        private System.Windows.Forms.ListBox lbFixes;
        private System.Windows.Forms.Label lNew;
        private System.Windows.Forms.Label lChanges;
        private System.Windows.Forms.Label lFixes;
        private System.Windows.Forms.PictureBox pbAddNew;
        private System.Windows.Forms.PictureBox pbAddChanges;
        private System.Windows.Forms.PictureBox pbAddFixes;
        private System.Windows.Forms.StatusStrip ssInfo;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem welcomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bBCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pawnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editChangelogTitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editChangelogVersionToolStripMenuItem;
    }
}

