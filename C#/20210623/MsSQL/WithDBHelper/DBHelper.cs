using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithDBHelper
{
    class DBHelper
    {
        public static SqlConnection conn = new SqlConnection();
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        public int ex1;
        public int ex2;

        public void example()
        {
            //System.Windows.Forms.MessageBox.Show("Test");
        }

        public DBHelper instance;

        public DBHelper getInstance()
        {
            if (instance == null)
                instance = new DBHelper();
            return instance;
        }

        public static void ConnectDB()
        {
            conn.ConnectionString = string.Format("Data Source=({0}); " +
                "Initial Catalog = {1};" +
                "Integrated Security = {2};" +
                "Timeout = 3"
                , "local", "MYDB1", "SSPI");
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }

        public static void Query_Select()
        {
            ConnectDB();

            //SQL 명령어 선언
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM TB_CUST";

            //DataAdapter 와 DataSet으로 DB table 불러오기
            da = new SqlDataAdapter(cmd); //select 구문이 들어감
            ds = new DataSet();
            da.Fill(ds, "TB_CUST"); // SELECT * FROM TB_CUST의 결과가 da에 입력됨

            //dataGridView에 DB에서 가져온 데이터 입력하기
            //dataGridView1.DataSource = ds;
            //dataGridView1.DataMember = "TB_CUST";
            conn.Close(); //연결 해제
        }

        public static void Query_Insert(string cust_id, string birth_dt)
        {
            ConnectDB();
            string sqlcommand = "Insert Into TB_CUST (CUST_ID, BIRTH_DT) values (@p1,@p2)";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            //Columd 명은 별도의 파라메터 형태로 선언함
            //SQL Injection을 방지하고자 함(SQL Injection : 유효하지 않은 데이터를 이용한 공격) 예: +나 ' 기호를 이용한 공격
            cmd.Parameters.AddWithValue("@p1", cust_id);
            cmd.Parameters.AddWithValue("@p2", birth_dt);
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();  //쿼리 실행
            conn.Close();
        }

        public static void Query_update(string cust_id, string birth_dt)
        {
            ConnectDB();
            string sqlcommand = "Update TB_CUST set CUST_ID=@p1, BIRTH_DT=@p2 where CUST_ID = @p3";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            //Columd 명은 별도의 파라메터 형태로 선언함
            //SQL Injection을 방지하고자 함(SQL Injection : 유효하지 않은 데이터를 이용한 공격) 예: +나 ' 기호를 이용한 공격
            cmd.Parameters.AddWithValue("@p1", cust_id);
            cmd.Parameters.AddWithValue("@p2", birth_dt);
            cmd.Parameters.AddWithValue("@p3", cust_id);
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();  //쿼리 실행
            conn.Close();
        }

        public static void Query_Delete(string cust_id)
        {
            ConnectDB();
            string sqlcommand = "Delete TB_CUST where CUST_id = @p1";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", cust_id);
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();  //쿼리 실행
            conn.Close();
        }
    }
}
