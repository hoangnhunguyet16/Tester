using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectSettings.Properties;
using DTO;

namespace DAL
{
    public class LoaiBaoDAL
    {
        DB_KDPM_QLGBDataContext dt = new DB_KDPM_QLGBDataContext(Settings.Default.UserConnectionString);

        public LoaiBaoDAL() { }

        public List<LoaiBao> GetDLLoaiBao()
        {
            return dt.LoaiBaos.ToList();
        }

        public List<LoaiBao> GetDLLoaiBaoTheoTen(string ten)
        {
            return dt.LoaiBaos.Where(t => t.TenLoaiBao.Contains(ten)).ToList();
        }

        public bool ThemLoaiBao(LoaiBao lb)
        {
            try
            {
                dt.LoaiBaos.InsertOnSubmit(lb);
                dt.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool XoaLoaiBao(int maLoaiBao)
        {
            try
            {
                LoaiBao lb = dt.LoaiBaos.Single(t => t.MaLoaiBao == maLoaiBao);
                dt.LoaiBaos.DeleteOnSubmit(lb);
                dt.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool SuaLoaiBao(LoaiBao lb)
        {
            try
            {
                LoaiBao lbSua = dt.LoaiBaos.Single(t => t.MaLoaiBao == lb.MaLoaiBao);
                lbSua.TenLoaiBao = lb.TenLoaiBao;
                lbSua.GiaTien = lb.GiaTien;

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
