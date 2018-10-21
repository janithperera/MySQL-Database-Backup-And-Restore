using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseBackupAndRestore
{
    public partial class DatabaseBackupAndRestore : Form
    {
        private static MySqlConnection con;

        private string server;
        private string database;
        private string username;
        private string password;

        public DatabaseBackupAndRestore()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            this.server = txtServer.Text;
            this.database = txtDatabaseName.Text;
            this.username = txtUsername.Text;
            this.password = txtPassword.Text;

            settings.Default.server = this.server;
            settings.Default.database = this.database;
            settings.Default.username = this.username;
            settings.Default.password = this.password;
            settings.Default.Save();

            DBConnection.SetConnection(this.server, this.database, this.username, this.password);

            con = DBConnection.GetConnection();

            if (con == null)
                lblConnectionStatus.Text = "Connection unsuccessful!";
            else
                lblConnectionStatus.Text = "Connection successful!";
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (DBUtilities.BackupDatabase(txtBackupPath.Text))
                lblBackupStatus.Text = "Database backup successful!";
            else
                lblBackupStatus.Text = "Database backup failed!";
        }

        private void btnBrowseBackupFile_Click(object sender, EventArgs e)
        {
            OFD.ShowDialog();
            txtRestoreFile.Text = OFD.FileName;
            settings.Default.BackupFile = OFD.FileName;
            settings.Default.Save();
        }

        private void btnBrowseBackupPath_Click(object sender, EventArgs e)
        {
            FBD.ShowDialog();
            txtBackupPath.Text = FBD.SelectedPath + '\\' + this.database + ".sql";
            settings.Default.BackupLocation = FBD.SelectedPath;
            settings.Default.Save();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (DBUtilities.RestoreDatabase(txtRestoreFile.Text))
                lblRestoreStatus.Text = "Database restore successful!";
            else
                lblRestoreStatus.Text = "Database restore failed!";
        }

        private void DatabaseBackupAndRestore_Load(object sender, EventArgs e)
        {
            txtServer.Text = settings.Default.server;
            txtDatabaseName.Text = settings.Default.database;
            txtUsername.Text = settings.Default.username;
            txtPassword.Text = settings.Default.password;

            txtBackupPath.Text = settings.Default.BackupLocation;
            txtRestoreFile.Text = settings.Default.BackupFile;
        }
    }
}
