namespace ChangeLogManager
{
    partial class ucRecent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lTitle = new System.Windows.Forms.Label();
            this.lVersion = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lClose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(54, 3);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(65, 13);
            this.lTitle.TabIndex = 1;
            this.lTitle.Text = "Update Title";
            this.lTitle.Click += new System.EventHandler(this.lDate_Click);
            this.lTitle.MouseEnter += new System.EventHandler(this.lDate_MouseEnter);
            this.lTitle.MouseLeave += new System.EventHandler(this.lDate_MouseLeave);
            // 
            // lVersion
            // 
            this.lVersion.AutoSize = true;
            this.lVersion.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVersion.Location = new System.Drawing.Point(54, 20);
            this.lVersion.Name = "lVersion";
            this.lVersion.Size = new System.Drawing.Size(58, 13);
            this.lVersion.TabIndex = 2;
            this.lVersion.Text = "Version 0.1";
            this.lVersion.Click += new System.EventHandler(this.lDate_Click);
            this.lVersion.MouseEnter += new System.EventHandler(this.lDate_MouseEnter);
            this.lVersion.MouseLeave += new System.EventHandler(this.lDate_MouseLeave);
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lDate.Location = new System.Drawing.Point(54, 36);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(45, 13);
            this.lDate.TabIndex = 3;
            this.lDate.Text = "1/1/2018";
            this.lDate.Click += new System.EventHandler(this.lDate_Click);
            this.lDate.MouseEnter += new System.EventHandler(this.lDate_MouseEnter);
            this.lDate.MouseLeave += new System.EventHandler(this.lDate_MouseLeave);
            // 
            // pbIcon
            // 
            this.pbIcon.Image = global::ChangeLogManager.Properties.Resources.iconfiles;
            this.pbIcon.Location = new System.Drawing.Point(3, 3);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(45, 45);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            this.pbIcon.Click += new System.EventHandler(this.lDate_Click);
            this.pbIcon.MouseEnter += new System.EventHandler(this.lDate_MouseEnter);
            this.pbIcon.MouseLeave += new System.EventHandler(this.lDate_MouseLeave);
            // 
            // lClose
            // 
            this.lClose.AutoSize = true;
            this.lClose.BackColor = System.Drawing.Color.Transparent;
            this.lClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.lClose.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClose.ForeColor = System.Drawing.Color.White;
            this.lClose.Location = new System.Drawing.Point(150, 0);
            this.lClose.Name = "lClose";
            this.lClose.Size = new System.Drawing.Size(16, 16);
            this.lClose.TabIndex = 4;
            this.lClose.Text = "x";
            this.lClose.Click += new System.EventHandler(this.lClose_Click);
            this.lClose.MouseEnter += new System.EventHandler(this.lClose_MouseEnter);
            this.lClose.MouseLeave += new System.EventHandler(this.lClose_MouseLeave);
            // 
            // ucRecent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.lClose);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.lVersion);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.pbIcon);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ucRecent";
            this.Size = new System.Drawing.Size(166, 54);
            this.Click += new System.EventHandler(this.ucRecent_Click);
            this.MouseEnter += new System.EventHandler(this.ucRecent_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ucRecent_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lVersion;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label lClose;
    }
}
