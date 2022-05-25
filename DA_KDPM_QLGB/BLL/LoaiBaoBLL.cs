using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class LoaiBaoBLL
    {
        LoaiBaoDAL lbDAL = new LoaiBaoDAL();

        public LoaiBaoBLL() { }

        public List<LoaiBao> LoadDLLoaiBao()
        {
            return lbDAL.GetDLLoaiBao();
        }

        public List<LoaiBao> LoadDLLoaiBaoTheoTen(string ten)
        {
            return lbDAL.GetDLLoaiBaoTheoTen(ten);
        }

        public bool ThemLoaiBao(LoaiBao lb)
        {
            return lbDAL.ThemLoaiBao(lb);
        }

        public bool XoaLoaiBao(int maLoaiBao)
        {
            return lbDAL.XoaLoaiBao(maLoaiBao);
        }

        public bool SuaLoaiBao(LoaiBao lb)
        {
            return lbDAL.SuaLoaiBao(lb);
        }
    }
}
