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
    public partial class FrmLoaiBao : Form
    {
        LoaiBaoBLL lbBLL = new LoaiBaoBLL();

        public FrmLoaiBao()
        {
            InitializeComponent();
        }

        private void FrmLoaiBao_Load(object sender, EventArgs e)
        {
            dgvDLLoaiBao.DataSource = lbBLL.LoadDLLoaiBao();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvDLLoaiBao.DataSource = lbBLL.LoadDLLoaiBaoTheoTen(txtTimKiem.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvDLLoaiBao.DataSource = lbBLL.LoadDLLoaiBao();
        }

        private void dgvDLLoaiBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDLLoaiBao.SelectedRows.Count > 0)
            {
                txtMaLoaiBao.Text = dgvDLLoaiBao.SelectedRows[0].Cells[0].Value.ToString();
                txtTenLoaiBao.Text = dgvDLLoaiBao.SelectedRows[0].Cells[1].Value.ToString();
                txtGiaTien.Text = dgvDLLoaiBao.SelectedRows[0].Cells[2].Value.ToString();
            }
        }


    }
}
