﻿namespace Project_SS.UserControls
{
    partial class selectedUser_ComboBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selectedUser_ComboBox));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
<<<<<<< Updated upstream
            this.panel1.Controls.Add(this.textBox4);
=======
            this.panel1.Controls.Add(this.cbxSchemaList);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnUpdatePriv);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtgvTableList);
            this.panel1.Controls.Add(this.txbSelectedRoleRight);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_UpdateUser);
            this.panel1.Controls.Add(this.txbSelectedRoleLeft);
>>>>>>> Stashed changes
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 580);
            this.panel1.TabIndex = 0;
            // 
<<<<<<< Updated upstream
=======
            // cbxSchemaList
            // 
            this.cbxSchemaList.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSchemaList.FormattingEnabled = true;
            this.cbxSchemaList.Location = new System.Drawing.Point(744, 179);
            this.cbxSchemaList.Name = "cbxSchemaList";
            this.cbxSchemaList.Size = new System.Drawing.Size(398, 36);
            this.cbxSchemaList.TabIndex = 141;
            this.cbxSchemaList.SelectedIndexChanged += new System.EventHandler(this.cbxSchemaList_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label11.Location = new System.Drawing.Point(616, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 28);
            this.label11.TabIndex = 132;
            this.label11.Text = "Select Schema:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.cbxWithGrantOptionRole);
            this.panel4.Controls.Add(this.NotRoleDropdown);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.btnGrantRole);
            this.panel4.Location = new System.Drawing.Point(617, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(524, 93);
            this.panel4.TabIndex = 119;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(267, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 26);
            this.button4.TabIndex = 122;
            this.button4.Text = "Revoke";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // cbxWithGrantOptionRole
            // 
            this.cbxWithGrantOptionRole.AutoSize = true;
            this.cbxWithGrantOptionRole.Font = new System.Drawing.Font("Malgun Gothic", 9F);
            this.cbxWithGrantOptionRole.Location = new System.Drawing.Point(113, 62);
            this.cbxWithGrantOptionRole.Name = "cbxWithGrantOptionRole";
            this.cbxWithGrantOptionRole.Size = new System.Drawing.Size(154, 24);
            this.cbxWithGrantOptionRole.TabIndex = 121;
            this.cbxWithGrantOptionRole.Text = "With grant option";
            this.cbxWithGrantOptionRole.UseVisualStyleBackColor = true;
            this.cbxWithGrantOptionRole.CheckedChanged += new System.EventHandler(this.cbxWithGrantOptionRole_CheckedChanged);
            // 
            // NotRoleDropdown
            // 
            this.NotRoleDropdown.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.NotRoleDropdown.FormattingEnabled = true;
            this.NotRoleDropdown.Location = new System.Drawing.Point(113, 26);
            this.NotRoleDropdown.Name = "NotRoleDropdown";
            this.NotRoleDropdown.Size = new System.Drawing.Size(382, 25);
            this.NotRoleDropdown.TabIndex = 100;
            this.NotRoleDropdown.SelectedIndexChanged += new System.EventHandler(this.NotRoleDropdown_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.label10.Font = new System.Drawing.Font("Malgun Gothic", 10F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label10.Location = new System.Drawing.Point(17, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 23);
            this.label10.TabIndex = 95;
            this.label10.Text = "Choose Role:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label8.Location = new System.Drawing.Point(212, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 28);
            this.label8.TabIndex = 93;
            this.label8.Text = "Grant Role";
            // 
            // btnGrantRole
            // 
            this.btnGrantRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGrantRole.BackColor = System.Drawing.Color.White;
            this.btnGrantRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrantRole.FlatAppearance.BorderSize = 2;
            this.btnGrantRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrantRole.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrantRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.btnGrantRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrantRole.Location = new System.Drawing.Point(399, 56);
            this.btnGrantRole.Name = "btnGrantRole";
            this.btnGrantRole.Size = new System.Drawing.Size(96, 26);
            this.btnGrantRole.TabIndex = 99;
            this.btnGrantRole.Text = "Grant";
            this.btnGrantRole.UseVisualStyleBackColor = false;
            this.btnGrantRole.Click += new System.EventHandler(this.btnGrantRole_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(121)))), ((int)(((byte)(195)))));
            this.panel3.Location = new System.Drawing.Point(574, -11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 600);
            this.panel3.TabIndex = 106;
            // 
            // btnUpdatePriv
            // 
            this.btnUpdatePriv.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdatePriv.BackColor = System.Drawing.Color.White;
            this.btnUpdatePriv.FlatAppearance.BorderSize = 2;
            this.btnUpdatePriv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePriv.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdatePriv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.btnUpdatePriv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdatePriv.Location = new System.Drawing.Point(772, 514);
            this.btnUpdatePriv.Name = "btnUpdatePriv";
            this.btnUpdatePriv.Size = new System.Drawing.Size(229, 39);
            this.btnUpdatePriv.TabIndex = 114;
            this.btnUpdatePriv.Text = "Grant";
            this.btnUpdatePriv.UseVisualStyleBackColor = false;
            this.btnUpdatePriv.Click += new System.EventHandler(this.btnUpdatePriv_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(85)))));
            this.label7.Location = new System.Drawing.Point(613, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 28);
            this.label7.TabIndex = 112;
            this.label7.Text = "Table of Database:";
            // 
            // dtgvTableList
            // 
            this.dtgvTableList.AllowUserToAddRows = false;
            this.dtgvTableList.AllowUserToDeleteRows = false;
            this.dtgvTableList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTableList.Location = new System.Drawing.Point(617, 257);
            this.dtgvTableList.Name = "dtgvTableList";
            this.dtgvTableList.ReadOnly = true;
            this.dtgvTableList.RowHeadersWidth = 51;
            this.dtgvTableList.Size = new System.Drawing.Size(229, 242);
            this.dtgvTableList.TabIndex = 111;
            this.dtgvTableList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTableList_CellContentClick);
            // 
            // txbSelectedRoleRight
            // 
            this.txbSelectedRoleRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txbSelectedRoleRight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbSelectedRoleRight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSelectedRoleRight.Cursor = System.Windows.Forms.Cursors.No;
            this.txbSelectedRoleRight.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSelectedRoleRight.Location = new System.Drawing.Point(761, 20);
            this.txbSelectedRoleRight.Name = "txbSelectedRoleRight";
            this.txbSelectedRoleRight.ReadOnly = true;
            this.txbSelectedRoleRight.Size = new System.Drawing.Size(381, 32);
            this.txbSelectedRoleRight.TabIndex = 108;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label5.Location = new System.Drawing.Point(613, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 28);
            this.label5.TabIndex = 107;
            this.label5.Text = "Selected User:";
            // 
            // btn_UpdateUser
            // 
            this.btn_UpdateUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_UpdateUser.BackColor = System.Drawing.Color.White;
            this.btn_UpdateUser.FlatAppearance.BorderSize = 2;
            this.btn_UpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateUser.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_UpdateUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.btn_UpdateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UpdateUser.Location = new System.Drawing.Point(405, 493);
            this.btn_UpdateUser.Name = "btn_UpdateUser";
            this.btn_UpdateUser.Size = new System.Drawing.Size(146, 34);
            this.btn_UpdateUser.TabIndex = 105;
            this.btn_UpdateUser.Text = "Update";
            this.btn_UpdateUser.UseVisualStyleBackColor = false;
            this.btn_UpdateUser.Click += new System.EventHandler(this.btn_UpdateUser_Click);
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_DeleteUser.BackColor = System.Drawing.Color.White;
            this.btn_DeleteUser.FlatAppearance.BorderSize = 2;
            this.btn_DeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteUser.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_DeleteUser.ForeColor = System.Drawing.Color.Red;
            this.btn_DeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteUser.Image")));
            this.btn_DeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeleteUser.Location = new System.Drawing.Point(375, 96);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(135, 34);
            this.btn_DeleteUser.TabIndex = 104;
            this.btn_DeleteUser.Text = "   Delete";
            this.btn_DeleteUser.UseVisualStyleBackColor = false;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // txbSelectedRoleLeft
            // 
            this.txbSelectedRoleLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txbSelectedRoleLeft.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbSelectedRoleLeft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSelectedRoleLeft.Cursor = System.Windows.Forms.Cursors.No;
            this.txbSelectedRoleLeft.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSelectedRoleLeft.Location = new System.Drawing.Point(160, 493);
            this.txbSelectedRoleLeft.Name = "txbSelectedRoleLeft";
            this.txbSelectedRoleLeft.ReadOnly = true;
            this.txbSelectedRoleLeft.Size = new System.Drawing.Size(228, 32);
            this.txbSelectedRoleLeft.TabIndex = 102;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label6.Location = new System.Drawing.Point(3, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 28);
            this.label6.TabIndex = 101;
            this.label6.Text = "Selected User:";
            // 
