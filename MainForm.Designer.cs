namespace WindowsFormsApplication1
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.connbt = new System.Windows.Forms.Button();
            this.show_tx_log = new System.Windows.Forms.TextBox();
            this.res_grid_view = new System.Windows.Forms.DataGridView();
            this.show_tx_sip = new System.Windows.Forms.TextBox();
            this.show_tx_usr = new System.Windows.Forms.TextBox();
            this.disconnbt = new System.Windows.Forms.Button();
            this.tx_id_bx = new System.Windows.Forms.TextBox();
            this.tx_pw_bx = new System.Windows.Forms.TextBox();
            this.tx_sip_bx = new System.Windows.Forms.TextBox();
            this.lb_sip = new System.Windows.Forms.Label();
            this.lb_uid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.verifibt = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cancelbt = new System.Windows.Forms.Button();
            this.show_tx_route = new System.Windows.Forms.TextBox();
            this.BT_read = new System.Windows.Forms.Button();
            this.BT_Delete = new System.Windows.Forms.Button();
            this.BT_insert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.res_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // connbt
            // 
            this.connbt.Location = new System.Drawing.Point(17, 474);
            this.connbt.Name = "connbt";
            this.connbt.Size = new System.Drawing.Size(96, 29);
            this.connbt.TabIndex = 5;
            this.connbt.Text = "Connect";
            this.connbt.UseVisualStyleBackColor = true;
            this.connbt.Click += new System.EventHandler(this.button1_Click);
            // 
            // show_tx_log
            // 
            this.show_tx_log.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.show_tx_log.Location = new System.Drawing.Point(14, 77);
            this.show_tx_log.Multiline = true;
            this.show_tx_log.Name = "show_tx_log";
            this.show_tx_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.show_tx_log.Size = new System.Drawing.Size(210, 232);
            this.show_tx_log.TabIndex = 9;
            this.show_tx_log.TabStop = false;
            this.show_tx_log.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // res_grid_view
            // 
            this.res_grid_view.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.res_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.res_grid_view.Location = new System.Drawing.Point(230, 44);
            this.res_grid_view.Name = "res_grid_view";
            this.res_grid_view.RowTemplate.Height = 23;
            this.res_grid_view.Size = new System.Drawing.Size(808, 459);
            this.res_grid_view.TabIndex = 10;
            this.res_grid_view.TabStop = false;
            this.res_grid_view.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.res_grid_view_CellValueChanged);
            this.res_grid_view.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.res_grid_view_CellDoubleClick);
            this.res_grid_view.KeyDown += new System.Windows.Forms.KeyEventHandler(this.res_grid_view_KeyDown);
            // 
            // show_tx_sip
            // 
            this.show_tx_sip.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.show_tx_sip.Location = new System.Drawing.Point(14, 15);
            this.show_tx_sip.Name = "show_tx_sip";
            this.show_tx_sip.Size = new System.Drawing.Size(210, 22);
            this.show_tx_sip.TabIndex = 7;
            this.show_tx_sip.TabStop = false;
            // 
            // show_tx_usr
            // 
            this.show_tx_usr.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.show_tx_usr.Location = new System.Drawing.Point(14, 44);
            this.show_tx_usr.Name = "show_tx_usr";
            this.show_tx_usr.Size = new System.Drawing.Size(210, 22);
            this.show_tx_usr.TabIndex = 8;
            this.show_tx_usr.TabStop = false;
            // 
            // disconnbt
            // 
            this.disconnbt.Location = new System.Drawing.Point(128, 474);
            this.disconnbt.Name = "disconnbt";
            this.disconnbt.Size = new System.Drawing.Size(96, 29);
            this.disconnbt.TabIndex = 6;
            this.disconnbt.Text = "Disconnect";
            this.disconnbt.UseVisualStyleBackColor = true;
            this.disconnbt.Click += new System.EventHandler(this.button2_Click);
            // 
            // tx_id_bx
            // 
            this.tx_id_bx.Location = new System.Drawing.Point(79, 357);
            this.tx_id_bx.Name = "tx_id_bx";
            this.tx_id_bx.Size = new System.Drawing.Size(145, 22);
            this.tx_id_bx.TabIndex = 2;
            this.tx_id_bx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tx_id_bx_KeyDown);
            // 
            // tx_pw_bx
            // 
            this.tx_pw_bx.Location = new System.Drawing.Point(79, 385);
            this.tx_pw_bx.Name = "tx_pw_bx";
            this.tx_pw_bx.Size = new System.Drawing.Size(145, 22);
            this.tx_pw_bx.TabIndex = 3;
            this.tx_pw_bx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tx_pw_bx_KeyDown);
            // 
            // tx_sip_bx
            // 
            this.tx_sip_bx.Location = new System.Drawing.Point(79, 329);
            this.tx_sip_bx.Name = "tx_sip_bx";
            this.tx_sip_bx.Size = new System.Drawing.Size(145, 22);
            this.tx_sip_bx.TabIndex = 1;
            this.tx_sip_bx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tx_sip_bx_KeyDown);
            // 
            // lb_sip
            // 
            this.lb_sip.AutoSize = true;
            this.lb_sip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_sip.Location = new System.Drawing.Point(14, 332);
            this.lb_sip.Name = "lb_sip";
            this.lb_sip.Size = new System.Drawing.Size(59, 15);
            this.lb_sip.TabIndex = 11;
            this.lb_sip.Text = "Server IP";
            // 
            // lb_uid
            // 
            this.lb_uid.AutoSize = true;
            this.lb_uid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_uid.Location = new System.Drawing.Point(14, 360);
            this.lb_uid.Name = "lb_uid";
            this.lb_uid.Size = new System.Drawing.Size(50, 15);
            this.lb_uid.TabIndex = 12;
            this.lb_uid.Text = "User ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(14, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "User PW";
            // 
            // verifibt
            // 
            this.verifibt.Location = new System.Drawing.Point(17, 442);
            this.verifibt.Name = "verifibt";
            this.verifibt.Size = new System.Drawing.Size(207, 29);
            this.verifibt.TabIndex = 14;
            this.verifibt.Text = "Verification";
            this.verifibt.UseVisualStyleBackColor = true;
            this.verifibt.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 413);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 23);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // cancelbt
            // 
            this.cancelbt.Location = new System.Drawing.Point(943, 16);
            this.cancelbt.Name = "cancelbt";
            this.cancelbt.Size = new System.Drawing.Size(96, 22);
            this.cancelbt.TabIndex = 16;
            this.cancelbt.Text = "Back";
            this.cancelbt.UseVisualStyleBackColor = true;
            this.cancelbt.Click += new System.EventHandler(this.cancelbt_Click);
            // 
            // show_tx_route
            // 
            this.show_tx_route.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.show_tx_route.Location = new System.Drawing.Point(230, 15);
            this.show_tx_route.Name = "show_tx_route";
            this.show_tx_route.Size = new System.Drawing.Size(302, 22);
            this.show_tx_route.TabIndex = 17;
            this.show_tx_route.TabStop = false;
            // 
            // BT_read
            // 
            this.BT_read.Location = new System.Drawing.Point(841, 16);
            this.BT_read.Name = "BT_read";
            this.BT_read.Size = new System.Drawing.Size(96, 22);
            this.BT_read.TabIndex = 18;
            this.BT_read.Text = "Excel Read";
            this.BT_read.UseVisualStyleBackColor = true;
            this.BT_read.Click += new System.EventHandler(this.BT_save_Click);
            // 
            // BT_Delete
            // 
            this.BT_Delete.Location = new System.Drawing.Point(739, 16);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(96, 22);
            this.BT_Delete.TabIndex = 19;
            this.BT_Delete.Text = "Delete";
            this.BT_Delete.UseVisualStyleBackColor = true;
            this.BT_Delete.Click += new System.EventHandler(this.BT_Delete_Click);
            // 
            // BT_insert
            // 
            this.BT_insert.Location = new System.Drawing.Point(637, 16);
            this.BT_insert.Name = "BT_insert";
            this.BT_insert.Size = new System.Drawing.Size(96, 22);
            this.BT_insert.TabIndex = 20;
            this.BT_insert.Text = "Insert";
            this.BT_insert.UseVisualStyleBackColor = true;
            this.BT_insert.Click += new System.EventHandler(this.BT_insert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(14, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Database";
            // 
            // BT_search
            // 
            this.BT_search.Location = new System.Drawing.Point(535, 16);
            this.BT_search.Name = "BT_search";
            this.BT_search.Size = new System.Drawing.Size(96, 22);
            this.BT_search.TabIndex = 22;
            this.BT_search.Text = "Search";
            this.BT_search.UseVisualStyleBackColor = true;
            this.BT_search.Click += new System.EventHandler(this.BT_search_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1051, 512);
            this.Controls.Add(this.BT_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BT_insert);
            this.Controls.Add(this.BT_Delete);
            this.Controls.Add(this.BT_read);
            this.Controls.Add(this.show_tx_route);
            this.Controls.Add(this.cancelbt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.verifibt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_uid);
            this.Controls.Add(this.lb_sip);
            this.Controls.Add(this.tx_sip_bx);
            this.Controls.Add(this.tx_pw_bx);
            this.Controls.Add(this.tx_id_bx);
            this.Controls.Add(this.disconnbt);
            this.Controls.Add(this.show_tx_usr);
            this.Controls.Add(this.show_tx_sip);
            this.Controls.Add(this.res_grid_view);
            this.Controls.Add(this.show_tx_log);
            this.Controls.Add(this.connbt);
            this.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "MainForm";
            this.Text = "DB 조회";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.res_grid_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connbt;
        private System.Windows.Forms.TextBox show_tx_log;
        private System.Windows.Forms.DataGridView res_grid_view;
        private System.Windows.Forms.TextBox show_tx_sip;
        private System.Windows.Forms.TextBox show_tx_usr;
        private System.Windows.Forms.Button disconnbt;
        private System.Windows.Forms.TextBox tx_sip_bx;
        private System.Windows.Forms.TextBox tx_id_bx;
        private System.Windows.Forms.TextBox tx_pw_bx;
        private System.Windows.Forms.Label lb_sip;
        private System.Windows.Forms.Label lb_uid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button verifibt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button cancelbt;
        private System.Windows.Forms.TextBox show_tx_route;
        private System.Windows.Forms.Button BT_read;
        private System.Windows.Forms.Button BT_Delete;
        private System.Windows.Forms.Button BT_insert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_search;
    }
}

