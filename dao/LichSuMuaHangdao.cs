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
    public class LichSuMuaHangdao
    {
        public List<LichSuMuaHangbean> GetLSMH()
        {
            List<LichSuMuaHangbean> ds = new List<LichSuMuaHangbean>();
            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            string sql = "select * from LichSuMuaHang";
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
                string MaSanPham = reader.GetString("MaSanPham");
                string TenSanPham = reader.GetString("TenSanPham");
                int SoLuong = reader.GetInt32("SoLuong");
                long DonGia = (long)reader.GetInt64("DonGia");
                long ThanhTien = (long)reader.GetInt64("ThanhTien");
                ds.Add(new LichSuMuaHangbean(MaNhanVien,MaSanPham,TenSanPham,SoLuong,DonGia,ThanhTien));
            }
            kn.CLoseConnection();
            return ds;

        }
    }
}
