using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL tkDAL = new TaiKhoanDAL();

        public TaiKhoanBLL() { }

        public TaiKhoan LoadTaiKhoan(string tenDangNhap, string matKhau)
        {
            return tkDAL.GetTaiKhoan(tenDangNhap, matKhau);
        }
    }
}
