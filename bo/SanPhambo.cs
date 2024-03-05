using QuanLyBanSach.bean;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.bo
{
    public class SanPhambo
    {
        SanPhamdao spdao = new SanPhamdao();
        List<SanPhambean> ds;
        public List<SanPhambean> GetSanPham()
        {
            return ds = spdao.GetSanPham();
        }
        public int AddSanPham(string masp, string tensp, string anhsp, long giaban, string maloai)
        {
            return spdao.AddSanPham(masp, tensp, anhsp, giaban, maloai);
        }
        public bool CheckDuplicateSanPham(string maSanPham)
        {
            return spdao.CheckDuplicateSanPham(maSanPham);
        }
        public int updateSanPham(string masp, string tensp, string anhsp, long giaban, string maloai)
        {
            return spdao.updateSanPham(masp,tensp,anhsp, giaban,maloai);
        }

        public int deleteSanPham(string masp)
        {
            return spdao.deleteSanPham(masp);
        }

        public List<SanPhambean> GetTKSP(string key)
        {
            return spdao.GetTKSP(key);
        }

        public string getMaSanPham(string TenLoaiSanPham)
        {
            return spdao.getMaSanPham(TenLoaiSanPham);
        }
        }
}
