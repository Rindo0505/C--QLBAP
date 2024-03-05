using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.bean
{
    public class TaiKhoanbean
    {
        public string MaTaiKhoan { get; set; }
        public string TenDangNhap { get; set; }

        public string MatKhau { get; set; }
        public string MaNhanVien { get; set; }
        public string Quyen {  get; set; }

        public TaiKhoanbean(string maTaiKhoan, string tenDangNhap, string matKhau, string maNhanVien, string quyen)
        {
            MaTaiKhoan = maTaiKhoan;
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            MaNhanVien = maNhanVien;
            Quyen = quyen;
        }
        

        public override string ToString()

        {
           return "TaiKhoanbean [MaTaiKhoan=" + MaTaiKhoan + ", TenDangNhap=" + TenDangNhap + ", MatKhau=" + MatKhau
                + ", MaNhanVien=" + MaNhanVien + ", Quyen= "+Quyen+"]";
        }
    }
}
