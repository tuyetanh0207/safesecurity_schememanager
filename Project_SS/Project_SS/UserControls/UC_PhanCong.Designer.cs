namespace Project_SS.UserControls
{
    partial class UC_PhanCong
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
            this.Phancong = new System.Windows.Forms.Label();
            this.dtgvDSPHANCONG = new System.Windows.Forms.DataGridView();
            this.cbxName = new System.Windows.Forms.ComboBox();
            this.cbxSchema = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbCurrTime = new System.Windows.Forms.TextBox();
            this.txbCurrEmp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCurrSchema = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSchema = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSPHANCONG)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Phancong
            // 
            this.Phancong.AutoSize = true;
            this.Phancong.Cursor = System.Windows.Forms.Cursors.Default;
            this.Phancong.Location = new System.Drawing.Point(36, 23);
            this.Phancong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Phancong.Name = "Phancong";
            this.Phancong.Size = new System.Drawing.Size(135, 28);
            this.Phancong.TabIndex = 0;
            this.Phancong.Text = "ASSIGNMENT";
            // 
            // dtgvDSPHANCONG
            // 
            this.dtgvDSPHANCONG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSPHANCONG.Location = new System.Drawing.Point(4, 65);
            this.dtgvDSPHANCONG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvDSPHANCONG.Name = "dtgvDSPHANCONG";
            this.dtgvDSPHANCONG.RowHeadersWidth = 51;
            this.dtgvDSPHANCONG.RowTemplate.Height = 24;
            this.dtgvDSPHANCONG.Size = new System.Drawing.Size(652, 488);
            this.dtgvDSPHANCONG.TabIndex = 1;
            this.dtgvDSPHANCONG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSPHANCONG_CellContentClick);
            // 
            // cbxName
            // 
            this.cbxName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbxName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbxName.FormattingEnabled = true;
            this.cbxName.Location = new System.Drawing.Point(17, 345);
            this.cbxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxName.Name = "cbxName";
            this.cbxName.Size = new System.Drawing.Size(267, 36);
            this.cbxName.TabIndex = 2;
            this.cbxName.Text = "Choose employee . . .";
            this.cbxName.SelectedIndexChanged += new System.EventHandler(this.cbxName_SelectedIndexChanged);
            // 
            // cbxSchema
            // 
            this.cbxSchema.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbxSchema.FormattingEnabled = true;
            this.cbxSchema.Location = new System.Drawing.Point(16, 234);
            this.cbxSchema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxSchema.Name = "cbxSchema";
            this.cbxSchema.Size = new System.Drawing.Size(267, 36);
            this.cbxSchema.TabIndex = 3;
            this.cbxSchema.Text = "Choose schema . . .";
            this.cbxSchema.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.txbCurrTime);
            this.panel1.Controls.Add(this.txbCurrEmp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbCurrSchema);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSaveUpdate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbSchema);
            this.panel1.Controls.Add(this.txbName);
            this.panel1.Controls.Add(this.cbxName);
            this.panel1.Controls.Add(this.cbxSchema);
            this.panel1.Location = new System.Drawing.Point(679, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 488);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txbCurrTime
            // 
            this.txbCurrTime.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCurrTime.Location = new System.Drawing.Point(7, 115);
            this.txbCurrTime.Name = "txbCurrTime";
            this.txbCurrTime.Size = new System.Drawing.Size(276, 30);
            this.txbCurrTime.TabIndex = 13;
            this.txbCurrTime.TextChanged += new System.EventHandler(this.txbCurrTime_TextChanged);
            // 
            // txbCurrEmp
            // 
            this.txbCurrEmp.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCurrEmp.Location = new System.Drawing.Point(7, 75);
            this.txbCurrEmp.Name = "txbCurrEmp";
            this.txbCurrEmp.Size = new System.Drawing.Size(276, 30);
            this.txbCurrEmp.TabIndex = 12;
            this.txbCurrEmp.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Assignement information: ";
            // 
            // txbCurrSchema
            // 
            this.txbCurrSchema.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCurrSchema.Location = new System.Drawing.Point(7, 35);
            this.txbCurrSchema.Name = "txbCurrSchema";
            this.txbCurrSchema.Size = new System.Drawing.Size(277, 30);
            this.txbCurrSchema.TabIndex = 10;
            this.txbCurrSchema.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(22, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 53);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.Location = new System.Drawing.Point(173, 415);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(111, 53);
            this.btnSaveUpdate.TabIndex = 8;
            this.btnSaveUpdate.Text = "SAVE";
            this.btnSaveUpdate.UseVisualStyleBackColor = true;
            this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(64, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search schema";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(64, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search employee";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbSchema
            // 
            this.txbSchema.Font = new System.Drawing.Font("Malgun Gothic Semilight", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSchema.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbSchema.Location = new System.Drawing.Point(16, 201);
            this.txbSchema.Name = "txbSchema";
            this.txbSchema.Size = new System.Drawing.Size(267, 25);
            this.txbSchema.TabIndex = 5;
            this.txbSchema.Text = "Phát triển ứng dụng . . .";
            this.txbSchema.TextChanged += new System.EventHandler(this.txbSchema_TextChanged);
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbName.Location = new System.Drawing.Point(17, 312);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(267, 25);
            this.txbName.TabIndex = 4;
            this.txbName.Text = "Nguyễn Tuyết Anh. . .";
            this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(796, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "+ ADD ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UC_PhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvDSPHANCONG);
            this.Controls.Add(this.Phancong);
            this.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_PhanCong";
            this.Size = new System.Drawing.Size(977, 571);
            this.Load += new System.EventHandler(this.UC_PhanCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSPHANCONG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Phancong;
        private System.Windows.Forms.DataGridView dtgvDSPHANCONG;
        private System.Windows.Forms.ComboBox cbxName;
        private System.Windows.Forms.ComboBox cbxSchema;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSchema;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btnSaveUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txbCurrTime;
        private System.Windows.Forms.TextBox txbCurrEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCurrSchema;
        private System.Windows.Forms.Button button1;
    }
}
