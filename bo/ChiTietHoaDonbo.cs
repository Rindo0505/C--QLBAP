using QuanLyBanSach.bean;
using QuanLyBanSach.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.bo
{
    public class ChiTietHoaDonbo
    {
        ChiTietHoaDondao cthddao = new ChiTietHoaDondao();
        public List<ChiTietHoaDonbean> GetChiTietHoaDon(int MaHD)
        {
            return cthddao.GetChiTietHoaDon(MaHD);
        }
        public int AddChiTietHoaDon(int MaHD, string MaSp,string tensp, int soluong, long dongia)
            { 
            return cthddao.AddChiTietHoaDon(MaHD, MaSp,tensp, soluong, dongia);
        }
        }
}
