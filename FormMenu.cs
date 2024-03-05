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
    public partial class FormMenu : Form
    {
        public TaiKhoanbean tk { get; set; }
        public int MaHD { get; set; }
        public FormMenu(TaiKhoanbean tk, int maHD)
        {
            InitializeComponent();
            this.tk = tk;
            this.MaHD = maHD;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormHienThiSanPham(tk, MaHD);
            f.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            var f = new FormTaiKhoan();
            f.ShowDialog();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormHienThiDSTK(tk, MaHD);
            f.ShowDialog();
        }

        private void tstml_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormMaLoai(tk, MaHD);
            f.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormDSNV(MaHD);
            f.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormQLHD_Admin(MaHD, tk);
            f.ShowDialog();
        }
    }
}
