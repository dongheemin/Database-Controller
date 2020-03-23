namespace WindowsFormsApplication1
{
    partial class ExcelReader
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
            this.label1 = new System.Windows.Forms.Label();
            this.ExcelGridView = new System.Windows.Forms.DataGridView();
            this.CB_dbNM = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_tableNM = new System.Windows.Forms.TextBox();
            this.BT_save = new System.Windows.Forms.Button();
            this.BT_cancel = new System.Windows.Forms.Button();
            this.BT_load = new System.Windows.Forms.Button();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_keyValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExcelGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "InputDB";
            // 
            // ExcelGridView
            // 
            this.ExcelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExcelGridView.Location = new System.Drawing.Point(12, 177);
            this.ExcelGridView.Name = "ExcelGridView";
            this.ExcelGridView.RowTemplate.Height = 23;
            this.ExcelGridView.Size = new System.Drawing.Size(713, 413);
            this.ExcelGridView.TabIndex = 1;
            // 
            // CB_dbNM
            // 
            this.CB_dbNM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_dbNM.FormattingEnabled = true;
            this.CB_dbNM.Location = new System.Drawing.Point(114, 10);
            this.CB_dbNM.Name = "CB_dbNM";
            this.CB_dbNM.Size = new System.Drawing.Size(121, 22);
            this.CB_dbNM.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Table Name";
            // 
            // TB_tableNM
            // 
            this.TB_tableNM.Location = new System.Drawing.Point(114, 42);
            this.TB_tableNM.Name = "TB_tableNM";
            this.TB_tableNM.Size = new System.Drawing.Size(121, 21);
            this.TB_tableNM.TabIndex = 4;
            // 
            // BT_save
            // 
            this.BT_save.Location = new System.Drawing.Point(547, 9);
            this.BT_save.Name = "BT_save";
            this.BT_save.Size = new System.Drawing.Size(88, 23);
            this.BT_save.TabIndex = 5;
            this.BT_save.Text = "Save Table";
            this.BT_save.UseVisualStyleBackColor = true;
            this.BT_save.Click += new System.EventHandler(this.BT_save_Click);
            // 
            // BT_cancel
            // 
            this.BT_cancel.Location = new System.Drawing.Point(638, 9);
            this.BT_cancel.Name = "BT_cancel";
            this.BT_cancel.Size = new System.Drawing.Size(88, 23);
            this.BT_cancel.TabIndex = 6;
            this.BT_cancel.Text = "Cancel";
            this.BT_cancel.UseVisualStyleBackColor = true;
            this.BT_cancel.Click += new System.EventHandler(this.BT_cancel_Click);
            // 
            // BT_load
            // 
            this.BT_load.Location = new System.Drawing.Point(456, 9);
            this.BT_load.Name = "BT_load";
            this.BT_load.Size = new System.Drawing.Size(88, 23);
            this.BT_load.TabIndex = 7;
            this.BT_load.Text = "Load Excel";
            this.BT_load.UseVisualStyleBackColor = true;
            this.BT_load.Click += new System.EventHandler(this.BT_load_Click);
            // 
            // FLP
            // 
            this.FLP.AutoScroll = true;
            this.FLP.Location = new System.Drawing.Point(12, 72);
            this.FLP.Name = "FLP";
            this.FLP.Size = new System.Drawing.Size(713, 99);
            this.FLP.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(247, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Key Value";
            // 
            // TB_keyValue
            // 
            this.TB_keyValue.Location = new System.Drawing.Point(339, 42);
            this.TB_keyValue.Name = "TB_keyValue";
            this.TB_keyValue.Size = new System.Drawing.Size(121, 21);
            this.TB_keyValue.TabIndex = 10;
            // 
            // ExcelReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(737, 602);
            this.Controls.Add(this.TB_keyValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FLP);
            this.Controls.Add(this.BT_load);
            this.Controls.Add(this.BT_cancel);
            this.Controls.Add(this.BT_save);
            this.Controls.Add(this.TB_tableNM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_dbNM);
            this.Controls.Add(this.ExcelGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "ExcelReader";
            this.Text = "ExcelReader";
            this.Load += new System.EventHandler(this.ExcelReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExcelGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ExcelGridView;
        private System.Windows.Forms.ComboBox CB_dbNM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_tableNM;
        private System.Windows.Forms.Button BT_save;
        private System.Windows.Forms.Button BT_cancel;
        private System.Windows.Forms.Button BT_load;
        private System.Windows.Forms.FlowLayoutPanel FLP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_keyValue;
    }
}