>>>>>>> Stashed changes
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(602, 277);
            this.label2.Name = "label2";
<<<<<<< Updated upstream
            this.label2.Size = new System.Drawing.Size(144, 21);
=======
            this.label2.Size = new System.Drawing.Size(143, 28);
>>>>>>> Stashed changes
            this.label2.TabIndex = 18;
            this.label2.Text = "Privileges of User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(12, 277);
            this.label1.Name = "label1";
<<<<<<< Updated upstream
            this.label1.Size = new System.Drawing.Size(104, 21);
=======
            this.label1.Size = new System.Drawing.Size(134, 28);
>>>>>>> Stashed changes
            this.label1.TabIndex = 17;
            this.label1.Text = "List of Users";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(606, 306);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(555, 255);
            this.dataGridView2.TabIndex = 16;
            // 
            // dataGridView1
            // 
<<<<<<< Updated upstream
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(555, 255);
            this.dataGridView1.TabIndex = 15;
=======
            this.dtgvRoleList.AllowUserToAddRows = false;
            this.dtgvRoleList.AllowUserToDeleteRows = false;
            this.dtgvRoleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRoleList.Location = new System.Drawing.Point(34, 234);
            this.dtgvRoleList.Name = "dtgvRoleList";
            this.dtgvRoleList.ReadOnly = true;
            this.dtgvRoleList.RowHeadersWidth = 51;
            this.dtgvRoleList.Size = new System.Drawing.Size(226, 208);
            this.dtgvRoleList.TabIndex = 15;
            this.dtgvRoleList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRoleList_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.text_User);
            this.panel2.Controls.Add(this.text_Pass);
            this.panel2.Controls.Add(this.btn_DeleteUser);
            this.panel2.Location = new System.Drawing.Point(30, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 145);
            this.panel2.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(21, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 28);
            this.label3.TabIndex = 97;
            this.label3.Text = "Password:";
