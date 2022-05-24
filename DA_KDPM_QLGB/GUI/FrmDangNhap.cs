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
using ProjectSettings;

namespace GUI
{
    public partial class FrmDangNhap : Form
    {
        TaiKhoanBLL tkBLL = new TaiKhoanBLL();

        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }

            return;
        }

        private int KiemTraDangNhap(TaiKhoan tk)
        {
            if (tk == null)
                return -1;
            else if (tk.TinhTrang == false)
                return 0;
            else
                return 1;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(t => String.IsNullOrEmpty(t.Text)))
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TaiKhoan tk = tkBLL.LoadTaiKhoan(txtTenDangNhap.Text, txtMatKhau.Text);
            int kq = KiemTraDangNhap(tk);

            if (kq == -1)
            {
                MessageBox.Show("Vui lòng kiểm tra lại tên đăng nhập và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (kq == 0)
            {
                MessageBox.Show("Tài khoản hiện đang bị khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            else
            {
                FrmTrangChu frm = new FrmTrangChu(tk);
                frm.Show();
                this.Hide();
            }
        }
    }
}
