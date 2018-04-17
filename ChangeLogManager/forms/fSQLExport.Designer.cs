namespace ChangeLogManager.forms
{
    partial class fSQLExport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSQLExport));
            this.lDatabaseName = new System.Windows.Forms.Label();
            this.tbDatabaseName = new System.Windows.Forms.TextBox();
            this.bExport = new System.Windows.Forms.Button();
            this.tbChangelogTabName = new System.Windows.Forms.TextBox();
            this.lMainTabName = new System.Windows.Forms.Label();
            this.tbNewTabName = new System.Windows.Forms.TextBox();
            this.lNewTabName = new System.Windows.Forms.Label();
            this.tbChangesTabName = new System.Windows.Forms.TextBox();
            this.lChangeTabName = new System.Windows.Forms.Label();
            this.tbFixesTabName = new System.Windows.Forms.TextBox();
            this.lFixesTabName = new System.Windows.Forms.Label();
            this.gbSQL = new System.Windows.Forms.GroupBox();
            this.rbMySQL = new System.Windows.Forms.RadioButton();
            this.rbSQLite = new System.Windows.Forms.RadioButton();
            this.rbSQLServer = new System.Windows.Forms.RadioButton();
            this.gbSQL.SuspendLayout();
            this.SuspendLayout();
            // 
            // lDatabaseName
            // 
            this.lDatabaseName.AutoSize = true;
            this.lDatabaseName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDatabaseName.Location = new System.Drawing.Point(26, 103);
            this.lDatabaseName.Name = "lDatabaseName";
            this.lDatabaseName.Size = new System.Drawing.Size(98, 16);
            this.lDatabaseName.TabIndex = 0;
            this.lDatabaseName.Text = "Database Name";
            // 
            // tbDatabaseName
            // 
            this.tbDatabaseName.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDatabaseName.Location = new System.Drawing.Point(161, 100);
            this.tbDatabaseName.Name = "tbDatabaseName";
            this.tbDatabaseName.Size = new System.Drawing.Size(146, 23);
            this.tbDatabaseName.TabIndex = 1;
            this.tbDatabaseName.Text = "db_changelogs";
            this.tbDatabaseName.TextChanged += new System.EventHandler(this.tbDatabaseName_TextChanged);
            // 
            // bExport
            // 
            this.bExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExport.Enabled = false;
            this.bExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExport.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExport.Location = new System.Drawing.Point(107, 300);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(120, 46);
            this.bExport.TabIndex = 2;
            this.bExport.Text = "Export";
            this.bExport.UseVisualStyleBackColor = true;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // tbChangelogTabName
            // 
            this.tbChangelogTabName.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChangelogTabName.Location = new System.Drawing.Point(161, 139);
            this.tbChangelogTabName.Name = "tbChangelogTabName";
            this.tbChangelogTabName.Size = new System.Drawing.Size(146, 23);
            this.tbChangelogTabName.TabIndex = 4;
            this.tbChangelogTabName.Text = "changelog_Info";
            this.tbChangelogTabName.TextChanged += new System.EventHandler(this.tbChangelogTabName_TextChanged);
            // 
            // lMainTabName
            // 
            this.lMainTabName.AutoSize = true;
            this.lMainTabName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMainTabName.Location = new System.Drawing.Point(26, 142);
            this.lMainTabName.Name = "lMainTabName";
            this.lMainTabName.Size = new System.Drawing.Size(129, 16);
            this.lMainTabName.TabIndex = 3;
            this.lMainTabName.Text = "Change-log info table";
            // 
            // tbNewTabName
            // 
            this.tbNewTabName.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewTabName.Location = new System.Drawing.Point(161, 178);
            this.tbNewTabName.Name = "tbNewTabName";
            this.tbNewTabName.Size = new System.Drawing.Size(146, 23);
            this.tbNewTabName.TabIndex = 6;
            this.tbNewTabName.Text = "new_features";
            this.tbNewTabName.TextChanged += new System.EventHandler(this.tbNewTabName_TextChanged);
            // 
            // lNewTabName
            // 
            this.lNewTabName.AutoSize = true;
            this.lNewTabName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNewTabName.Location = new System.Drawing.Point(26, 181);
            this.lNewTabName.Name = "lNewTabName";
            this.lNewTabName.Size = new System.Drawing.Size(115, 16);
            this.lNewTabName.TabIndex = 5;
            this.lNewTabName.Text = "New features table";
            // 
            // tbChangesTabName
            // 
            this.tbChangesTabName.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChangesTabName.Location = new System.Drawing.Point(161, 217);
            this.tbChangesTabName.Name = "tbChangesTabName";
            this.tbChangesTabName.Size = new System.Drawing.Size(146, 23);
            this.tbChangesTabName.TabIndex = 8;
            this.tbChangesTabName.Text = "changes";
            this.tbChangesTabName.TextChanged += new System.EventHandler(this.tbChangesTabName_TextChanged);
            // 
            // lChangeTabName
            // 
            this.lChangeTabName.AutoSize = true;
            this.lChangeTabName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lChangeTabName.Location = new System.Drawing.Point(26, 220);
            this.lChangeTabName.Name = "lChangeTabName";
            this.lChangeTabName.Size = new System.Drawing.Size(88, 16);
            this.lChangeTabName.TabIndex = 7;
            this.lChangeTabName.Text = "Changes table";
            // 
            // tbFixesTabName
            // 
            this.tbFixesTabName.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFixesTabName.Location = new System.Drawing.Point(161, 256);
            this.tbFixesTabName.Name = "tbFixesTabName";
            this.tbFixesTabName.Size = new System.Drawing.Size(146, 23);
            this.tbFixesTabName.TabIndex = 10;
            this.tbFixesTabName.Text = "fixes";
            this.tbFixesTabName.TextChanged += new System.EventHandler(this.tbFixesTabName_TextChanged);
            // 
            // lFixesTabName
            // 
            this.lFixesTabName.AutoSize = true;
            this.lFixesTabName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFixesTabName.Location = new System.Drawing.Point(26, 259);
            this.lFixesTabName.Name = "lFixesTabName";
            this.lFixesTabName.Size = new System.Drawing.Size(68, 16);
            this.lFixesTabName.TabIndex = 9;
            this.lFixesTabName.Text = "Fixes table";
            // 
            // gbSQL
            // 
            this.gbSQL.Controls.Add(this.rbSQLServer);
            this.gbSQL.Controls.Add(this.rbSQLite);
            this.gbSQL.Controls.Add(this.rbMySQL);
            this.gbSQL.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSQL.Location = new System.Drawing.Point(29, 12);
            this.gbSQL.Name = "gbSQL";
            this.gbSQL.Size = new System.Drawing.Size(278, 76);
            this.gbSQL.TabIndex = 11;
            this.gbSQL.TabStop = false;
            this.gbSQL.Text = "Database management system:";
            // 
            // rbMySQL
            // 
            this.rbMySQL.AutoSize = true;
            this.rbMySQL.Location = new System.Drawing.Point(19, 33);
            this.rbMySQL.Name = "rbMySQL";
            this.rbMySQL.Size = new System.Drawing.Size(66, 20);
            this.rbMySQL.TabIndex = 0;
            this.rbMySQL.TabStop = true;
            this.rbMySQL.Text = "MySQL";
            this.rbMySQL.UseVisualStyleBackColor = true;
            this.rbMySQL.CheckedChanged += new System.EventHandler(this.rbMySQL_CheckedChanged);
            // 
            // rbSQLite
            // 
            this.rbSQLite.AutoSize = true;
            this.rbSQLite.Location = new System.Drawing.Point(97, 33);
            this.rbSQLite.Name = "rbSQLite";
            this.rbSQLite.Size = new System.Drawing.Size(64, 20);
            this.rbSQLite.TabIndex = 1;
            this.rbSQLite.TabStop = true;
            this.rbSQLite.Text = "SQLite";
            this.rbSQLite.UseVisualStyleBackColor = true;
            this.rbSQLite.CheckedChanged += new System.EventHandler(this.rbSQLite_CheckedChanged);
            // 
            // rbSQLServer
            // 
            this.rbSQLServer.AutoSize = true;
            this.rbSQLServer.Location = new System.Drawing.Point(173, 33);
            this.rbSQLServer.Name = "rbSQLServer";
            this.rbSQLServer.Size = new System.Drawing.Size(93, 20);
            this.rbSQLServer.TabIndex = 2;
            this.rbSQLServer.TabStop = true;
            this.rbSQLServer.Text = "SQL Server";
            this.rbSQLServer.UseVisualStyleBackColor = true;
            this.rbSQLServer.CheckedChanged += new System.EventHandler(this.rbSQLServer_CheckedChanged);
            // 
            // fSQLExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 366);
            this.Controls.Add(this.gbSQL);
            this.Controls.Add(this.tbFixesTabName);
            this.Controls.Add(this.lFixesTabName);
            this.Controls.Add(this.tbChangesTabName);
            this.Controls.Add(this.lChangeTabName);
            this.Controls.Add(this.tbNewTabName);
            this.Controls.Add(this.lNewTabName);
            this.Controls.Add(this.tbChangelogTabName);
            this.Controls.Add(this.lMainTabName);
            this.Controls.Add(this.bExport);
            this.Controls.Add(this.tbDatabaseName);
            this.Controls.Add(this.lDatabaseName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSQLExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Export";
            this.gbSQL.ResumeLayout(false);
            this.gbSQL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lDatabaseName;
        private System.Windows.Forms.TextBox tbDatabaseName;
        private System.Windows.Forms.Button bExport;
        private System.Windows.Forms.TextBox tbChangelogTabName;
        private System.Windows.Forms.Label lMainTabName;
        private System.Windows.Forms.TextBox tbNewTabName;
        private System.Windows.Forms.Label lNewTabName;
        private System.Windows.Forms.TextBox tbChangesTabName;
        private System.Windows.Forms.Label lChangeTabName;
        private System.Windows.Forms.TextBox tbFixesTabName;
        private System.Windows.Forms.Label lFixesTabName;
        private System.Windows.Forms.GroupBox gbSQL;
        private System.Windows.Forms.RadioButton rbSQLServer;
        private System.Windows.Forms.RadioButton rbSQLite;
        private System.Windows.Forms.RadioButton rbMySQL;
    }
}