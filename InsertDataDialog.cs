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
    public partial class InsertDataDialog : Form
    {
        #region 1. Variable Declare & Initialization
        private TextBox[] tbx = new System.Windows.Forms.TextBox[1000];
        private Label[] lb = new System.Windows.Forms.Label[250];
        private MainForm Main_Form = null;
        private int cols = 0;
        private string TBNM = "";
        private string headerTXT = "";
        private string columntyp = "";
        private string[] types = null;
        int i = 0, j = 0;
        #endregion

        #region 2. Form Method
        public InsertDataDialog(MainForm Mainform, string TBNM, int cols, string HeaderTxT, string type)
        {
            InitializeComponent();
            this.Main_Form = Mainform;
            this.TBNM = TBNM;
            this.cols = cols;
            this.headerTXT = HeaderTxT;
            this.columntyp = type;
        }
        private void InsertDataDialog_Load(object sender, EventArgs e)
        {
            types = columntyp.Split('/');

            for (int i = 0; i < lb.Length; i++)
            {
                lb[i] = new Label();
                lb[i].Text = "";
                lb[i].Width = 80;
                lb[i].Visible = true;
                lb[i].Margin = new Padding(0, 5, 0, 0);
            }
            for (int i = 0; i < tbx.Length; i++)
            {
                tbx[i] = new TextBox();
                tbx[i].Width = (int)((FLPanel1.Width-lb[0].Width+5)/(this.cols+1));
                tbx[i].Visible = true;
                if (types[i % cols].Equals("int") || types[i % cols].Equals("numeric") || types[i % cols].Equals("float"))
                {
                    tbx[i].KeyPress += new KeyPressEventHandler(InsertDataDialog_KeyPress_forINT);
                }
            }
        }

        void InsertDataDialog_KeyPress_forINT(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region 3. Button Event
        private void BT_insert_Click(object sender, EventArgs e)
        {
            lb[i].Text = "Row " + (i + 1).ToString();
            FLPanel1.Controls.Add(lb[i]);
            i++;
            for (int k = 0; k < cols; k++)
            {
                FLPanel1.Controls.Add(tbx[j]);
                j++;
            }
            tbx[j - cols].Focus();
        }

        private void BT_delete_Click(object sender, EventArgs e)
        {
            if (i > 0 && j >= cols)
            {
                FLPanel1.Controls.Remove(lb[i - 1]);
                for (int k = 0; k < cols; k++)
                {
                    FLPanel1.Controls.Remove(tbx[j - 1]);
                    if (j > 0) j--;
                    else if (j <= 0) j = 0;
                }
                if (i > 0) i--;
                else if (i <= 0) i = 0;
            }
            else
            {
                return;
            }
        }

        private void BT_save_Click(object sender, EventArgs e)
        {
            String query = "";
            query += "INSERT INTO " + TBNM + "(" + headerTXT + ") VALUES";
            for (int k = 0; k < j; k++)
            {
                if (k % cols == 0)
                {
                    query += "(";
                }
                if (types[k % cols].Equals("int") || types[k % cols].Equals("numeric") || types[k % cols].Equals("float"))
                {
                    query += tbx[k].Text;

                }
                else
                {
                    query += "\'" + tbx[k].Text + "\'";
                }
                if (k % cols < cols - 1 && k % cols >= 0)
                {
                    query += ", ";
                }
                if (k % cols == cols - 1)
                {
                    query += "),";
                }
            }
            query = query.Remove(query.Length - 1);
            Main_Form.QueryPass(query);
            this.Close();

        }

        private void BT_cancel_Click(object sender, EventArgs e)
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

        #region 4. HotKeys
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!base.ProcessCmdKey(ref msg, keyData))
            {
                if (keyData.Equals(Keys.Escape))
                {
                    BT_cancel.PerformClick();
                    return true;
                }
                else if (keyData.Equals(Keys.PageUp))
                {
                    BT_insert.PerformClick();
                    return true;
                }
                else if (keyData.Equals(Keys.PageDown))
                {
                    BT_delete.PerformClick();
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

        private void InsertDataDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

    }
}
