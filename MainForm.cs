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
    public partial class MainForm : Form
    {
        #region 1. Variable Declare & Initialization
        private SqlConnection sqlConn = new SqlConnection();
        private SqlCommand sqlComm;
        private String sip = "", uid = "", upw = "", sdb = "";
        private string connectionString = "";
        private DataSet ds;
        private string route = "";
        private SqlDataAdapter da;
        private string DBlist = "";
        #endregion
        
        #region 2. Form_initialization
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region 3. Form Method
        #region 3-1. Form Loading Method(폼이 켜질때 돌아가는 애들)
        private void Form1_Load(object sender, EventArgs e)
        {
            show_tx_log.Text = "SQL 결과 조회";
            show_tx_log.ReadOnly = true;        //읽기 전용 창 생성
            show_tx_sip.Text = "접속 서버 : ";
            show_tx_sip.ReadOnly = true;        //읽기 전용 창 생성
            show_tx_usr.Text = "접속자 : ";
            show_tx_usr.ReadOnly = true;
            show_tx_route.ReadOnly = true;
            tx_sip_bx.Text = "192.168.22.13";   //귀찮아서 넣어둠
            tx_id_bx.Text = "sa";               //귀찮아서 넣어둠
            tx_pw_bx.PasswordChar = '*';        //패스워드 *표처리
            connbt.Enabled = false;
            this.ActiveControl = tx_sip_bx;
        }
        #endregion
        #region 3-2. Form_Closing Method(폼이 꺼질 때 돌아가는 애들)
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("접속을 종료합니다");
            //종료 후 sql 연결 된 경우 연결 해제
            if (sqlConn != null && sqlConn.State == ConnectionState.Open)
            {
                sqlConn.Close();
            }
        }
        #endregion
        #endregion

        #region 4. Button Event Method
        #region 4-1. Connection Button Click Method(연결버튼이 클릭됬을 때, PW 입력창에서 엔터키가 눌렸을때)
        private void button1_Click(object sender, EventArgs e)
        {
            //재연결 방지
            if (sqlConn != null && sqlConn.State == ConnectionState.Open)
            {
                show_tx_log.Text = "이미 연결되어 있습니다.";
                return;
            }

            //값 획득
            show_tx_log.Text = "";
            sip = tx_sip_bx.Text;
            uid = tx_id_bx.Text;
            upw = tx_pw_bx.Text;
            sdb = comboBox1.Text;

            //유효성 검사
            if (sip.Equals("") || uid.Equals("") || upw.Equals("") || sdb.Equals(""))
            {
                show_tx_log.Text = "잘못된 정보를 입력하셨습니다. \r\n다시 입력 후 접속해주세요. \r\n";
                return;
            }

            //SQL 연결정보 생성
            connectionString = "server = "+sip+"; uid = "+uid+"; pwd = "+upw+"; database = "+sdb+";";
            sqlConn = new SqlConnection(connectionString);

            //접속 시도
            try
            {
                sqlConn.Open();
                show_tx_log.Text = "연결 성공\r\n";
                show_tx_sip.Text = sip;//현재 서버 정보 제공
                show_tx_usr.Text = uid;//현재 사용자 정보 제공
                connbt.Enabled = false;
                show_tx_route.Text = "/DB."+sdb+"/";


                tx_sip_bx.BackColor = System.Drawing.SystemColors.ScrollBar;
                tx_sip_bx.ReadOnly = true;
                tx_id_bx.BackColor = System.Drawing.SystemColors.ScrollBar;
                tx_id_bx.ReadOnly = true;
                tx_pw_bx.BackColor = System.Drawing.SystemColors.ScrollBar;
                tx_pw_bx.ReadOnly = true;

                sqlComm = new SqlCommand();
                sqlComm.Connection = sqlConn;
                sqlComm.CommandText = "SELECT TABLE_NAME, TABLE_TYPE FROM INFORMATION_SCHEMA.TABLES"; //테이블 조회 쿼리
                da = new SqlDataAdapter(sqlComm); //어댑터로 데이터 획득?
                ds = new DataSet();//데이터셋 생성
                da.Fill(ds, "Tables");//데이터 전달
                res_grid_view.ReadOnly = true;
                

                res_grid_view.DataSource = ds; 
                res_grid_view.DataMember = "Tables";
            }
            //연결 중 에러 발생
            catch (Exception ero)
            {
                show_tx_log.Text = "에러발생 연결해제\r\n"+ero.ToString();
                sqlConn.Close();
                return;
            }
        }
        #endregion
        #region 4-2. DisConnection Button Click Method(연결해제 버튼이 클릭됬을 때)
        private void button2_Click(object sender, EventArgs e)
        {
            if (sqlConn != null && sqlConn.State == ConnectionState.Closed)
                show_tx_log.Text = "연결되지 않았습니다. \r\n";
            else
            {
                sqlConn.Close();
                sqlConn = null;
                res_grid_view.Columns.Clear();
                //res_grid_view.Rows.Clear();
                res_grid_view.Refresh();
                tx_sip_bx.BackColor = System.Drawing.SystemColors.Window;
                tx_sip_bx.ReadOnly = false;
                tx_id_bx.BackColor = System.Drawing.SystemColors.Window;
                tx_id_bx.ReadOnly = false;
                tx_pw_bx.BackColor = System.Drawing.SystemColors.Window;
                tx_pw_bx.ReadOnly = false;
                show_tx_log.Text = "연결 종료\r\n";
                show_tx_sip.Text = "접속 서버 : ";
                show_tx_usr.Text = "접속자 : ";
                tx_id_bx.Text = "";
                tx_pw_bx.Text = "";
                tx_sip_bx.Text = "";
                verifibt.Enabled = true;
                connbt.Enabled = false;
                comboBox1.Items.Clear();
                comboBox1.Text = "";
                show_tx_route.Text = "";
            }
        }
        #endregion
        #region 4-3. Verification Method(with ComboBox)(검증이벤트)
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (sqlConn != null && sqlConn.State == ConnectionState.Open)
            {
                show_tx_log.Text = "이미 연결되어 있습니다.";
                return;
            }

            string[] data = { };
            DBlist = "";
            show_tx_log.Text = "";
            sip = tx_sip_bx.Text;
            uid = tx_id_bx.Text;
            upw = tx_pw_bx.Text;

            //유효성 검사
            if (sip.Equals("") || uid.Equals("") || upw.Equals(""))
            {
                show_tx_log.Text = "잘못된 정보를 입력하셨습니다. \r\n다시 입력 후 접속해주세요. \r\n";
                return;
            }

            //SQL 연결정보 생성
            connectionString = "server = " + sip + "; uid = " + uid + "; pwd = " + upw + ";";
            sqlConn = new SqlConnection(connectionString);

            //접속 시도
            try
            {
                sqlConn.Open();
                MessageBox.Show("검증 성공");
                sqlComm = new SqlCommand();
                sqlComm.Connection = sqlConn;
                sqlComm.CommandText = "SELECT * FROM SYS.SYSDATABASES"; //테이블 조회 쿼리
                using (SqlDataReader SqlRs = sqlComm.ExecuteReader())
                {
                    int i = 0;
                    while (SqlRs.Read())
                    {
                        //시스템DB, ReportDB 회피용 조건문
                        if (i > 5)
                        {                            
                            comboBox1.Items.Add(SqlRs[0].ToString());
                            DBlist += SqlRs[0].ToString()+"/";
                        }
                        i++;
                    }
                }
                comboBox1.SelectedIndex = 0;
                connbt.Enabled = true;
                verifibt.Enabled = false;
            }
            //연결 중 에러 발생
            catch (Exception ero)
            {
                show_tx_log.Text += "에러발생 검증실패\r\n" + ero.ToString();
            }
            finally
            {
                sqlConn.Close();
            }
        }
        #endregion
        #region 4-4. Back Method(with TextBox)(뒤로가기)
        private void cancelbt_Click(object sender, EventArgs e)
        {
            if (!connbt.Enabled && !verifibt.Enabled)
            {
                if (res_grid_view.DataMember.ToString().Equals("Data"))
                {
                    sqlComm.CommandText = "SELECT TABLE_NAME, TABLE_TYPE FROM INFORMATION_SCHEMA.TABLES";
                    da = new SqlDataAdapter(sqlComm); //어댑터로 데이터 획득?
                    ds = new DataSet();//데이터셋 생성
                    da.Fill(ds, "Tables");//데이터 전달

                    show_tx_route.Text = "/DB." + sdb + "/";

                    res_grid_view.DataSource = ds;
                    res_grid_view.DataMember = "Tables";
                    res_grid_view.ReadOnly = true;
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("연결 후에 사용해주세요");
            }
        }
        #endregion
        #region 4-5. Column Insert Method(행삽입)
        private void BT_insert_Click(object sender, EventArgs e)
        {
            if (!connbt.Enabled && !verifibt.Enabled && res_grid_view.DataMember.ToString().Equals("Tables"))
            {
                InsertTableDialog ITD = new InsertTableDialog(this, DBlist, sip, uid, upw);
                ITD.Show();
            }
            else if (!connbt.Enabled && !verifibt.Enabled && res_grid_view.DataMember.ToString().Equals("Data"))
            {
                string columnstr = "";
                string columntyp = "";
                sqlComm.CommandText = "SELECT DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = \'"+ route+"\'";
                sqlComm.ExecuteNonQuery();
                using (SqlDataReader SqlRs = sqlComm.ExecuteReader())
                {
                    while (SqlRs.Read())
                    {
                        columntyp += SqlRs[0].ToString() + "/";
                    }
                }
                columntyp = columntyp.Remove(columntyp.Length-1);


                columnstr = res_grid_view.Columns[0].HeaderText.ToString();
                for (int i = 1; i < res_grid_view.Columns.Count; i++)
                {
                    columnstr += ", " + res_grid_view.Columns[i].HeaderText.ToString();
                }

                InsertDataDialog IDD = new InsertDataDialog(this, route, res_grid_view.Columns.Count, columnstr, columntyp);
                IDD.Show();
            }
            else
            {
                MessageBox.Show("연결 후에 사용해주세요");
            }
        }
        #endregion
        #region 4-6. Column Delete Method(행삭제)
        private void BT_Delete_Click(object sender, EventArgs e)
        {
            if (!connbt.Enabled && !verifibt.Enabled)
            {
                if (res_grid_view.DataMember.Equals("Tables"))
                {
                    String query = res_grid_view.Rows[this.res_grid_view.CurrentCellAddress.Y].Cells[0].Value.ToString();
                    sqlComm.CommandText = "DROP TABLE " + query;
                    sqlComm.ExecuteNonQuery();
                    res_grid_view.Rows.Remove(res_grid_view.Rows[this.res_grid_view.CurrentCellAddress.Y]);
                    
                }
                else if (res_grid_view.DataMember.Equals("Data"))
                {
                    string query = "";
                    string columntyp = "";
                    string[] columnarr = null;
                    sqlComm.CommandText = "SELECT DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = \'" + route + "\'";
                    sqlComm.ExecuteNonQuery();
                    using (SqlDataReader SqlRs = sqlComm.ExecuteReader())
                    {
                        while (SqlRs.Read())
                        {
                            columntyp += SqlRs[0].ToString() + "/";
                        }
                    }
                    columntyp = columntyp.Remove(columntyp.Length - 1);
                    columnarr = columntyp.Split('/');


                    query += "DELETE FROM " + route + " WHERE " + res_grid_view.Columns[res_grid_view.CurrentCell.ColumnIndex].HeaderText.ToString() + " = ";
                    if (columnarr[res_grid_view.CurrentCell.ColumnIndex].Equals("nvarchar") || columnarr[res_grid_view.CurrentCell.ColumnIndex].Equals("char") || columnarr[res_grid_view.CurrentCell.ColumnIndex].Equals("datetime"))
                    {
                        query += "\'" + res_grid_view.CurrentCell.Value.ToString() + "\'";
                    }
                    else
                    {
                        query += res_grid_view.CurrentCell.Value.ToString();
                    }

                    try
                    {
                        sqlComm.CommandText = query;
                        sqlComm.ExecuteNonQuery();
                        res_grid_view.Rows.Remove(res_grid_view.Rows[this.res_grid_view.CurrentCellAddress.Y]);
                    }
                    catch
                    {

                    }
                    //sqlComm.CommandText = "DELETE FROM " + route + " WHERE " + res_grid_view.SelectedColumns.Count;

                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("연결 후에 사용해주세요");
            }
        }
        #endregion
        #region 4-7. Excel Reader Call Method(엑셀 읽어오기)
        private void BT_save_Click(object sender, EventArgs e)
        {
            if (!connbt.Enabled && !verifibt.Enabled)
            {
                if (res_grid_view.DataMember.ToString().Equals("Tables"))
                {
                    ExcelReader form = new ExcelReader(this, DBlist, sip, uid, upw);
                    form.Show();
                }
                else
                {
                    ExcelReader_Data form = new ExcelReader_Data(this, DBlist, sip, uid, upw, route);
                    form.Show();
                }
            }
            else
            {
                MessageBox.Show("연결 후에 사용해 주세요");
            }
        }
        #endregion
        #region 4-8. Search Method(항목 검색)
        private void BT_search_Click(object sender, EventArgs e)
        {
            if (!connbt.Enabled && !verifibt.Enabled)
            {
                SearchItemDialog SID = new SearchItemDialog(this);
                SID.Show(); 
            }
            else
            {
                MessageBox.Show("연결 후에 사용해주세요");
            }
            
        }
        #endregion
        #endregion

        #region 5. Etc Event Method
        #region 5-1. Log Refresh Method(로그 창에서 스크롤에 맞춰 넘어가도록)
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.show_tx_log.SelectionStart = show_tx_log.TextLength;
            this.show_tx_log.ScrollToCaret();
        }
        #endregion
        #region 5-2. Enter Verification & Login(패스워드 자리에서 엔터키 눌렀을 때 이벤트 호출)
        private void tx_pw_bx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !connbt.Enabled) //검증 전 일때 이벤트
                verifibt.PerformClick();
            else if (e.KeyCode == Keys.Enter && !verifibt.Enabled) //검증 후 일때 이벤트
                connbt.PerformClick();
            else
                return;
        }
        #endregion
        #region 5-3. ComboBox Enter
        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !connbt.Enabled) //검증 전 일때 이벤트
                verifibt.PerformClick();
            else if (e.KeyCode == Keys.Enter && !verifibt.Enabled) //검증 후 일때 이벤트
                connbt.PerformClick();
            else
                return;
        }
        #endregion
        #region 5-4. IP, ID position Enter Focus Control Event
        private void tx_sip_bx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tx_id_bx.Focus();
            else
                return;
        }

        private void tx_id_bx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tx_pw_bx.Focus();
            else
                return;
        }
        #endregion
        #region 5-5. Passor
        public void QueryPass(String Data)
        {
            try
            {
                sqlComm.CommandText = Data;
                sqlComm.ExecuteNonQuery();
                
                if (res_grid_view.DataMember.ToString().Equals("Tables"))
                { 
                    sqlComm.CommandText = "SELECT TABLE_NAME, TABLE_TYPE FROM INFORMATION_SCHEMA.TABLES";
                    da = new SqlDataAdapter(sqlComm);
                    DataTable dt = new DataTable();
                    da.Fill(dt);


                    res_grid_view.Refresh();
                    res_grid_view.DataSource = dt;
                    res_grid_view.DataMember = "Tables";
                }
                else if (res_grid_view.DataMember.ToString().Equals("Data"))
                {
                    sqlComm.CommandText = "SELECT * FROM " + route;
                    da = new SqlDataAdapter(sqlComm);
                    DataTable dt = new DataTable();
                    da.Fill(dt);


                    res_grid_view.Refresh();
                    res_grid_view.DataSource = dt;
                    res_grid_view.DataMember = "Data";
                }
                else return;
            }
            catch(Exception E)
            {
                show_tx_log.Text = E.ToString();
            }
        }

        public void SearchPass(String Data) 
        {
            String value = "";
            int i = 0, j = 0;
            for (i = 0; i < res_grid_view.Rows.Count-1; i++)
            {
                for (j = 0; j < res_grid_view.Columns.Count; j++)
                {
                    value = res_grid_view.Rows[i].Cells[j].Value.ToString();
                    if(value.Equals(Data))
                    {
                        res_grid_view.CurrentCell = res_grid_view.Rows[i].Cells[j];
                        return;
                    }
                }
            }
            if (i.Equals(res_grid_view.Rows.Count-1) && j.Equals(res_grid_view.Columns.Count))
            {
                MessageBox.Show("값이 없습니다.");
            }
        }
        #endregion
        #endregion

        #region 6. GridView Event Method
        #region 6-1 DoubleClick Method(셀을 더블클릭 했을 때)
        private void res_grid_view_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //show_tx_log.Text = res_grid_view.CurrentRow.Cells[0].Value.ToString();
            //MessageBox.Show(res_grid_view.DataMember.ToString());
            if (res_grid_view.DataMember.ToString().Equals("Tables"))
            {
                route = this.res_grid_view.CurrentRow.Cells[0].Value.ToString();
                sqlComm.CommandText = "SELECT * FROM " + route;
                da = new SqlDataAdapter(sqlComm); //어댑터로 데이터 획득?
                ds = new DataSet();//데이터셋 생성
                da.Fill(ds, "Data");//데이터 전달

                show_tx_route.Text = "/DB." + sdb + "/dbo." + route;

                res_grid_view.DataSource = ds;
                res_grid_view.DataMember = "Data";
            }
            else
            {
                return;
            }
        }
        #endregion
        #region 6-2 BackSpace Push Method
        private void res_grid_view_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
                cancelbt.PerformClick();
            else
                return;
        }
        #endregion

        private void res_grid_view_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //수정 반영용
        }
        #endregion

        #region 7. HotKeys
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!base.ProcessCmdKey(ref msg, keyData))
            {
                if (keyData.Equals(Keys.F1))
                {
                    Assistance AssiForm = new Assistance();
                    AssiForm.Show();
                    return true;
                }
                else if (keyData.Equals(Keys.F3))
                {
                    BT_search.PerformClick();
                    return true;
                }
                else if (keyData.Equals(Keys.F4))
                {
                    BT_insert.PerformClick();
                    return true;
                }
                else if (keyData.Equals(Keys.F5))
                {
                    BT_Delete.PerformClick();
                    return true;
                }
                else if (keyData.Equals(Keys.F6))
                {
                    BT_read.PerformClick();
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
