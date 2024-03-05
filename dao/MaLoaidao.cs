using QuanLyBanSach.bean;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace QuanLyBanSach.dao
{
    public class MaLoaidao
    {
        public List<MaLoaibean> GetMaLoai()
        {
            List<MaLoaibean> ds = new List<MaLoaibean>();
            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            string sql = "SELECT * FROM LoaiSanPham ";
            // B4: Thực hiện lệnh SQl
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = kn.sqlConn;
            cmd.CommandText = sql;
            // Thêm tham số và giá trị tương ứng
            /* cmd.ExecuteNonQuery(); // thực hiện lệnh sql*/
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string MaLoaiSanPham = reader.GetString("MaLoaiSanPham");
                string TenLoaiSanPham = reader.GetString("TenLoaiSanPham");
                ds.Add(new MaLoaibean(MaLoaiSanPham,TenLoaiSanPham));
            }

            kn.CLoseConnection();
            return ds;
           
        }

        public int AddMaLoai(string malsp, string tenlsp)
        {
            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            string sql = "INSERT INTO LoaiSanPham(MaLoaiSanPham,TenLoaiSanPham) " +
                "VALUES(@MaLoaiSanPham,@TenLoaiSanPham)";
            SqlCommand cmd = new SqlCommand(sql, kn.sqlConn);
            // Thêm tham số và giá trị tương ứng
            cmd.Parameters.AddWithValue("@MaLoaiSanPham", malsp);
            cmd.Parameters.AddWithValue("@TenLoaiSanPham", tenlsp);
            int res = cmd.ExecuteNonQuery();

            kn.CLoseConnection();
            return res;
        }

        public bool CheckDuplicateMaLoai(string malsp)
        {
            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            string sql = "SELECT COUNT(*) FROM LoaiSanPham WHERE MaLoaiSanPham = @MaLoaiSanPham";

            using (SqlCommand cmd = new SqlCommand(sql, kn.sqlConn))
            {
                cmd.Parameters.AddWithValue("@MaLoaiSanPham", malsp);

                // Lấy số lượng bản ghi có mã sản phẩm tương ứng
                int count = (int)cmd.ExecuteScalar();
                kn.CLoseConnection();
                return count > 0;
            }
        }

        public int updateLoaiSanPham(string malsp,string tenlsp)
        {
            KetNoi kn = new KetNoi();
            kn.OpenConnection();

            string sql = "UPDATE LoaiSanPham SET TenLoaiSanPham = @TenLoaiSanPham " +
              "WHERE MaLoaiSanPham = @MaLoaiSanPham";

            SqlCommand cmd = new SqlCommand(sql, kn.sqlConn);

            cmd.Parameters.AddWithValue("@MaLoaiSanPham", malsp);
            cmd.Parameters.AddWithValue("@TenLoaiSanPham", tenlsp);
            int res = cmd.ExecuteNonQuery();
            kn.CLoseConnection();
            return res;
        }

        public int deleteLoaiSanPham(string malsp)
        {
            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            string sql = "DELETE FROM LoaiSanPham WHERE MaLoaiSanPham = @MaLoaiSanPham";
            SqlCommand cmd = new SqlCommand(sql, kn.sqlConn);
            cmd.Parameters.AddWithValue("@MaLoaiSanPham", malsp);
            int res = cmd.ExecuteNonQuery();
            return res;
            kn.CLoseConnection();
        }
    }
}
