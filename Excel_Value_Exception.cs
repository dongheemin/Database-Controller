using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Excel_Value_Exception : System.Exception
    {
        private string EMessage = "";
        
        public Excel_Value_Exception(String CODE)
        {
            if (CODE.Equals("SQ001"))
            {
                this.EMessage = "동일한 테이블 명이 있습니다.";
            }

            else if (CODE.Equals("SQ002"))
            {
                this.EMessage = "동일한 기본 키 값이 있습니다.";
            }
        }

        public void show(){
            MessageBox.Show(EMessage);
        }
    }
}
