using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Serializable]
    public class ConnectDB
    {
        public string ServerName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }

        public ConnectDB() { }

        public ConnectDB(string serverName, string userName, string password, string database)
        {
            this.ServerName = serverName;
            this.UserName = userName;
            this.Password = password;
            this.Database = database;
        }

        /// <summary>
        /// Lưu file kết nối cơ sở dữ liệu vào trong Debug folder của project DTO
        /// Trường hợp file đã tồn tại:
        /// - Xóa file xong tiến hành tạo file lại 
        /// - Để tránh xảy ra lỗi "The file is apparently being used by another process" trong quá trình xóa
        /// ta sử dụng Garbage Collection (dòng 1, 2 trong if)
        /// </summary>
        public void SaveFileConnectDB()
        {
            if (File.Exists("connect-db.dba"))
            {
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                File.Delete("connect-db.dba");
            }

            FileStream fs = File.Open("connect-db.dba", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            fs.Close();
        }

        public ConnectDB ReadFileConnectDB()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.Open("connect-db.dba", FileMode.Open, FileAccess.Read);
            return (ConnectDB)bf.Deserialize(fs);
        }

        public bool CheckConnection()
        {
            SqlConnection conn = new SqlConnection(string.Format("Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3};", ServerName, Database, UserName, Password));
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CheckDatabase()
        {
            return this.Database.Equals("QLSINHVIEN") ? true : false;
        }
    }
}
