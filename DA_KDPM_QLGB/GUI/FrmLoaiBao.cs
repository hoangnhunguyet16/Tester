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
        string loaiThucThi = string.Empty;

        public FrmLoaiBao()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Tất cả các control thông tin loại báo bị vô hiệu hóa, dữ liệu trống trừ nút thêm và data grid view hiển thị dữ liệu
        /// </summary>
        private void LoadCauHinhControl()
        {
            dgvDLLoaiBao.DataSource = lbBLL.LoadDLLoaiBao();
            dgvDLLoaiBao.ClearSelection();
            grbThongTin.Controls.OfType<TextBox>().ToList().ForEach(t => t.Enabled = false);
            grbThongTin.Controls.OfType<TextBox>().ToList().ForEach(t => t.Text = string.Empty);
            grbThongTin.Controls.OfType<Button>().Where(t => t != btnThem).ToList().ForEach(t => t.Enabled = false);
        }

        private void FrmLoaiBao_Load(object sender, EventArgs e)
        {
            LoadCauHinhControl();
        }

        private void dgvDLLoaiBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDLLoaiBao.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDLLoaiBao.SelectedRows[0];
                btnXoa.Enabled = btnSua.Enabled = true;

                txtMaLoaiBao.Text = row.Cells[0].Value.ToString();
                txtTenLoaiBao.Text = row.Cells[1].Value.ToString();
                txtGiaTien.Text = row.Cells[2].Value.ToString();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvDLLoaiBao.ClearSelection();
            dgvDLLoaiBao.DataSource = lbBLL.LoadDLLoaiBaoTheoTen(txtTimKiem.Text);
        }

        #region Các nghiệp vụ
        private void ThemLoaiBao()
        {
            if (grbThongTin.Controls.OfType<TextBox>().Where(t => t != txtMaLoaiBao).Any(t => String.IsNullOrEmpty(t.Text)))
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoaiBao lb = new LoaiBao()
            {
                TenLoaiBao = txtTenLoaiBao.Text,
                GiaTien = double.Parse(txtGiaTien.Text)
            };

            if (lbBLL.ThemLoaiBao(lb))
            {
                LoadCauHinhControl();
                btnThem.Enabled = true;
                loaiThucThi = string.Empty;
            }
            else
            {
                MessageBox.Show("Thêm loại báo thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void XoaLoaiBao(int maLoaiBao)
        {
            if (lbBLL.XoaLoaiBao(maLoaiBao))
            {
                LoadCauHinhControl();
            }
            else
            {
                MessageBox.Show("Xóa loại báo thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void SuaLoaiBao()
        {
            if (grbThongTin.Controls.OfType<TextBox>().Where(t => t != txtMaLoaiBao).Any(t => String.IsNullOrEmpty(t.Text)))
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoaiBao lb = new LoaiBao()
            {
                MaLoaiBao = int.Parse(txtMaLoaiBao.Text),
                TenLoaiBao = txtTenLoaiBao.Text,
                GiaTien = double.Parse(txtGiaTien.Text)
            };

            if (lbBLL.SuaLoaiBao(lb))
            {
                LoadCauHinhControl();
                btnThem.Enabled = true;
                loaiThucThi = string.Empty;
            }
            else
            {
                MessageBox.Show("Sua loại báo thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        #endregion

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvDLLoaiBao.DataSource = lbBLL.LoadDLLoaiBao();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            grbThongTin.Controls.OfType<TextBox>().Where(t => t != txtMaLoaiBao).ToList().ForEach(t => t.Enabled = true);
            grbThongTin.Controls.OfType<TextBox>().ToList().ForEach(t => t.Text = string.Empty);

            btnLuu.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            loaiThucThi = "Them";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(string.Format("Xóa loại báo: {0}", txtTenLoaiBao.Text), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
            {
                XoaLoaiBao(int.Parse(txtMaLoaiBao.Text));
            }

            return;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            grbThongTin.Controls.OfType<TextBox>().Where(t => t != txtMaLoaiBao).ToList().ForEach(t => t.Enabled = true);

            btnLuu.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            loaiThucThi = "Sua";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (loaiThucThi)
            {
                case "Them":
                    ThemLoaiBao();
                    break;
                case "Sua":
                    SuaLoaiBao();
                    break;
            }
        }
    }
}
