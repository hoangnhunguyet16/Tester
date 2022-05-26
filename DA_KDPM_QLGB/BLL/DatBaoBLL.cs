using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class DatBaoBLL
    {
        DatBaoDAL dbDAL = new DatBaoDAL();

        public DatBaoBLL() { }

        public List<DatBao> LoadDLDatBao()
        {
            return dbDAL.GetDLDatBao();
        }

        public List<view_DanhSachDatBao> LoadDLDSDatBao()
        {
            return dbDAL.GetDLDSDatBao();
        }

        public List<DatBao> LoadDLDatBaoTheoTenKH(string tenKH)
        {
            return dbDAL.GetDLDatBaoTheoTenKH(tenKH);
        }

        public List<view_DanhSachDatBao> LoadDLDSDatBaoTheoTenKH(string tenKH)
        {
            return dbDAL.GetDLDSDatBaoTheoTenKH(tenKH);
        }


        public int LoadDLGetDLMaDatBaoCuoiCung()
        {
            return dbDAL.GetDLMaDatBaoCuoiCung();
        }

        public bool ThemDatBao(DatBao db)
        {
            return dbDAL.ThemDatBao(db);
        }

        public bool XoaDatBao(int maDatBao)
        {
            return dbDAL.XoaDatBao(maDatBao);
        }

        public bool SuaDatBao(DatBao db)
        {
            return dbDAL.SuaDatBao(db);
        }
    }
}
