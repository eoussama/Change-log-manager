namespace ChangeLogManager.forms
{
    partial class fPawnExport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPawnExport));
            this.rbCommand = new System.Windows.Forms.RadioButton();
            this.rbDialog = new System.Windows.Forms.RadioButton();
            this.gbExportOptions = new System.Windows.Forms.GroupBox();
            this.rtbExport = new System.Windows.Forms.RichTextBox();
            this.bExport = new System.Windows.Forms.Button();
            this.bCopy = new System.Windows.Forms.Button();
            this.tbCommandName = new System.Windows.Forms.TextBox();
            this.cmDialogStyle = new System.Windows.Forms.ComboBox();
            this.bGenerate = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.tbDialogName = new System.Windows.Forms.TextBox();
            this.gbExportOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbCommand
            // 
            this.rbCommand.AutoSize = true;
            this.rbCommand.Location = new System.Drawing.Point(6, 19);
            this.rbCommand.Name = "rbCommand";
            this.rbCommand.Size = new System.Drawing.Size(72, 17);
            this.rbCommand.TabIndex = 0;
            this.rbCommand.TabStop = true;
            this.rbCommand.Text = "Command";
            this.rbCommand.UseVisualStyleBackColor = true;
            this.rbCommand.CheckedChanged += new System.EventHandler(this.rbCommand_CheckedChanged);
            // 
            // rbDialog
            // 
            this.rbDialog.AutoSize = true;
            this.rbDialog.Location = new System.Drawing.Point(6, 42);
            this.rbDialog.Name = "rbDialog";
            this.rbDialog.Size = new System.Drawing.Size(55, 17);
            this.rbDialog.TabIndex = 1;
            this.rbDialog.TabStop = true;
            this.rbDialog.Text = "Dialog";
            this.rbDialog.UseVisualStyleBackColor = true;
            // 
            // gbExportOptions
            // 
            this.gbExportOptions.Controls.Add(this.tbCommandName);
            this.gbExportOptions.Controls.Add(this.rbCommand);
            this.gbExportOptions.Controls.Add(this.rbDialog);
            this.gbExportOptions.Location = new System.Drawing.Point(12, 10);
            this.gbExportOptions.Name = "gbExportOptions";
            this.gbExportOptions.Size = new System.Drawing.Size(173, 65);
            this.gbExportOptions.TabIndex = 2;
            this.gbExportOptions.TabStop = false;
            this.gbExportOptions.Text = "Export as";
            // 
            // rtbExport
            // 
            this.rtbExport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbExport.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbExport.Location = new System.Drawing.Point(12, 83);
            this.rtbExport.Name = "rtbExport";
            this.rtbExport.Size = new System.Drawing.Size(418, 265);
            this.rtbExport.TabIndex = 3;
            this.rtbExport.Text = "";
            // 
            // bExport
            // 
            this.bExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.bExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExport.Location = new System.Drawing.Point(354, 47);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(75, 27);
            this.bExport.TabIndex = 4;
            this.bExport.Text = "Export";
            this.bExport.UseVisualStyleBackColor = true;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // bCopy
            // 
            this.bCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.bCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCopy.Location = new System.Drawing.Point(354, 16);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(75, 28);
            this.bCopy.TabIndex = 5;
            this.bCopy.Text = "Copy";
            this.bCopy.UseVisualStyleBackColor = true;
            this.bCopy.Click += new System.EventHandler(this.bCopy_Click);
            // 
            // tbCommandName
            // 
            this.tbCommandName.Enabled = false;
            this.tbCommandName.Location = new System.Drawing.Point(84, 18);
            this.tbCommandName.Name = "tbCommandName";
            this.tbCommandName.Size = new System.Drawing.Size(81, 20);
            this.tbCommandName.TabIndex = 2;
            // 
            // cmDialogStyle
            // 
            this.cmDialogStyle.FormattingEnabled = true;
            this.cmDialogStyle.Items.AddRange(new object[] {
            "DIALOG_STYLE_MSGBOX",
            "DIALOG_STYLE_LIST"});
            this.cmDialogStyle.Location = new System.Drawing.Point(191, 16);
            this.cmDialogStyle.Name = "cmDialogStyle";
            this.cmDialogStyle.Size = new System.Drawing.Size(75, 21);
            this.cmDialogStyle.TabIndex = 6;
            // 
            // bGenerate
            // 
            this.bGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.bGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGenerate.Location = new System.Drawing.Point(191, 47);
            this.bGenerate.Name = "bGenerate";
            this.bGenerate.Size = new System.Drawing.Size(75, 27);
            this.bGenerate.TabIndex = 7;
            this.bGenerate.Text = "Generate";
            this.bGenerate.UseVisualStyleBackColor = true;
            this.bGenerate.Click += new System.EventHandler(this.bGenerate_Click);
            // 
            // bClear
            // 
            this.bClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClear.Location = new System.Drawing.Point(273, 47);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 27);
            this.bClear.TabIndex = 8;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // tbDialogName
            // 
            this.tbDialogName.Location = new System.Drawing.Point(272, 16);
            this.tbDialogName.Name = "tbDialogName";
            this.tbDialogName.Size = new System.Drawing.Size(76, 20);
            this.tbDialogName.TabIndex = 3;
            // 
            // fPawnExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 360);
            this.Controls.Add(this.tbDialogName);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bGenerate);
            this.Controls.Add(this.cmDialogStyle);
            this.Controls.Add(this.bCopy);
            this.Controls.Add(this.bExport);
            this.Controls.Add(this.rtbExport);
            this.Controls.Add(this.gbExportOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fPawnExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export in pawn syntax";
            this.gbExportOptions.ResumeLayout(false);
            this.gbExportOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCommand;
        private System.Windows.Forms.RadioButton rbDialog;
        private System.Windows.Forms.GroupBox gbExportOptions;
        private System.Windows.Forms.RichTextBox rtbExport;
        private System.Windows.Forms.Button bExport;
        private System.Windows.Forms.Button bCopy;
        private System.Windows.Forms.TextBox tbCommandName;
        private System.Windows.Forms.ComboBox cmDialogStyle;
        private System.Windows.Forms.Button bGenerate;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.TextBox tbDialogName;
    }
}