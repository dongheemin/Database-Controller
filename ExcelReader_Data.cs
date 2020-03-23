using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using System.Data.OleDb;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class ExcelReader_Data : Form
    {
        MainForm Mainform = null;
        string db = "", sip = "", uid = "", upw = "", route = "";

        public ExcelReader_Data(MainForm Main_Form, string db, string sip, string uid, string upw, string route)
        {
            InitializeComponent();
            this.Mainform = Main_Form;
            this.db = db;
            this.sip = sip;
            this.uid = uid;
            this.upw = upw;
            this.route = route;
        }


        #region Button Method
        private void BT_load_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.Filter = "Microsoft Excel 워크시트| *.xlsx |Excel Files(97~2003)|*.xls";
                    dlg.InitialDirectory = @"./";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        ImportExcelData_Read(dlg.FileName, ExcelDataGridview);
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }

        }

        private void BT_save_Click(object sender, EventArgs e)
        {
            string query = "";
            query += "INSERT INTO " + TB_TableNM.Text.ToString() + "(" + ") Values";
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

        #region ETC Method
        public void ImportExcelData_Read(string fileName, DataGridView dgv)
        {
            // 엑셀 문서 내용 추출
            string connectionString = string.Empty;

            if (File.Exists(fileName))  // 파일 확장자 검사
            {
                if (Path.GetExtension(fileName).ToLower() == ".xls")
                {   // Microsoft.Jet.OLEDB.4.0 은 32 bit 에서만 동작되므로 빌드할 때 64비트로 하면 에러가 발생함.
                    connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0};Extended Properties=Excel 8.0;", fileName);
                }
                else if (Path.GetExtension(fileName).ToLower() == ".xlsx")
                {
                    connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0};Extended Properties=Excel 12.0;", fileName);
                }
            }

            DataSet data = new DataSet();

            string strQuery = "SELECT * FROM [Sheet1$]";  // 엑셀 시트명 Sheet1의 모든 데이터를 가져오기
            OleDbConnection oleConn = new OleDbConnection(connectionString);
            oleConn.Open();

            OleDbCommand oleCmd = new OleDbCommand(strQuery, oleConn);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(oleCmd);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            data.Tables.Add(dataTable);

            dgv.DataSource = data.Tables[0].DefaultView;

            // 데이터에 맞게 칼럼 사이즈 조정하기
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);
            }
            dgv.AllowUserToAddRows = false;  // 빈레코드 표시 안하기
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // 화면크기에 맞춰 채우기

            dataTable.Dispose();
            dataAdapter.Dispose();
            oleCmd.Dispose();

            oleConn.Close();
            oleConn.Dispose();
        }
        #endregion

        private void ExcelReader_Data_Load(object sender, EventArgs e)
        {
            TB_TableNM.Text = route;
            TB_TableNM.ReadOnly = true;
        }
    }
}
