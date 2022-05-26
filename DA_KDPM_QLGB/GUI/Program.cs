using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectSettings;
using DTO;
using System.IO;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(SelectStartupForm());
        }

        /// <summary>
        /// Trước khi chạy, để lựa chọn startup form phù hợp chương trình sẽ kiểm tra xem user config có kết nối được cơ sở dữ liệu hay không?
        /// Nếu không kết nối được cơ sở dữ liệu:
        /// - Kiểm tra xem có tồn tại file kết nối cơ sở dữ liệu <<connect-db.dba>> hay không?
        ///   - Nếu có, tiến hành sử dụng file <<connect-db.dba>> tạo user config
        ///   - Nếu không, khởi tạo FrmCauHinh để người dùng tiến hành cấu hình
        ///   
        /// </summary>
        /// <returns></returns>
        static Form SelectStartupForm()
        {
            var frm = (dynamic)null;

            if (Helper.CheckUserConfig() != 0)
            {
                if (File.Exists("connect-db.dba"))
                {
                    ConnectDB connDB = new ConnectDB();
                    connDB = connDB.ReadFileConnectDB();

                    if (!connDB.CheckDatabase())
                    {
                        frm = new FrmCauHinh("modify");
                    }
                    else
                    {
                        Helper.SaveUserConfig(connDB);
                        frm = new FrmDangNhap();
                    }
                }
                else
                {
                    frm = new FrmCauHinh("modify");
                }
            }
            else
            {
                frm = new FrmDangNhap();
            }

            return frm;
        }
    }
}
