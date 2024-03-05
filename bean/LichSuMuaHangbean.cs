using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.bean
{
    public class LichSuMuaHangbean
    {
        public  string MaNhanVien {  get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int SoLuong {  get; set; }
        public long DonGia { get; set; }
        public long ThanhTien { get; set; }

        public LichSuMuaHangbean(string manhanvien, string masanpham, string tensanpham, int soluong,long dongia,long thanhtien) {
            MaNhanVien = manhanvien;
            MaSanPham = masanpham;
            TenSanPham= tensanpham;
            SoLuong = soluong;
            DonGia = dongia;
            ThanhTien = thanhtien;
        }

    }
}
