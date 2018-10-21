namespace DatabaseBackupAndRestore
{
    partial class DatabaseBackupAndRestore
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBackupPath = new System.Windows.Forms.Label();
            this.btnBrowseBackupPath = new System.Windows.Forms.Button();
            this.lblBackupStatus = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRestoreFile = new System.Windows.Forms.Label();
            this.btnBrowseBackupFile = new System.Windows.Forms.Button();
            this.lblRestoreStatus = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblConnectionStatus);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDatabaseName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATABASE CONNECTION";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionStatus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblConnectionStatus.Location = new System.Drawing.Point(6, 148);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(523, 25);
            this.lblConnectionStatus.TabIndex = 7;
            this.lblConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(535, 146);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(114, 28);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(136, 115);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(513, 25);
            this.txtPassword.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "PASSWORD";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(136, 84);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(513, 25);
            this.txtUsername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "USER NAME";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabaseName.Location = new System.Drawing.Point(136, 53);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(513, 25);
            this.txtDatabaseName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "DATABASE NAME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.Location = new System.Drawing.Point(136, 22);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(513, 25);
            this.txtServer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERVER NAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBackupPath);
            this.groupBox2.Controls.Add(this.btnBrowseBackupPath);
            this.groupBox2.Controls.Add(this.lblBackupStatus);
            this.groupBox2.Controls.Add(this.btnBackup);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(12, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 92);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATABASE BACKUP";
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBackupPath.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackupPath.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBackupPath.Location = new System.Drawing.Point(136, 22);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.Size = new System.Drawing.Size(464, 25);
            this.txtBackupPath.TabIndex = 8;
            this.txtBackupPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBrowseBackupPath
            // 
            this.btnBrowseBackupPath.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseBackupPath.Location = new System.Drawing.Point(606, 22);
            this.btnBrowseBackupPath.Name = "btnBrowseBackupPath";
            this.btnBrowseBackupPath.Size = new System.Drawing.Size(43, 28);
            this.btnBrowseBackupPath.TabIndex = 6;
            this.btnBrowseBackupPath.Text = "...";
            this.btnBrowseBackupPath.UseVisualStyleBackColor = true;
            this.btnBrowseBackupPath.Click += new System.EventHandler(this.btnBrowseBackupPath_Click);
            // 
            // lblBackupStatus
            // 
            this.lblBackupStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackupStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBackupStatus.Location = new System.Drawing.Point(3, 58);
            this.lblBackupStatus.Name = "lblBackupStatus";
            this.lblBackupStatus.Size = new System.Drawing.Size(523, 25);
            this.lblBackupStatus.TabIndex = 7;
            this.lblBackupStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBackup
            // 
            this.btnBackup.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Location = new System.Drawing.Point(535, 56);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(114, 28);
            this.btnBackup.TabIndex = 7;
            this.btnBackup.Text = "BACKUP";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "BACKUP PATH";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRestoreFile);
            this.groupBox3.Controls.Add(this.btnBrowseBackupFile);
            this.groupBox3.Controls.Add(this.lblRestoreStatus);
            this.groupBox3.Controls.Add(this.btnRestore);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(12, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(655, 92);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DATABASE RESTORE";
            // 
            // txtRestoreFile
            // 
            this.txtRestoreFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRestoreFile.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestoreFile.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtRestoreFile.Location = new System.Drawing.Point(136, 22);
            this.txtRestoreFile.Name = "txtRestoreFile";
            this.txtRestoreFile.Size = new System.Drawing.Size(464, 25);
            this.txtRestoreFile.TabIndex = 10;
            this.txtRestoreFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBrowseBackupFile
            // 
            this.btnBrowseBackupFile.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseBackupFile.Location = new System.Drawing.Point(606, 22);
            this.btnBrowseBackupFile.Name = "btnBrowseBackupFile";
            this.btnBrowseBackupFile.Size = new System.Drawing.Size(43, 28);
            this.btnBrowseBackupFile.TabIndex = 8;
            this.btnBrowseBackupFile.Text = "...";
            this.btnBrowseBackupFile.UseVisualStyleBackColor = true;
            this.btnBrowseBackupFile.Click += new System.EventHandler(this.btnBrowseBackupFile_Click);
            // 
            // lblRestoreStatus
            // 
            this.lblRestoreStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestoreStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRestoreStatus.Location = new System.Drawing.Point(3, 58);
            this.lblRestoreStatus.Name = "lblRestoreStatus";
            this.lblRestoreStatus.Size = new System.Drawing.Size(523, 25);
            this.lblRestoreStatus.TabIndex = 7;
            this.lblRestoreStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRestore
            // 
            this.btnRestore.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Location = new System.Drawing.Point(535, 56);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(114, 28);
            this.btnRestore.TabIndex = 9;
            this.btnRestore.Text = "RESTORE";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "BACKUP FILE";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OFD
            // 
            this.OFD.FileName = "backup.sql";
            // 
            // DatabaseBackupAndRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 403);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DatabaseBackupAndRestore";
            this.Text = "MySQL Database Backup & Restore";
            this.Load += new System.EventHandler(this.DatabaseBackupAndRestore_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBrowseBackupPath;
        private System.Windows.Forms.Label lblBackupStatus;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBrowseBackupFile;
        private System.Windows.Forms.Label lblRestoreStatus;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.Label txtBackupPath;
        private System.Windows.Forms.Label txtRestoreFile;
    }
}

