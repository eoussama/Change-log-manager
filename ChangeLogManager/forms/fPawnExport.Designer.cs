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
            this.bGenerate = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.gbDialog = new System.Windows.Forms.GroupBox();
            this.cbDialogStyle = new System.Windows.Forms.ComboBox();
            this.gbDialogId = new System.Windows.Forms.GroupBox();
            this.cbRandomId = new System.Windows.Forms.CheckBox();
            this.nudDialogId = new System.Windows.Forms.NumericUpDown();
            this.lDialogStyle = new System.Windows.Forms.Label();
            this.gbCommand = new System.Windows.Forms.GroupBox();
            this.lCommandName = new System.Windows.Forms.Label();
            this.tbCommandName = new System.Windows.Forms.TextBox();
            this.lCommandProcc = new System.Windows.Forms.Label();
            this.cbProcessor = new System.Windows.Forms.ComboBox();
            this.lCaption = new System.Windows.Forms.Label();
            this.tbCaption = new System.Windows.Forms.TextBox();
            this.gbExportOptions.SuspendLayout();
            this.gbDialog.SuspendLayout();
            this.gbDialogId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDialogId)).BeginInit();
            this.gbCommand.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbCommand
            // 
            this.rbCommand.AutoSize = true;
            this.rbCommand.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCommand.Location = new System.Drawing.Point(14, 19);
            this.rbCommand.Name = "rbCommand";
            this.rbCommand.Size = new System.Drawing.Size(84, 20);
            this.rbCommand.TabIndex = 0;
            this.rbCommand.TabStop = true;
            this.rbCommand.Text = "Command";
            this.rbCommand.UseVisualStyleBackColor = true;
            this.rbCommand.CheckedChanged += new System.EventHandler(this.rbCommand_CheckedChanged);
            // 
            // rbDialog
            // 
            this.rbDialog.AutoSize = true;
            this.rbDialog.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDialog.Location = new System.Drawing.Point(165, 19);
            this.rbDialog.Name = "rbDialog";
            this.rbDialog.Size = new System.Drawing.Size(63, 20);
            this.rbDialog.TabIndex = 1;
            this.rbDialog.TabStop = true;
            this.rbDialog.Text = "Dialog";
            this.rbDialog.UseVisualStyleBackColor = true;
            // 
            // gbExportOptions
            // 
            this.gbExportOptions.Controls.Add(this.rbCommand);
            this.gbExportOptions.Controls.Add(this.rbDialog);
            this.gbExportOptions.Location = new System.Drawing.Point(13, 7);
            this.gbExportOptions.Name = "gbExportOptions";
            this.gbExportOptions.Size = new System.Drawing.Size(242, 52);
            this.gbExportOptions.TabIndex = 2;
            this.gbExportOptions.TabStop = false;
            this.gbExportOptions.Text = "Export as";
            // 
            // rtbExport
            // 
            this.rtbExport.BackColor = System.Drawing.Color.White;
            this.rtbExport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbExport.DetectUrls = false;
            this.rtbExport.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbExport.Location = new System.Drawing.Point(269, 12);
            this.rtbExport.Name = "rtbExport";
            this.rtbExport.Size = new System.Drawing.Size(418, 265);
            this.rtbExport.TabIndex = 3;
            this.rtbExport.Text = "";
            this.rtbExport.WordWrap = false;
            this.rtbExport.TextChanged += new System.EventHandler(this.rtbExport_TextChanged);
            // 
            // bExport
            // 
            this.bExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExport.Enabled = false;
            this.bExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.bExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExport.Location = new System.Drawing.Point(593, 283);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(92, 27);
            this.bExport.TabIndex = 4;
            this.bExport.Text = "Export";
            this.bExport.UseVisualStyleBackColor = true;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // bCopy
            // 
            this.bCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCopy.Enabled = false;
            this.bCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.bCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCopy.Location = new System.Drawing.Point(485, 283);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(92, 28);
            this.bCopy.TabIndex = 5;
            this.bCopy.Text = "Copy";
            this.bCopy.UseVisualStyleBackColor = true;
            this.bCopy.Click += new System.EventHandler(this.bCopy_Click);
            // 
            // bGenerate
            // 
            this.bGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.bGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGenerate.Location = new System.Drawing.Point(269, 284);
            this.bGenerate.Name = "bGenerate";
            this.bGenerate.Size = new System.Drawing.Size(92, 27);
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
            this.bClear.Location = new System.Drawing.Point(377, 284);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(92, 27);
            this.bClear.TabIndex = 8;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // gbDialog
            // 
            this.gbDialog.Controls.Add(this.tbCaption);
            this.gbDialog.Controls.Add(this.lCaption);
            this.gbDialog.Controls.Add(this.cbDialogStyle);
            this.gbDialog.Controls.Add(this.gbDialogId);
            this.gbDialog.Controls.Add(this.lDialogStyle);
            this.gbDialog.Location = new System.Drawing.Point(13, 64);
            this.gbDialog.Name = "gbDialog";
            this.gbDialog.Size = new System.Drawing.Size(242, 149);
            this.gbDialog.TabIndex = 9;
            this.gbDialog.TabStop = false;
            this.gbDialog.Text = "Dialog settings";
            // 
            // cbDialogStyle
            // 
            this.cbDialogStyle.FormattingEnabled = true;
            this.cbDialogStyle.Items.AddRange(new object[] {
            "DIALOG_STYLE_MSGBOX",
            "DIALOG_STYLE_LIST"});
            this.cbDialogStyle.Location = new System.Drawing.Point(74, 83);
            this.cbDialogStyle.Name = "cbDialogStyle";
            this.cbDialogStyle.Size = new System.Drawing.Size(160, 21);
            this.cbDialogStyle.TabIndex = 4;
            // 
            // gbDialogId
            // 
            this.gbDialogId.Controls.Add(this.cbRandomId);
            this.gbDialogId.Controls.Add(this.nudDialogId);
            this.gbDialogId.Location = new System.Drawing.Point(7, 19);
            this.gbDialogId.Name = "gbDialogId";
            this.gbDialogId.Size = new System.Drawing.Size(227, 58);
            this.gbDialogId.TabIndex = 3;
            this.gbDialogId.TabStop = false;
            this.gbDialogId.Text = "Dialog ID";
            // 
            // cbRandomId
            // 
            this.cbRandomId.AutoSize = true;
            this.cbRandomId.Location = new System.Drawing.Point(8, 27);
            this.cbRandomId.Name = "cbRandomId";
            this.cbRandomId.Size = new System.Drawing.Size(80, 17);
            this.cbRandomId.TabIndex = 0;
            this.cbRandomId.Text = "Random ID";
            this.cbRandomId.UseVisualStyleBackColor = true;
            this.cbRandomId.CheckedChanged += new System.EventHandler(this.cbRandomId_CheckedChanged);
            // 
            // nudDialogId
            // 
            this.nudDialogId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudDialogId.Location = new System.Drawing.Point(148, 25);
            this.nudDialogId.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudDialogId.Name = "nudDialogId";
            this.nudDialogId.Size = new System.Drawing.Size(71, 20);
            this.nudDialogId.TabIndex = 2;
            // 
            // lDialogStyle
            // 
            this.lDialogStyle.AutoSize = true;
            this.lDialogStyle.Location = new System.Drawing.Point(4, 86);
            this.lDialogStyle.Name = "lDialogStyle";
            this.lDialogStyle.Size = new System.Drawing.Size(61, 13);
            this.lDialogStyle.TabIndex = 1;
            this.lDialogStyle.Text = "Dialog style";
            // 
            // gbCommand
            // 
            this.gbCommand.Controls.Add(this.cbProcessor);
            this.gbCommand.Controls.Add(this.lCommandProcc);
            this.gbCommand.Controls.Add(this.tbCommandName);
            this.gbCommand.Controls.Add(this.lCommandName);
            this.gbCommand.Location = new System.Drawing.Point(13, 219);
            this.gbCommand.Name = "gbCommand";
            this.gbCommand.Size = new System.Drawing.Size(242, 92);
            this.gbCommand.TabIndex = 10;
            this.gbCommand.TabStop = false;
            this.gbCommand.Text = "Command Settings";
            this.gbCommand.Visible = false;
            // 
            // lCommandName
            // 
            this.lCommandName.AutoSize = true;
            this.lCommandName.Location = new System.Drawing.Point(6, 24);
            this.lCommandName.Name = "lCommandName";
            this.lCommandName.Size = new System.Drawing.Size(83, 13);
            this.lCommandName.TabIndex = 0;
            this.lCommandName.Text = "Command name";
            // 
            // tbCommandName
            // 
            this.tbCommandName.Location = new System.Drawing.Point(109, 21);
            this.tbCommandName.Name = "tbCommandName";
            this.tbCommandName.Size = new System.Drawing.Size(125, 20);
            this.tbCommandName.TabIndex = 1;
            // 
            // lCommandProcc
            // 
            this.lCommandProcc.AutoSize = true;
            this.lCommandProcc.Location = new System.Drawing.Point(6, 56);
            this.lCommandProcc.Name = "lCommandProcc";
            this.lCommandProcc.Size = new System.Drawing.Size(54, 13);
            this.lCommandProcc.TabIndex = 2;
            this.lCommandProcc.Text = "Processor";
            // 
            // cbProcessor
            // 
            this.cbProcessor.FormattingEnabled = true;
            this.cbProcessor.Items.AddRange(new object[] {
            "None",
            "ZCMD",
            "iZCMD",
            "PawnCMD",
            "y_command"});
            this.cbProcessor.Location = new System.Drawing.Point(109, 53);
            this.cbProcessor.Name = "cbProcessor";
            this.cbProcessor.Size = new System.Drawing.Size(125, 21);
            this.cbProcessor.TabIndex = 5;
            // 
            // lCaption
            // 
            this.lCaption.AutoSize = true;
            this.lCaption.Location = new System.Drawing.Point(4, 122);
            this.lCaption.Name = "lCaption";
            this.lCaption.Size = new System.Drawing.Size(75, 13);
            this.lCaption.TabIndex = 5;
            this.lCaption.Text = "Dialog caption";
            // 
            // tbCaption
            // 
            this.tbCaption.Location = new System.Drawing.Point(85, 119);
            this.tbCaption.Name = "tbCaption";
            this.tbCaption.Size = new System.Drawing.Size(149, 20);
            this.tbCaption.TabIndex = 6;
            // 
            // fPawnExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 318);
            this.Controls.Add(this.gbCommand);
            this.Controls.Add(this.gbDialog);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bGenerate);
            this.Controls.Add(this.bCopy);
            this.Controls.Add(this.bExport);
            this.Controls.Add(this.rtbExport);
            this.Controls.Add(this.gbExportOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fPawnExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export in pawn syntax";
            this.gbExportOptions.ResumeLayout(false);
            this.gbExportOptions.PerformLayout();
            this.gbDialog.ResumeLayout(false);
            this.gbDialog.PerformLayout();
            this.gbDialogId.ResumeLayout(false);
            this.gbDialogId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDialogId)).EndInit();
            this.gbCommand.ResumeLayout(false);
            this.gbCommand.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCommand;
        private System.Windows.Forms.RadioButton rbDialog;
        private System.Windows.Forms.GroupBox gbExportOptions;
        private System.Windows.Forms.RichTextBox rtbExport;
        private System.Windows.Forms.Button bExport;
        private System.Windows.Forms.Button bCopy;
        private System.Windows.Forms.Button bGenerate;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.GroupBox gbDialog;
        private System.Windows.Forms.Label lDialogStyle;
        private System.Windows.Forms.CheckBox cbRandomId;
        private System.Windows.Forms.NumericUpDown nudDialogId;
        private System.Windows.Forms.GroupBox gbDialogId;
        private System.Windows.Forms.ComboBox cbDialogStyle;
        private System.Windows.Forms.GroupBox gbCommand;
        private System.Windows.Forms.Label lCommandName;
        private System.Windows.Forms.TextBox tbCommandName;
        private System.Windows.Forms.Label lCommandProcc;
        private System.Windows.Forms.ComboBox cbProcessor;
        private System.Windows.Forms.Label lCaption;
        private System.Windows.Forms.TextBox tbCaption;
    }
}