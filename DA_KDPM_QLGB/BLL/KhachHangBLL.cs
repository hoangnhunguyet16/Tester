using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class KhachHangBLL
    {
        KhachHangDAL khDAL = new KhachHangDAL();

        public KhachHangBLL() { }

        public List<KhachHang> LoadDLKhachHang()
        {
            return khDAL.GetDLKhachHang();
        }

        public List<KhachHang> LoadDLKhachHangTheoTen(string ten)
        {
            return khDAL.GetDLKhachHangTheoTen(ten);
        }

        public bool ThemKhachHang(KhachHang kh)
        {
            return khDAL.ThemKhachHang(kh);
        }

        public bool XoaKhachHang(int maKH)
        {
            return khDAL.XoaKhachHang(maKH);
        }

        public bool SuaKhachHang(KhachHang kh)
        {
            return khDAL.SuaKhachHang(kh);
        }
    }
}
