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
    public partial class FormDSNV : Form
    {
        NhanVienbo nvbo = new NhanVienbo();
        public TaiKhoanbean tk { get; set; }
        public int MaHD { get; set; }
        public FormDSNV(int maHD)
        {
            InitializeComponent();
            dgvbang.DataSource = nvbo.GetNhanVien();
            MaHD = maHD;
        }

        private void FormDSNV_Load(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            string tennv = txttnv.Text;

            if (!DateTime.TryParse(dgvbang.CurrentRow.Cells[2].Value.ToString(), out DateTime ngaysinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                return;
            }

            if (!bool.TryParse(txtgioitinh.Text, out bool gioitinh))
            {
                MessageBox.Show("Giới tính không hợp lệ");
                return;
            }

            if (manv == "" || tennv == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                nvbo.AddNhanVien(manv, tennv, ngaysinh, gioitinh);
                MessageBox.Show("Thêm nhân viên thành công");
                dgvbang.DataSource = nvbo.GetNhanVien();
            }
        }

        private void dgvbang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmanv.Text = dgvbang.CurrentRow.Cells[0].Value.ToString();
            txttnv.Text = dgvbang.CurrentRow.Cells[1].Value.ToString();
            dtpngaysinh.Text = dgvbang.CurrentRow.Cells[2].Value.ToString();
            txtgioitinh.Text = dgvbang.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            string tennv = txttnv.Text;
            List<NhanVienbean> nv = nvbo.GetNhanVien();

            if (!DateTime.TryParse(dgvbang.CurrentRow.Cells[2].Value.ToString(), out DateTime ngaysinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                return;
            }

            if (!bool.TryParse(txtgioitinh.Text, out bool gioitinh))
            {
                MessageBox.Show("Giới tính không hợp lệ");
                return;
            }
            if (nv == null)
            {
                MessageBox.Show("Lỗi! vui lòng điển đẩy đủ thông tin");
            }
            else
            {
                nvbo.updateNhanVien(manv, tennv, ngaysinh, gioitinh);
                MessageBox.Show("Cập nhật thành công");
                dgvbang.DataSource = nvbo.GetNhanVien();
            }
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormMenu(tk, MaHD);
            f.ShowDialog();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            if (nvbo.CheckDuplicateMa(manv))
            {
                if (MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Thông báo",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    nvbo.deleteNhanVien(manv);
                    MessageBox.Show("Đã xóa nhân viên");
                    dgvbang.DataSource = nvbo.GetNhanVien();
                }
            }
        }
    }
}
