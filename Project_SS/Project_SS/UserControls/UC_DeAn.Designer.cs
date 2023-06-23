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
			this.dgv_ListScheme = new System.Windows.Forms.DataGridView();
			this.DeAn = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Button_Exit = new System.Windows.Forms.Button();
			this.button_AddScheme = new System.Windows.Forms.Button();
			this.button_DelScheme = new System.Windows.Forms.Button();
			this.button_UpScheme = new System.Windows.Forms.Button();
			this.label_SchemeInf = new System.Windows.Forms.Label();
			this.txbCurrSchema = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgv_ListScheme)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgv_ListScheme
			// 
			this.dgv_ListScheme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_ListScheme.Location = new System.Drawing.Point(4, 68);
			this.dgv_ListScheme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgv_ListScheme.Name = "dgv_ListScheme";
			this.dgv_ListScheme.RowHeadersWidth = 51;
			this.dgv_ListScheme.RowTemplate.Height = 24;
			this.dgv_ListScheme.Size = new System.Drawing.Size(652, 488);
			this.dgv_ListScheme.TabIndex = 7;
			this.dgv_ListScheme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListScheme_CellContentClick);
			// 
			// DeAn
			// 
			this.DeAn.AutoSize = true;
			this.DeAn.Cursor = System.Windows.Forms.Cursors.Default;
			this.DeAn.Location = new System.Drawing.Point(36, 26);
			this.DeAn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.DeAn.Name = "DeAn";
			this.DeAn.Size = new System.Drawing.Size(88, 28);
			this.DeAn.TabIndex = 6;
			this.DeAn.Text = "SCHEME";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkCyan;
			this.panel1.Controls.Add(this.label_SchemeInf);
			this.panel1.Controls.Add(this.txbCurrSchema);
			this.panel1.Controls.Add(this.button_UpScheme);
			this.panel1.Controls.Add(this.button_DelScheme);
			this.panel1.Controls.Add(this.Button_Exit);
			this.panel1.Controls.Add(this.button_AddScheme);
			this.panel1.Location = new System.Drawing.Point(679, 68);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(294, 488);
			this.panel1.TabIndex = 8;
			// 
			// Button_Exit
			// 
			this.Button_Exit.Location = new System.Drawing.Point(184, 415);
			this.Button_Exit.Name = "Button_Exit";
			this.Button_Exit.Size = new System.Drawing.Size(94, 53);
			this.Button_Exit.TabIndex = 9;
			this.Button_Exit.Text = "EXIT";
			this.Button_Exit.UseVisualStyleBackColor = true;
			// 
			// button_AddScheme
			// 
			this.button_AddScheme.BackColor = System.Drawing.Color.Coral;
			this.button_AddScheme.Location = new System.Drawing.Point(18, 206);
			this.button_AddScheme.Name = "button_AddScheme";
			this.button_AddScheme.Size = new System.Drawing.Size(166, 51);
			this.button_AddScheme.TabIndex = 9;
			this.button_AddScheme.Text = "+ ADD ";
			this.button_AddScheme.UseVisualStyleBackColor = false;
			// 
			// button_DelScheme
			// 
			this.button_DelScheme.BackColor = System.Drawing.Color.Coral;
			this.button_DelScheme.Location = new System.Drawing.Point(18, 277);
			this.button_DelScheme.Name = "button_DelScheme";
			this.button_DelScheme.Size = new System.Drawing.Size(166, 51);
			this.button_DelScheme.TabIndex = 10;
			this.button_DelScheme.Text = "- DELETE";
			this.button_DelScheme.UseVisualStyleBackColor = false;
			// 
			// button_UpScheme
			// 
			this.button_UpScheme.BackColor = System.Drawing.Color.Coral;
			this.button_UpScheme.Location = new System.Drawing.Point(18, 355);
			this.button_UpScheme.Name = "button_UpScheme";
			this.button_UpScheme.Size = new System.Drawing.Size(166, 51);
			this.button_UpScheme.TabIndex = 11;
			this.button_UpScheme.Text = "+ UPDATE";
			this.button_UpScheme.UseVisualStyleBackColor = false;
			// 
			// label_SchemeInf
			// 
			this.label_SchemeInf.AutoSize = true;
			this.label_SchemeInf.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_SchemeInf.Location = new System.Drawing.Point(3, 18);
			this.label_SchemeInf.Name = "label_SchemeInf";
			this.label_SchemeInf.Size = new System.Drawing.Size(85, 20);
			this.label_SchemeInf.TabIndex = 13;
			this.label_SchemeInf.Text = "Scheme ID:";
			// 
			// txbCurrSchema
			// 
			this.txbCurrSchema.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbCurrSchema.Location = new System.Drawing.Point(7, 41);
			this.txbCurrSchema.Name = "txbCurrSchema";
			this.txbCurrSchema.Size = new System.Drawing.Size(277, 30);
			this.txbCurrSchema.TabIndex = 12;
			// 
			// UC_DeAn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dgv_ListScheme);
			this.Controls.Add(this.DeAn);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "UC_DeAn";
			this.Size = new System.Drawing.Size(977, 571);
			((System.ComponentModel.ISupportInitialize)(this.dgv_ListScheme)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_ListScheme;
		private System.Windows.Forms.Label DeAn;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button Button_Exit;
		private System.Windows.Forms.Button button_AddScheme;
		private System.Windows.Forms.Button button_UpScheme;
		private System.Windows.Forms.Button button_DelScheme;
		private System.Windows.Forms.Label label_SchemeInf;
		private System.Windows.Forms.TextBox txbCurrSchema;
	}
}
