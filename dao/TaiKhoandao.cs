using QuanLyBanSach.bean;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using System.Collections;

namespace QuanLyBanSach.dao
{
    public class TaiKhoandao
    {
        public TaiKhoanbean GetDangNhap(string tdn, string mk) 
        {
            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            string sql = "SELECT * FROM TaiKhoan WHERE TaiKhoan.TenDangNhap = @TenDangNhap AND TaiKhoan.MatKhau = @MatKhau";
            // B4: Thực hiện lệnh SQl
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = kn.sqlConn;
            cmd.CommandText = sql;
            // Thêm tham số và giá trị tương ứng
            cmd.Parameters.AddWithValue("@TenDangNhap",tdn );
            cmd.Parameters.AddWithValue("@MatKhau", mk);
            /* cmd.ExecuteNonQuery(); // thực hiện lệnh sql*/
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string MaTaiKhoan = reader.GetString("MaTaiKhoan");
                string TenDangNhap = reader.GetString("TenDangNhap");
                string MatKhau = reader.GetString("MatKhau");
                string MaNhanVien = reader.GetString("MaNhanVien");
                string Quyen = reader.GetString("Quyen");
                return new TaiKhoanbean(MaTaiKhoan,TenDangNhap,MatKhau,MaNhanVien,Quyen);
            }
            return null;
            kn.CLoseConnection();
        }

        public List<TaiKhoanbean> GetDSTK()
        {
            List<TaiKhoanbean> ds = new List<TaiKhoanbean>();
            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            string sql = "SELECT * FROM TaiKhoan  ";
            // B4: Thực hiện lệnh SQl
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = kn.sqlConn;
            cmd.CommandText = sql;
            // Thêm tham số và giá trị tương ứng
            /* cmd.ExecuteNonQuery(); // thực hiện lệnh sql*/
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string MaTaiKhoan = reader.GetString("MaTaiKhoan");
                string TenDangNhap = reader.GetString("TenDangNhap");
                string MatKhau = reader.GetString("MatKhau");
                string MaNhanVien = reader.GetString("MaNhanVien");
                string Quyen = reader.GetString("Quyen");
                ds.Add(new TaiKhoanbean(MaTaiKhoan,TenDangNhap,MatKhau,MaNhanVien,Quyen));
            }
            return ds;
            kn.CLoseConnection();
        }

        public int AddTaiKhoan(string matk, string tendn, string mk, string manv, string quyen)
        {
            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            string sql = "insert into TaiKhoan(MaTaiKhoan, TenDangNhap, MatKhau, MaNhanVien,Quyen) " +
                "values(@MaTaiKhoan, @TenDangNhap, @MatKhau, @MaNhanVien, @Quyen)";
            SqlCommand cmd = new SqlCommand(sql, kn.sqlConn);
            // Thêm tham số và giá trị tương ứng
            cmd.Parameters.AddWithValue("@MaTaiKhoan", matk);
            cmd.Parameters.AddWithValue("@TenDangNhap", tendn);
            cmd.Parameters.AddWithValue("@MatKhau", mk);
            cmd.Parameters.AddWithValue("@MaNhanVien", manv);
            cmd.Parameters.AddWithValue("@Quyen", quyen);
            int res = cmd.ExecuteNonQuery();
            kn.CLoseConnection();
            return res;

        }
        public bool CheckDuplicateTK(string maTaiKhoan)
        {
            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE MaTaiKhoan = @MaTaiKhoan";

            using (SqlCommand cmd = new SqlCommand(sql, kn.sqlConn))
            {
                cmd.Parameters.AddWithValue("@MaTaiKhoan", maTaiKhoan);

                // Lấy số lượng bản ghi có mã sản phẩm tương ứng
                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }

        public int updateTaiKhoan(string matk, string tendn, string mk, string manv, string quyen)
        {
            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            string sql = "UPDATE TaiKhoan SET TenDangNhap = @TenDangNhap, MatKhau = @MatKhau, MaNhanVien = @MaNhanVien, Quyen =@Quyen " +
             "WHERE MaTaiKhoan = @MaTaiKhoan";
            SqlCommand cmd = new SqlCommand(sql, kn.sqlConn);
            // Thêm tham số và giá trị tương ứng
            cmd.Parameters.AddWithValue("@MaTaiKhoan", matk);
            cmd.Parameters.AddWithValue("@TenDangNhap", tendn);
            cmd.Parameters.AddWithValue("@MatKhau", mk);
            cmd.Parameters.AddWithValue("@MaNhanVien", manv);
            cmd.Parameters.AddWithValue("@Quyen", quyen);
            int res = cmd.ExecuteNonQuery();
            kn.CLoseConnection();
            return res;

        }

        public int deleteTaiKhoan(string matk)
        {
            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            string sql = "DELETE FROM TaiKhoan WHERE MaTaiKhoan = @MaTaiKhoan";
            SqlCommand cmd = new SqlCommand(sql, kn.sqlConn);
            cmd.Parameters.AddWithValue("@MaTaiKhoan", matk);
            int res = cmd.ExecuteNonQuery();
            return res;
            kn.CLoseConnection();
        }
    }
}
