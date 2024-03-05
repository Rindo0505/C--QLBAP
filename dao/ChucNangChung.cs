using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyBanSach.dao
{
    public class ChucNangChung
    {
        public void  FillComboBox( ComboBox comboName ,DataTable data, string displayMenber, string valueMenber)
        {
            comboName.DataSource = data;
            comboName.DisplayMember = displayMenber;
            comboName.ValueMember = valueMenber;
        }

    }
}
