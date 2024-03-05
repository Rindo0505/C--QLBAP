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
    public partial class FormMaLoai : Form
    {
        MaLoaibo mlbo = new MaLoaibo();

        public TaiKhoanbean tk { get; set; }

        public int MaHD { get; set; }
        public FormMaLoai(TaiKhoanbean tk, int MaHD)
        {
            InitializeComponent();
            dgvbang.DataSource = mlbo.GetMaLoai();
            this.tk = tk;
            this.MaHD = MaHD;
        }

        private void FormMaLoai_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormMenu(tk, MaHD);
            f.ShowDialog();
        }

        private void dgvbang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmasp.Text = dgvbang.CurrentRow.Cells[0].Value.ToString();
            txttensp.Text = dgvbang.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string malsp = txtmasp.Text;
            string tenmlsp = txttensp.Text;
            if (mlbo.CheckDuplicateMaLoai(malsp))
            {
                MessageBox.Show("Mã loại sản phẩm này đã tồn tại, vui lòng nhập mã khác");
            }
            else
            {
                mlbo.AddMaLoai(malsp, tenmlsp);
                MessageBox.Show("Thêm mã loại thành công");
                dgvbang.DataSource = mlbo.GetMaLoai();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string malsp = txtmasp.Text;
            string tenmlsp = txttensp.Text;
            List<MaLoaibean> ml = mlbo.GetMaLoai();

            if (ml != null)
            {
                mlbo.updateLoaiSanPham(malsp, tenmlsp);
                MessageBox.Show("Cập nhật thành công");
                dgvbang.DataSource = mlbo.GetMaLoai();
            }
            else
                MessageBox.Show("Cập nhật thất bại");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string malsp = txtmasp.Text;
            if (mlbo.CheckDuplicateMaLoai(malsp))
            {
                if (MessageBox.Show("Bạn có muốn xóa sản phẩm này không?", "Thông báo",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    mlbo.deleteLoaiSanPham(malsp);
                    MessageBox.Show("Đã xóa sản phẩm");
                    dgvbang.DataSource = mlbo.GetMaLoai();
                }
            }
        }
    }
}
