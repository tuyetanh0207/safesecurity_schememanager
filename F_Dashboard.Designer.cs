namespace project_ATBM_HTTT
{
    partial class F_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Dashboard));
            this.avaUser = new System.Windows.Forms.PictureBox();
            this.Username = new System.Windows.Forms.Label();
            this.Dashboard = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.Label();
            this.UserBirthday = new System.Windows.Forms.Label();
            this.UserGender = new System.Windows.Forms.Label();
            this.UserPhone = new System.Windows.Forms.Label();
            this.UserAddress = new System.Windows.Forms.Label();
            this.Text_ID = new System.Windows.Forms.TextBox();
            this.Text_Username = new System.Windows.Forms.TextBox();
            this.Text_Gender = new System.Windows.Forms.TextBox();
            this.Text_Birthday = new System.Windows.Forms.TextBox();
            this.Text_Phone = new System.Windows.Forms.TextBox();
            this.Text_Address = new System.Windows.Forms.TextBox();
            this.Button_Edit_Confirm = new System.Windows.Forms.Button();
            this.Button_Logout = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Menu_Dashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Emp = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Department = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Project = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Assignment = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.avaUser)).BeginInit();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // avaUser
            // 
            this.avaUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.avaUser.Image = ((System.Drawing.Image)(resources.GetObject("avaUser.Image")));
            this.avaUser.Location = new System.Drawing.Point(15, 230);
            this.avaUser.Name = "avaUser";
            this.avaUser.Size = new System.Drawing.Size(305, 397);
            this.avaUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avaUser.TabIndex = 0;
            this.avaUser.TabStop = false;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Username.Location = new System.Drawing.Point(326, 293);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(149, 38);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            this.Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Username.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Dashboard.Location = new System.Drawing.Point(313, 96);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(807, 93);
            this.Dashboard.TabIndex = 2;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserID
            // 
            this.UserID.Location = new System.Drawing.Point(326, 230);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(149, 38);
            this.UserID.TabIndex = 3;
            this.UserID.Text = "ID User";
            this.UserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserBirthday
            // 
            this.UserBirthday.Location = new System.Drawing.Point(326, 418);
            this.UserBirthday.Name = "UserBirthday";
            this.UserBirthday.Size = new System.Drawing.Size(149, 38);
            this.UserBirthday.TabIndex = 4;
            this.UserBirthday.Text = "Birthday";
            this.UserBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserGender
            // 
            this.UserGender.Location = new System.Drawing.Point(326, 356);
            this.UserGender.Name = "UserGender";
            this.UserGender.Size = new System.Drawing.Size(149, 38);
            this.UserGender.TabIndex = 5;
            this.UserGender.Text = "Gender";
            this.UserGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserPhone
            // 
            this.UserPhone.Location = new System.Drawing.Point(326, 479);
            this.UserPhone.Name = "UserPhone";
            this.UserPhone.Size = new System.Drawing.Size(149, 38);
            this.UserPhone.TabIndex = 6;
            this.UserPhone.Text = "Phone number";
            this.UserPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserAddress
            // 
            this.UserAddress.Location = new System.Drawing.Point(326, 535);
            this.UserAddress.Name = "UserAddress";
            this.UserAddress.Size = new System.Drawing.Size(149, 38);
            this.UserAddress.TabIndex = 7;
            this.UserAddress.Text = "Address";
            this.UserAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Text_ID
            // 
            this.Text_ID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Text_ID.Enabled = false;
            this.Text_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Text_ID.Location = new System.Drawing.Point(498, 230);
            this.Text_ID.Multiline = true;
            this.Text_ID.Name = "Text_ID";
            this.Text_ID.ReadOnly = true;
            this.Text_ID.Size = new System.Drawing.Size(126, 38);
            this.Text_ID.TabIndex = 8;
            // 
            // Text_Username
            // 
            this.Text_Username.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Text_Username.Enabled = false;
            this.Text_Username.Location = new System.Drawing.Point(496, 293);
            this.Text_Username.Multiline = true;
            this.Text_Username.Name = "Text_Username";
            this.Text_Username.ReadOnly = true;
            this.Text_Username.Size = new System.Drawing.Size(521, 38);
            this.Text_Username.TabIndex = 9;
            // 
            // Text_Gender
            // 
            this.Text_Gender.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Text_Gender.Enabled = false;
            this.Text_Gender.Location = new System.Drawing.Point(496, 356);
            this.Text_Gender.Multiline = true;
            this.Text_Gender.Name = "Text_Gender";
            this.Text_Gender.ReadOnly = true;
            this.Text_Gender.Size = new System.Drawing.Size(128, 30);
            this.Text_Gender.TabIndex = 10;
            // 
            // Text_Birthday
            // 
            this.Text_Birthday.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Text_Birthday.Enabled = false;
            this.Text_Birthday.Location = new System.Drawing.Point(498, 418);
            this.Text_Birthday.Multiline = true;
            this.Text_Birthday.Name = "Text_Birthday";
            this.Text_Birthday.ReadOnly = true;
            this.Text_Birthday.Size = new System.Drawing.Size(167, 38);
            this.Text_Birthday.TabIndex = 11;
            // 
            // Text_Phone
            // 
            this.Text_Phone.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Text_Phone.Enabled = false;
            this.Text_Phone.Location = new System.Drawing.Point(496, 479);
            this.Text_Phone.Multiline = true;
            this.Text_Phone.Name = "Text_Phone";
            this.Text_Phone.ReadOnly = true;
            this.Text_Phone.Size = new System.Drawing.Size(261, 38);
            this.Text_Phone.TabIndex = 12;
            // 
            // Text_Address
            // 
            this.Text_Address.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Text_Address.Enabled = false;
            this.Text_Address.Location = new System.Drawing.Point(496, 535);
            this.Text_Address.Multiline = true;
            this.Text_Address.Name = "Text_Address";
            this.Text_Address.ReadOnly = true;
            this.Text_Address.Size = new System.Drawing.Size(514, 76);
            this.Text_Address.TabIndex = 13;
            // 
            // Button_Edit_Confirm
            // 
            this.Button_Edit_Confirm.Location = new System.Drawing.Point(654, 654);
            this.Button_Edit_Confirm.Name = "Button_Edit_Confirm";
            this.Button_Edit_Confirm.Size = new System.Drawing.Size(183, 61);
            this.Button_Edit_Confirm.TabIndex = 14;
            this.Button_Edit_Confirm.Text = "Edit";
            this.Button_Edit_Confirm.UseVisualStyleBackColor = true;
            this.Button_Edit_Confirm.Click += new System.EventHandler(this.Button_Edit_Confirm_Click);
            // 
            // Button_Logout
            // 
            this.Button_Logout.Location = new System.Drawing.Point(1187, 654);
            this.Button_Logout.Name = "Button_Logout";
            this.Button_Logout.Size = new System.Drawing.Size(183, 58);
            this.Button_Logout.TabIndex = 15;
            this.Button_Logout.Text = "Log out";
            this.Button_Logout.UseVisualStyleBackColor = true;
            this.Button_Logout.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menu
            // 
            this.Menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Dashboard,
            this.Menu_Emp,
            this.Menu_Department,
            this.Menu_Project,
            this.Menu_Assignment});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu.Size = new System.Drawing.Size(1382, 28);
            this.Menu.TabIndex = 17;
            this.Menu.Text = "Menu";
            // 
            // Menu_Dashboard
            // 
            this.Menu_Dashboard.Name = "Menu_Dashboard";
            this.Menu_Dashboard.Size = new System.Drawing.Size(96, 24);
            this.Menu_Dashboard.Text = "Dashboard";
            this.Menu_Dashboard.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // Menu_Emp
            // 
            this.Menu_Emp.Name = "Menu_Emp";
            this.Menu_Emp.Size = new System.Drawing.Size(89, 24);
            this.Menu_Emp.Text = "Employee";
            this.Menu_Emp.Click += new System.EventHandler(this.manageEmployeeToolStripMenuItem_Click);
            // 
            // Menu_Department
            // 
            this.Menu_Department.Name = "Menu_Department";
            this.Menu_Department.Size = new System.Drawing.Size(103, 24);
            this.Menu_Department.Text = "Department";
            this.Menu_Department.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // Menu_Project
            // 
            this.Menu_Project.Name = "Menu_Project";
            this.Menu_Project.Size = new System.Drawing.Size(69, 24);
            this.Menu_Project.Text = "Project";
            // 
            // Menu_Assignment
            // 
            this.Menu_Assignment.Name = "Menu_Assignment";
            this.Menu_Assignment.Size = new System.Drawing.Size(100, 24);
            this.Menu_Assignment.Text = "Assignment";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1090, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(257, 311);
            this.dataGridView1.TabIndex = 18;
            // 
            // F_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Button_Logout);
            this.Controls.Add(this.Button_Edit_Confirm);
            this.Controls.Add(this.Text_Address);
            this.Controls.Add(this.Text_Phone);
            this.Controls.Add(this.Text_Birthday);
            this.Controls.Add(this.Text_Gender);
            this.Controls.Add(this.Text_Username);
            this.Controls.Add(this.Text_ID);
            this.Controls.Add(this.UserAddress);
            this.Controls.Add(this.UserPhone);
            this.Controls.Add(this.UserGender);
            this.Controls.Add(this.UserBirthday);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.avaUser);
            this.Controls.Add(this.Menu);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenuStrip = this.Menu;
            this.Name = "F_Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avaUser)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox avaUser;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Dashboard;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label UserBirthday;
        private System.Windows.Forms.Label UserGender;
        private System.Windows.Forms.Label UserPhone;
        private System.Windows.Forms.Label UserAddress;
        private System.Windows.Forms.TextBox Text_ID;
        private System.Windows.Forms.TextBox Text_Username;
        private System.Windows.Forms.TextBox Text_Gender;
        private System.Windows.Forms.TextBox Text_Birthday;
        private System.Windows.Forms.TextBox Text_Phone;
        private System.Windows.Forms.TextBox Text_Address;
        private System.Windows.Forms.Button Button_Edit_Confirm;
        private System.Windows.Forms.Button Button_Logout;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem Menu_Dashboard;
        private System.Windows.Forms.ToolStripMenuItem Menu_Emp;
        private System.Windows.Forms.ToolStripMenuItem Menu_Department;
        private System.Windows.Forms.ToolStripMenuItem Menu_Project;
        private System.Windows.Forms.ToolStripMenuItem Menu_Assignment;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}