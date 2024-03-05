using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.bean
{
    public class SanPhambean
    {
        public string MaSanPham {  get; set; }
        public string TenSanPham { get; set;}
        public string AnhSanPham { get; set;}
        public long GiaBan {  get; set;}
        public string MaLoaiSanPham {  get; set;}

        public SanPhambean(string maSanPham, string tenSanPham, string anhSanPham, long giaBan, string maLoaiSanPham)
        {
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            AnhSanPham = anhSanPham;
            GiaBan = giaBan;
            MaLoaiSanPham = maLoaiSanPham;
        }

        public override string ToString()

        {
            return "SanPhambean [MaSanPham=" + MaSanPham + ", TenSanPham=" + TenSanPham + ", AnhSanPham=" + AnhSanPham
                 + ", GiaBan=" + GiaBan + ", MaLoaiSanPham=" + MaLoaiSanPham + "]";
        }
    }
}
