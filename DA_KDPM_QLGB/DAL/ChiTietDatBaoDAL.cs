using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectSettings.Properties;
using DTO;

namespace DAL
{
    public class ChiTietDatBaoDAL
    {
        DB_KDPM_QLGBDataContext dt = new DB_KDPM_QLGBDataContext(Settings.Default.UserConnectionString);

        public ChiTietDatBaoDAL() { }

        public List<ChiTietDatBao> GetDLChiTietDatBao()
        {
            return dt.ChiTietDatBaos.ToList();
        }

        public List<ChiTietDatBao> GetDLChiTietDatBaoTheoMaDB(int maDatBao)
        {
            return dt.ChiTietDatBaos.Where(t => t.MaDatBao == maDatBao).ToList();
        }

        public List<view_ThongKeSoLuongDatLoaiBao> GetDLThongKeSoLuongDatLoaiBao()
        {
            return dt.view_ThongKeSoLuongDatLoaiBaos.ToList();
        }

        public bool ThemChiTietDatBao(ChiTietDatBao ctdb)
        {
            try
            {
                dt.ChiTietDatBaos.InsertOnSubmit(ctdb);
                dt.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool XoaChiTietDatBao(int maDatBao, int maLoaiBao)
        {
            try
            {
                ChiTietDatBao ctdb = dt.ChiTietDatBaos.Single(t => t.MaDatBao == maDatBao && t.MaLoaiBao == maLoaiBao);
                dt.ChiTietDatBaos.DeleteOnSubmit(ctdb);
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
