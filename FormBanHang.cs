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
    public partial class FormBanHang : Form
    {
        SanPhambo spbo = new SanPhambo();

        string fileAnh;

        HoaDonbo hdbo = new HoaDonbo();

        ChiTietHoaDonbo cthdbo = new ChiTietHoaDonbo();


        public TaiKhoanbean tk { get; set; }

        public int MaHD { get; set; }
        public FormBanHang(TaiKhoanbean tk, int MaHD)
        {
            InitializeComponent();
            dgvbang1.DataSource = spbo.GetSanPham();
            txttongtien.Text = TinhTongTien().ToString();
            this.tk = tk;
            this.MaHD = MaHD;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ptbanh_Click(object sender, EventArgs e)
        {

            var openFile = new OpenFileDialog()
            {
                Title = "Chọn file ảnh"
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var selectedFile = openFile.FileName;
                ptbanh.ImageLocation = selectedFile;
            }

        }

        private void dgvbang1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txttensp.Text = dgvbang1.CurrentRow.Cells[0].Value.ToString();
            txtgiaban.Text = dgvbang1.CurrentRow.Cells[2].Value.ToString();
            fileAnh = dgvbang1.CurrentRow.Cells[1].Value.ToString();
            ptbanh.Image = Image.FromFile(fileAnh);
        }

        private void btngiohang_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvbang2.Rows)
            {
                // Nếu sản phẩm đã tồn tại thì tăng số lượng lên 1
                if (item.Cells[0].Value.Equals(dgvbang1.CurrentRow.Cells[0].Value.ToString()))
                {
                    item.Cells[3].Value = int.Parse(item.Cells[3].Value.ToString()) + 1;
                    item.Cells[4].Value = int.Parse(item.Cells[2].Value.ToString()) * int.Parse(item.Cells[3].Value.ToString());
                    TongTien();
                    txttongtien.Text = TinhTongTien().ToString();
                    return;
                }
            }
            dgvbang2.Rows.Add(new object[] {
            dgvbang1.CurrentRow.Cells[0].Value.ToString(),
            dgvbang1.CurrentRow.Cells[1].Value.ToString(),
            dgvbang1.CurrentRow.Cells[2].Value,1,
            dgvbang1.CurrentRow.Cells[2].Value.ToString()

                });
            txttongtien.Text = TinhTongTien().ToString();


        }


        private void TongTien()
        {
            int tongTien = 0;

            // Duyệt qua từng dòng trong DataGridView
            foreach (DataGridViewRow row in dgvbang2.Rows)
            {
                // Kiểm tra giá trị của ô cột 4 (hoặc cột bạn đang sử dụng để tính thành tiền)
                if (row.Cells[4].Value != null)
                {
                    // Thêm giá trị của ô cột 4 vào tổng tiền
                    tongTien += Convert.ToInt32(row.Cells[4].Value);
                }
            }
        }

        private void dgvbang2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dgvbang2.Columns[e.ColumnIndex].Name;

            if (columnName == "delete")
            {
                DataGridViewRow selectedRow = dgvbang2.Rows[e.RowIndex];
                dgvbang2.Rows.Remove(selectedRow);
                TongTien();
            }

            if (columnName == "update")
            {
                object cellValue = dgvbang2.Rows[e.RowIndex].Cells[2].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int result))
                {
                    int currentQuantity = Convert.ToInt32(dgvbang2.Rows[e.RowIndex].Cells[3].Value);
                    if (currentQuantity <= 0)
                    {
                        MessageBox.Show("Số lượng nhập vào không được âm");
                        return;
                    }
                    dgvbang2.Rows[e.RowIndex].Cells[3].Value = currentQuantity;
                    dgvbang2.Rows[e.RowIndex].Cells[4].Value = currentQuantity * int.Parse(dgvbang2.Rows[e.RowIndex].Cells[2].Value.ToString());
                    TongTien();
                }
                else
                {
                    MessageBox.Show("Số lượng nhập vào không hợp lệ");
                }
            }
        }

        private decimal TinhTongTien()
        {
            decimal tongTien = 0;

            // Duyệt qua từng dòng trong DataGridView
            foreach (DataGridViewRow row in dgvbang2.Rows)
            {
                // Kiểm tra giá trị của ô cột 4 (hoặc cột bạn đang sử dụng để tính thành tiền)
                if (row.Cells[4].Value != null && row.Cells[4].Value != DBNull.Value)
                {
                    // Chuyển đổi giá trị của ô thành kiểu số nguyên
                    if (decimal.TryParse(row.Cells[4].Value.ToString(), out decimal giaTri))
                    {
                        // Thêm giá trị của ô vào tổng tiền
                        tongTien += giaTri;
                    }
                }
            }

            return tongTien;
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {

        }

        private void btnmua_Click(object sender, EventArgs e)
        {
            if (dgvbang2.Rows.Count != 0)
            {
                hdbo.AddHoaDon(tk.MaNhanVien);
                int MaxDH = hdbo.maxDH();
                foreach (DataGridViewRow item in dgvbang2.Rows)
                {

                    if (item.Cells[0].Value != null && item.Cells[1].Value != null &&
                        item.Cells[2].Value != null)
                    {
                        cthdbo.AddChiTietHoaDon(MaxDH, spbo.getMaSanPham(item.Cells[0].Value.ToString()),
                            item.Cells[0].Value.ToString(),
                            int.Parse(item.Cells[3].Value.ToString()),
                             long.Parse(item.Cells[2].Value.ToString()));
                    }
                }
                dgvbang2.Rows.Clear();
                MessageBox.Show("Mua hàng thành công! Vui lòng kiểm tra ở lịch sử mua hàng.");
            }
            else
                MessageBox.Show("Vui lòng chọn hàng vào giỏ hàng!");
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text;
            if (timkiem == " ")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {

                dgvbang1.DataSource = spbo.GetTKSP(timkiem);
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
