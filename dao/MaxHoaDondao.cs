using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.dao
{
    public class MaxHoaDondao
    {
        public long maxDH()
        {
            try
            {
                KetNoi kn = new KetNoi();
                kn.OpenConnection();
                string sql = "SELECT MAX(MaHoaDon) AS MaxDH  FROM HoaDon";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                long kq = 0;
                if (reader.Read())
                {
                    kq = reader.GetInt32("MaxDH");
                }
                return kq;
                kn.CLoseConnection();
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
