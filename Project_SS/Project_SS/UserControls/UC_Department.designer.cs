namespace Project_SS.UserControls
{
    partial class UC_Department
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
            this.department_DataGrid = new System.Windows.Forms.DataGridView();
            this.name_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.name_Text = new System.Windows.Forms.TextBox();
            this.idTP_Text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.department_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // department_DataGrid
            // 
            this.department_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.department_DataGrid.Location = new System.Drawing.Point(45, 57);
            this.department_DataGrid.Name = "department_DataGrid";
            this.department_DataGrid.RowHeadersWidth = 51;
            this.department_DataGrid.RowTemplate.Height = 24;
            this.department_DataGrid.Size = new System.Drawing.Size(1385, 374);
            this.department_DataGrid.TabIndex = 0;
            this.department_DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.department_DataGrid_CellContentClick);
            // 
            // name_Label
            // 
            this.name_Label.AutoSize = true;
            this.name_Label.Location = new System.Drawing.Point(29, 495);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(44, 16);
            this.name_Label.TabIndex = 2;
            this.name_Label.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 552);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Truong phong";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(841, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 69);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(811, 562);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 63);
            this.button2.TabIndex = 5;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // name_Text
            // 
            this.name_Text.Location = new System.Drawing.Point(190, 495);
            this.name_Text.Name = "name_Text";
            this.name_Text.Size = new System.Drawing.Size(100, 22);
            this.name_Text.TabIndex = 6;
            // 
            // idTP_Text
            // 
            this.idTP_Text.Location = new System.Drawing.Point(190, 552);
            this.idTP_Text.Name = "idTP_Text";
            this.idTP_Text.Size = new System.Drawing.Size(100, 22);
            this.idTP_Text.TabIndex = 7;
            // 
            // UC_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.idTP_Text);
            this.Controls.Add(this.name_Text);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name_Label);
            this.Controls.Add(this.department_DataGrid);
            this.Name = "UC_Department";
            this.Size = new System.Drawing.Size(1486, 719);
            ((System.ComponentModel.ISupportInitialize)(this.department_DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView department_DataGrid;
        private System.Windows.Forms.Label name_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox name_Text;
        private System.Windows.Forms.TextBox idTP_Text;
    }
}
