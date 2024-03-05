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
    public partial class FormQuanLyHoaDon_nhanvien : Form
    {
        HoaDonbo hdbo = new HoaDonbo();
        public int MaHD { get; set; }
        public TaiKhoanbean tk { get; set; }

        public FormQuanLyHoaDon_nhanvien(int MaHD, TaiKhoanbean tk)
        {
            InitializeComponent();
            this.tk = tk;
            dgvbang.DataSource = hdbo.GetHoaDon();
            this.MaHD = MaHD;
        }

        private void FormQuanLyHoaDon_nhanvien_Load(object sender, EventArgs e)
        {


        }

        private void dgvbang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dgvbang.Columns[e.ColumnIndex].Name;
            if (columnName == "ChiTiet")
            {
                int maHD = Convert.ToInt32(dgvbang.Rows[e.RowIndex].Cells["MaHoaDon"].Value);

                var f = new FormChiTietHoaDon(maHD, tk);
                f.ShowDialog();
                this.Hide();
            }
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormQuanLyBanHang(tk, MaHD);
            f.ShowDialog();
        }
    }
}
