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
    public partial class FrmTrangChu : Form
    {
        TaiKhoan tk = new TaiKhoan();
        Utilities utl = new Utilities();

        public FrmTrangChu(TaiKhoan tk)
        {
            this.tk = tk;
            InitializeComponent();
        }

        private void FrmTrangChu_Load(object sender, EventArgs e)
        {
            lblTaiKhoan.Text = string.Format("Xin chào {0}", tk.TenDangNhap);
            HideSubMenu();
        }

        #region Sub menu
        private void ShowSubMenu(Panel pnl)
        {
            if (pnl.Visible == false)
            {
                HideSubMenu();
                pnl.Visible = true;
            }
            else
                pnl.Visible = false;
        }

        private void HideSubMenu()
        {
            if (pnlQuanLySubMenu.Visible == true)
                pnlQuanLySubMenu.Visible = false;

            if (pnlChucNangSubMenu.Visible == true)
                pnlChucNangSubMenu.Visible = false;

            if (pnlHeThongSubMenu.Visible == true)
                pnlHeThongSubMenu.Visible = false;
        }

        
        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlQuanLySubMenu);
        }

        private void btnChucNang_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlChucNangSubMenu);
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlHeThongSubMenu);
        }
        #endregion
        
        private void btnLoaiBao_Click(object sender, EventArgs e)
        {
            FrmLoaiBao frm = new FrmLoaiBao();
            utl.LoadChildForm(frm, pnlMain);
            HideSubMenu();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            FrmKhachHang frm = new FrmKhachHang();
            utl.LoadChildForm(frm, pnlMain);
            HideSubMenu();
        }

        private void btnDatBao_Click(object sender, EventArgs e)
        {
            FrmDatBao frm = new FrmDatBao((int)tk.MaNV);
            utl.LoadChildForm(frm, pnlMain);
            HideSubMenu();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            FrmBackup frm = new FrmBackup();
            utl.LoadChildForm(frm, pnlMain);
            HideSubMenu();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Xác nhận đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
            {
                this.SetVisibleCore(false);
                FrmDangNhap frm = new FrmDangNhap();
                frm.Show();
            }

            return;
        }
    }
}
