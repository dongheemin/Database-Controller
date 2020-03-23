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
    public partial class SearchItemDialog : Form
    {
        #region 1. Variable Declare & Initialization
        private MainForm Main_Form = null;
        #endregion

        #region 2. Form Initialization
        public SearchItemDialog(MainForm Mainform)
        {
            InitializeComponent();
            this.Main_Form = Mainform;
        }
        #endregion

        #region 3. Hot Key Declare
        private void TB_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String str = TB_Search.Text.ToString();
                Main_Form.SearchPass(str);
            }
            else return;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!base.ProcessCmdKey(ref msg, keyData))
            {
                if (keyData.Equals(Keys.Escape))
                {
                    this.Close();
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
    }
}
