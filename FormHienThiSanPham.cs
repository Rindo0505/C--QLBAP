using QuanLyBanSach.bean;
using QuanLyBanSach.bo;
using QuanLyBanSach.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSach
{
    public partial class FormHienThiSanPham : Form
    {
        KetNoi kn = new KetNoi();
        SanPhambo spbo = new SanPhambo();
        string fileAnh;
        public TaiKhoanbean tk { get; set; }
        public int MaHD { get; set; }
        public FormHienThiSanPham(TaiKhoanbean tk, int maHD)
        {

            InitializeComponent();

            dgvhang.DataSource = spbo.GetSanPham();
            this.tk = tk;
            MaHD = maHD;
        }
        private void FormHienThiSanPham_Load(object sender, EventArgs e)

        {
            LoadData();

        }
        void LoadData()
        {
            DataTable dthang = kn.ReadData("select * from SanPham");

            dgvhang.DataSource = dthang;
        }

        private void dgvhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtma.Text = dgvhang.CurrentRow.Cells[0].Value.ToString();
            txtten.Text = dgvhang.CurrentRow.Cells[1].Value.ToString();
            txtgiaban.Text = dgvhang.CurrentRow.Cells[3].Value.ToString();
            Cbbmaloai.Text = dgvhang.CurrentRow.Cells[4].Value.ToString();
            fileAnh = dgvhang.CurrentRow.Cells[2].Value.ToString();
            ptbanh.Image = Image.FromFile(fileAnh);



        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormMenu(tk, MaHD);
            f.ShowDialog();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            string masp = txtma.Text;
            string tensp = txtten.Text;
            long giaban = long.Parse(txtgiaban.Text);
            string maloai = Cbbmaloai.Text;
            string anhsp = ptbanh.ImageLocation.ToString();

            if (masp == "" || tensp == "" || giaban == 0 || maloai == "")
            {
                MessageBox.Show("vui lòng điền đầy đủ thông tin");
            }
            else
            {
                //List<SanPhambean> sp = spbo.GetSanPham();
                if (spbo.CheckDuplicateSanPham(masp))
                {
                    MessageBox.Show("Mã sản phẩm này đã tồn tại, vui lòng nhập mã sản phẩm khác");
                }

                else
                {
                    int them = spbo.AddSanPham(masp, tensp, anhsp, giaban, maloai);
                    if (them > 0)
                    {
                        MessageBox.Show("Thêm sản phẩm thành công");
                        dgvhang.DataSource = spbo.GetSanPham();
                    }
                    else
                        MessageBox.Show("Thêm sản phẩm thất bại");

                }
            }
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

        private void btnsua_Click(object sender, EventArgs e)
        {
            string masp = txtma.Text;
            string tensp = txtten.Text;
            long giaban = long.Parse(txtgiaban.Text);
            string maloai = Cbbmaloai.Text;
            string anhsp = ptbanh.ImageLocation.ToString();

            List<SanPhambean> sp = spbo.GetSanPham();
            if (sp != null)
            {
                spbo.updateSanPham(masp, tensp, anhsp, giaban, maloai);
                MessageBox.Show("Cập nhật thành công");
                dgvhang.DataSource = spbo.GetSanPham();
            }
            else
            {
                MessageBox.Show("Cập nhập thất bại");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string masp = txtma.Text;
            if (spbo.CheckDuplicateSanPham(masp))
            {
                if (MessageBox.Show("Bạn có muốn xóa sản phẩm này không?", "Thông báo",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    spbo.deleteSanPham(masp);
                    MessageBox.Show("Đã xóa sản phẩm");
                    dgvhang.DataSource = spbo.GetSanPham();
                }
            }
        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {

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

                dgvhang.DataSource = spbo.GetTKSP(timkiem);
            }
        }
    }
}
