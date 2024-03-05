using QuanLyBanSach.bean;
using QuanLyBanSach.bo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.dao
{
    public class ChiTietHoaDondao
    {

        public List<ChiTietHoaDonbean> GetChiTietHoaDon(int MaHD)
        {
            List<ChiTietHoaDonbean> ds = new List<ChiTietHoaDonbean>();
            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            string sql = "select * from ChiTietHoaDon where MaHoaDon=@MaHoaDon";
            // B4: Thực hiện lệnh SQl
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = kn.sqlConn;
            cmd.CommandText = sql;
            // Thêm tham số và giá trị tương ứng
            cmd.Parameters.AddWithValue("@MaHoaDon", MaHD);
            /* cmd.ExecuteNonQuery(); // thực hiện lệnh sql*/
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int MaHoaDon = reader.GetInt32("MaHoaDon");
                string MaSanPham = reader.GetString("MaSanPham");
                string TenSanPham = reader.GetString("TenSanPham");
                int SoLuong = reader.GetInt32("SoLuong");
                long DonGia = (long)reader.GetInt64("DonGia");
                ds.Add(new ChiTietHoaDonbean(MaHoaDon,MaSanPham,TenSanPham,SoLuong,DonGia));
            }
            kn.CLoseConnection();
            return ds;
           
        }
        public int AddChiTietHoaDon(int MaHD, string MaSp, string tensp, int soluong, long dongia)
        {
            try
            {
                KetNoi kn = new KetNoi();
                kn.OpenConnection();
                string sql = "INSERT INTO ChiTietHoaDon(MaHoaDon,MaSanPham,TenSanPham,SoLuong,DonGia)" +
                    " VALUES(@MaHoaDon,@MaSanPham, @TenSanPham, @SoLuong,@DonGia)";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@MaHoaDon",MaHD);
                cmd.Parameters.AddWithValue("@MaSanPham", MaSp);
                cmd.Parameters.AddWithValue("@TenSanPham", tensp);
                cmd.Parameters.AddWithValue("@SoLuong",soluong );
                cmd.Parameters.AddWithValue("@DonGia", dongia);
                int kq = cmd.ExecuteNonQuery();

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
