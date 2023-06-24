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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnWorks = new System.Windows.Forms.Button();
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.btnContractors = new System.Windows.Forms.Button();
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
            this.lblTitle = new System.Windows.Forms.Label();
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
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1303, 731);
            this.panelContainer.TabIndex = 6;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(121)))), ((int)(((byte)(195)))));
            this.panel_Left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Left.Controls.Add(this.panel1);
            this.panel_Left.Controls.Add(this.btnAboutUs);
            this.panel_Left.Controls.Add(this.btnReports);
            this.panel_Left.Controls.Add(this.btnWorks);
            this.panel_Left.Controls.Add(this.btnAnalytics);
            this.panel_Left.Controls.Add(this.btnContractors);
            this.panel_Left.Controls.Add(this.btnJobs);
            this.panel_Left.Controls.Add(this.btnDashboard);
            this.panel_Left.Controls.Add(this.panel_Logo);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(297, 886);
            this.panel_Left.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 194);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 54);
            this.panel1.TabIndex = 3;
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
            this.btnAboutUs.Location = new System.Drawing.Point(16, 827);
            this.btnAboutUs.Margin = new System.Windows.Forms.Padding(4);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(275, 54);
            this.btnAboutUs.TabIndex = 1;
            this.btnAboutUs.Text = "       Logout";
            this.btnAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // btnReports
            // 
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(12, 564);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(279, 54);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "   Reports";
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = true;
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
            this.btnWorks.Margin = new System.Windows.Forms.Padding(4);
            this.btnWorks.Name = "btnWorks";
            this.btnWorks.Size = new System.Drawing.Size(279, 54);
            this.btnWorks.TabIndex = 1;
            this.btnWorks.Text = "   Manage Works";
            this.btnWorks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWorks.UseVisualStyleBackColor = true;
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnalytics.FlatAppearance.BorderSize = 0;
            this.btnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalytics.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnAnalytics.ForeColor = System.Drawing.Color.White;
            this.btnAnalytics.Image = ((System.Drawing.Image)(resources.GetObject("btnAnalytics.Image")));
            this.btnAnalytics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalytics.Location = new System.Drawing.Point(16, 490);
            this.btnAnalytics.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Size = new System.Drawing.Size(279, 54);
            this.btnAnalytics.TabIndex = 1;
            this.btnAnalytics.Text = "   Analytics";
            this.btnAnalytics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnalytics.UseVisualStyleBackColor = true;
            // 
            // btnContractors
            // 
            this.btnContractors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContractors.FlatAppearance.BorderSize = 0;
            this.btnContractors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContractors.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnContractors.ForeColor = System.Drawing.Color.White;
            this.btnContractors.Image = ((System.Drawing.Image)(resources.GetObject("btnContractors.Image")));
            this.btnContractors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContractors.Location = new System.Drawing.Point(16, 342);
            this.btnContractors.Margin = new System.Windows.Forms.Padding(4);
            this.btnContractors.Name = "btnContractors";
            this.btnContractors.Size = new System.Drawing.Size(279, 54);
            this.btnContractors.TabIndex = 1;
            this.btnContractors.Text = "   Contractors";
            this.btnContractors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContractors.UseVisualStyleBackColor = true;
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
            this.btnJobs.Location = new System.Drawing.Point(16, 268);
            this.btnJobs.Margin = new System.Windows.Forms.Padding(4);
            this.btnJobs.Name = "btnJobs";
            this.btnJobs.Size = new System.Drawing.Size(279, 54);
            this.btnJobs.TabIndex = 1;
            this.btnJobs.Text = "   Assigned Jobs";
            this.btnJobs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJobs.UseVisualStyleBackColor = true;
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
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(279, 54);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "   Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // panel_Logo
            // 
            this.panel_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(121)))), ((int)(((byte)(195)))));
            this.panel_Logo.Controls.Add(this.pictureBox1);
            this.panel_Logo.Controls.Add(this.btn_Roll_Dashboard);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(295, 149);
            this.panel_Logo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_SS.Properties.Resources.LogoText_white__4x;
            this.pictureBox1.Location = new System.Drawing.Point(52, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
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
            this.btn_Roll_Dashboard.Margin = new System.Windows.Forms.Padding(4);
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
            this.panel_Time.Name = "panel_Time";
            this.panel_Time.Size = new System.Drawing.Size(1303, 49);
            this.panel_Time.TabIndex = 3;
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.label_User.ForeColor = System.Drawing.Color.White;
            this.label_User.Location = new System.Drawing.Point(57, 12);
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
            this.tb_User.Location = new System.Drawing.Point(146, 12);
            this.tb_User.Name = "tb_User";
            this.tb_User.Size = new System.Drawing.Size(156, 25);
            this.tb_User.TabIndex = 14;
            this.tb_User.Text = "____________";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(546, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(230, 54);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Dashboard";
            // 
            // tb_Role
            // 
            this.tb_Role.AutoSize = true;
            this.tb_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Role.ForeColor = System.Drawing.Color.White;
            this.tb_Role.Location = new System.Drawing.Point(146, 47);
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
            this.label4.Location = new System.Drawing.Point(98, 47);
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
            this.panel_Role.Controls.Add(this.lblTitle);
            this.panel_Role.Controls.Add(this.tb_User);
            this.panel_Role.Controls.Add(this.label_User);
            this.panel_Role.Location = new System.Drawing.Point(223, 41);
            this.panel_Role.Name = "panel_Role";
            this.panel_Role.Size = new System.Drawing.Size(977, 85);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnContractors;
        private System.Windows.Forms.Button btnAnalytics;
        private System.Windows.Forms.Button btnWorks;
        private System.Windows.Forms.Button btnReports;
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
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label tb_Role;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_Role;
        private System.Windows.Forms.Panel panel1;
    }
}