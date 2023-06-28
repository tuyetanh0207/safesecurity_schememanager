namespace Project_SS.UserControls
{
    partial class UC_Role
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
            this.panel1 = new System.Windows.Forms.Panel();
<<<<<<< Updated upstream
=======
            this.cbxSchemaList = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdatePriv = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgvTableList = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_UpdateUser = new System.Windows.Forms.Button();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.selectedRole_ComboBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvUsersOfRole = new System.Windows.Forms.DataGridView();
            this.dtgvRoleList = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.name_Text = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbxGrantable4 = new System.Windows.Forms.CheckBox();
            this.cbxGrantable3 = new System.Windows.Forms.CheckBox();
            this.cbxGrantable2 = new System.Windows.Forms.CheckBox();
            this.cbxGrantable1 = new System.Windows.Forms.CheckBox();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnEditPriv = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.clbColumnUpdate = new System.Windows.Forms.CheckedListBox();
            this.clbColumnSelect = new System.Windows.Forms.CheckedListBox();
            this.cbxInsert = new System.Windows.Forms.CheckBox();
            this.cbxSelect = new System.Windows.Forms.CheckBox();
            this.cbxUpdate = new System.Windows.Forms.CheckBox();
            this.cbxDelete = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTableList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsersOfRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRoleList)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
>>>>>>> Stashed changes
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
<<<<<<< Updated upstream
=======
            this.panel1.Controls.Add(this.cbxSchemaList);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnUpdatePriv);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtgvTableList);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_UpdateUser);
            this.panel1.Controls.Add(this.btn_DeleteUser);
            this.panel1.Controls.Add(this.selectedRole_ComboBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtgvUsersOfRole);
            this.panel1.Controls.Add(this.dtgvRoleList);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
>>>>>>> Stashed changes
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 580);
            this.panel1.TabIndex = 0;
            // 
<<<<<<< Updated upstream
            // UC_Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
=======
            // cbxSchemaList
            // 
            this.cbxSchemaList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxSchemaList.FormattingEnabled = true;
            this.cbxSchemaList.Location = new System.Drawing.Point(754, 37);
            this.cbxSchemaList.Name = "cbxSchemaList";
            this.cbxSchemaList.Size = new System.Drawing.Size(392, 31);
            this.cbxSchemaList.TabIndex = 140;
            this.cbxSchemaList.SelectedIndexChanged += new System.EventHandler(this.cbxSchemaList_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.panel3.Location = new System.Drawing.Point(578, -10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 600);
            this.panel3.TabIndex = 130;
            // 
            // btnUpdatePriv
            // 
            this.btnUpdatePriv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdatePriv.BackColor = System.Drawing.Color.White;
            this.btnUpdatePriv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatePriv.FlatAppearance.BorderSize = 2;
            this.btnUpdatePriv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePriv.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdatePriv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.btnUpdatePriv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdatePriv.Location = new System.Drawing.Point(917, 502);
            this.btnUpdatePriv.Name = "btnUpdatePriv";
            this.btnUpdatePriv.Size = new System.Drawing.Size(229, 43);
            this.btnUpdatePriv.TabIndex = 137;
            this.btnUpdatePriv.Text = "Save";
            this.btnUpdatePriv.UseVisualStyleBackColor = false;
            this.btnUpdatePriv.Click += new System.EventHandler(this.btnUpdatePriv_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(622, 502);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 43);
            this.button2.TabIndex = 136;
            this.button2.Text = "Revoke";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(85)))));
            this.label7.Location = new System.Drawing.Point(618, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 28);
            this.label7.TabIndex = 135;
            this.label7.Text = "Table of Database:";
            // 
            // dtgvTableList
            // 
            this.dtgvTableList.AllowUserToAddRows = false;
            this.dtgvTableList.AllowUserToDeleteRows = false;
            this.dtgvTableList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTableList.Location = new System.Drawing.Point(622, 135);
            this.dtgvTableList.Name = "dtgvTableList";
            this.dtgvTableList.ReadOnly = true;
            this.dtgvTableList.RowHeadersWidth = 51;
            this.dtgvTableList.Size = new System.Drawing.Size(229, 335);
            this.dtgvTableList.TabIndex = 134;
            this.dtgvTableList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTableList_CellContentClick);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label5.Location = new System.Drawing.Point(617, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 28);
            this.label5.TabIndex = 131;
            this.label5.Text = "Select Schema:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btn_UpdateUser
            // 
            this.btn_UpdateUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_UpdateUser.BackColor = System.Drawing.Color.White;
            this.btn_UpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UpdateUser.FlatAppearance.BorderSize = 2;
            this.btn_UpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateUser.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_UpdateUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.btn_UpdateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UpdateUser.Location = new System.Drawing.Point(394, 511);
            this.btn_UpdateUser.Name = "btn_UpdateUser";
            this.btn_UpdateUser.Size = new System.Drawing.Size(146, 34);
            this.btn_UpdateUser.TabIndex = 129;
            this.btn_UpdateUser.Text = "Update";
            this.btn_UpdateUser.UseVisualStyleBackColor = false;
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_DeleteUser.BackColor = System.Drawing.Color.White;
            this.btn_DeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeleteUser.FlatAppearance.BorderSize = 2;
            this.btn_DeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteUser.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_DeleteUser.ForeColor = System.Drawing.Color.Red;
            this.btn_DeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteUser.Image")));
            this.btn_DeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeleteUser.Location = new System.Drawing.Point(176, 511);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(135, 34);
            this.btn_DeleteUser.TabIndex = 128;
            this.btn_DeleteUser.Text = "   Delete";
            this.btn_DeleteUser.UseVisualStyleBackColor = false;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // selectedRole_ComboBox
            // 
            this.selectedRole_ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