>>>>>>> Stashed changes
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label4.Location = new System.Drawing.Point(88, 82);
            this.label4.Name = "label4";
<<<<<<< Updated upstream
            this.label4.Size = new System.Drawing.Size(91, 21);
=======
            this.label4.Size = new System.Drawing.Size(108, 28);
>>>>>>> Stashed changes
            this.label4.TabIndex = 95;
            this.label4.Text = "Username:";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.lblTime.Location = new System.Drawing.Point(178, 38);
            this.lblTime.Name = "lblTime";
<<<<<<< Updated upstream
            this.lblTime.Size = new System.Drawing.Size(143, 25);
=======
            this.lblTime.Size = new System.Drawing.Size(145, 32);
>>>>>>> Stashed changes
            this.lblTime.TabIndex = 93;
            this.lblTime.Text = "Add New User";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.textBox1.Location = new System.Drawing.Point(183, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 29);
            this.textBox1.TabIndex = 96;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.textBox2.Location = new System.Drawing.Point(183, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 29);
            this.textBox2.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(88, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 97;
            this.label3.Text = "Password:";
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.button5.Image = global::Project_SS.Properties.Resources.plus__1_;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
<<<<<<< Updated upstream
            this.button5.Location = new System.Drawing.Point(259, 174);
=======
            this.button5.Location = new System.Drawing.Point(399, 21);
>>>>>>> Stashed changes
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 41);
            this.button5.TabIndex = 99;
            this.button5.Text = "    Add";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1020, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 40);
            this.button2.TabIndex = 19;
            this.button2.Text = "   Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
<<<<<<< Updated upstream
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox4.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.textBox4.Location = new System.Drawing.Point(812, 76);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(189, 32);
            this.textBox4.TabIndex = 102;
=======
            this.text_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_User.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.text_User.Location = new System.Drawing.Point(122, 48);
            this.text_User.Name = "text_User";
            this.text_User.Size = new System.Drawing.Size(246, 34);
            this.text_User.TabIndex = 96;
>>>>>>> Stashed changes
            // 
            // label6
            // 
