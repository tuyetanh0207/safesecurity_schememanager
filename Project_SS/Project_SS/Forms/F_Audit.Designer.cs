namespace Project_SS.Forms
{
    partial class F_Audit
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
            this.audit_DataGrid = new System.Windows.Forms.DataGridView();
            this.changetime_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.change_LP_Button = new System.Windows.Forms.Button();
            this.changenhanvien_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.QLPHANCONG = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.qlphancong_Button = new System.Windows.Forms.Button();
            this.uid_nhanvien_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.audit_DataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // audit_DataGrid
            // 
            this.audit_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.audit_DataGrid.Location = new System.Drawing.Point(34, 33);
            this.audit_DataGrid.Name = "audit_DataGrid";
            this.audit_DataGrid.RowHeadersWidth = 51;
            this.audit_DataGrid.RowTemplate.Height = 24;
            this.audit_DataGrid.Size = new System.Drawing.Size(967, 309);
            this.audit_DataGrid.TabIndex = 0;
            // 
            // changetime_button
            // 
            this.changetime_button.Location = new System.Drawing.Point(176, 62);
            this.changetime_button.Name = "changetime_button";
            this.changetime_button.Size = new System.Drawing.Size(241, 38);
            this.changetime_button.TabIndex = 1;
            this.changetime_button.Text = "ENABLE AUDIT";
            this.changetime_button.UseVisualStyleBackColor = true;
            this.changetime_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHANGETIME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "CHANGE_LP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "CHANGENHANVIEN";
            // 
            // change_LP_Button
            // 
            this.change_LP_Button.Location = new System.Drawing.Point(176, 118);
            this.change_LP_Button.Name = "change_LP_Button";
            this.change_LP_Button.Size = new System.Drawing.Size(241, 44);
            this.change_LP_Button.TabIndex = 5;
            this.change_LP_Button.Text = "ENABLE AUDIT";
            this.change_LP_Button.UseVisualStyleBackColor = true;
            this.change_LP_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // changenhanvien_Button
            // 
            this.changenhanvien_Button.Location = new System.Drawing.Point(176, 176);
            this.changenhanvien_Button.Name = "changenhanvien_Button";
            this.changenhanvien_Button.Size = new System.Drawing.Size(241, 41);
            this.changenhanvien_Button.TabIndex = 6;
            this.changenhanvien_Button.Text = "ENABLE AUDIT";
            this.changenhanvien_Button.UseVisualStyleBackColor = true;
            this.changenhanvien_Button.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.changetime_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.change_LP_Button);
            this.panel1.Controls.Add(this.changenhanvien_Button);
            this.panel1.Location = new System.Drawing.Point(34, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 241);
            this.panel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(183, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "AUDIT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.QLPHANCONG);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.qlphancong_Button);
            this.panel2.Controls.Add(this.uid_nhanvien_button);
            this.panel2.Location = new System.Drawing.Point(517, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 241);
            this.panel2.TabIndex = 12;
            // 
            // QLPHANCONG
            // 
            this.QLPHANCONG.AutoSize = true;
            this.QLPHANCONG.Location = new System.Drawing.Point(74, 176);
            this.QLPHANCONG.Name = "QLPHANCONG";
            this.QLPHANCONG.Size = new System.Drawing.Size(101, 16);
            this.QLPHANCONG.TabIndex = 14;
            this.QLPHANCONG.Text = "QLPHANCONG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "UID_NHANVIEN";
            // 
            // qlphancong_Button
            // 
            this.qlphancong_Button.Location = new System.Drawing.Point(247, 149);
            this.qlphancong_Button.Name = "qlphancong_Button";
            this.qlphancong_Button.Size = new System.Drawing.Size(215, 61);
            this.qlphancong_Button.TabIndex = 12;
            this.qlphancong_Button.Text = "ENABLE VPD";
            this.qlphancong_Button.UseVisualStyleBackColor = true;
            this.qlphancong_Button.Click += new System.EventHandler(this.qlphancong_Button_Click);
            // 
            // uid_nhanvien_button
            // 
            this.uid_nhanvien_button.Location = new System.Drawing.Point(247, 62);
            this.uid_nhanvien_button.Name = "uid_nhanvien_button";
            this.uid_nhanvien_button.Size = new System.Drawing.Size(215, 56);
            this.uid_nhanvien_button.TabIndex = 11;
            this.uid_nhanvien_button.Text = "ENABLE VPD";
            this.uid_nhanvien_button.UseVisualStyleBackColor = true;
            this.uid_nhanvien_button.Click += new System.EventHandler(this.uid_nhanvien_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(231, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "VPD";
            // 
            // F_Audit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 614);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.audit_DataGrid);
            this.Name = "F_Audit";
            this.Text = "Audit";
            ((System.ComponentModel.ISupportInitialize)(this.audit_DataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView audit_DataGrid;
        private System.Windows.Forms.Button changetime_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button change_LP_Button;
        private System.Windows.Forms.Button changenhanvien_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label QLPHANCONG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button qlphancong_Button;
        private System.Windows.Forms.Button uid_nhanvien_button;
    }
}