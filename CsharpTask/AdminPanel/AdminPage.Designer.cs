﻿namespace AdminPanel
{
    partial class AdminPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddNewEditor = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUpdateID = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPassWord = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.checkBoxDelete = new System.Windows.Forms.CheckBox();
            this.checkBoxUpdate = new System.Windows.Forms.CheckBox();
            this.checkBoxRead = new System.Windows.Forms.CheckBox();
            this.checkBoxCreat = new System.Windows.Forms.CheckBox();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.groupBoxAdmin = new System.Windows.Forms.GroupBox();
            this.BtnAdminUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAdminEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAdminPassWord = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtAdminUserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtAdminId = new System.Windows.Forms.TextBox();
            this.BtnUpdateTrue = new System.Windows.Forms.Button();
            this.groupBoxUpdate = new System.Windows.Forms.GroupBox();
            this.BtnDeleteSeen = new System.Windows.Forms.Button();
            this.groupBoxDelete = new System.Windows.Forms.GroupBox();
            this.BtnMin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxAdmin.SuspendLayout();
            this.groupBoxUpdate.SuspendLayout();
            this.groupBoxDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 176);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAddNewEditor
            // 
            this.btnAddNewEditor.Location = new System.Drawing.Point(12, 223);
            this.btnAddNewEditor.Name = "btnAddNewEditor";
            this.btnAddNewEditor.Size = new System.Drawing.Size(121, 23);
            this.btnAddNewEditor.TabIndex = 1;
            this.btnAddNewEditor.Text = "Add New Editor";
            this.btnAddNewEditor.UseVisualStyleBackColor = true;
            this.btnAddNewEditor.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(88, 15);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(52, 23);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(43, 17);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(39, 20);
            this.TxtID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            // 
            // TxtUpdateID
            // 
            this.TxtUpdateID.Location = new System.Drawing.Point(73, 22);
            this.TxtUpdateID.Name = "TxtUpdateID";
            this.TxtUpdateID.Size = new System.Drawing.Size(39, 20);
            this.TxtUpdateID.TabIndex = 6;
            this.TxtUpdateID.TextChanged += new System.EventHandler(this.TxtUpdateID_TextChanged);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(73, 126);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(111, 23);
            this.BtnUpdate.TabIndex = 5;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(12, 194);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(121, 23);
            this.BtnRefresh.TabIndex = 8;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username:";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(73, 48);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(39, 20);
            this.TxtUserName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password:";
            // 
            // TxtPassWord
            // 
            this.TxtPassWord.Location = new System.Drawing.Point(73, 74);
            this.TxtPassWord.Name = "TxtPassWord";
            this.TxtPassWord.Size = new System.Drawing.Size(39, 20);
            this.TxtPassWord.TabIndex = 11;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(12, 103);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(35, 13);
            this.Email.TabIndex = 14;
            this.Email.Text = "Email:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(73, 100);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(39, 20);
            this.TxtEmail.TabIndex = 13;
            // 
            // checkBoxDelete
            // 
            this.checkBoxDelete.AutoSize = true;
            this.checkBoxDelete.Location = new System.Drawing.Point(127, 94);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.Size = new System.Drawing.Size(57, 17);
            this.checkBoxDelete.TabIndex = 18;
            this.checkBoxDelete.Text = "Delete";
            this.checkBoxDelete.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpdate
            // 
            this.checkBoxUpdate.AutoSize = true;
            this.checkBoxUpdate.Location = new System.Drawing.Point(127, 71);
            this.checkBoxUpdate.Name = "checkBoxUpdate";
            this.checkBoxUpdate.Size = new System.Drawing.Size(61, 17);
            this.checkBoxUpdate.TabIndex = 17;
            this.checkBoxUpdate.Text = "Update";
            this.checkBoxUpdate.UseVisualStyleBackColor = true;
            // 
            // checkBoxRead
            // 
            this.checkBoxRead.AutoSize = true;
            this.checkBoxRead.Location = new System.Drawing.Point(127, 48);
            this.checkBoxRead.Name = "checkBoxRead";
            this.checkBoxRead.Size = new System.Drawing.Size(52, 17);
            this.checkBoxRead.TabIndex = 16;
            this.checkBoxRead.Text = "Read";
            this.checkBoxRead.UseVisualStyleBackColor = true;
            // 
            // checkBoxCreat
            // 
            this.checkBoxCreat.AutoSize = true;
            this.checkBoxCreat.Location = new System.Drawing.Point(127, 25);
            this.checkBoxCreat.Name = "checkBoxCreat";
            this.checkBoxCreat.Size = new System.Drawing.Size(51, 17);
            this.checkBoxCreat.TabIndex = 15;
            this.checkBoxCreat.Text = "Creat";
            this.checkBoxCreat.UseVisualStyleBackColor = true;
            // 
            // BtnSettings
            // 
            this.BtnSettings.Location = new System.Drawing.Point(12, 279);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(121, 23);
            this.BtnSettings.TabIndex = 19;
            this.BtnSettings.Text = "Settings(admin)";
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // groupBoxAdmin
            // 
            this.groupBoxAdmin.Controls.Add(this.BtnAdminUpdate);
            this.groupBoxAdmin.Controls.Add(this.label5);
            this.groupBoxAdmin.Controls.Add(this.TxtAdminEmail);
            this.groupBoxAdmin.Controls.Add(this.label6);
            this.groupBoxAdmin.Controls.Add(this.TxtAdminPassWord);
            this.groupBoxAdmin.Controls.Add(this.label7);
            this.groupBoxAdmin.Controls.Add(this.TxtAdminUserName);
            this.groupBoxAdmin.Controls.Add(this.label8);
            this.groupBoxAdmin.Controls.Add(this.TxtAdminId);
            this.groupBoxAdmin.Location = new System.Drawing.Point(572, 224);
            this.groupBoxAdmin.Name = "groupBoxAdmin";
            this.groupBoxAdmin.Size = new System.Drawing.Size(162, 152);
            this.groupBoxAdmin.TabIndex = 20;
            this.groupBoxAdmin.TabStop = false;
            // 
            // BtnAdminUpdate
            // 
            this.BtnAdminUpdate.Location = new System.Drawing.Point(6, 123);
            this.BtnAdminUpdate.Name = "BtnAdminUpdate";
            this.BtnAdminUpdate.Size = new System.Drawing.Size(111, 23);
            this.BtnAdminUpdate.TabIndex = 23;
            this.BtnAdminUpdate.Text = "Update";
            this.BtnAdminUpdate.UseVisualStyleBackColor = true;
            this.BtnAdminUpdate.Click += new System.EventHandler(this.BtnAdminUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Email:";
            // 
            // TxtAdminEmail
            // 
            this.TxtAdminEmail.Enabled = false;
            this.TxtAdminEmail.Location = new System.Drawing.Point(73, 94);
            this.TxtAdminEmail.Name = "TxtAdminEmail";
            this.TxtAdminEmail.Size = new System.Drawing.Size(83, 20);
            this.TxtAdminEmail.TabIndex = 21;
            this.TxtAdminEmail.Text = "admin@gmail.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Password:";
            // 
            // TxtAdminPassWord
            // 
            this.TxtAdminPassWord.Location = new System.Drawing.Point(73, 68);
            this.TxtAdminPassWord.Name = "TxtAdminPassWord";
            this.TxtAdminPassWord.Size = new System.Drawing.Size(83, 20);
            this.TxtAdminPassWord.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Username:";
            // 
            // TxtAdminUserName
            // 
            this.TxtAdminUserName.Location = new System.Drawing.Point(73, 42);
            this.TxtAdminUserName.Name = "TxtAdminUserName";
            this.TxtAdminUserName.Size = new System.Drawing.Size(83, 20);
            this.TxtAdminUserName.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "ID:";
            // 
            // TxtAdminId
            // 
            this.TxtAdminId.Enabled = false;
            this.TxtAdminId.Location = new System.Drawing.Point(73, 16);
            this.TxtAdminId.Name = "TxtAdminId";
            this.TxtAdminId.Size = new System.Drawing.Size(83, 20);
            this.TxtAdminId.TabIndex = 15;
            this.TxtAdminId.Text = "11";
            // 
            // BtnUpdateTrue
            // 
            this.BtnUpdateTrue.Location = new System.Drawing.Point(12, 250);
            this.BtnUpdateTrue.Name = "BtnUpdateTrue";
            this.BtnUpdateTrue.Size = new System.Drawing.Size(121, 23);
            this.BtnUpdateTrue.TabIndex = 21;
            this.BtnUpdateTrue.Text = "Update";
            this.BtnUpdateTrue.UseVisualStyleBackColor = true;
            this.BtnUpdateTrue.Click += new System.EventHandler(this.BtnUpdateTrue_Click);
            // 
            // groupBoxUpdate
            // 
            this.groupBoxUpdate.Controls.Add(this.TxtUpdateID);
            this.groupBoxUpdate.Controls.Add(this.BtnUpdate);
            this.groupBoxUpdate.Controls.Add(this.label2);
            this.groupBoxUpdate.Controls.Add(this.TxtUserName);
            this.groupBoxUpdate.Controls.Add(this.checkBoxDelete);
            this.groupBoxUpdate.Controls.Add(this.label3);
            this.groupBoxUpdate.Controls.Add(this.checkBoxUpdate);
            this.groupBoxUpdate.Controls.Add(this.TxtPassWord);
            this.groupBoxUpdate.Controls.Add(this.checkBoxRead);
            this.groupBoxUpdate.Controls.Add(this.label4);
            this.groupBoxUpdate.Controls.Add(this.checkBoxCreat);
            this.groupBoxUpdate.Controls.Add(this.TxtEmail);
            this.groupBoxUpdate.Controls.Add(this.Email);
            this.groupBoxUpdate.Location = new System.Drawing.Point(263, 215);
            this.groupBoxUpdate.Name = "groupBoxUpdate";
            this.groupBoxUpdate.Size = new System.Drawing.Size(200, 161);
            this.groupBoxUpdate.TabIndex = 22;
            this.groupBoxUpdate.TabStop = false;
            // 
            // BtnDeleteSeen
            // 
            this.BtnDeleteSeen.Location = new System.Drawing.Point(12, 308);
            this.BtnDeleteSeen.Name = "BtnDeleteSeen";
            this.BtnDeleteSeen.Size = new System.Drawing.Size(121, 23);
            this.BtnDeleteSeen.TabIndex = 23;
            this.BtnDeleteSeen.Text = "Delete";
            this.BtnDeleteSeen.UseVisualStyleBackColor = true;
            this.BtnDeleteSeen.Click += new System.EventHandler(this.BtnDeleteSeen_Click);
            // 
            // groupBoxDelete
            // 
            this.groupBoxDelete.Controls.Add(this.label1);
            this.groupBoxDelete.Controls.Add(this.BtnDelete);
            this.groupBoxDelete.Controls.Add(this.TxtID);
            this.groupBoxDelete.Location = new System.Drawing.Point(517, 194);
            this.groupBoxDelete.Name = "groupBoxDelete";
            this.groupBoxDelete.Size = new System.Drawing.Size(154, 48);
            this.groupBoxDelete.TabIndex = 24;
            this.groupBoxDelete.TabStop = false;
            // 
            // BtnMin
            // 
            this.BtnMin.Location = new System.Drawing.Point(12, 337);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(121, 23);
            this.BtnMin.TabIndex = 25;
            this.BtnMin.Text = "Minimize";
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMin);
            this.Controls.Add(this.groupBoxDelete);
            this.Controls.Add(this.BtnDeleteSeen);
            this.Controls.Add(this.groupBoxUpdate);
            this.Controls.Add(this.BtnUpdateTrue);
            this.Controls.Add(this.groupBoxAdmin);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.btnAddNewEditor);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Page";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxAdmin.ResumeLayout(false);
            this.groupBoxAdmin.PerformLayout();
            this.groupBoxUpdate.ResumeLayout(false);
            this.groupBoxUpdate.PerformLayout();
            this.groupBoxDelete.ResumeLayout(false);
            this.groupBoxDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddNewEditor;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUpdateID;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPassWord;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.CheckBox checkBoxDelete;
        private System.Windows.Forms.CheckBox checkBoxUpdate;
        private System.Windows.Forms.CheckBox checkBoxRead;
        private System.Windows.Forms.CheckBox checkBoxCreat;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.GroupBox groupBoxAdmin;
        private System.Windows.Forms.Button BtnAdminUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAdminEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAdminPassWord;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtAdminUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtAdminId;
        private System.Windows.Forms.Button BtnUpdateTrue;
        private System.Windows.Forms.GroupBox groupBoxUpdate;
        private System.Windows.Forms.Button BtnDeleteSeen;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.Button BtnMin;
    }
}