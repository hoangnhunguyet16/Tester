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
    public partial class FrmDatBao : Form
    {
        KhachHangBLL khBLL = new KhachHangBLL();
        LoaiBaoBLL lbBLL = new LoaiBaoBLL();
        DatBaoBLL dbBLL = new DatBaoBLL();
        ChiTietDatBaoBLL ctdbBLL = new ChiTietDatBaoBLL();
        Utilities utl = new Utilities();

        int stt = 0;
        int maNV = 0;
        double tongTien = 0;

        KhachHang kh;
        LoaiBao lb;
        List<ChiTietDatBao> ctdbList = new List<ChiTietDatBao>();

        public FrmDatBao(int maNV)
        {
            this.maNV = maNV;
            InitializeComponent();
        }

        private void Default()
        {
            ctdbList.Clear();
            lsvDLCTDB.Items.Clear();
            grbThongTinKH.Controls.OfType<TextBox>().ToList().ForEach(t => t.Clear());
            kh = null;
            tongTien = stt = 0;
            btnXacNhan.Text = "Xác nhận";
            txtSoLuong.Clear();
            lblTongTienThanhToan.Text = "";
            grbThongTinKH.Enabled = cmbKhachHang.Enabled = true;
        }

        private void LoadDL()
        {
            cmbKhachHang.DataSource = khBLL.LoadDLKhachHang();
            cmbKhachHang.DisplayMember = "TenKH";
            cmbKhachHang.ValueMember = "MaKH";

            cmbLoaiBao.DataSource = lbBLL.LoadDLLoaiBao();
            cmbLoaiBao.DisplayMember = "TenLoaiBao";
            cmbLoaiBao.ValueMember = "MaLoaiBao";
        }

        private void FrmDatBao_Load(object sender, EventArgs e)
        {
            LoadDL();
            cmbLoaiBao.SelectedIndex = cmbKhachHang.SelectedIndex = 0;
            dtpNgayBatDau.MinDate = dtpNgayKetThuc.MinDate = DateTime.Today.AddDays(1);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (btnXacNhan.Text.Equals("Xác nhận"))
            {
                if (kh == null)
                {
                    cmbKhachHang.Focus();
                    return;
                }

                btnXacNhan.Text = "Hủy";
                grbThongTinKH.Enabled = cmbKhachHang.Enabled = false;
            }
            else
            {
                kh = null;
                btnXacNhan.Text = "Xác nhận";
                grbThongTinKH.Enabled = cmbKhachHang.Enabled = true;
                grbThongTinKH.Controls.OfType<TextBox>().ToList().ForEach(t => t.Clear());
            }
        }

        private void dtpNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgayBatDau.Value > dtpNgayKetThuc.Value)
            {
                dtpNgayKetThuc.Value = dtpNgayBatDau.Value;
            }
            dtpNgayKetThuc.MinDate = dtpNgayKetThuc.Value;
        }

        private void cmbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKH = cmbKhachHang.SelectedValue.ToString();
            if (maKH.Equals("DTO.KhachHang"))
                return;

            kh = khBLL.LoadDLKhachHangTheoMaKH(int.Parse(maKH));

            txtHoTen.Text = kh.TenKH;
            txtEmail.Text = kh.Email;
            txtSoDienThoai.Text = kh.SDT;
            txtDiaChi.Text = kh.DiaChi;
        }

        private void cmbLoaiBao_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLoaiBao = cmbLoaiBao.SelectedValue.ToString();
            if (maLoaiBao.Equals("DTO.LoaiBao"))
                return;

            lb = lbBLL.LoadDLLoaiBaoTheoMaLoaiBao(int.Parse(maLoaiBao));
        }

        private void TaoVaThemChiTietDaBao()
        {
            stt = lsvDLCTDB.Items.Count + 1;
            int soLuong = int.Parse(txtSoLuong.Text);
            double giaTien = (double)lb.GiaTien;
            double soKy = 0;

            if (lb.TenLoaiBao.Contains("Cuối Tuần"))
            {
                soKy = utl.TimSoLuongNgayCuoiTuan(dtpNgayBatDau.Value, dtpNgayKetThuc.Value);
            }
            else
            {
                soKy = (dtpNgayKetThuc.Value - dtpNgayBatDau.Value).TotalDays + 1;
            }

            double thanhTien = soLuong * (giaTien * soKy);

            ChiTietDatBao ctdbThemMoi = new ChiTietDatBao()
            {
                MaLoaiBao = lb.MaLoaiBao,
                NgayBatDau = dtpNgayBatDau.Value,
                NgayKetThuc = dtpNgayKetThuc.Value,
                SoLuong = soLuong,
                ThanhTien = thanhTien
            };

            if (ctdbList.Any(t => t.MaLoaiBao == ctdbThemMoi.MaLoaiBao))
            {
                ChiTietDatBao ctdbCu = ctdbList.Where(t => t.MaLoaiBao == ctdbThemMoi.MaLoaiBao).Single();
                ctdbCu.SoLuong += ctdbThemMoi.SoLuong;
                ctdbCu.ThanhTien += ctdbThemMoi.ThanhTien;

                lsvDLCTDB.Items.Clear();
                stt = 0;
                foreach (ChiTietDatBao ctdb in ctdbList)
                {
                    stt = lsvDLCTDB.Items.Count + 1;
                    LoaiBao lbThem = lbBLL.LoadDLLoaiBaoTheoMaLoaiBao(ctdb.MaLoaiBao);
                    double soKyThem = (ctdb.NgayKetThuc.Value - ctdb.NgayBatDau.Value).TotalDays + 1;
                    int soLuongThem = (int)ctdb.SoLuong;
                    double thanhTienThem = (double)ctdb.ThanhTien;

                    ListViewItem item = new ListViewItem(new[] 
                        {
                            stt.ToString(),
                            lbThem.TenLoaiBao,
                            lbThem.GiaTien.ToString(),
                            soKyThem.ToString(),
                            soLuongThem.ToString(),
                            thanhTienThem.ToString()
                        });

                    lsvDLCTDB.Items.Add(item);
                }
            }
            else
            {
                ListViewItem item = new ListViewItem(new[] 
                    {
                        stt.ToString(),
                        lb.TenLoaiBao.ToString(),
                        giaTien.ToString(),
                        soKy.ToString(),
                        soLuong.ToString(),
                        thanhTien.ToString()
                    });

                ctdbList.Add(ctdbThemMoi);
                lsvDLCTDB.Items.Add(item);
            }

            tongTien = 0;
            foreach (ChiTietDatBao ctdb in ctdbList)
            {
                tongTien += (double)ctdb.ThanhTien;
            }

            lblTongTienThanhToan.Text = String.Format("{0:#,###,###.##}", tongTien);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lb == null)
            {
                cmbLoaiBao.Focus();
                return;
            }

            TaoVaThemChiTietDaBao();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void TestDuLieu()
        {
            string t = "";
            foreach (ChiTietDatBao ctdb in ctdbList)
            {
                t += string.Format("Mã đặt báo: {0}, Mã loại báo: {1}, Ngày BD: {2}, Ngày KT: {3}, Số lượng: {4}, Thành tiền: {5}\n",
                        ctdb.MaDatBao.ToString(),
                        ctdb.MaLoaiBao.ToString(),
                        ctdb.NgayBatDau.Value.ToString(),
                        ctdb.NgayKetThuc.Value.ToString(),
                        ctdb.SoLuong.ToString(),
                        ctdb.ThanhTien.ToString()
                    );
            }
            MessageBox.Show(t);
        }

        private void btnDatBao_Click(object sender, EventArgs e)
        {
            if (kh == null)
            {
                cmbKhachHang.Focus();
                return;
            }

            DatBao db = new DatBao()
            {
                NgayDat = DateTime.Today,
                MaKH = kh.MaKH,
                MaNV = maNV,
                TongTien = tongTien,
                TinhTrang = true
            };

            try
            {
                dbBLL.ThemDatBao(db);

                int maDatBaoCC = dbBLL.LoadDLGetDLMaDatBaoCuoiCung();

                ctdbList.ForEach(t => t.MaDatBao = maDatBaoCC);
                ctdbList.ForEach(t => ctdbBLL.ThemChiTietDatBao(t));

                MessageBox.Show("Đặt báo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Default();
            }
            catch (Exception)
            {
                MessageBox.Show("Đặt báo thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
