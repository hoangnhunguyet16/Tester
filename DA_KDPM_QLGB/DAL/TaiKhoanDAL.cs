using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectSettings.Properties;
using DTO;

namespace DAL
{
    public class TaiKhoanDAL
    {
        DB_KDPM_QLGBDataContext dt = new DB_KDPM_QLGBDataContext(Settings.Default.UserConnectionString);

        public TaiKhoanDAL() { }

        public TaiKhoan GetTaiKhoan(string tenDangNhap, string matKhau)
        {
            return dt.TaiKhoans.Where(t => t.TenDangNhap.Equals(tenDangNhap) && t.MatKhau.Equals(matKhau)).FirstOrDefault();
        }
    }
}
