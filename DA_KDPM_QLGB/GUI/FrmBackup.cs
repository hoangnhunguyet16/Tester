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

namespace GUI
{
    public partial class FrmBackup : Form
    {
        SqlConnection conn = new SqlConnection(Settings.Default.UserConnectionString);

        public FrmBackup()
        {
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
                lblPercentage.Text = "Backup thành công";
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = dlg.SelectedPath;
                btnBackup.Enabled = true;
            }
        }

        private async void btnBackup_Click(object sender, EventArgs e)
        {
            if (txtFilePath.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn nơi lưu file backup", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AnimateProgressBar(6500);
                string database = conn.Database.ToString();
                string sql = "BACKUP DATABASE [" + database + "] TO DISK = '" + txtFilePath.Text + "\\" + database + ".bak'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                await cmd.ExecuteNonQueryAsync();
                conn.Close();
            }
        }
    }
}
