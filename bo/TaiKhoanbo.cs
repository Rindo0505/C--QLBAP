using QuanLyBanSach.bean;
using QuanLyBanSach.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.bo
{
    public class TaiKhoanbo
    {
        TaiKhoandao tkdao = new TaiKhoandao();
        public TaiKhoanbean GetDangNhap(string tdn, string mk)
        {
            return tkdao.GetDangNhap(tdn, mk);
        }

        public List<TaiKhoanbean> GetDSTK()
        { return tkdao.GetDSTK(); 
        }

        public int AddTaiKhoan(string matk, string tendn, string mk, string manv, string quyen)
        {
            return tkdao.AddTaiKhoan(matk,tendn,mk,manv,quyen); 
        }

        public bool CheckDuplicateTK(string maTaiKhoan)
        { 
            return tkdao.CheckDuplicateTK(maTaiKhoan);
        }

        public int updateTaiKhoan(string matk, string tendn, string mk, string manv, string quyen)
        {
            return tkdao.updateTaiKhoan(matk, tendn, mk, manv, quyen);
        }

        public int deleteTaiKhoan(string matk)
        {
            return tkdao.deleteTaiKhoan(matk);
        }
        }
}
