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
    public partial class FrmKhachHang : Form
    {
        KhachHangBLL khBLL = new KhachHangBLL();
        string loaiThucThi = string.Empty;

        public FrmKhachHang()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Tất cả các control thông tin loại báo bị vô hiệu hóa, dữ liệu trống trừ nút thêm và data grid view hiển thị dữ liệu
        /// </summary>
        private void LoadCauHinhControl()
        {
            dgvDLKhachHang.DataSource = khBLL.LoadDLKhachHang();
            dgvDLKhachHang.ClearSelection();
            grbThongTin.Controls.OfType<TextBox>().ToList().ForEach(t => t.Enabled = false);
            grbThongTin.Controls.OfType<TextBox>().ToList().ForEach(t => t.Text = string.Empty);
            grbThongTin.Controls.OfType<Button>().Where(t => t != btnThem).ToList().ForEach(t => t.Enabled = false);
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            LoadCauHinhControl();
        }

        private void dgvDLKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDLKhachHang.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDLKhachHang.SelectedRows[0];
                btnXoa.Enabled = btnSua.Enabled = true;

                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTenKH.Text = row.Cells[1].Value.ToString();
                txtEmail.Text = row.Cells[2].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();
                txtSoDienThoai.Text = row.Cells[4].Value.ToString();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvDLKhachHang.ClearSelection();
            dgvDLKhachHang.DataSource = khBLL.LoadDLKhachHangTheoTen(txtTimKiem.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvDLKhachHang.DataSource = khBLL.LoadDLKhachHang();
        }

        #region Các nghiệp vụ
        private void ThemKhachHang()
        {
            if (grbThongTin.Controls.OfType<TextBox>().Where(t => t != txtMaKH).Any(t => String.IsNullOrEmpty(t.Text)))
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KhachHang kh = new KhachHang()
            {
                TenKH = txtTenKH.Text,
                Email = txtEmail.Text,
                DiaChi = txtDiaChi.Text,
                SDT = txtSoDienThoai.Text
            };

            if (khBLL.ThemKhachHang(kh))
            {
                LoadCauHinhControl();
                btnThem.Enabled = true;
                loaiThucThi = string.Empty;
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void XoaKhachHang(int maKH)
        {
            if (khBLL.XoaKhachHang(maKH))
            {
                LoadCauHinhControl();
            }
            else
            {
                MessageBox.Show("Xóa khách hàng thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void SuaKhachHang()
        {
            if (grbThongTin.Controls.OfType<TextBox>().Where(t => t != txtMaKH).Any(t => String.IsNullOrEmpty(t.Text)))
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KhachHang kh = new KhachHang()
            {
                MaKH = int.Parse(txtMaKH.Text),
                TenKH = txtTenKH.Text,
                Email = txtEmail.Text,
                DiaChi = txtDiaChi.Text,
                SDT = txtSoDienThoai.Text
            };

            if (khBLL.SuaKhachHang(kh))
            {
                LoadCauHinhControl();
                btnThem.Enabled = true;
                loaiThucThi = string.Empty;
            }
            else
            {
                MessageBox.Show("Sua khách hàng thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        #endregion

        private void btnThem_Click(object sender, EventArgs e)
        {
            grbThongTin.Controls.OfType<TextBox>().Where(t => t != txtMaKH).ToList().ForEach(t => t.Enabled = true);
            grbThongTin.Controls.OfType<TextBox>().ToList().ForEach(t => t.Text = string.Empty);

            btnLuu.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            loaiThucThi = "Them";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(string.Format("Xóa khách hàng: {0}", txtTenKH.Text), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
            {
                XoaKhachHang(int.Parse(txtMaKH.Text));
            }

            return;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            grbThongTin.Controls.OfType<TextBox>().Where(t => t != txtMaKH).ToList().ForEach(t => t.Enabled = true);

            btnLuu.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            loaiThucThi = "Sua";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (loaiThucThi)
            {
                case "Them":
                    ThemKhachHang();
                    break;
                case "Sua":
                    SuaKhachHang();
                    break;
            }
        }
    }
}
