using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using ProjectSettings.Properties;

namespace DAL
{
    public class KhachHangDAL
    {
        DB_KDPM_QLGBDataContext dt = new DB_KDPM_QLGBDataContext(Settings.Default.UserConnectionString);

        public KhachHangDAL() { }

        public List<KhachHang> GetDLKhachHang()
        {
            return dt.KhachHangs.ToList();
        }

        public List<KhachHang> GetDLKhachHangTheoTen(string ten)
        {
            return dt.KhachHangs.Where
                (
                    t => 
                        t.TenKH.Contains(ten) ||
                        t.Email.Contains(ten) ||
                        t.DiaChi.Contains(ten) ||
                        t.SDT.Contains(ten)
                ).ToList();
        }

        public bool ThemKhachHang(KhachHang kh)
        {
            try
            {
                dt.KhachHangs.InsertOnSubmit(kh);
                dt.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool XoaKhachHang(int maKH)
        {
            try
            {
                KhachHang kh = dt.KhachHangs.Single(t => t.MaKH == maKH);
                dt.KhachHangs.DeleteOnSubmit(kh);
                dt.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool SuaKhachHang(KhachHang kh)
        {
            try
            {
                KhachHang khSua = dt.KhachHangs.Single(t => t.MaKH == kh.MaKH);
                khSua.TenKH = kh.TenKH;
                khSua.Email = kh.Email;
                khSua.DiaChi = kh.DiaChi;
                khSua.SDT = kh.SDT;

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
