using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.bean
{
    public class HoaDonbean
    {
        public int MaHoaDon {  get; set; }  
        public DateTime NgayLap { get; set; }
        public string Manv {  get; set; }

        public HoaDonbean(int maHD, DateTime ngayLap, string manv ) {
            MaHoaDon = maHD;
            NgayLap = ngayLap;
            Manv = manv;
        
        }

        public override string ToString()

        {
            return "HoaDonbean [MaHoaDon=" + MaHoaDon + ", NgayLap=" + NgayLap + ", MaNhanVien=" +Manv+  "]";
        }
    }
}
