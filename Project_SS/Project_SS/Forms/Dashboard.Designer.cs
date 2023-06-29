namespace Project_SS
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.timerRoll = new System.Windows.Forms.Timer(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.btnProject = new System.Windows.Forms.Button();
            this.btnWorks = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnJobs = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Roll_Dashboard = new System.Windows.Forms.Button();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.label_Exit = new System.Windows.Forms.Label();
            this.panel_Time = new System.Windows.Forms.Panel();
            this.label_User = new System.Windows.Forms.Label();
            this.tb_User = new System.Windows.Forms.Label();
            this.text_Title = new System.Windows.Forms.Label();
            this.tb_Role = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_Role = new System.Windows.Forms.Panel();
            this.panel_Left.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Time.SuspendLayout();
            this.panel_Role.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerRoll
            // 
            this.timerRoll.Tick += new System.EventHandler(this.timerRoll_Tick);
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Location = new System.Drawing.Point(297, 155);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1303, 731);
            this.panelContainer.TabIndex = 6;
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(121)))), ((int)(((byte)(195)))));
            this.panel_Left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Left.Controls.Add(this.panelSide);
            this.panel_Left.Controls.Add(this.btnAboutUs);
            this.panel_Left.Controls.Add(this.btnProject);
            this.panel_Left.Controls.Add(this.btnWorks);
            this.panel_Left.Controls.Add(this.btnEmployee);
            this.panel_Left.Controls.Add(this.btnJobs);
            this.panel_Left.Controls.Add(this.btnDashboard);
            this.panel_Left.Controls.Add(this.panel_Logo);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(297, 886);
            this.panel_Left.TabIndex = 4;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(0, 194);
            this.panelSide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(11, 54);
            this.panelSide.TabIndex = 3;
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAboutUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAboutUs.FlatAppearance.BorderSize = 0;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnAboutUs.ForeColor = System.Drawing.Color.White;
            this.btnAboutUs.Image = global::Project_SS.Properties.Resources.logout__2_;
            this.btnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.Location = new System.Drawing.Point(13, 816);
            this.btnAboutUs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(275, 54);
            this.btnAboutUs.TabIndex = 1;
            this.btnAboutUs.Text = "         Logout";
            this.btnAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // btnProject
            // 
            this.btnProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProject.FlatAppearance.BorderSize = 0;
            this.btnProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProject.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnProject.ForeColor = System.Drawing.Color.White;
            this.btnProject.Image = ((System.Drawing.Image)(resources.GetObject("btnProject.Image")));
            this.btnProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProject.Location = new System.Drawing.Point(17, 492);
            this.btnProject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(279, 54);
            this.btnProject.TabIndex = 1;
            this.btnProject.Text = "   Project";
            this.btnProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProject.UseVisualStyleBackColor = true;
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // btnWorks
            // 
            this.btnWorks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWorks.FlatAppearance.BorderSize = 0;
            this.btnWorks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorks.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnWorks.ForeColor = System.Drawing.Color.White;
            this.btnWorks.Image = ((System.Drawing.Image)(resources.GetObject("btnWorks.Image")));
            this.btnWorks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorks.Location = new System.Drawing.Point(16, 416);
            this.btnWorks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWorks.Name = "btnWorks";
            this.btnWorks.Size = new System.Drawing.Size(279, 54);
            this.btnWorks.TabIndex = 1;
            this.btnWorks.Text = "   Phong ban";
            this.btnWorks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWorks.UseVisualStyleBackColor = true;
            // 
            // btnEmployee
            // 
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(17, 270);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(279, 54);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "   Employee";
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnJobs
            // 
            this.btnJobs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJobs.FlatAppearance.BorderSize = 0;
            this.btnJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJobs.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnJobs.ForeColor = System.Drawing.Color.White;
            this.btnJobs.Image = ((System.Drawing.Image)(resources.GetObject("btnJobs.Image")));
            this.btnJobs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJobs.Location = new System.Drawing.Point(17, 342);
            this.btnJobs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJobs.Name = "btnJobs";
            this.btnJobs.Size = new System.Drawing.Size(279, 54);
            this.btnJobs.TabIndex = 1;
            this.btnJobs.Text = "   Assigned Jobs";
            this.btnJobs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJobs.UseVisualStyleBackColor = true;
            this.btnJobs.Click += new System.EventHandler(this.btnJobs_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(16, 194);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(279, 54);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "   Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel_Logo
            // 
            this.panel_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(121)))), ((int)(((byte)(195)))));
            this.panel_Logo.Controls.Add(this.pictureBox1);
            this.panel_Logo.Controls.Add(this.btn_Roll_Dashboard);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(295, 149);
            this.panel_Logo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_SS.Properties.Resources.LogoText_white__4x;
            this.pictureBox1.Location = new System.Drawing.Point(52, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Roll_Dashboard
            // 
            this.btn_Roll_Dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Roll_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Roll_Dashboard.FlatAppearance.BorderSize = 0;
            this.btn_Roll_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Roll_Dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_Roll_Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("btn_Roll_Dashboard.Image")));
            this.btn_Roll_Dashboard.Location = new System.Drawing.Point(307, 2);
            this.btn_Roll_Dashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Roll_Dashboard.Name = "btn_Roll_Dashboard";
            this.btn_Roll_Dashboard.Size = new System.Drawing.Size(61, 54);
            this.btn_Roll_Dashboard.TabIndex = 1;
            this.btn_Roll_Dashboard.UseVisualStyleBackColor = true;
            this.btn_Roll_Dashboard.Click += new System.EventHandler(this.btn_Roll_Dashboard_Click);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.labelTime.Location = new System.Drawing.Point(309, 11);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(112, 28);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "HH:MM:SS";
            // 
            // label_Exit
            // 
            this.label_Exit.AutoSize = true;
            this.label_Exit.BackColor = System.Drawing.Color.White;
            this.label_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_Exit.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(19)))), ((int)(((byte)(117)))));
            this.label_Exit.Location = new System.Drawing.Point(1269, 0);
            this.label_Exit.Name = "label_Exit";
            this.label_Exit.Size = new System.Drawing.Size(34, 41);
            this.label_Exit.TabIndex = 8;
            this.label_Exit.Text = "x";
            this.label_Exit.Click += new System.EventHandler(this.label_Exit_Click);
            // 
            // panel_Time
            // 
            this.panel_Time.BackColor = System.Drawing.Color.White;
            this.panel_Time.Controls.Add(this.label_Exit);
            this.panel_Time.Controls.Add(this.labelTime);
            this.panel_Time.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Time.Location = new System.Drawing.Point(297, 0);
            this.panel_Time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Time.Name = "panel_Time";
            this.panel_Time.Size = new System.Drawing.Size(1303, 49);
            this.panel_Time.TabIndex = 3;
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.label_User.ForeColor = System.Drawing.Color.White;
            this.label_User.Location = new System.Drawing.Point(57, 23);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(108, 28);
            this.label_User.TabIndex = 14;
            this.label_User.Text = "Username:";
            // 
            // tb_User
            // 
            this.tb_User.AutoSize = true;
            this.tb_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_User.ForeColor = System.Drawing.Color.White;
            this.tb_User.Location = new System.Drawing.Point(184, 23);
            this.tb_User.Name = "tb_User";
            this.tb_User.Size = new System.Drawing.Size(156, 25);
            this.tb_User.TabIndex = 14;
            this.tb_User.Text = "____________";
            // 
            // text_Title
            // 
            this.text_Title.AutoSize = true;
            this.text_Title.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Title.ForeColor = System.Drawing.Color.White;
            this.text_Title.Location = new System.Drawing.Point(547, 23);
            this.text_Title.Name = "text_Title";
            this.text_Title.Size = new System.Drawing.Size(230, 54);
            this.text_Title.TabIndex = 14;
            this.text_Title.Text = "Dashboard";
            // 
            // tb_Role
            // 
            this.tb_Role.AutoSize = true;
            this.tb_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Role.ForeColor = System.Drawing.Color.White;
            this.tb_Role.Location = new System.Drawing.Point(184, 58);
            this.tb_Role.Name = "tb_Role";
            this.tb_Role.Size = new System.Drawing.Size(156, 25);
            this.tb_Role.TabIndex = 14;
            this.tb_Role.Text = "____________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(111, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Role:";
            // 
            // panel_Role
            // 
            this.panel_Role.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_Role.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(121)))), ((int)(((byte)(195)))));
            this.panel_Role.Controls.Add(this.label4);
            this.panel_Role.Controls.Add(this.tb_Role);
            this.panel_Role.Controls.Add(this.text_Title);
            this.panel_Role.Controls.Add(this.tb_User);
            this.panel_Role.Controls.Add(this.label_User);
            this.panel_Role.Location = new System.Drawing.Point(297, 46);
            this.panel_Role.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Role.Name = "panel_Role";
            this.panel_Role.Size = new System.Drawing.Size(1303, 108);
            this.panel_Role.TabIndex = 5;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 886);
            this.Controls.Add(this.panel_Role);
            this.Controls.Add(this.panel_Time);
            this.Controls.Add(this.panel_Left);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel_Left.ResumeLayout(false);
            this.panel_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Time.ResumeLayout(false);
            this.panel_Time.PerformLayout();
            this.panel_Role.ResumeLayout(false);
            this.panel_Role.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerRoll;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnJobs;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnWorks;
        private System.Windows.Forms.Button btnProject;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.Button btn_Roll_Dashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label_Exit;
        private System.Windows.Forms.Panel panel_Time;
        private System.Windows.Forms.Label label_User;
        private System.Windows.Forms.Label tb_User;
        private System.Windows.Forms.Label text_Title;
        private System.Windows.Forms.Label tb_Role;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_Role;
        private System.Windows.Forms.Panel panelSide;
    }
}