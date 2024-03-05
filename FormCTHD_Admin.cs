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
    public partial class FormCTHD_Admin : Form
    {
        ChiTietHoaDonbo cthdbo = new ChiTietHoaDonbo();
        public int MaHD { get; set; }
        public TaiKhoanbean tk { get; set; }
        public FormCTHD_Admin(int MaHD, TaiKhoanbean tk)
        {

            InitializeComponent();
            this.MaHD = MaHD;
            this.tk = tk;
            dgvcthd.DataSource = null;
            dgvcthd.DataSource = cthdbo.GetChiTietHoaDon(MaHD);

        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormQLHD_Admin(MaHD, tk);
            f.ShowDialog();
        }
    }
}
