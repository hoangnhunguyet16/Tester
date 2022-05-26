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
    public partial class FrmDSDatBao : Form
    {
        DatBaoBLL dbBLL = new DatBaoBLL();
        Utilities utl = new Utilities();

        public FrmDSDatBao()
        {
            InitializeComponent();
        }

        private void FrmDSDatBao_Load(object sender, EventArgs e)
        {
            dgvDLDatSach.DataSource = dbBLL.LoadDLDSDatBao();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvDLDatSach.DataSource = dbBLL.LoadDLDSDatBaoTheoTenKH(txtTimKiem.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvDLDatSach.DataSource = dbBLL.LoadDLDSDatBao();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvDLDatSach.SelectedRows.Count > 0) 
            {
                int maDB = int.Parse(dgvDLDatSach.SelectedRows[0].Cells[0].Value.ToString());

                FrmChiTietDatBao frmCT = new FrmChiTietDatBao(maDB);

                Panel pnl = this.Parent as Panel;
                pnl.Controls.Clear();

                utl.LoadChildForm(frmCT, pnl);
            }
        }
    }
}
