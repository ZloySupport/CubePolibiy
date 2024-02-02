using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.SQLite;
namespace Shiferina
{
    public class DB
    {
        private SQLiteConnection? conn;
        public bool ConnectDB(string patch)
        {
            conn = new SQLiteConnection("Data Source = "+patch);
            conn.Open();
            return true;
        }
        public bool DisDB() {
            if (conn != null)
            {
                if(conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Dispose();
                }
            }
            return true;
        }
        public bool RegisterUser(string username, string password)
        {
            //INSERT INTO 'Logs'(Login, Pass) VALUES ('username', 'password')
            if(conn != null)
            {
                if(conn.State == System.Data.ConnectionState.Open)
                {
                    try
                    {
                        SQLiteCommand cmd = conn.CreateCommand();
                        cmd.CommandText = $"INSERT INTO 'Logs'(Login, Pass) VALUES ('{username}', '{HeshPassword(password)}')";
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch 
                    {
                        MessageBox.Show("Логин занят", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return false;
        }
        public bool AutUser(string username, string password) 
        {
            //SELECT Login FROM 'Logs' WHERE Login = 'username'
            //SELECT Pass FROM 'Logs' WHERE Pass = 'password'
            if (conn != null)
            {
                if(conn.State == System.Data.ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = $"SELECT Login, Pass FROM 'Logs' WHERE Login = '{username}'";
                    cmd.ExecuteNonQuery();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    string user = "";
                    string pas = "";
                    while (reader.Read())
                    {
                         user = reader.GetString(0);
                         pas = reader.GetString(1);
                    }
                    if (user == username)
                    {
                        if (pas == HeshPassword(password)) {
                            return true;
                        }
                        return false;
                    }
                    return false;
                }
                return false;
            }
            return false;
        }
        private string HeshPassword(string Pass)
        {
            SHA256 PassH = SHA256.Create();
            Byte[] PASST = Encoding.Unicode.GetBytes(Pass);
            Byte[] PassHa = PassH.ComputeHash(PASST);
            string hash = Encoding.Unicode.GetString(PassHa);
            PassH.Clear();
            return hash;
        }
    }
}
