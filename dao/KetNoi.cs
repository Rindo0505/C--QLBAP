using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.dao
{
    public class KetNoi
    {
        //B1: khai báo chuỗi kết nối
        public string connectionString = "Data Source=DESKTOP-ETF8C6F\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
        public SqlConnection sqlConn = null;
        public void OpenConnection()
        {
            sqlConn = new SqlConnection(connectionString);
            if (sqlConn.State != ConnectionState.Open)
            {
                sqlConn.Open();
            }
        }

        public DataTable ReadData(string sqlSelect)
        {
            DataTable dt = new DataTable();
            OpenConnection();
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelect, sqlConn);
            sqlData.Fill(dt);
            CLoseConnection();
            sqlData.Dispose();
            return dt;
        }

        public void ChangeData(string sql)
        {
            OpenConnection();
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConn;
            sqlComm.CommandText = sql;
            sqlComm.ExecuteNonQuery();
            CLoseConnection();
            sqlComm.Dispose();
        }
        public void UpdateData(string sql)
        {
            OpenConnection() ;
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConn;
            sqlComm.CommandText = sql;
            sqlComm.ExecuteNonQuery();
            CLoseConnection();
            sqlComm.Dispose();
        }
        public void CLoseConnection()
        {
            if (sqlConn.State != ConnectionState.Closed)
            {
                sqlConn.Close();
                sqlConn.Dispose();
            }


            // Console.WriteLine("đã đóng kết nối");
        }
       
    }
}
