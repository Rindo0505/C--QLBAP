using QuanLyBanSach.bean;
using QuanLyBanSach.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.bo
{
    public class MaLoaibo
    {
        MaLoaidao mldao= new MaLoaidao();
        public List<MaLoaibean> GetMaLoai()
        {
            return mldao.GetMaLoai();
        }

        public bool CheckDuplicateMaLoai(string malsp)
        {
           return mldao.CheckDuplicateMaLoai(malsp);        
        }

        public int AddMaLoai(string malsp, string tenlsp)
        { 
        return mldao.AddMaLoai(malsp, tenlsp);
        }

        public int updateLoaiSanPham(string malsp, string tenlsp)
        {
            return mldao.updateLoaiSanPham(malsp, tenlsp);
        }
        public int deleteLoaiSanPham(string malsp)
        {
            return mldao.deleteLoaiSanPham(malsp);
        }
    }
}
