using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class FrmCauHinh : Form
    {
        TestBLL testBLL = new TestBLL();

        public FrmCauHinh()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            MessageBox.Show(testBLL.GetUserConnectionString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuFile_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
