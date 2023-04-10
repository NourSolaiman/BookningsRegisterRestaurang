using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BookningsRegisterRestaurang
{
    internal class KopplingTillDb
    {
        private string connectionString;

        public KopplingTillDb(string server = "localhost", string database = "bookningsregister_restaurang", string user = "root", string password = "Mn")
        {
            connectionString = $"SERVER={server};DATABASE={database};UID={user};PASSWORD={password};";
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
