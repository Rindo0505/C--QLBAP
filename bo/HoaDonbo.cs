using QuanLyBanSach.bean;
using QuanLyBanSach.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.bo
{
    public class HoaDonbo
    {
        HoaDondao hddao = new HoaDondao();
        public List<HoaDonbean> GetHoaDon()
        {
            return hddao.GetHoaDon();
        }
            public int AddHoaDon( string Manv)
        {
            return hddao.AddHoaDon( Manv);
        }

        public int maxDH()
        {
            return hddao.maxDH();
        }

        public List<int> ThongKeHD()
        {
            List<int> dshd = new List<int>();
            for (int i = 1; i <= 12; ++i)
            {
                int hd = hddao.ThongKeHD(i);
                dshd.Add(hd);
            }
            return dshd;
        }
        }
}
