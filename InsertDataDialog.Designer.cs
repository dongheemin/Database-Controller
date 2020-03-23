namespace WindowsFormsApplication1
{
    partial class InsertDataDialog
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
            this.FLPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BT_insert = new System.Windows.Forms.Button();
            this.BT_delete = new System.Windows.Forms.Button();
            this.BT_save = new System.Windows.Forms.Button();
            this.BT_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FLPanel1
            // 
            this.FLPanel1.Location = new System.Drawing.Point(12, 14);
            this.FLPanel1.Name = "FLPanel1";
            this.FLPanel1.Size = new System.Drawing.Size(536, 445);
            this.FLPanel1.TabIndex = 0;
            // 
            // BT_insert
            // 
            this.BT_insert.Location = new System.Drawing.Point(12, 465);
            this.BT_insert.Name = "BT_insert";
            this.BT_insert.Size = new System.Drawing.Size(134, 27);
            this.BT_insert.TabIndex = 0;
            this.BT_insert.Text = "Insert Row";
            this.BT_insert.UseVisualStyleBackColor = true;
            this.BT_insert.Click += new System.EventHandler(this.BT_insert_Click);
            // 
            // BT_delete
            // 
            this.BT_delete.Location = new System.Drawing.Point(146, 465);
            this.BT_delete.Name = "BT_delete";
            this.BT_delete.Size = new System.Drawing.Size(134, 27);
            this.BT_delete.TabIndex = 1;
            this.BT_delete.Text = "Delete Row";
            this.BT_delete.UseVisualStyleBackColor = true;
            this.BT_delete.Click += new System.EventHandler(this.BT_delete_Click);
            // 
            // BT_save
            // 
            this.BT_save.Location = new System.Drawing.Point(280, 465);
            this.BT_save.Name = "BT_save";
            this.BT_save.Size = new System.Drawing.Size(134, 27);
            this.BT_save.TabIndex = 2;
            this.BT_save.Text = "Save";
            this.BT_save.UseVisualStyleBackColor = true;
            this.BT_save.Click += new System.EventHandler(this.BT_save_Click);
            // 
            // BT_cancel
            // 
            this.BT_cancel.Location = new System.Drawing.Point(414, 465);
            this.BT_cancel.Name = "BT_cancel";
            this.BT_cancel.Size = new System.Drawing.Size(134, 27);
            this.BT_cancel.TabIndex = 3;
            this.BT_cancel.Text = "Cancel";
            this.BT_cancel.UseVisualStyleBackColor = true;
            this.BT_cancel.Click += new System.EventHandler(this.BT_cancel_Click);
            // 
            // InsertDataDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(556, 506);
            this.Controls.Add(this.BT_cancel);
            this.Controls.Add(this.BT_save);
            this.Controls.Add(this.BT_delete);
            this.Controls.Add(this.BT_insert);
            this.Controls.Add(this.FLPanel1);
            this.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "InsertDataDialog";
            this.Text = "데이터 추가";
            this.Load += new System.EventHandler(this.InsertDataDialog_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InsertDataDialog_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPanel1;
        private System.Windows.Forms.Button BT_insert;
        private System.Windows.Forms.Button BT_delete;
        private System.Windows.Forms.Button BT_save;
        private System.Windows.Forms.Button BT_cancel;
    }
}