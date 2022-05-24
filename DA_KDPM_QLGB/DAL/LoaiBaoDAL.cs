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
    }
}
