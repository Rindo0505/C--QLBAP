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
    public partial class FormThongKe : Form
    {
        HoaDonbo hdbo = new HoaDonbo();
        public FormThongKe()
        {
            InitializeComponent();
            for (int i = 1; i <= 12; i++)
            { 
                dgvthongke.DataSource = hdbo.ThongKeHD();
            }
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {

        }
    }
}
