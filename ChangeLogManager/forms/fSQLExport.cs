using System;
using System.Windows.Forms;
using System.Linq;
using ChangeLogManager.classes;

namespace ChangeLogManager.forms
{
    public partial class fSQLExport : Form
    {
        // Variables ------------------------------------------------------------------
        public static TextBox database_name, changelog_info_table, new_features_table, changes_table, fixes_table;
        public static GroupBox dbsystem;


        // Form -----------------------------------------------------------------------
        public fSQLExport()
        {
            InitializeComponent();

            database_name = this.tbDatabaseName;
            changelog_info_table = this.tbChangelogTabName;
            new_features_table = this.tbNewTabName;
            changes_table = this.tbChangesTabName;
            fixes_table = this.tbFixesTabName;
            dbsystem = this.gbSQL;
        }


        // RadioButtons ---------------------------------------------------------------
        private void rbMySQL_CheckedChanged(object sender, EventArgs e)
        {
            CheckInput();
        }

        private void rbSQLite_CheckedChanged(object sender, EventArgs e)
        {
            CheckInput();
        }

        private void rbSQLServer_CheckedChanged(object sender, EventArgs e)
        {
            CheckInput();
        }


        // Textboxes ------------------------------------------------------------------
        private void tbDatabaseName_TextChanged(object sender, EventArgs e)
        {
            CheckInput();
        }

        private void tbChangelogTabName_TextChanged(object sender, EventArgs e)
        {
            CheckInput();
        }

        private void tbNewTabName_TextChanged(object sender, EventArgs e)
        {
            CheckInput();
        }

        private void tbChangesTabName_TextChanged(object sender, EventArgs e)
        {
            CheckInput();
        }

        private void tbFixesTabName_TextChanged(object sender, EventArgs e)
        {
            CheckInput();
        }


        // Buttons --------------------------------------------------------------------
        private void bExport_Click(object sender, EventArgs e)
        {
            cLog.ExportLog(SaveType.SQL);
        }


        // Methods --------------------------------------------------------------------
        private void CheckInput()
        {
            bool radioButtons = (gbSQL.Controls.OfType<RadioButton>().Count(rb => rb.Checked == true)) > 0;
            bool textBoxes = (this.Controls.OfType<TextBox>().Count(tb => tb.Text.Length > 0)) == 5;

            bExport.Enabled = (radioButtons && textBoxes);
        }
    }
}
