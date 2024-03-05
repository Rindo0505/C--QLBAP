using QuanLyBanSach.bean;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.dao
{
    public class HoaDondao
    {
        public List<HoaDonbean> GetHoaDon()
        {
            List<HoaDonbean> ds = new List<HoaDonbean>();
            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            string sql = "select *from HoaDon order by MaHoaDon desc";
            // B4: Thực hiện lệnh SQl
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = kn.sqlConn;
            cmd.CommandText = sql;
            // Thêm tham số và giá trị tương ứng
            /* cmd.ExecuteNonQuery(); // thực hiện lệnh sql*/
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int MaHoaDon = reader.GetInt32("MaHoaDon");
                DateTime NgayLap = reader.GetDateTime("NgayLap");
                string MaNhanVien = reader.GetString("MaNhanVien");
                ds.Add(new HoaDonbean(MaHoaDon, NgayLap, MaNhanVien));
            }
            return ds;
            kn.CLoseConnection();
        }
        public int AddHoaDon(string Manv)
        {

            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            string sql = "INSERT INTO HoaDon(NgayLap,MaNhanVien) VALUES (@NgayLap,@MaNhanVien)";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = kn.sqlConn;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@NgayLap", DateTime.Now);
            cmd.Parameters.AddWithValue("@MaNhanVien", Manv);
            int kq = cmd.ExecuteNonQuery();
            return kq;
            kn.CLoseConnection();

        }




        public int maxDH()
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
                int kq = 0;
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

        public int ThongKeHD(int month)
        {
            try
            {
                KetNoi kn = new KetNoi();
                kn.OpenConnection();
                string sql = "SELECT COUNT(MaHoaDon) AS TongHD " +
                               "FROM HoaDon " +
                               "WHERE YEAR(NgayLap) = 2024 AND MONTH(NgayLap) = @Thang";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Thang", month);
                SqlDataReader reader = cmd.ExecuteReader();
                int kq = 0;
                if (reader.Read())
                {
                    kq = reader.GetInt32("TongHD");
                }
                kn.CLoseConnection();
                return kq;
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
    }
}
