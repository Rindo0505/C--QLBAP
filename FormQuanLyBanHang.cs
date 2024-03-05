using QuanLyBanSach.bean;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSach
{
    public partial class FormQuanLyBanHang : Form
    {
        public TaiKhoanbean tk { get; set; }
        public int MaHD { get; set; }
        public FormQuanLyBanHang(TaiKhoanbean tk, int MaHD)
        {
            InitializeComponent();
            this.tk = tk;
            this.MaHD = MaHD;
        }

        private void btnbh_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormBanHang(tk, MaHD);
            f.ShowDialog();
        }

        private void btnqlhd_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormQuanLyHoaDon_nhanvien(MaHD, tk);
            f.ShowDialog();
        }

        private void btnlsmh_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormLichSuMuaHang(tk, MaHD);
            f.ShowDialog();
        }
    }
}
