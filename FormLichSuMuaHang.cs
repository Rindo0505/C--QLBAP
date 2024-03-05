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
    public partial class FormLichSuMuaHang : Form
    {
        public TaiKhoanbean tk { get; set; }
        public int MaHD { get; set; }

        LichSuMuaHangbo lsbo = new LichSuMuaHangbo();
        public FormLichSuMuaHang(TaiKhoanbean tk, int maHD)
        {
            InitializeComponent();
            this.tk = tk;
            dgvbang.DataSource = lsbo.GetLSMH();
            MaHD = maHD;
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormQuanLyBanHang(tk, MaHD);
            f.ShowDialog();
        }

        private void dgvbang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
