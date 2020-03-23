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
    public partial class Assistance : Form
    {
        #region 1. Variable Initialization

        #endregion

        #region 2. Form Initialization
        public Assistance()
        {
            InitializeComponent();
        }
        #endregion

        #region 3. HotKeys
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
