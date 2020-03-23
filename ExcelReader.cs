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
    public partial class ExcelReader : Form
    {
        #region 1. Variable Declare & Initialize
        private MainForm Mainform = null;
        private string DBlist = "";
        private string sip = "", uid = "", upw = "";
        private Label[] lb = new Label[1000];
        private ComboBox[] cbx_type = new ComboBox[1000];
        private ComboBox[] cbx_oppt = new ComboBox[1000];
        private TextBox[] tbx_nm = new TextBox[1000]; 
        private string[] cbx_type_str = { "CHAR", "VARCHAR", "INT", "NUMERIC", "FLOAT" };
        private string[] cbx_oppt_str = { "", "NOT NULL", "DEFAULT" };
        private int Count = 0;
        #endregion

        #region 2. Form Method
        public ExcelReader(MainForm mainform, string DBlist, string sip, string uid, string upw)
        {
            InitializeComponent();
            this.Mainform = mainform;
            this.DBlist = DBlist;
            this.sip = sip;
            this.uid = uid;
            this.upw = upw;
        }

        private void ExcelReader_Load(object sender, EventArgs e)
        {
            

        }
        #endregion

        #region 3. Button Event
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
                        ImportExcelData_Read(dlg.FileName, ExcelGridView);
                    }
                }

                Count = ExcelGridView.Columns.Count;

                for (int i = 0; i < Count; i++)
                {
                    FLP.Controls.Add(lb[i]);
                    FLP.Controls.Add(tbx_nm[i]);
                    FLP.Controls.Add(cbx_type[i]);
                    FLP.Controls.Add(cbx_oppt[i]);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
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

        private void BT_save_Click(object sender, EventArgs e)
        {
            string query = "";
            string connectionstring = "server = " + sip + "; uid = " + uid + "; pwd = " + upw + "; database = " + CB_dbNM.SelectedItem + ";";
            SqlConnection sqlConn = new SqlConnection(connectionstring);
            SqlCommand sqlComm;
            try
            {
                sqlConn.Open();
                //**********************************************************
                //테이블 중복 예외처리 구간 시작
                query = "";
                query += "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";
                sqlComm = new SqlCommand();
                sqlComm.Connection = sqlConn;
                sqlComm.CommandText = query;
                using (SqlDataReader SqlRs = sqlComm.ExecuteReader())
                {
                    while (SqlRs.Read())
                    {
                        //시스템DB, ReportDB 회피용 조건문
                        if (SqlRs[0].ToString().Equals(TB_tableNM.Text.ToString()))
                        {
                            throw new Excel_Value_Exception("SQ001");
                        }
                    }
                }

               

                //끝
                //**********************************************************
                //**********************************************************
                //테이블 데이터 예외처리 구간 시작
                //1. Key내 중복 검증
                int keyIndex = 0;
                for (int i = 0; i < Count; i++)
                {
                    if (ExcelGridView.Columns[i].HeaderText.ToString().Equals(TB_keyValue.Text.ToString()))
                    {
                        keyIndex++;
                    }
                }

                for (int i = 1; i < ExcelGridView.Rows.Count; i++)
                {
                    if (ExcelGridView.Rows[i - 1].Cells[keyIndex].Value.ToString().Equals(ExcelGridView.Rows[i].Cells[keyIndex].Value.ToString()))
                    {
                        throw new Excel_Value_Exception("SQ002");
                    }
                }
                //끝
                //***********************************************************


                query = "";
                query += "CREATE TABLE " + TB_tableNM.Text.ToString() + "(\n";
                for (int j = 0; j < Count; j++)
                {
                    query += tbx_nm[j].Text + " " + cbx_type[j].Text + "(20) " + cbx_oppt[j].Text + ",\n";
                }
                query += "CONSTRAINT PK_" + TB_tableNM.Text.ToString() + " PRIMARY KEY(" + TB_keyValue.Text.ToString() + "))";
                sqlComm = new SqlCommand();
                sqlComm.Connection = sqlConn;
                sqlComm.CommandText = query;
                sqlComm.ExecuteNonQuery();

                
                query = "";
                query += "INSERT INTO " + TB_tableNM.Text.ToString() + "(";
                for (int i = 0; i < Count; i++)
                {
                    query += tbx_nm[i].Text + ", ";
                }
                query = query.Remove(query.Length - 2);
                query += ") VALUES";

                for (int i = 0; i < ExcelGridView.Rows.Count; i++)
                {
                    query += "(";
                    for (int j = 0; j < Count; j++)
                    {
                        if (ExcelGridView.Columns[j].HeaderText.ToString().Equals("INT") || ExcelGridView.Columns[j].HeaderText.ToString().Equals("NUMERIC") || ExcelGridView.Columns[j].HeaderText.ToString().Equals("FLOAT"))
                        {
                            query += ExcelGridView.Rows[i].Cells[j].Value.ToString() + ", ";
                        }
                        else
                        {
                            query += "\'" + ExcelGridView.Rows[i].Cells[j].Value.ToString() + "\', ";
                        }
                    }
                    query = query.Remove(query.Length-2);
                    query += "), ";
                }
                query = query.Remove(query.Length - 2);
                sqlComm.CommandText = query;
                sqlComm.ExecuteNonQuery();


                MessageBox.Show("저장되었습니다");
                
                this.Close();
                

            }
            catch (Excel_Value_Exception E)
            {
                E.show();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
            
            finally
            {
                sqlConn.Close();
            }
        }
        #endregion

        #region 4. ETC Methods
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

            setupControls();
        }

        private void setupControls()
        {
            string[] list = null;
            list = DBlist.Split('/');

            for (int i = 0; i < list.Length; i++)
            {
                CB_dbNM.Items.Add(list[i]);
            }
            CB_dbNM.SelectedIndex = 0;

            for (int i = 0; i < lb.Length; i++)
            {
                lb[i] = new Label();
                lb[i].Text = "Column " + i.ToString();
                lb[i].Visible = true;
                lb[i].Margin = new Padding(0, 5, 0, 0);
            }
            for (int i = 0; i < tbx_nm.Length; i++)
            {
                tbx_nm[i] = new TextBox();
                tbx_nm[i].Width = (int)(FLP.Width / 4);
                tbx_nm[i].Visible = true;
            }
            for (int i = 0; i < cbx_type.Length; i++)
            {
                cbx_type[i] = new ComboBox();
                cbx_type[i].Width = (int)(FLP.Width / 4);
                cbx_type[i].Visible = true;
                cbx_type[i].Items.AddRange(cbx_type_str);
                cbx_type[i].SelectedIndex = 0;
                cbx_type[i].DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            }
            for (int i = 0; i < cbx_type.Length; i++)
            {
                cbx_oppt[i] = new ComboBox();
                cbx_oppt[i].Width = (int)(FLP.Width / 4);
                cbx_oppt[i].Visible = true;
                cbx_oppt[i].Items.AddRange(cbx_oppt_str);
                cbx_oppt[i].SelectedIndex = 0;
                cbx_oppt[i].DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            }
        }
        #endregion

        

        

        

    }
}
