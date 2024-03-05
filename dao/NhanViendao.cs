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
    public class NhanViendao
    {
        public List<NhanVienbean> GetNhanVien()
        {
            List<NhanVienbean> ds = new List<NhanVienbean>();
            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            string sql = "select *from NhanVien";
            // B4: Thực hiện lệnh SQl
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = kn.sqlConn;
            cmd.CommandText = sql;
            // Thêm tham số và giá trị tương ứng
            /* cmd.ExecuteNonQuery(); // thực hiện lệnh sql*/
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string MaNhanVien = reader.GetString("MaNhanVien");
                string TenNhanVien = reader.GetString("TenNhanVien");
                DateTime NgaySinh = reader.GetDateTime("NgaySinh");
                bool GioiTinh = reader.GetBoolean("GioiTinh");
                ds.Add(new NhanVienbean(MaNhanVien,TenNhanVien,NgaySinh,GioiTinh));
            }
            return ds;
            kn.CLoseConnection();
        }
        public int AddNhanVien(string manv, string tennv, DateTime ngaysinh,bool gioitinh)
        {
            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            string sql = "insert into NhanVien(MaNhanVien, TenNhanVien, NgaySinh, GioiTinh) " +
                "values(@MaNhanVien, @TenNhanVien, @NgaySinh, @GioiTinh)";
            SqlCommand cmd = new SqlCommand(sql, kn.sqlConn);
            // Thêm tham số và giá trị tương ứng
            cmd.Parameters.AddWithValue("@MaNhanVien", manv);
            cmd.Parameters.AddWithValue("@TenNhanVien", tennv);
            cmd.Parameters.AddWithValue("@NgaySinh", ngaysinh);
            cmd.Parameters.AddWithValue("@GioiTinh",gioitinh );
            int res = cmd.ExecuteNonQuery();
            kn.CLoseConnection();
            return res;
            
        }
        public bool CheckDuplicateMa(string maNhanVien)
        {
            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            string sql = "SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien = @MaNhanVien";

            using (SqlCommand cmd = new SqlCommand(sql, kn.sqlConn))
            {
                cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);

                // Lấy số lượng bản ghi có mã sản phẩm tương ứng
                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }

        public int updateNhanVien(string manv, string tennv, DateTime ngaysinh, bool gioitinh)
        {
            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            string sql = "UPDATE NhanVien SET TenNhanVien = @TenNhanVien, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh " +
     "WHERE MaNhanVien = @MaNhanVien";
            SqlCommand cmd = new SqlCommand(sql, kn.sqlConn);
            // Thêm tham số và giá trị tương ứng
            cmd.Parameters.AddWithValue("@MaNhanVien", manv);
            cmd.Parameters.AddWithValue("@TenNhanVien", tennv);
            cmd.Parameters.AddWithValue("@NgaySinh", ngaysinh);
            cmd.Parameters.AddWithValue("@GioiTinh", gioitinh);
            int res = cmd.ExecuteNonQuery();
            kn.CLoseConnection();
            return res;

        }

        public int deleteNhanVien(string manv)
        {
            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            string sql = "DELETE FROM NhanVien WHERE MaNhanVien = @MaNhanVien";
            SqlCommand cmd = new SqlCommand(sql, kn.sqlConn);
            cmd.Parameters.AddWithValue("@MaNhanVien", manv);
            int res = cmd.ExecuteNonQuery();
            return res;
            kn.CLoseConnection();
        }
    }
}
