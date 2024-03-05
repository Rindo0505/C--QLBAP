using QuanLyBanSach.bean;
using QuanLyBanSach.bo;
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
    public partial class FormChiTietHoaDon : Form
    {
        ChiTietHoaDonbo cthdbo = new ChiTietHoaDonbo();
        public int MaHD { get; set; }
        public TaiKhoanbean tk { get; set; }
        public FormChiTietHoaDon(int MaHD, TaiKhoanbean tk)
        {
            this.MaHD = MaHD;
            InitializeComponent();
            dgvcthd.DataSource = cthdbo.GetChiTietHoaDon(MaHD);
            this.tk = tk;
        }

        private void FormChiTietHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormQuanLyHoaDon_nhanvien(MaHD, tk);
            f.ShowDialog();
        }
    }
}
