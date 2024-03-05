using QuanLyBanSach.bean;
using QuanLyBanSach.dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.bo
{
    public class SanPhamdao
    {
        public List<SanPhambean> GetSanPham()
        {
            List<SanPhambean> ds= new List<SanPhambean>();
            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            string sql = "select *from SanPham";
            // B4: Thực hiện lệnh SQl
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = kn.sqlConn;
            cmd.CommandText = sql;
            // Thêm tham số và giá trị tương ứng
            /* cmd.ExecuteNonQuery(); // thực hiện lệnh sql*/
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string MaSanPham = reader.GetString("MaSanPham");
                string TenSanPham = reader.GetString("TenSanPham");
                string AnhSanPham = reader.GetString("AnhSanPham");
                long GiaBan = (long)reader.GetInt64("GiaBan");
                string MaLoaiSanPham = reader.GetString("MaLoaiSanPham");
                 ds.Add(new SanPhambean(MaSanPham,TenSanPham,AnhSanPham,GiaBan,MaLoaiSanPham));
            }
            return ds;
            kn.CLoseConnection();
        }

        public int  AddSanPham(string masp,string tensp, string anhsp, long giaban, string maloai)
        {
            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            string sql = "INSERT INTO SanPham(MaSanPham,TenSanPham, AnhSanPham, GiaBan, MaLoaiSanPham) " +
                "VALUES(@MaSanPham,@TenSanPham, @AnhSanPham, @GiaBan, @MaLoaiSanPham)";
            SqlCommand cmd = new SqlCommand(sql, kn.sqlConn);
            // Thêm tham số và giá trị tương ứng
            cmd.Parameters.AddWithValue("@MaSanPham", masp);
            cmd.Parameters.AddWithValue("@TenSanPham", tensp);
            cmd.Parameters.AddWithValue("@AnhSanPham", anhsp);
            cmd.Parameters.AddWithValue("@GiaBan", giaban);
            cmd.Parameters.AddWithValue("@MaLoaiSanPham", maloai);
            int res = cmd.ExecuteNonQuery();
            return res;
            kn.CLoseConnection();
        }

        public bool CheckDuplicateSanPham(string maSanPham)
        {
           KetNoi kn= new KetNoi();
                kn.OpenConnection();
                string sql = "SELECT COUNT(*) FROM SanPham WHERE MaSanPham = @MaSanPham";

                using (SqlCommand cmd = new SqlCommand(sql, kn.sqlConn))
                {
                    cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);

                    // Lấy số lượng bản ghi có mã sản phẩm tương ứng
                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }

        public int updateSanPham(string masp, string tensp, string anhsp, long giaban, string maloai)
        {
            KetNoi kn = new KetNoi();
            kn.OpenConnection();

            string sql = "UPDATE SanPham SET TenSanPham = @TenSanPham, AnhSanPham = @AnhSanPham, " +
                     "GiaBan = @GiaBan, MaLoaiSanPham = @MaLoaiSanPham WHERE MaSanPham = @MaSanPham";

            SqlCommand cmd = new SqlCommand(sql, kn.sqlConn);
           
            cmd.Parameters.AddWithValue("@TenSanPham", tensp);
            cmd.Parameters.AddWithValue("@AnhSanPham", anhsp);
            cmd.Parameters.AddWithValue("@GiaBan", giaban);
            cmd.Parameters.AddWithValue("@MaLoaiSanPham", maloai);
            cmd.Parameters.AddWithValue("@MaSanPham", masp);
            int res = cmd.ExecuteNonQuery();
            return res;
            kn.CLoseConnection();
        }
        public int deleteSanPham(string masp)
        {
            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            string sql = "DELETE FROM SanPham WHERE MaSanPham = @MaSanPham";
            SqlCommand cmd = new SqlCommand(sql,kn.sqlConn);
            cmd.Parameters.AddWithValue("@MaSanPham", masp);
            int res = cmd.ExecuteNonQuery();
            return res;
            kn.CLoseConnection();
        }

        public List<SanPhambean> GetTKSP(string key)
        {
            List<SanPhambean> ds = new List<SanPhambean>();
            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            string sql = "select *from SanPham where TenSanPham like @TenSanPham or MaLoaiSanPham like @MaLoaiSanPham";
            // B4: Thực hiện lệnh SQl
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = kn.sqlConn;
            cmd.CommandText = sql;
            // Thêm tham số và giá trị tương ứng
            cmd.Parameters.AddWithValue("@TenSanPham", "%" + key + "%");
            cmd.Parameters.AddWithValue("@MaLoaiSanPham", "%" + key + "%");
            /* cmd.ExecuteNonQuery(); // thực hiện lệnh sql*/
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string MaSanPham = reader.GetString("MaSanPham");
                string TenSanPham = reader.GetString("TenSanPham");
                string AnhSanPham = reader.GetString("AnhSanPham");
                long GiaBan = (long)reader.GetInt64("GiaBan");
                string MaLoaiSanPham = reader.GetString("MaLoaiSanPham");
                ds.Add(new SanPhambean(MaSanPham, TenSanPham, AnhSanPham, GiaBan, MaLoaiSanPham));
            }
            kn.CLoseConnection();

            return ds;
           
        }

        public string getMaSanPham(string TenSanPham)
        {
            string MaSanPham = "";
            try
            {
                KetNoi kn = new KetNoi();
                kn.OpenConnection();
                string sql = "SELECT * FROM SanPham WHERE TenSanPham = @TenSanPham";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@TenSanPham", TenSanPham);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MaSanPham = reader.GetString("MaSanPham");
                }
                kn.CLoseConnection();
                return MaSanPham;
                
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
           
            return MaSanPham;
        }

    }
}
