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
using DTO;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Data.SqlClient;
using ProjectSettings;

namespace GUI
{
    public partial class FrmCauHinh : Form
    {
        ConnectDB connDB;
        TaiKhoanBLL tkBLL = new TaiKhoanBLL();
        string config = "";
        bool flag;

        public FrmCauHinh(string config)
        {
            this.config = config;
            InitializeComponent();

            if (config.Equals("modify"))
            {
                btnThoat.Text = "Đăng nhập";
                btnThoat.Enabled = false;
            }
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            string server = cbbServer.Text;
            string user = txtUser.Text;
            string password = txtPassword.Text;
            string database = cbbDatabase.Text;

            connDB = new ConnectDB(server, user, password, database);

            if (connDB.CheckConnection())
            {
                MessageBox.Show("Kết nối thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            else
            {
                MessageBox.Show("Kết nối thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Chọn file cấu hình kết nối cơ sở dữ liệu";
            op.Filter = "Text Files (*.dba)|*.dba|All Files(*.*)|*.*";

            if (op.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.Open(op.FileName, FileMode.Open, FileAccess.Read);
                connDB = (ConnectDB)bf.Deserialize(fs);

                string server = connDB.ServerName;
                string user = connDB.UserName;
                string password = connDB.Password;
                string database = connDB.Database;

                cbbServer.Text = server;
                txtUser.Text = user;
                txtPassword.Text = password;
                cbbDatabase.Text = database;
            }
        }

        private void btnLuuFile_Click(object sender, EventArgs e)
        {
            string server = cbbServer.Text;
            string user = txtUser.Text;
            string password = txtPassword.Text;
            string database = cbbDatabase.Text;

            connDB = new ConnectDB(server, user, password, database);

            if (!connDB.CheckDatabase())
            {
                MessageBox.Show("Vui lòng kết nối đúng database", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbDatabase.Focus();
                return;
            }

            try
            {
                connDB.SaveFileConnectDB();
                Helper.SaveUserConfig(connDB);
                MessageBox.Show("Lưu file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Lưu file thất bại" , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            flag = true;

            if (config.Equals("modify") && flag)
            {
                btnThoat.Enabled = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (config.Equals("modify"))
            {
                Form frm;

                if (tkBLL.CheckDuLieuTaiKhoan() <= 0)
                {
                    MessageBox.Show("Dữ liệu hệ thống bị thiếu hoặc lỗi. Tiến hành restore.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    frm = new FrmRestore("modify");
                }
                else
                {
                    frm = new FrmDangNhap();
                }

                this.Hide();
                frm.Closed += (s, args) => this.Close();
                frm.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void cbbDatabase_MouseClick(object sender, MouseEventArgs e)
        {
            cbbDatabase.Items.Clear();

            string connStr = string.Format("server={0}; User ID={1}; pwd={2}", cbbServer.Text, txtUser.Text, txtPassword.Text);
            string query = "SELECT NAME FROM SYS.DATABASES";

            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Server, user hoặc password không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlCommand cmd = new SqlCommand(query, conn);
            IDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cbbDatabase.Items.Add(dr[0].ToString());
            }
        }
    }
}
