namespace Project_SS.UserControls
{
    partial class UC_DeAn
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
			this.panel_UC_DeAn = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgv_UC_DeAn = new System.Windows.Forms.DataGridView();
			this.panel_UC_DeAn.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_UC_DeAn)).BeginInit();
			this.SuspendLayout();
			// 
			// panel_UC_DeAn
			// 
			this.panel_UC_DeAn.BackColor = System.Drawing.Color.Gainsboro;
			this.panel_UC_DeAn.Controls.Add(this.panel2);
			this.panel_UC_DeAn.Controls.Add(this.panel1);
			this.panel_UC_DeAn.Location = new System.Drawing.Point(17, 20);
			this.panel_UC_DeAn.Name = "panel_UC_DeAn";
			this.panel_UC_DeAn.Size = new System.Drawing.Size(937, 531);
			this.panel_UC_DeAn.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Control;
			this.panel2.Location = new System.Drawing.Point(503, 90);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(418, 424);
			this.panel2.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.dgv_UC_DeAn);
			this.panel1.Location = new System.Drawing.Point(17, 90);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(418, 424);
			this.panel1.TabIndex = 0;
			// 
			// dgv_UC_DeAn
			// 
			this.dgv_UC_DeAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_UC_DeAn.Location = new System.Drawing.Point(3, 90);
			this.dgv_UC_DeAn.Name = "dgv_UC_DeAn";
			this.dgv_UC_DeAn.RowHeadersWidth = 51;
			this.dgv_UC_DeAn.RowTemplate.Height = 24;
			this.dgv_UC_DeAn.Size = new System.Drawing.Size(412, 331);
			this.dgv_UC_DeAn.TabIndex = 1;
			this.dgv_UC_DeAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_UC_DeAn_CellContentClick);
			// 
			// UC_DeAn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel_UC_DeAn);
			this.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "UC_DeAn";
			this.Size = new System.Drawing.Size(977, 571);
			this.panel_UC_DeAn.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_UC_DeAn)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_UC_DeAn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_UC_DeAn;
    }
}
