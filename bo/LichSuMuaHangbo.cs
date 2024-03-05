using QuanLyBanSach.bean;
using QuanLyBanSach.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.bo
{
    public class LichSuMuaHangbo
    {
        LichSuMuaHangdao lsdao = new LichSuMuaHangdao();
        public List<LichSuMuaHangbean> GetLSMH()
        {
            return lsdao.GetLSMH();
        }
        }
}
