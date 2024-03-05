using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.bean
{
    public class ChiTietHoaDonbean
    {
        public int MaHoaDon {  get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public long DonGia { get; set; }

        public ChiTietHoaDonbean( int mahd, string maSanPham, string tenSanPham, int soLuong, long donGia) {
            MaHoaDon = mahd;
            MaSanPham = maSanPham;
            TenSanPham= tenSanPham;
            SoLuong = soLuong;
            DonGia = donGia;
        
        }
        public override string ToString()

        {
            return "ChiTietHoaDonbean [MaHoaDon=" + MaHoaDon + ",MaSanPham=" + MaSanPham + ", TenSanPham=" + TenSanPham +  ", " +
                "SoLuong=" + SoLuong + ", DonGia=" + DonGia + "]";
        }
    }
}
