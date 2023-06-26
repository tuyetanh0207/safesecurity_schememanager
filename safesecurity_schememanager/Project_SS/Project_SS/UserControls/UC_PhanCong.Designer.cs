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
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbSchema = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.dtgvDSPHANCONG.Location = new System.Drawing.Point(19, 65);
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
            this.cbxName.FormattingEnabled = true;
            this.cbxName.Location = new System.Drawing.Point(14, 120);
            this.cbxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxName.Name = "cbxName";
            this.cbxName.Size = new System.Drawing.Size(267, 36);
            this.cbxName.TabIndex = 2;
            // 
            // cbxSchema
            // 
            this.cbxSchema.FormattingEnabled = true;
            this.cbxSchema.Location = new System.Drawing.Point(14, 273);
            this.cbxSchema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxSchema.Name = "cbxSchema";
            this.cbxSchema.Size = new System.Drawing.Size(267, 36);
            this.cbxSchema.TabIndex = 3;
            this.cbxSchema.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbSchema);
            this.panel1.Controls.Add(this.txbName);
            this.panel1.Controls.Add(this.cbxName);
            this.panel1.Controls.Add(this.cbxSchema);
            this.panel1.Location = new System.Drawing.Point(679, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 390);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(14, 78);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(267, 34);
            this.txbName.TabIndex = 4;
            // 
            // txbSchema
            // 
            this.txbSchema.Location = new System.Drawing.Point(14, 231);
            this.txbSchema.Name = "txbSchema";
            this.txbSchema.Size = new System.Drawing.Size(267, 34);
            this.txbSchema.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(71, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search employee";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(83, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search schema";
            // 
            // UC_PhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvDSPHANCONG);
            this.Controls.Add(this.Phancong);
            this.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_PhanCong";
            this.Size = new System.Drawing.Size(977, 571);
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
    }
}
