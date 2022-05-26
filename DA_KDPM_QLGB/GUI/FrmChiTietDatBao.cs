using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class FrmChiTietDatBao : Form
    {
        int maDatBao = 0;
        ChiTietDatBaoBLL ctdbBLL = new ChiTietDatBaoBLL();
        List<view_ChiTietDatBao> lst;
        Utilities utl = new Utilities();

        public FrmChiTietDatBao(int maDatBao)
        {
            this.maDatBao = maDatBao;
            InitializeComponent();

            lblHeader.Text = string.Format("CHI TIẾT ĐẶT BÁO MÃ ĐẶT BÁO {0}", maDatBao);
            lst = ctdbBLL.LoadDLChiTietDatBaoTheoMaDatBao(maDatBao);
        }

        private void FrmChiTietDatBao_Load(object sender, EventArgs e)
        {
            foreach (var item in lst)
            {
                CTDBControl ctdbCtrl = new CTDBControl();
                ctdbCtrl.SetDLCTDB(item.TenLoaiBao, String.Format("{0:#,###,###.##}", item.GiaTien), item.SoLuong.ToString(), String.Format("{0:#,###,###.##}", item.ThanhTien), item.NgayBatDau.Value.ToShortDateString(), item.NgayKetThuc.Value.ToShortDateString());
                ctdbCtrl.Left = (this.ClientSize.Width - ctdbCtrl.Width) / 2;
                ctdbCtrl.Top = (this.ClientSize.Height - ctdbCtrl.Height) / 2;
                fpnlDSChiTietDatBao.Controls.Add(ctdbCtrl);
                ctdbCtrl.Anchor = AnchorStyles.None;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FrmDSDatBao frm = new FrmDSDatBao();
            Panel pnl = this.Parent as Panel;
            pnl.Controls.Clear();

            utl.LoadChildForm(frm, pnl);
        }
    }
}
