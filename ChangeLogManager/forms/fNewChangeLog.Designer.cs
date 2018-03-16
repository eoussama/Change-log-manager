namespace ChangeLogManager
{
    partial class fNewChangeLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNewChangeLog));
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbVersion = new System.Windows.Forms.TextBox();
            this.lTitle = new System.Windows.Forms.Label();
            this.lVersion = new System.Windows.Forms.Label();
            this.bNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTitle.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.ForeColor = System.Drawing.Color.White;
            this.tbTitle.Location = new System.Drawing.Point(24, 33);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(224, 22);
            this.tbTitle.TabIndex = 0;
            this.tbTitle.TextChanged += new System.EventHandler(this.tbTitle_TextChanged);
            // 
            // tbVersion
            // 
            this.tbVersion.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbVersion.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVersion.ForeColor = System.Drawing.Color.White;
            this.tbVersion.Location = new System.Drawing.Point(24, 98);
            this.tbVersion.Name = "tbVersion";
            this.tbVersion.Size = new System.Drawing.Size(224, 22);
            this.tbVersion.TabIndex = 1;
            this.tbVersion.TextChanged += new System.EventHandler(this.tbVersion_TextChanged);
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(21, 14);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(99, 16);
            this.lTitle.TabIndex = 2;
            this.lTitle.Text = "Change-log title";
            // 
            // lVersion
            // 
            this.lVersion.AutoSize = true;
            this.lVersion.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVersion.Location = new System.Drawing.Point(21, 79);
            this.lVersion.Name = "lVersion";
            this.lVersion.Size = new System.Drawing.Size(120, 16);
            this.lVersion.TabIndex = 3;
            this.lVersion.Text = "Change-log version";
            // 
            // bNew
            // 
            this.bNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNew.Enabled = false;
            this.bNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.bNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNew.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNew.Location = new System.Drawing.Point(96, 133);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(81, 35);
            this.bNew.TabIndex = 4;
            this.bNew.Text = "Create";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // fNewChangeLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 179);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.lVersion);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.tbVersion);
            this.Controls.Add(this.tbTitle);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fNewChangeLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Change-log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbVersion;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lVersion;
        private System.Windows.Forms.Button bNew;
    }
}