<<<<<<< Updated upstream
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label6.Location = new System.Drawing.Point(717, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 101;
            this.label6.Text = "Username:";
=======
            this.text_Pass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.text_Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_Pass.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.text_Pass.Location = new System.Drawing.Point(122, 88);
            this.text_Pass.Name = "text_Pass";
            this.text_Pass.Size = new System.Drawing.Size(246, 34);
            this.text_Pass.TabIndex = 98;
>>>>>>> Stashed changes
            // 
            // label7
            // 
<<<<<<< Updated upstream
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label7.Location = new System.Drawing.Point(807, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 25);
            this.label7.TabIndex = 100;
            this.label7.Text = "Selected User";
=======
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.panel5.Controls.Add(this.btnCancelEdit);
            this.panel5.Controls.Add(this.btnEditPriv);
            this.panel5.Controls.Add(this.cbxGrantable4);
            this.panel5.Controls.Add(this.cbxGrantable3);
            this.panel5.Controls.Add(this.cbxGrantable2);
            this.panel5.Controls.Add(this.cbxGrantable1);
            this.panel5.Controls.Add(this.cbxInsert);
            this.panel5.Controls.Add(this.cbxSelect);
            this.panel5.Controls.Add(this.cbxUpdate);
            this.panel5.Controls.Add(this.cbxDelete);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.clbColumnUpdate);
            this.panel5.Controls.Add(this.clbColumnSelect);
            this.panel5.Location = new System.Drawing.Point(872, 226);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(269, 273);
            this.panel5.TabIndex = 120;
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.Color.White;
            this.btnCancelEdit.FlatAppearance.BorderSize = 2;
            this.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEdit.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelEdit.ForeColor = System.Drawing.Color.Red;
            this.btnCancelEdit.Location = new System.Drawing.Point(17, 235);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(106, 28);
            this.btnCancelEdit.TabIndex = 136;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnEditPriv
            // 
            this.btnEditPriv.BackColor = System.Drawing.Color.White;
            this.btnEditPriv.FlatAppearance.BorderSize = 2;
            this.btnEditPriv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPriv.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditPriv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.btnEditPriv.Location = new System.Drawing.Point(148, 235);
            this.btnEditPriv.Name = "btnEditPriv";
            this.btnEditPriv.Size = new System.Drawing.Size(108, 28);
            this.btnEditPriv.TabIndex = 135;
            this.btnEditPriv.Text = "Edit";
            this.btnEditPriv.UseVisualStyleBackColor = false;
            this.btnEditPriv.Click += new System.EventHandler(this.btnEditPriv_Click);
            // 
            // cbxGrantable4
            // 
            this.cbxGrantable4.AutoSize = true;
            this.cbxGrantable4.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGrantable4.Location = new System.Drawing.Point(172, 107);
            this.cbxGrantable4.Name = "cbxGrantable4";
            this.cbxGrantable4.Size = new System.Drawing.Size(82, 24);
            this.cbxGrantable4.TabIndex = 134;
            this.cbxGrantable4.Text = "grantable";
            this.cbxGrantable4.UseVisualStyleBackColor = true;
            this.cbxGrantable4.CheckedChanged += new System.EventHandler(this.cbxGrantable4_CheckedChanged);
            // 
            // cbxGrantable3
            // 
            this.cbxGrantable3.AutoSize = true;
            this.cbxGrantable3.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGrantable3.Location = new System.Drawing.Point(48, 107);
            this.cbxGrantable3.Name = "cbxGrantable3";
            this.cbxGrantable3.Size = new System.Drawing.Size(82, 24);
            this.cbxGrantable3.TabIndex = 133;
            this.cbxGrantable3.Text = "grantable";
            this.cbxGrantable3.UseVisualStyleBackColor = true;
            this.cbxGrantable3.CheckedChanged += new System.EventHandler(this.cbxGrantable3_CheckedChanged);
            // 
            // cbxGrantable2
            // 
            this.cbxGrantable2.AutoSize = true;
            this.cbxGrantable2.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGrantable2.Location = new System.Drawing.Point(172, 62);
            this.cbxGrantable2.Name = "cbxGrantable2";
            this.cbxGrantable2.Size = new System.Drawing.Size(82, 24);
            this.cbxGrantable2.TabIndex = 132;
            this.cbxGrantable2.Text = "grantable";
            this.cbxGrantable2.UseVisualStyleBackColor = true;
            this.cbxGrantable2.CheckedChanged += new System.EventHandler(this.cbxGrantable2_CheckedChanged);
            // 
            // cbxGrantable1
            // 
            this.cbxGrantable1.AutoSize = true;
            this.cbxGrantable1.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGrantable1.Location = new System.Drawing.Point(48, 62);
            this.cbxGrantable1.Name = "cbxGrantable1";
            this.cbxGrantable1.Size = new System.Drawing.Size(82, 24);
            this.cbxGrantable1.TabIndex = 131;
            this.cbxGrantable1.Text = "grantable";
            this.cbxGrantable1.UseVisualStyleBackColor = true;
            this.cbxGrantable1.CheckedChanged += new System.EventHandler(this.cbxGrantable1_CheckedChanged);
            // 
            // cbxInsert
            // 
            this.cbxInsert.AutoSize = true;
            this.cbxInsert.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.cbxInsert.Location = new System.Drawing.Point(23, 40);
            this.cbxInsert.Name = "cbxInsert";
            this.cbxInsert.Size = new System.Drawing.Size(85, 32);
            this.cbxInsert.TabIndex = 127;
            this.cbxInsert.Text = "Insert";
            this.cbxInsert.UseVisualStyleBackColor = true;
            this.cbxInsert.CheckedChanged += new System.EventHandler(this.cbxInsert_CheckedChanged);
            // 
            // cbxSelect
            // 
            this.cbxSelect.AutoSize = true;
            this.cbxSelect.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.cbxSelect.Location = new System.Drawing.Point(23, 85);
            this.cbxSelect.Name = "cbxSelect";
            this.cbxSelect.Size = new System.Drawing.Size(88, 32);
            this.cbxSelect.TabIndex = 129;
            this.cbxSelect.Text = "Select";
            this.cbxSelect.UseVisualStyleBackColor = true;
            this.cbxSelect.CheckedChanged += new System.EventHandler(this.cbxSelect_CheckedChanged);
            // 
            // cbxUpdate
            // 
            this.cbxUpdate.AutoSize = true;
            this.cbxUpdate.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.cbxUpdate.Location = new System.Drawing.Point(148, 85);
            this.cbxUpdate.Name = "cbxUpdate";
            this.cbxUpdate.Size = new System.Drawing.Size(100, 32);
            this.cbxUpdate.TabIndex = 130;
            this.cbxUpdate.Text = "Update";
            this.cbxUpdate.UseVisualStyleBackColor = true;
            this.cbxUpdate.CheckedChanged += new System.EventHandler(this.cbxUpdate_CheckedChanged);
            // 
            // cbxDelete
            // 
            this.cbxDelete.AutoSize = true;
            this.cbxDelete.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.cbxDelete.Location = new System.Drawing.Point(148, 40);
            this.cbxDelete.Name = "cbxDelete";
            this.cbxDelete.Size = new System.Drawing.Size(93, 32);
            this.cbxDelete.TabIndex = 128;
            this.cbxDelete.Text = "Delete";
            this.cbxDelete.UseVisualStyleBackColor = true;
            this.cbxDelete.CheckedChanged += new System.EventHandler(this.cbxDelete_CheckedChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.label9.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label9.Location = new System.Drawing.Point(60, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 28);
            this.label9.TabIndex = 101;
            this.label9.Text = "Granted Privileges";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // clbColumnUpdate
            // 
            this.clbColumnUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbColumnUpdate.Font = new System.Drawing.Font("Malgun Gothic", 8F);
            this.clbColumnUpdate.FormattingEnabled = true;
            this.clbColumnUpdate.Items.AddRange(new object[] {
            "Nhan vien",
            "De an",
            "Phan cong"});
            this.clbColumnUpdate.Location = new System.Drawing.Point(148, 134);
            this.clbColumnUpdate.Name = "clbColumnUpdate";
            this.clbColumnUpdate.Size = new System.Drawing.Size(108, 80);
            this.clbColumnUpdate.TabIndex = 120;
            this.clbColumnUpdate.SelectedIndexChanged += new System.EventHandler(this.clbColumnUpdate_SelectedIndexChanged);
            // 
            // clbColumnSelect
            // 
            this.clbColumnSelect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbColumnSelect.Font = new System.Drawing.Font("Malgun Gothic", 8F);
            this.clbColumnSelect.FormattingEnabled = true;
            this.clbColumnSelect.Items.AddRange(new object[] {
            "De an",
            "Nhan vien",
            "Phan cong"});
            this.clbColumnSelect.Location = new System.Drawing.Point(17, 134);
            this.clbColumnSelect.Name = "clbColumnSelect";
            this.clbColumnSelect.Size = new System.Drawing.Size(106, 80);
            this.clbColumnSelect.Sorted = true;
            this.clbColumnSelect.TabIndex = 119;
            this.clbColumnSelect.SelectedIndexChanged += new System.EventHandler(this.clbColumnSelect_SelectedIndexChanged);
>>>>>>> Stashed changes
            // 
            // selectedUser_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(121)))), ((int)(((byte)(195)))));
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold);
<<<<<<< Updated upstream
            this.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.Name = "UC_User";
            this.Padding = new System.Windows.Forms.Padding(10);
=======
            this.Margin = new System.Windows.Forms.Padding(15);
            this.Name = "selectedUser_ComboBox";
            this.Padding = new System.Windows.Forms.Padding(15);
>>>>>>> Stashed changes
            this.Size = new System.Drawing.Size(1200, 600);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
