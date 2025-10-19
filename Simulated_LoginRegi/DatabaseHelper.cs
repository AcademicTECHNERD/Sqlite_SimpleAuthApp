using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Simulated_LoginRegi
{

    public static class DatabaseHelper
    {
        private static string connectionString = "Data Source=users.db";

        // 初始化数据库
        public static void Initialize()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var tableCmd = connection.CreateCommand();
                tableCmd.CommandText =
                    @"CREATE TABLE IF NOT EXISTS users (
                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                            username TEXT,
                            password TEXT,
                            sex TEXT,
                            email TEXT
                        );";
                tableCmd.ExecuteNonQuery();
            }
        }

        // 插入用户
        public static void AddUser(string username, string password ,string sex, string email)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO users (username, password , sex ,email) VALUES (@u, @p ,@s ,@e)";
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                cmd.Parameters.AddWithValue("@s", sex);
                cmd.Parameters.AddWithValue("@e", email);
                cmd.ExecuteNonQuery();
            }
        }
        // 检查用户名是否存在（用于注册时避免重复）
        public static bool IsUsernameExist(string username)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM users WHERE username = @u";
                cmd.Parameters.AddWithValue("@u", username);
                var result = cmd.ExecuteScalar();
                return Convert.ToInt32(result) > 0;
            }
        }

        // 登录验证（只需要用户名和密码）
        public static bool CheckUser(string username, string password)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var cmd = connection.CreateCommand();
                cmd.CommandText =
                    "SELECT COUNT(*) FROM users WHERE username = @u AND password = @p";
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                var result = cmd.ExecuteScalar(); // 返回单个值（COUNT 结果）

                // 判断是否有匹配记录
                return Convert.ToInt32(result) > 0;
            }
        }
    }
}

