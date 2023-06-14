namespace project_ATBM_HTTT
{
    partial class Login
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
            this.lb_User = new System.Windows.Forms.Label();
            this.lb_Pass = new System.Windows.Forms.Label();
            this.tb_User = new System.Windows.Forms.TextBox();
            this.tb_Pass = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.Location = new System.Drawing.Point(185, 103);
            this.lb_User.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(73, 16);
            this.lb_User.TabIndex = 0;
            this.lb_User.Text = "Username:";
            // 
            // lb_Pass
            // 
            this.lb_Pass.AutoSize = true;
            this.lb_Pass.Location = new System.Drawing.Point(185, 167);
            this.lb_Pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Pass.Name = "lb_Pass";
            this.lb_Pass.Size = new System.Drawing.Size(70, 16);
            this.lb_Pass.TabIndex = 1;
            this.lb_Pass.Text = "Password:";
            // 
            // tb_User
            // 
            this.tb_User.Location = new System.Drawing.Point(284, 95);
            this.tb_User.Margin = new System.Windows.Forms.Padding(4);
            this.tb_User.Name = "tb_User";
            this.tb_User.Size = new System.Drawing.Size(271, 22);
            this.tb_User.TabIndex = 2;
            // 
            // tb_Pass
            // 
            this.tb_Pass.Location = new System.Drawing.Point(284, 159);
            this.tb_Pass.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Pass.Name = "tb_Pass";
            this.tb_Pass.Size = new System.Drawing.Size(271, 22);
            this.tb_Pass.TabIndex = 3;
            this.tb_Pass.UseSystemPasswordChar = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(347, 223);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(127, 43);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 357);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Pass);
            this.Controls.Add(this.tb_User);
            this.Controls.Add(this.lb_Pass);
            this.Controls.Add(this.lb_User);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.Label lb_Pass;
        private System.Windows.Forms.TextBox tb_User;
        private System.Windows.Forms.TextBox tb_Pass;
        private System.Windows.Forms.Button btn_Login;
    }
}

