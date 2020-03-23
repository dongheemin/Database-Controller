namespace WindowsFormsApplication1
{
    partial class InsertTableDialog
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
            this.TB_tablename = new System.Windows.Forms.TextBox();
            this.BT_ADD_column = new System.Windows.Forms.Button();
            this.BT_DEL_column = new System.Windows.Forms.Button();
            this.BT_OK = new System.Windows.Forms.Button();
            this.BT_CANCEL = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TB_Key = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_load_excel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TableName";
            // 
            // TB_tablename
            // 
            this.TB_tablename.Location = new System.Drawing.Point(98, 15);
            this.TB_tablename.Name = "TB_tablename";
            this.TB_tablename.Size = new System.Drawing.Size(161, 25);
            this.TB_tablename.TabIndex = 1;
            // 
            // BT_ADD_column
            // 
            this.BT_ADD_column.Location = new System.Drawing.Point(10, 335);
            this.BT_ADD_column.Name = "BT_ADD_column";
            this.BT_ADD_column.Size = new System.Drawing.Size(81, 23);
            this.BT_ADD_column.TabIndex = 23;
            this.BT_ADD_column.TabStop = false;
            this.BT_ADD_column.Text = "Add";
            this.BT_ADD_column.UseVisualStyleBackColor = true;
            this.BT_ADD_column.Click += new System.EventHandler(this.BT_ADD_column_Click);
            // 
            // BT_DEL_column
            // 
            this.BT_DEL_column.Location = new System.Drawing.Point(102, 335);
            this.BT_DEL_column.Name = "BT_DEL_column";
            this.BT_DEL_column.Size = new System.Drawing.Size(81, 23);
            this.BT_DEL_column.TabIndex = 24;
            this.BT_DEL_column.TabStop = false;
            this.BT_DEL_column.Text = "Delete";
            this.BT_DEL_column.UseVisualStyleBackColor = true;
            this.BT_DEL_column.Click += new System.EventHandler(this.BT_DEL_column_Click);
            // 
            // BT_OK
            // 
            this.BT_OK.Location = new System.Drawing.Point(285, 335);
            this.BT_OK.Name = "BT_OK";
            this.BT_OK.Size = new System.Drawing.Size(80, 23);
            this.BT_OK.TabIndex = 25;
            this.BT_OK.TabStop = false;
            this.BT_OK.Text = "Save";
            this.BT_OK.UseVisualStyleBackColor = true;
            this.BT_OK.Click += new System.EventHandler(this.BT_OK_Click);
            // 
            // BT_CANCEL
            // 
            this.BT_CANCEL.Location = new System.Drawing.Point(376, 335);
            this.BT_CANCEL.Name = "BT_CANCEL";
            this.BT_CANCEL.Size = new System.Drawing.Size(80, 23);
            this.BT_CANCEL.TabIndex = 26;
            this.BT_CANCEL.TabStop = false;
            this.BT_CANCEL.Text = "Cancel";
            this.BT_CANCEL.UseVisualStyleBackColor = true;
            this.BT_CANCEL.Click += new System.EventHandler(this.BT_CANCEL_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 46);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(448, 283);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // TB_Key
            // 
            this.TB_Key.Location = new System.Drawing.Point(306, 15);
            this.TB_Key.Name = "TB_Key";
            this.TB_Key.Size = new System.Drawing.Size(153, 25);
            this.TB_Key.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Key";
            // 
            // BT_load_excel
            // 
            this.BT_load_excel.Location = new System.Drawing.Point(194, 335);
            this.BT_load_excel.Name = "BT_load_excel";
            this.BT_load_excel.Size = new System.Drawing.Size(80, 23);
            this.BT_load_excel.TabIndex = 30;
            this.BT_load_excel.TabStop = false;
            this.BT_load_excel.Text = "Load";
            this.BT_load_excel.UseVisualStyleBackColor = true;
            this.BT_load_excel.Click += new System.EventHandler(this.BT_load_excel_Click);
            // 
            // InsertTableDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(471, 370);
            this.Controls.Add(this.BT_load_excel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Key);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.BT_CANCEL);
            this.Controls.Add(this.BT_OK);
            this.Controls.Add(this.BT_DEL_column);
            this.Controls.Add(this.BT_ADD_column);
            this.Controls.Add(this.TB_tablename);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InsertTableDialog";
            this.Text = "테이블 추가";
            this.Load += new System.EventHandler(this.InsertTableDialog_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InsertTableDialog_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_tablename;
        private System.Windows.Forms.Button BT_ADD_column;
        private System.Windows.Forms.Button BT_DEL_column;
        private System.Windows.Forms.Button BT_OK;
        private System.Windows.Forms.Button BT_CANCEL;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox TB_Key;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_load_excel;
    }
}