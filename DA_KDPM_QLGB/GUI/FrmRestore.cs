using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectSettings.Properties;
using System.Data.SqlClient;
using System.Threading;

namespace GUI
{
    public partial class FrmRestore : Form
    {
        SqlConnection conn = new SqlConnection(Settings.Default.UserConnectionString);
        string type = "";

        public FrmRestore(string type)
        {
            this.type = type;
            InitializeComponent();
        }

        public void AnimateProgressBar(int mil)
        {
            if (timer.Enabled) return;

            prgBarStatus.Value = 0;
            timer.Interval = mil / 100;
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (prgBarStatus.Value < 100)
            {
                prgBarStatus.Value += 1;
                prgBarStatus.Refresh();
                lblPercentage.Text = prgBarStatus.Value + "%";
            }
            else
            {
                timer.Enabled = false;
                lblPercentage.Text = "Restore thành công";
                MessageBox.Show("Hệ thống sẽ đóng sau 5s", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Thread.Sleep(5000);

                FrmDangNhap frmDN = new FrmDangNhap();
                frmDN.Show();

                if (type.Equals("default"))
                {
                    Panel pnl = this.Parent as Panel;
                    pnl.Controls.Clear();
                    Form frm = pnl.Parent as Form;
                    frm.Close();
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup files(*.bak)|*.bak";
            dlg.Title = "Restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = dlg.FileName;
                btnRestore.Enabled = true;
            }
        }

        private async void btnRestore_Click(object sender, EventArgs e)
        {
            if (txtFilePath.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn file backup", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string database = conn.Database.ToString();
                conn.Open();

                string sql1 = "ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                cmd1.ExecuteNonQuery();

                AnimateProgressBar(6500);

                string sql2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK = '" + txtFilePath.Text + "' WITH REPLACE;";
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                await cmd2.ExecuteNonQueryAsync();

                string sql3 = "ALTER DATABASE [" + database + "] SET MULTI_USER;";
                SqlCommand cmd3 = new SqlCommand(sql3,conn);
                cmd3.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng lưu file tại ổ đĩa khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                throw;
            }
        }
    }
}
