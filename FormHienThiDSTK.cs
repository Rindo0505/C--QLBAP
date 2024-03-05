using QuanLyBanSach.bean;
using QuanLyBanSach.bo;
using QuanLyBanSach.dao;
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
    public partial class FormHienThiDSTK : Form
    {
        KetNoi kn = new KetNoi();
        TaiKhoanbo tkbo = new TaiKhoanbo();
        public TaiKhoanbean tk { get; set; }
        public int MaHD { get; set; }

        public FormHienThiDSTK(TaiKhoanbean tk, int MaHD)
        {
            InitializeComponent();
            dgvbangtk.DataSource = tkbo.GetDSTK();
            this.tk = tk;
            this.MaHD = MaHD;

        }

        private void FormHienThiDSTK_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        void LoadData()
        {/*
            DataTable dthang = kn.ReadData("select *from TaiKhoan");
            dgvbangtk.DataSource = dthang;*/
        }

        private void dgvbangtk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmatk.Text = dgvbangtk.CurrentRow.Cells[0].Value.ToString();
            txttendn.Text = dgvbangtk.CurrentRow.Cells[1].Value.ToString();
            txtmk.Text = dgvbangtk.CurrentRow.Cells[2].Value.ToString();
            txtmanv.Text = dgvbangtk.CurrentRow.Cells[3].Value.ToString();
            txtquyen.Text = dgvbangtk.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string matk = txtmatk.Text;
            string tendn = txttendn.Text;
            string mk = txtmk.Text;
            string manv = txtmanv.Text;
            string quyen = txtquyen.Text;

            if (matk == "" || tendn == "" || mk == "" || manv == "" || quyen == "")
            {
                MessageBox.Show("vui lòng điền đầy đủ thông tin");
            }
            else
            {
                //List<SanPhambean> sp = spbo.GetSanPham();
                if (tkbo.CheckDuplicateTK(matk))
                {
                    MessageBox.Show("Mã tài khoản này đã tồn tại, vui lòng nhập mã tài khoản khác");
                }

                else
                {
                    int them = tkbo.AddTaiKhoan(matk, tendn, mk, manv, quyen);
                    if (them > 0)
                    {
                        MessageBox.Show("Thêm tài khoản thành công");
                        dgvbangtk.DataSource = tkbo.GetDSTK();
                    }
                    else
                        MessageBox.Show("Thêm tài khoản thất bại");

                }
            }
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormMenu(tk, MaHD);
            f.ShowDialog();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string matk = txtmatk.Text;
            string tendn = txttendn.Text;
            string mk = txtmk.Text;
            string manv = txtmanv.Text;
            string quyen = txtquyen.Text;

            List<TaiKhoanbean> tk = tkbo.GetDSTK();
            if (tk != null)
            {
                tkbo.updateTaiKhoan(matk, tendn, mk, manv, quyen);
                MessageBox.Show("Cập nhật thành công");
                dgvbangtk.DataSource = tkbo.GetDSTK();
            }
            else
            {
                MessageBox.Show("Cập nhập thất bại");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string matk = txtmatk.Text;
            if (tkbo.CheckDuplicateTK(matk))
            {
                if (MessageBox.Show("Bạn có muốn xóa Tài khoan này không?", "Thông báo",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    tkbo.deleteTaiKhoan(matk);
                    MessageBox.Show("Đã xóa tài khoản");
                    dgvbangtk.DataSource = tkbo.GetDSTK();
                }
            }
        }
    }
}
