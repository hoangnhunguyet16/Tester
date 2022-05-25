using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class FrmThongKe : Form
    {
        ChiTietDatBaoBLL ctdbBLL = new ChiTietDatBaoBLL();
        LoaiBaoBLL lbBLL = new LoaiBaoBLL();

        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            List<view_ThongKeSoLuongDatLoaiBao> lstTK = ctdbBLL.LoadDLThongKeSoLuongDatLoaiBao();

            chartThongKe.ChartAreas["areaThongKe"].AxisX.Interval = 1;
            chartThongKe.Series["ThongKe"].XValueMember = "TenLoaiBao";
            chartThongKe.Series["ThongKe"].YValueMembers = "SoLuong";

            foreach (var item in lstTK)
            {
                LoaiBao lb = lbBLL.LoadDLLoaiBaoTheoMaLoaiBao(item.MaLoaiBao);
                chartThongKe.Series["ThongKe"].Points.AddXY(lb.TenLoaiBao, item.SoLuong);
            }
        }
    }
}
