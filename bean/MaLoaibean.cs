using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.bean
{
    public class MaLoaibean
    {
        public string MaLoaiSanPham {  get; set; }

        public string TenLoaiSanPham { get; set; }

        public MaLoaibean(string maLoaiSanPham, string tenLoaiSanPham) {
            MaLoaiSanPham = maLoaiSanPham;
            TenLoaiSanPham = tenLoaiSanPham;
        }

        public override string ToString()

        {
            return "TaiKhoanbean [MaLoaiSanPham=" +MaLoaiSanPham  + ", TenLoaiSanPham=" + TenLoaiSanPham + "]";
        }

    }
}
