using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace ProjectSettings
{
    public class Helper
    {
        public static void SaveUserConfig(ConnectDB conn)
        {
            Properties.Settings.Default.UserConnectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};pwd={3}", conn.ServerName, conn.Database, conn.UserName, conn.Password); ;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Kiểm tra chuỗi kết nối cơ sở dữ liệu trong Settings.settings (User setting)
        /// </summary>
        /// <returns>
        /// 1 - Chuỗi cấu hình không tồn tại
        /// 0 - Kết nối cơ sở dữ liệu thành công
        /// 2 - Chuỗi cấu hình không phù hợp
        /// </returns>
        public static int CheckUserConfig()
        {
            if (Properties.Settings.Default.UserConnectionString == string.Empty)
                return 1;
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.UserConnectionString);
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                return 0;
            }
            catch (Exception)
            {
                return 2;
            }
        }
    }
}
