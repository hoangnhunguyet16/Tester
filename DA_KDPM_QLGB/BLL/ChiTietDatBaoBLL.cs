using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ChiTietDatBaoBLL
    {
        ChiTietDatBaoDAL ctdbDAL = new ChiTietDatBaoDAL();

        public ChiTietDatBaoBLL() { }

        public List<ChiTietDatBao> LoadDLChiTietDatBao()
        {
            return ctdbDAL.GetDLChiTietDatBao();
        }

        public List<ChiTietDatBao> LoadDLGetDLChiTietDatBaoTheoMaDB(int maDatBao)
        {
            return ctdbDAL.GetDLChiTietDatBaoTheoMaDB(maDatBao);
        }

        public bool ThemChiTietDatBao(ChiTietDatBao ctdb)
        {
            return ctdbDAL.ThemChiTietDatBao(ctdb);
        }

        public bool XoaChiTietDatBao(int maDatBao, int maLoaiBao)
        {
            return ctdbDAL.XoaChiTietDatBao(maDatBao, maLoaiBao);
        }
    }
}
