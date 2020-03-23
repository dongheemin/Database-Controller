using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class InsertTableDialog : Form
    {
        #region 1. Variable Declare & Initialization
        private string uid, upw, sip, db;
        private TextBox[] tbx = new System.Windows.Forms.TextBox[1000];
        private Label[] lb = new System.Windows.Forms.Label[1000];
        private ComboBox[] cbx1 = new System.Windows.Forms.ComboBox[1000];
        private ComboBox[] cbx2 = new System.Windows.Forms.ComboBox[1000];
        private MainForm Main_Form = null;
        int i = 0;
        #endregion

        #region 2. Form Initialization
        public InsertTableDialog(MainForm MainForm, string db, string sip, string uid, string upw)
        {
            InitializeComponent();
            this.Main_Form = MainForm;
            this.uid = uid;
            this.upw = upw;
            this.sip = sip;
            this.db = db;
        }
        #endregion

        #region 3. Button Events
        private void BT_ADD_column_Click(object sender, EventArgs e)
        {
            lb[i].Text = "Row " + (i+1).ToString();
            flowLayoutPanel1.Controls.Add(lb[i]);
            flowLayoutPanel1.Controls.Add(tbx[i]);
            flowLayoutPanel1.Controls.Add(cbx1[i]);
            flowLayoutPanel1.Controls.Add(cbx2[i]);
            tbx[i].Focus();
            i++;
        }

        private void BT_DEL_column_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Remove(lb[i]);
            flowLayoutPanel1.Controls.Remove(tbx[i]);
            flowLayoutPanel1.Controls.Remove(cbx1[i]);
            flowLayoutPanel1.Controls.Remove(cbx2[i]);
            if (i > 0) i--;
            else if (i <= 0) i = 0;
            
        }

        private void BT_OK_Click(object sender, EventArgs e)
        {
            String query = "";
            query += "CREATE TABLE " + TB_tablename.Text.ToString()+"(\n";
            for (int j = 0; j < i; j++)
            {
                query += tbx[j].Text + " " + cbx1[j].Text + "(20) " + cbx2[j].Text + ",\n";
            }
            query += "CONSTRAINT PK_" + TB_tablename.Text.ToString() + " PRIMARY KEY("+TB_Key.Text.ToString()+"))";


            if (MessageBox.Show("테이블을 추가하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Main_Form.QueryPass(query);
                this.Close();
            }
            else
            {
                return;
            }
            

        }

        private void BT_CANCEL_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("입력 정보는 저장되지 않습니다.", "Notice", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
            
        }
        #endregion

        #region 4. Form_load Module
        private void InsertTableDialog_Load(object sender, EventArgs e)
        {
            string[] cbx1data = {"CHAR", "VARCHAR", "INT", "NUMERIC", "FLOAT"};
            string[] cbx2data = {"", "NOT NULL", "DEFAULT" };
            for (int i = 0; i < tbx.Length; i++)
            {
                tbx[i] = new TextBox();
                tbx[i].Width = 150;
                tbx[i].Visible = true;
            }
            for (int i = 0; i < lb.Length; i++)
            {
                lb[i] = new Label();
                lb[i].Text = "";
                lb[i].Width = 80;
                lb[i].Visible = true;
                lb[i].Margin = new Padding(0, 5, 0, 0);
            }
            for (int i = 0; i < cbx1.Length; i++)
            {
                cbx1[i] = new ComboBox();
                cbx1[i].Width = 90;
                cbx1[i].Visible = true;
                cbx1[i].Items.AddRange(cbx1data);
                cbx1[i].SelectedIndex = 0;
                cbx1[i].DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            }
            for (int i = 0; i < cbx2.Length; i++)
            {
                cbx2[i] = new ComboBox();
                cbx2[i].Width = 90;
                cbx2[i].Visible = true;
                cbx2[i].Items.AddRange(cbx2data);
                cbx2[i].SelectedIndex = 0;
                cbx2[i].DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            }
        }
        #endregion

        #region 5. HotKeys
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!base.ProcessCmdKey(ref msg, keyData))
            {
                if (keyData.Equals(Keys.Escape))
                {
                    BT_CANCEL.PerformClick();
                    return true;
                }
                else if (keyData.Equals(Keys.PageUp))
                {
                    BT_ADD_column.PerformClick();
                    return true;
                }
                else if (keyData.Equals(Keys.PageDown))
                {
                    BT_DEL_column.PerformClick();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
        #endregion

        private void InsertTableDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void BT_load_excel_Click(object sender, EventArgs e)
        {
            ExcelReader form = new ExcelReader(Main_Form, db, sip, uid, upw);
            form.Show();

            this.Close();

        }
    }
}
