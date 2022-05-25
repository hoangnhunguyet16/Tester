using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class Utilities
    {
        public void LoadChildForm(Form frm, Panel pnl)
        {
            pnl.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnl.Controls.Add(frm);
            pnl.Tag = frm;

            frm.Show();
        }

        public int TimSoLuongNgayCuoiTuan(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            DateTime fdate = ngayKetThuc;
            DateTime sdate = ngayBatDau;
            TimeSpan ts = fdate - sdate;
            var sundays = ((ts.TotalDays / 7) + (sdate.DayOfWeek == DayOfWeek.Sunday || fdate.DayOfWeek == DayOfWeek.Sunday || fdate.DayOfWeek > sdate.DayOfWeek ? 1 : 0));

            sundays = Math.Round(sundays, MidpointRounding.AwayFromZero);

            return (int)sundays;
        }
    }
}
