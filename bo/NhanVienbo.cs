using QuanLyBanSach.bean;
using QuanLyBanSach.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.bo
{
    public class NhanVienbo
    {
        NhanViendao nvdao = new NhanViendao();
        public List<NhanVienbean> GetNhanVien()
        { 
            return nvdao.GetNhanVien();
        }

        public int AddNhanVien(string manv, string tennv, DateTime ngaysinh, bool gioitinh)
        {
            return nvdao.AddNhanVien(manv,tennv,ngaysinh,gioitinh);
        }
        public bool CheckDuplicateMa(string maNhanVien)
        { 
            return nvdao.CheckDuplicateMa(maNhanVien);
        }

        public int updateNhanVien(string manv, string tennv, DateTime ngaysinh, bool gioitinh)
        { 
        return nvdao.updateNhanVien(manv,tennv,ngaysinh,gioitinh);
        }

        public int deleteNhanVien(string manv)
        {
           return nvdao.deleteNhanVien(manv);
        }
        }
}
