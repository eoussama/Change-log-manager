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
            this.components = new System.ComponentModel.Container();
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.pbFixDelete = new System.Windows.Forms.PictureBox();
            this.pbFixEdit = new System.Windows.Forms.PictureBox();
            this.pbFixCopy = new System.Windows.Forms.PictureBox();
            this.pbChangeDelete = new System.Windows.Forms.PictureBox();
            this.pbChangeEdit = new System.Windows.Forms.PictureBox();
            this.pbChangeCopy = new System.Windows.Forms.PictureBox();
            this.pbNewDelete = new System.Windows.Forms.PictureBox();
            this.pbNewEdit = new System.Windows.Forms.PictureBox();
            this.pbNewCopy = new System.Windows.Forms.PictureBox();
            this.pbAddFixes = new System.Windows.Forms.PictureBox();
            this.pbAddChanges = new System.Windows.Forms.PictureBox();
            this.pbAddNew = new System.Windows.Forms.PictureBox();
            this.toolTipAdd = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipCopy = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEdit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDelete = new System.Windows.Forms.ToolTip(this.components);
            this.pbChangeUp = new System.Windows.Forms.PictureBox();
            this.pbChangeDown = new System.Windows.Forms.PictureBox();
            this.pbNewUp = new System.Windows.Forms.PictureBox();
            this.pbNewDown = new System.Windows.Forms.PictureBox();
            this.pbFixUp = new System.Windows.Forms.PictureBox();
            this.pbFixDown = new System.Windows.Forms.PictureBox();
            this.toolTipUp = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDown = new System.Windows.Forms.ToolTip(this.components);
            this.pTitle.SuspendLayout();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFixDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFixEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFixCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangeDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangeEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangeCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddFixes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddChanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFixUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFixDown)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lTitle.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.White;
            this.lTitle.Location = new System.Drawing.Point(0, 0);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(700, 39);
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
            this.lVersion.ForeColor = System.Drawing.Color.LightGray;
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
            this.lbNew.SelectedIndexChanged += new System.EventHandler(this.lbNew_SelectedIndexChanged);
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
            this.lbChanges.SelectedIndexChanged += new System.EventHandler(this.lbChanges_SelectedIndexChanged);
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
            this.lbFixes.SelectedIndexChanged += new System.EventHandler(this.lbFixes_SelectedIndexChanged);
            // 
            // lNew
            // 
            this.lNew.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lNew.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNew.ForeColor = System.Drawing.Color.White;
            this.lNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lNew.Location = new System.Drawing.Point(12, 107);
            this.lNew.Name = "lNew";
            this.lNew.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lNew.Size = new System.Drawing.Size(223, 25);
            this.lNew.TabIndex = 8;
            this.lNew.Text = "New features";
            this.lNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lChanges
            // 
            this.lChanges.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lChanges.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lChanges.ForeColor = System.Drawing.Color.White;
            this.lChanges.Location = new System.Drawing.Point(239, 107);
            this.lChanges.Name = "lChanges";
            this.lChanges.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lChanges.Size = new System.Drawing.Size(223, 25);
            this.lChanges.TabIndex = 9;
            this.lChanges.Text = "Changes";
            this.lChanges.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lFixes
            // 
            this.lFixes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lFixes.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFixes.ForeColor = System.Drawing.Color.White;
            this.lFixes.Location = new System.Drawing.Point(466, 107);
            this.lFixes.Name = "lFixes";
            this.lFixes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lFixes.Size = new System.Drawing.Size(223, 25);
            this.lFixes.TabIndex = 10;
            this.lFixes.Text = "Fixes";
            this.lFixes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ssInfo
            // 
            this.ssInfo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ssInfo.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssInfo.Location = new System.Drawing.Point(0, 474);
            this.ssInfo.Name = "ssInfo";
            this.ssInfo.Size = new System.Drawing.Size(700, 22);
            this.ssInfo.TabIndex = 14;
            this.ssInfo.Text = "Change-log manager - version 0.3";
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
            this.saveUsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // welcomeToolStripMenuItem
            // 
            this.welcomeToolStripMenuItem.Name = "welcomeToolStripMenuItem";
            this.welcomeToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.welcomeToolStripMenuItem.Text = "Welcome";
            this.welcomeToolStripMenuItem.Click += new System.EventHandler(this.welcomeToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveUsToolStripMenuItem
            // 
            this.saveUsToolStripMenuItem.Name = "saveUsToolStripMenuItem";
            this.saveUsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.saveUsToolStripMenuItem.Text = "Save as";
            this.saveUsToolStripMenuItem.Click += new System.EventHandler(this.saveUsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
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
            this.textFileToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.textFileToolStripMenuItem.Text = "Text file";
            this.textFileToolStripMenuItem.Click += new System.EventHandler(this.textFileToolStripMenuItem_Click);
            // 
            // bBCodeToolStripMenuItem
            // 
            this.bBCodeToolStripMenuItem.Name = "bBCodeToolStripMenuItem";
            this.bBCodeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.bBCodeToolStripMenuItem.Text = "BB Code";
            this.bBCodeToolStripMenuItem.Click += new System.EventHandler(this.bBCodeToolStripMenuItem_Click);
            // 
            // markdownToolStripMenuItem
            // 
            this.markdownToolStripMenuItem.Name = "markdownToolStripMenuItem";
            this.markdownToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.markdownToolStripMenuItem.Text = "Markdown";
            this.markdownToolStripMenuItem.Click += new System.EventHandler(this.markdownToolStripMenuItem_Click);
            // 
            // hTMLToolStripMenuItem
            // 
            this.hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
            this.hTMLToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.hTMLToolStripMenuItem.Text = "HTML";
            this.hTMLToolStripMenuItem.Click += new System.EventHandler(this.hTMLToolStripMenuItem_Click);
            // 
            // pawnToolStripMenuItem
            // 
            this.pawnToolStripMenuItem.Name = "pawnToolStripMenuItem";
            this.pawnToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
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
            // pbFixDelete
            // 
            this.pbFixDelete.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbFixDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFixDelete.Image = ((System.Drawing.Image)(resources.GetObject("pbFixDelete.Image")));
            this.pbFixDelete.Location = new System.Drawing.Point(607, 110);
            this.pbFixDelete.Name = "pbFixDelete";
            this.pbFixDelete.Size = new System.Drawing.Size(20, 20);
            this.pbFixDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFixDelete.TabIndex = 24;
            this.pbFixDelete.TabStop = false;
            this.toolTipDelete.SetToolTip(this.pbFixDelete, "Delete the selected item");
            this.pbFixDelete.Visible = false;
            this.pbFixDelete.Click += new System.EventHandler(this.pbFixDelete_Click);
            // 
            // pbFixEdit
            // 
            this.pbFixEdit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbFixEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFixEdit.Image = ((System.Drawing.Image)(resources.GetObject("pbFixEdit.Image")));
            this.pbFixEdit.Location = new System.Drawing.Point(627, 110);
            this.pbFixEdit.Name = "pbFixEdit";
            this.pbFixEdit.Size = new System.Drawing.Size(20, 20);
            this.pbFixEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFixEdit.TabIndex = 23;
            this.pbFixEdit.TabStop = false;
            this.toolTipEdit.SetToolTip(this.pbFixEdit, "Edit the selected item");
            this.pbFixEdit.Visible = false;
            this.pbFixEdit.Click += new System.EventHandler(this.pbFixEdit_Click);
            // 
            // pbFixCopy
            // 
            this.pbFixCopy.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbFixCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFixCopy.Image = ((System.Drawing.Image)(resources.GetObject("pbFixCopy.Image")));
            this.pbFixCopy.Location = new System.Drawing.Point(647, 110);
            this.pbFixCopy.Name = "pbFixCopy";
            this.pbFixCopy.Size = new System.Drawing.Size(20, 20);
            this.pbFixCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFixCopy.TabIndex = 22;
            this.pbFixCopy.TabStop = false;
            this.toolTipCopy.SetToolTip(this.pbFixCopy, "Copy the selected item");
            this.pbFixCopy.Visible = false;
            this.pbFixCopy.Click += new System.EventHandler(this.pbFixCopy_Click);
            // 
            // pbChangeDelete
            // 
            this.pbChangeDelete.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbChangeDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbChangeDelete.Image = ((System.Drawing.Image)(resources.GetObject("pbChangeDelete.Image")));
            this.pbChangeDelete.Location = new System.Drawing.Point(380, 110);
            this.pbChangeDelete.Name = "pbChangeDelete";
            this.pbChangeDelete.Size = new System.Drawing.Size(20, 20);
            this.pbChangeDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbChangeDelete.TabIndex = 21;
            this.pbChangeDelete.TabStop = false;
            this.toolTipDelete.SetToolTip(this.pbChangeDelete, "Delete the selected item");
            this.pbChangeDelete.Visible = false;
            this.pbChangeDelete.Click += new System.EventHandler(this.pbChangeDelete_Click);
            // 
            // pbChangeEdit
            // 
            this.pbChangeEdit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbChangeEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbChangeEdit.Image = ((System.Drawing.Image)(resources.GetObject("pbChangeEdit.Image")));
            this.pbChangeEdit.Location = new System.Drawing.Point(400, 110);
            this.pbChangeEdit.Name = "pbChangeEdit";
            this.pbChangeEdit.Size = new System.Drawing.Size(20, 20);
            this.pbChangeEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbChangeEdit.TabIndex = 20;
            this.pbChangeEdit.TabStop = false;
            this.toolTipEdit.SetToolTip(this.pbChangeEdit, "Edit the selected item");
            this.pbChangeEdit.Visible = false;
            this.pbChangeEdit.Click += new System.EventHandler(this.pbChangeEdit_Click);
            // 
            // pbChangeCopy
            // 
            this.pbChangeCopy.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbChangeCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbChangeCopy.Image = ((System.Drawing.Image)(resources.GetObject("pbChangeCopy.Image")));
            this.pbChangeCopy.Location = new System.Drawing.Point(420, 110);
            this.pbChangeCopy.Name = "pbChangeCopy";
            this.pbChangeCopy.Size = new System.Drawing.Size(20, 20);
            this.pbChangeCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbChangeCopy.TabIndex = 19;
            this.pbChangeCopy.TabStop = false;
            this.toolTipCopy.SetToolTip(this.pbChangeCopy, "Copy the selected item");
            this.pbChangeCopy.Visible = false;
            this.pbChangeCopy.Click += new System.EventHandler(this.pbChangeCopy_Click);
            // 
            // pbNewDelete
            // 
            this.pbNewDelete.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbNewDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNewDelete.Image = ((System.Drawing.Image)(resources.GetObject("pbNewDelete.Image")));
            this.pbNewDelete.Location = new System.Drawing.Point(153, 110);
            this.pbNewDelete.Name = "pbNewDelete";
            this.pbNewDelete.Size = new System.Drawing.Size(20, 20);
            this.pbNewDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNewDelete.TabIndex = 18;
            this.pbNewDelete.TabStop = false;
            this.toolTipDelete.SetToolTip(this.pbNewDelete, "Delete the selected item");
            this.pbNewDelete.Visible = false;
            this.pbNewDelete.Click += new System.EventHandler(this.pbNewDelete_Click);
            // 
            // pbNewEdit
            // 
            this.pbNewEdit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbNewEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNewEdit.Image = ((System.Drawing.Image)(resources.GetObject("pbNewEdit.Image")));
            this.pbNewEdit.Location = new System.Drawing.Point(173, 110);
            this.pbNewEdit.Name = "pbNewEdit";
            this.pbNewEdit.Size = new System.Drawing.Size(20, 20);
            this.pbNewEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNewEdit.TabIndex = 17;
            this.pbNewEdit.TabStop = false;
            this.toolTipEdit.SetToolTip(this.pbNewEdit, "Edit the selected item");
            this.pbNewEdit.Visible = false;
            this.pbNewEdit.Click += new System.EventHandler(this.pbNewEdit_Click);
            // 
            // pbNewCopy
            // 
            this.pbNewCopy.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbNewCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNewCopy.Image = ((System.Drawing.Image)(resources.GetObject("pbNewCopy.Image")));
            this.pbNewCopy.Location = new System.Drawing.Point(193, 110);
            this.pbNewCopy.Name = "pbNewCopy";
            this.pbNewCopy.Size = new System.Drawing.Size(20, 20);
            this.pbNewCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNewCopy.TabIndex = 16;
            this.pbNewCopy.TabStop = false;
            this.toolTipCopy.SetToolTip(this.pbNewCopy, "Copy the selected item");
            this.pbNewCopy.Visible = false;
            this.pbNewCopy.Click += new System.EventHandler(this.pbNewCopy_Click);
            // 
            // pbAddFixes
            // 
            this.pbAddFixes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbAddFixes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddFixes.Image = global::ChangeLogManager.Properties.Resources.icon_add;
            this.pbAddFixes.Location = new System.Drawing.Point(667, 110);
            this.pbAddFixes.Name = "pbAddFixes";
            this.pbAddFixes.Size = new System.Drawing.Size(20, 20);
            this.pbAddFixes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddFixes.TabIndex = 13;
            this.pbAddFixes.TabStop = false;
            this.toolTipAdd.SetToolTip(this.pbAddFixes, "Add a new entry to the list box");
            this.pbAddFixes.Click += new System.EventHandler(this.pbAddFixes_Click);
            // 
            // pbAddChanges
            // 
            this.pbAddChanges.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbAddChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddChanges.Image = global::ChangeLogManager.Properties.Resources.icon_add;
            this.pbAddChanges.Location = new System.Drawing.Point(440, 110);
            this.pbAddChanges.Name = "pbAddChanges";
            this.pbAddChanges.Size = new System.Drawing.Size(20, 20);
            this.pbAddChanges.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddChanges.TabIndex = 12;
            this.pbAddChanges.TabStop = false;
            this.toolTipAdd.SetToolTip(this.pbAddChanges, "Add a new entry to the list box");
            this.pbAddChanges.Click += new System.EventHandler(this.pbAddChanges_Click);
            // 
            // pbAddNew
            // 
            this.pbAddNew.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddNew.Image = global::ChangeLogManager.Properties.Resources.icon_add;
            this.pbAddNew.Location = new System.Drawing.Point(213, 110);
            this.pbAddNew.Name = "pbAddNew";
            this.pbAddNew.Size = new System.Drawing.Size(20, 20);
            this.pbAddNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddNew.TabIndex = 11;
            this.pbAddNew.TabStop = false;
            this.toolTipAdd.SetToolTip(this.pbAddNew, "Add a new entry to the list box");
            this.pbAddNew.Click += new System.EventHandler(this.pbAddNew_Click);
            // 
            // toolTipAdd
            // 
            this.toolTipAdd.AutomaticDelay = 1000;
            this.toolTipAdd.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipAdd.ToolTipTitle = "Add";
            // 
            // toolTipCopy
            // 
            this.toolTipCopy.AutomaticDelay = 1000;
            this.toolTipCopy.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipCopy.ToolTipTitle = "Copy";
            // 
            // toolTipEdit
            // 
            this.toolTipEdit.AutomaticDelay = 1000;
            this.toolTipEdit.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipEdit.ToolTipTitle = "Edit";
            // 
            // toolTipDelete
            // 
            this.toolTipDelete.AutomaticDelay = 1000;
            this.toolTipDelete.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipDelete.ToolTipTitle = "Delete";
            // 
            // pbChangeUp
            // 
            this.pbChangeUp.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbChangeUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbChangeUp.Image = ((System.Drawing.Image)(resources.GetObject("pbChangeUp.Image")));
            this.pbChangeUp.Location = new System.Drawing.Point(360, 110);
            this.pbChangeUp.Name = "pbChangeUp";
            this.pbChangeUp.Size = new System.Drawing.Size(20, 10);
            this.pbChangeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbChangeUp.TabIndex = 26;
            this.pbChangeUp.TabStop = false;
            this.toolTipUp.SetToolTip(this.pbChangeUp, "Move the selected item up");
            this.pbChangeUp.Visible = false;
            this.pbChangeUp.Click += new System.EventHandler(this.pbChangeUp_Click);
            // 
            // pbChangeDown
            // 
            this.pbChangeDown.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbChangeDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbChangeDown.Image = ((System.Drawing.Image)(resources.GetObject("pbChangeDown.Image")));
            this.pbChangeDown.Location = new System.Drawing.Point(360, 120);
            this.pbChangeDown.Name = "pbChangeDown";
            this.pbChangeDown.Size = new System.Drawing.Size(20, 10);
            this.pbChangeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbChangeDown.TabIndex = 25;
            this.pbChangeDown.TabStop = false;
            this.toolTipDown.SetToolTip(this.pbChangeDown, "Move the selected item down");
            this.pbChangeDown.Visible = false;
            this.pbChangeDown.Click += new System.EventHandler(this.pbChangeDown_Click);
            // 
            // pbNewUp
            // 
            this.pbNewUp.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbNewUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNewUp.Image = ((System.Drawing.Image)(resources.GetObject("pbNewUp.Image")));
            this.pbNewUp.Location = new System.Drawing.Point(133, 110);
            this.pbNewUp.Name = "pbNewUp";
            this.pbNewUp.Size = new System.Drawing.Size(20, 10);
            this.pbNewUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNewUp.TabIndex = 28;
            this.pbNewUp.TabStop = false;
            this.toolTipUp.SetToolTip(this.pbNewUp, "Move the selected item up");
            this.pbNewUp.Visible = false;
            this.pbNewUp.Click += new System.EventHandler(this.pbNewUp_Click);
            // 
            // pbNewDown
            // 
            this.pbNewDown.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbNewDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNewDown.Image = ((System.Drawing.Image)(resources.GetObject("pbNewDown.Image")));
            this.pbNewDown.Location = new System.Drawing.Point(133, 120);
            this.pbNewDown.Name = "pbNewDown";
            this.pbNewDown.Size = new System.Drawing.Size(20, 10);
            this.pbNewDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNewDown.TabIndex = 27;
            this.pbNewDown.TabStop = false;
            this.toolTipDown.SetToolTip(this.pbNewDown, "Move the selected item down");
            this.pbNewDown.Visible = false;
            this.pbNewDown.Click += new System.EventHandler(this.pbNewDown_Click);
            // 
            // pbFixUp
            // 
            this.pbFixUp.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbFixUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFixUp.Image = ((System.Drawing.Image)(resources.GetObject("pbFixUp.Image")));
            this.pbFixUp.Location = new System.Drawing.Point(587, 110);
            this.pbFixUp.Name = "pbFixUp";
            this.pbFixUp.Size = new System.Drawing.Size(20, 10);
            this.pbFixUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFixUp.TabIndex = 30;
            this.pbFixUp.TabStop = false;
            this.toolTipUp.SetToolTip(this.pbFixUp, "Move the selected item up");
            this.pbFixUp.Visible = false;
            this.pbFixUp.Click += new System.EventHandler(this.pbFixUp_Click);
            // 
            // pbFixDown
            // 
            this.pbFixDown.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbFixDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFixDown.Image = ((System.Drawing.Image)(resources.GetObject("pbFixDown.Image")));
            this.pbFixDown.Location = new System.Drawing.Point(587, 120);
            this.pbFixDown.Name = "pbFixDown";
            this.pbFixDown.Size = new System.Drawing.Size(20, 10);
            this.pbFixDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFixDown.TabIndex = 29;
            this.pbFixDown.TabStop = false;
            this.toolTipDown.SetToolTip(this.pbFixDown, "Move the selected item down");
            this.pbFixDown.Visible = false;
            this.pbFixDown.Click += new System.EventHandler(this.pbFixDown_Click);
            // 
            // toolTipUp
            // 
            this.toolTipUp.AutomaticDelay = 1000;
            this.toolTipUp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipUp.ToolTipTitle = "Move up";
            // 
            // toolTipDown
            // 
            this.toolTipDown.AutomaticDelay = 1000;
            this.toolTipDown.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipDown.ToolTipTitle = "Move down";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 496);
            this.Controls.Add(this.pbFixUp);
            this.Controls.Add(this.pbFixDown);
            this.Controls.Add(this.pbNewUp);
            this.Controls.Add(this.pbNewDown);
            this.Controls.Add(this.pbChangeUp);
            this.Controls.Add(this.pbChangeDown);
            this.Controls.Add(this.pbFixDelete);
            this.Controls.Add(this.pbFixEdit);
            this.Controls.Add(this.pbFixCopy);
            this.Controls.Add(this.pbChangeDelete);
            this.Controls.Add(this.pbChangeEdit);
            this.Controls.Add(this.pbChangeCopy);
            this.Controls.Add(this.pbNewDelete);
            this.Controls.Add(this.pbNewEdit);
            this.Controls.Add(this.pbNewCopy);
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
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFixDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFixEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFixCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangeDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangeEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangeCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddFixes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddChanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFixUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFixDown)).EndInit();
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
        private System.Windows.Forms.PictureBox pbNewCopy;
        private System.Windows.Forms.PictureBox pbNewEdit;
        private System.Windows.Forms.PictureBox pbNewDelete;
        private System.Windows.Forms.PictureBox pbChangeDelete;
        private System.Windows.Forms.PictureBox pbChangeEdit;
        private System.Windows.Forms.PictureBox pbChangeCopy;
        private System.Windows.Forms.PictureBox pbFixDelete;
        private System.Windows.Forms.PictureBox pbFixEdit;
        private System.Windows.Forms.PictureBox pbFixCopy;
        private System.Windows.Forms.ToolTip toolTipAdd;
        private System.Windows.Forms.ToolTip toolTipCopy;
        private System.Windows.Forms.ToolTip toolTipEdit;
        private System.Windows.Forms.ToolTip toolTipDelete;
        private System.Windows.Forms.ToolStripMenuItem saveUsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbChangeUp;
        private System.Windows.Forms.PictureBox pbChangeDown;
        private System.Windows.Forms.PictureBox pbNewUp;
        private System.Windows.Forms.PictureBox pbNewDown;
        private System.Windows.Forms.PictureBox pbFixUp;
        private System.Windows.Forms.PictureBox pbFixDown;
        private System.Windows.Forms.ToolTip toolTipUp;
        private System.Windows.Forms.ToolTip toolTipDown;
    }
}

