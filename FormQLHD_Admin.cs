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
    public partial class FormQLHD_Admin : Form
    {
        HoaDonbo hdbo = new HoaDonbo();
        public int MaHD { get; set; }
        public TaiKhoanbean tk { get; set; }
        public FormQLHD_Admin(int MaHD, TaiKhoanbean tk)
        {
            InitializeComponent();
            this.tk = tk;
            dgvbang.DataSource = hdbo.GetHoaDon();
            this.MaHD = MaHD;
        }

        private void dgvbang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dgvbang.Columns[e.ColumnIndex].Name;
            if (columnName == "ChiTiet")
            {
                int maHD = Convert.ToInt32(dgvbang.Rows[e.RowIndex].Cells["MaHoaDon"].Value);

                var f = new FormCTHD_Admin(maHD, tk);
                f.ShowDialog();
                this.Hide();
            }
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormMenu(tk, MaHD);
            f.ShowDialog();
        }
    }
}
