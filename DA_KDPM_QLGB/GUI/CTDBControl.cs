using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CTDBControl : UserControl
    {
        public CTDBControl()
        {
            InitializeComponent();
        }

        public void SetDLCTDB(string ten, string giaTien, string soLuong, string thanhTien, string ngayBD, string ngayKT)
        {
            lblTenLoaiBao.Text += ten;
            lblGiaTien.Text += giaTien;
            lblSoLuong.Text += soLuong;
            lblThanhTien.Text += thanhTien;
            lblTuNgay.Text += ngayBD;
            lblDenNgay.Text += ngayKT;
        }
    }
}
