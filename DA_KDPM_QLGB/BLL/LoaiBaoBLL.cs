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
    }
}
