using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.bean
{
    public class NhanVienbean
    {
        public string MaNhanVien {  get; set; }

        public string TenNhanVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }

        public NhanVienbean(string maNhanVien, string tenNhanVien, DateTime ngaySinh, bool gioiTinh)
        {
            MaNhanVien = maNhanVien;
            TenNhanVien = tenNhanVien;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
        }

        public override string ToString()
        {
            return "TaiKhoanbean [MaNhanVien=" + MaNhanVien + ", TenNhanVien=" + TenNhanVien + ",NgaySinh=" +NgaySinh + "" +
                ",GioiTinh=" + GioiTinh + "]";
        }
    }
}