<<<<<<< Updated upstream
            this.selectedRole_ComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.selectedRole_ComboBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectedRole_ComboBox.Cursor = System.Windows.Forms.Cursors.No;
            this.selectedRole_ComboBox.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedRole_ComboBox.Location = new System.Drawing.Point(176, 469);
            this.selectedRole_ComboBox.Name = "selectedRole_ComboBox";
            this.selectedRole_ComboBox.ReadOnly = true;
            this.selectedRole_ComboBox.Size = new System.Drawing.Size(364, 32);
            this.selectedRole_ComboBox.TabIndex = 126;
=======
            this.txbSelectedRoleLeft.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbSelectedRoleLeft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSelectedRoleLeft.Cursor = System.Windows.Forms.Cursors.No;
            this.txbSelectedRoleLeft.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSelectedRoleLeft.Location = new System.Drawing.Point(176, 469);
            this.txbSelectedRoleLeft.Name = "txbSelectedRoleLeft";
            this.txbSelectedRoleLeft.ReadOnly = true;
            this.txbSelectedRoleLeft.Size = new System.Drawing.Size(364, 32);
            this.txbSelectedRoleLeft.TabIndex = 126;
>>>>>>> Stashed changes
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label6.Location = new System.Drawing.Point(30, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 28);
            this.label6.TabIndex = 125;
            this.label6.Text = "Selected Role:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(291, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 28);
            this.label2.TabIndex = 124;
            this.label2.Text = "Users of Role:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(30, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 123;
            this.label1.Text = "List of Roles:";
            // 
            // dtgvUsersOfRole
            // 
            this.dtgvUsersOfRole.AllowUserToAddRows = false;
            this.dtgvUsersOfRole.AllowUserToDeleteRows = false;
            this.dtgvUsersOfRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsersOfRole.Location = new System.Drawing.Point(296, 234);
            this.dtgvUsersOfRole.Name = "dtgvUsersOfRole";
            this.dtgvUsersOfRole.ReadOnly = true;
            this.dtgvUsersOfRole.RowHeadersWidth = 51;
            this.dtgvUsersOfRole.Size = new System.Drawing.Size(244, 208);
            this.dtgvUsersOfRole.TabIndex = 122;
            // 
            // dtgvRoleList
            // 
            this.dtgvRoleList.AllowUserToAddRows = false;
            this.dtgvRoleList.AllowUserToDeleteRows = false;
            this.dtgvRoleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRoleList.Location = new System.Drawing.Point(34, 234);
            this.dtgvRoleList.Name = "dtgvRoleList";
            this.dtgvRoleList.ReadOnly = true;
            this.dtgvRoleList.RowHeadersWidth = 51;
            this.dtgvRoleList.Size = new System.Drawing.Size(226, 208);
            this.dtgvRoleList.TabIndex = 121;
            this.dtgvRoleList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRoleList_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.name_Text);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(30, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 145);
            this.panel2.TabIndex = 127;
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
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label4.Location = new System.Drawing.Point(21, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 28);
            this.label4.TabIndex = 95;
            this.label4.Text = "Username:";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.lblTime.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.lblTime.Location = new System.Drawing.Point(189, 10);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(145, 32);
            this.lblTime.TabIndex = 93;
            this.lblTime.Text = "Create Role";
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.button5.Image = global::Project_SS.Properties.Resources.plus__1_;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(395, 57);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(89, 46);
            this.button5.TabIndex = 99;
            this.button5.Text = "  Add";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // name_Text
            // 
            this.name_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.name_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_Text.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.name_Text.Location = new System.Drawing.Point(122, 48);
            this.name_Text.Name = "name_Text";
            this.name_Text.Size = new System.Drawing.Size(246, 34);
            this.name_Text.TabIndex = 96;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.textBox2.Location = new System.Drawing.Point(122, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(246, 34);
            this.textBox2.TabIndex = 98;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.panel5.Controls.Add(this.cbxGrantable4);
            this.panel5.Controls.Add(this.cbxGrantable3);
            this.panel5.Controls.Add(this.cbxGrantable2);
            this.panel5.Controls.Add(this.cbxGrantable1);
            this.panel5.Controls.Add(this.btnCancelEdit);
            this.panel5.Controls.Add(this.btnEditPriv);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.clbColumnUpdate);
            this.panel5.Controls.Add(this.clbColumnSelect);
            this.panel5.Controls.Add(this.cbxInsert);
            this.panel5.Controls.Add(this.cbxSelect);
            this.panel5.Controls.Add(this.cbxUpdate);
            this.panel5.Controls.Add(this.cbxDelete);
            this.panel5.Location = new System.Drawing.Point(877, 106);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(269, 364);
            this.panel5.TabIndex = 139;
            // 
            // cbxGrantable4
            // 
            this.cbxGrantable4.AutoSize = true;
            this.cbxGrantable4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxGrantable4.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGrantable4.Location = new System.Drawing.Point(174, 104);
            this.cbxGrantable4.Name = "cbxGrantable4";
            this.cbxGrantable4.Size = new System.Drawing.Size(82, 24);
            this.cbxGrantable4.TabIndex = 126;
            this.cbxGrantable4.Text = "grantable";
            this.cbxGrantable4.UseVisualStyleBackColor = true;
            // 
            // cbxGrantable3
            // 
            this.cbxGrantable3.AutoSize = true;
            this.cbxGrantable3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxGrantable3.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGrantable3.Location = new System.Drawing.Point(43, 104);
            this.cbxGrantable3.Name = "cbxGrantable3";
            this.cbxGrantable3.Size = new System.Drawing.Size(82, 24);
            this.cbxGrantable3.TabIndex = 125;
            this.cbxGrantable3.Text = "grantable";
            this.cbxGrantable3.UseVisualStyleBackColor = true;
            // 
            // cbxGrantable2
            // 
            this.cbxGrantable2.AutoSize = true;
            this.cbxGrantable2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxGrantable2.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGrantable2.Location = new System.Drawing.Point(174, 60);
            this.cbxGrantable2.Name = "cbxGrantable2";
            this.cbxGrantable2.Size = new System.Drawing.Size(82, 24);
            this.cbxGrantable2.TabIndex = 124;
            this.cbxGrantable2.Text = "grantable";
            this.cbxGrantable2.UseVisualStyleBackColor = true;
            // 
            // cbxGrantable1
            // 
            this.cbxGrantable1.AutoSize = true;
            this.cbxGrantable1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxGrantable1.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGrantable1.Location = new System.Drawing.Point(43, 60);
            this.cbxGrantable1.Name = "cbxGrantable1";
            this.cbxGrantable1.Size = new System.Drawing.Size(82, 24);
            this.cbxGrantable1.TabIndex = 123;
            this.cbxGrantable1.Text = "grantable";
            this.cbxGrantable1.UseVisualStyleBackColor = true;
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.Color.White;
            this.btnCancelEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelEdit.FlatAppearance.BorderSize = 2;
            this.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEdit.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEdit.ForeColor = System.Drawing.Color.Red;
            this.btnCancelEdit.Location = new System.Drawing.Point(18, 312);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(106, 38);
            this.btnCancelEdit.TabIndex = 122;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnEditPriv
            // 
            this.btnEditPriv.BackColor = System.Drawing.Color.White;
            this.btnEditPriv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPriv.FlatAppearance.BorderSize = 2;
            this.btnEditPriv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPriv.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPriv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.btnEditPriv.Location = new System.Drawing.Point(146, 312);
            this.btnEditPriv.Name = "btnEditPriv";
            this.btnEditPriv.Size = new System.Drawing.Size(108, 38);
            this.btnEditPriv.TabIndex = 121;
            this.btnEditPriv.Text = "Edit";
            this.btnEditPriv.UseVisualStyleBackColor = false;
            this.btnEditPriv.Click += new System.EventHandler(this.btnEditPriv_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.label9.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label9.Location = new System.Drawing.Point(60, 4);
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
            this.clbColumnUpdate.Location = new System.Drawing.Point(146, 127);
            this.clbColumnUpdate.Name = "clbColumnUpdate";
            this.clbColumnUpdate.Size = new System.Drawing.Size(108, 160);
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
            this.clbColumnSelect.Location = new System.Drawing.Point(18, 125);
            this.clbColumnSelect.Name = "clbColumnSelect";
            this.clbColumnSelect.Size = new System.Drawing.Size(106, 160);
            this.clbColumnSelect.Sorted = true;
            this.clbColumnSelect.TabIndex = 119;
            this.clbColumnSelect.SelectedIndexChanged += new System.EventHandler(this.clbColumnSelect_SelectedIndexChanged);
            // 
            // cbxInsert
            // 
            this.cbxInsert.AutoSize = true;
            this.cbxInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxInsert.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.cbxInsert.Location = new System.Drawing.Point(18, 30);
            this.cbxInsert.Name = "cbxInsert";
            this.cbxInsert.Size = new System.Drawing.Size(85, 32);
            this.cbxInsert.TabIndex = 115;
            this.cbxInsert.Text = "Insert";
            this.cbxInsert.UseVisualStyleBackColor = true;
            this.cbxInsert.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbxSelect
            // 
            this.cbxSelect.AutoSize = true;
            this.cbxSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxSelect.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.cbxSelect.Location = new System.Drawing.Point(18, 75);
            this.cbxSelect.Name = "cbxSelect";
            this.cbxSelect.Size = new System.Drawing.Size(88, 32);
            this.cbxSelect.TabIndex = 117;
            this.cbxSelect.Text = "Select";
            this.cbxSelect.UseVisualStyleBackColor = true;
            this.cbxSelect.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // cbxUpdate
            // 
            this.cbxUpdate.AutoSize = true;
            this.cbxUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxUpdate.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.cbxUpdate.Location = new System.Drawing.Point(150, 75);
            this.cbxUpdate.Name = "cbxUpdate";
            this.cbxUpdate.Size = new System.Drawing.Size(100, 32);
            this.cbxUpdate.TabIndex = 118;
            this.cbxUpdate.Text = "Update";
            this.cbxUpdate.UseVisualStyleBackColor = true;
            this.cbxUpdate.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // cbxDelete
            // 
            this.cbxDelete.AutoSize = true;
            this.cbxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxDelete.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.cbxDelete.Location = new System.Drawing.Point(150, 30);
            this.cbxDelete.Name = "cbxDelete";
            this.cbxDelete.Size = new System.Drawing.Size(93, 32);
            this.cbxDelete.TabIndex = 116;
            this.cbxDelete.Text = "Delete";
            this.cbxDelete.UseVisualStyleBackColor = true;
            this.cbxDelete.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // UC_Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "UC_Role";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1200, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
<<<<<<< Updated upstream
=======
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUpdatePriv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgvTableList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_UpdateUser;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.TextBox selectedRole_ComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvUsersOfRole;
        private System.Windows.Forms.DataGridView dtgvRoleList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox name_Text;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox clbColumnUpdate;
        private System.Windows.Forms.CheckedListBox clbColumnSelect;
        private System.Windows.Forms.CheckBox cbxInsert;
        private System.Windows.Forms.CheckBox cbxSelect;
        private System.Windows.Forms.CheckBox cbxUpdate;
        private System.Windows.Forms.CheckBox cbxDelete;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnEditPriv;
        private System.Windows.Forms.ComboBox cbxSchemaList;
        private System.Windows.Forms.CheckBox cbxGrantable1;
        private System.Windows.Forms.CheckBox cbxGrantable2;
        private System.Windows.Forms.CheckBox cbxGrantable4;
        private System.Windows.Forms.CheckBox cbxGrantable3;
>>>>>>> Stashed changes
    }
}
