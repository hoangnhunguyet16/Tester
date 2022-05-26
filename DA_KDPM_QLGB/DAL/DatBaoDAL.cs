using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectSettings.Properties;
using DTO;

namespace DAL
{
    public class DatBaoDAL
    {
        DB_KDPM_QLGBDataContext dt = new DB_KDPM_QLGBDataContext(Settings.Default.UserConnectionString);
        KhachHangDAL khDAL = new KhachHangDAL();

        public DatBaoDAL() { }

        public List<DatBao> GetDLDatBao()
        {
            return dt.DatBaos.ToList();
        }

        public List<view_DanhSachDatBao> GetDLDSDatBao()
        {
            return dt.view_DanhSachDatBaos.ToList();
        }

        public List<DatBao> GetDLDatBaoTheoTenKH(string tenKH)
        {
            KhachHang kh = khDAL.GetDLKhachHangTheoTen(tenKH).Single();
            return dt.DatBaos.Where(t => t.MaKH == kh.MaKH).ToList();
        }

        public List<view_DanhSachDatBao> GetDLDSDatBaoTheoTenKH(string tenKH)
        {
            return dt.view_DanhSachDatBaos.Where(t => t.TenKH.Contains(tenKH)).ToList();
        }

        public int GetDLMaDatBaoCuoiCung()
        {
            return dt.DatBaos.OrderByDescending(t => t.MaDatBao).First().MaDatBao;
        }

        public bool ThemDatBao(DatBao db)
        {
            try
            {
                dt.DatBaos.InsertOnSubmit(db);
                dt.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool XoaDatBao(int maDatBao)
        {
            try
            {
                DatBao db = dt.DatBaos.Single(t => t.MaDatBao == maDatBao);
                dt.DatBaos.DeleteOnSubmit(db);
                dt.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool SuaDatBao(DatBao db)
        {
            try
            {
                DatBao dbSua = dt.DatBaos.Single(t => t.MaDatBao == db.MaDatBao);
                dbSua.NgayDat = db.NgayDat;
                dbSua.MaKH = db.MaKH;
                dbSua.MaNV = db.MaNV;
                dbSua.TongTien = db.TongTien;
                dbSua.TinhTrang = db.TinhTrang;

                dt.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
