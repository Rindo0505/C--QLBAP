using QuanLyBanSach.bean;
using QuanLyBanSach.bo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSach
{
    public partial class FormTaiKhoan : Form
    {
        public int MaHD { get; set; }
        public FormTaiKhoan()
        {
            InitializeComponent();

        }
        TaiKhoanbo tkbo = new TaiKhoanbo();
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string tendn = txttdn.Text;
            string matkhau = txtmk.Text;

            if (tendn != null && matkhau != null)
            {
                TaiKhoanbean Tk = tkbo.GetDangNhap(tendn, matkhau);
                if (Tk == null)
                {
                    MessageBox.Show("Đăng Nhập thất bại, vui lòng điền đầy đủ thông tin");
                }
                else
                {
                    if (tendn.Equals(Tk.TenDangNhap) && matkhau.Equals(Tk.MatKhau))
                    {
                        if (Tk.Quyen.Equals("Admin"))
                        {
                            this.Hide();
                            var f = new FormMenu(Tk, MaHD);
                            f.ShowDialog();
                        }
                        else
                        {
                            this.Hide();
                            var f = new FormQuanLyBanHang(Tk, MaHD);
                            f.ShowDialog();
                        }
                    }

                }
            }

        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
