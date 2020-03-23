namespace WindowsFormsApplication1
{
    partial class ExcelReader_Data
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
            this.TB_TableNM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_load = new System.Windows.Forms.Button();
            this.BT_save = new System.Windows.Forms.Button();
            this.BT_cancel = new System.Windows.Forms.Button();
            this.ExcelDataGridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ExcelDataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_TableNM
            // 
            this.TB_TableNM.Location = new System.Drawing.Point(112, 12);
            this.TB_TableNM.Name = "TB_TableNM";
            this.TB_TableNM.Size = new System.Drawing.Size(171, 21);
            this.TB_TableNM.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table Name";
            // 
            // BT_load
            // 
            this.BT_load.Location = new System.Drawing.Point(289, 11);
            this.BT_load.Name = "BT_load";
            this.BT_load.Size = new System.Drawing.Size(96, 23);
            this.BT_load.TabIndex = 2;
            this.BT_load.Text = "Load";
            this.BT_load.UseVisualStyleBackColor = true;
            this.BT_load.Click += new System.EventHandler(this.BT_load_Click);
            // 
            // BT_save
            // 
            this.BT_save.Location = new System.Drawing.Point(386, 11);
            this.BT_save.Name = "BT_save";
            this.BT_save.Size = new System.Drawing.Size(96, 23);
            this.BT_save.TabIndex = 3;
            this.BT_save.Text = "Save";
            this.BT_save.UseVisualStyleBackColor = true;
            this.BT_save.Click += new System.EventHandler(this.BT_save_Click);
            // 
            // BT_cancel
            // 
            this.BT_cancel.Location = new System.Drawing.Point(483, 11);
            this.BT_cancel.Name = "BT_cancel";
            this.BT_cancel.Size = new System.Drawing.Size(96, 23);
            this.BT_cancel.TabIndex = 4;
            this.BT_cancel.Text = "Cancel";
            this.BT_cancel.UseVisualStyleBackColor = true;
            this.BT_cancel.Click += new System.EventHandler(this.BT_cancel_Click);
            // 
            // ExcelDataGridview
            // 
            this.ExcelDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExcelDataGridview.Location = new System.Drawing.Point(15, 39);
            this.ExcelDataGridview.Name = "ExcelDataGridview";
            this.ExcelDataGridview.RowTemplate.Height = 23;
            this.ExcelDataGridview.Size = new System.Drawing.Size(564, 451);
            this.ExcelDataGridview.TabIndex = 5;
            // 
            // ExcelReader_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(591, 502);
            this.Controls.Add(this.ExcelDataGridview);
            this.Controls.Add(this.BT_cancel);
            this.Controls.Add(this.BT_save);
            this.Controls.Add(this.BT_load);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_TableNM);
            this.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "ExcelReader_Data";
            this.Text = "엑셀에서 데이터 추가";
            this.Load += new System.EventHandler(this.ExcelReader_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExcelDataGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_TableNM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_load;
        private System.Windows.Forms.Button BT_save;
        private System.Windows.Forms.Button BT_cancel;
        private System.Windows.Forms.DataGridView ExcelDataGridview;
    }
}