using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList.Controller
{
    class DataBaseConecction
    {
        public MySqlConnection conecction()
        {
            string server = "localhost";
            string db = "store";
            string user = "root";
            string password = "Ar@44539449";

            string conecctionWord = "Database=" + db + "; Data Source=" + server +
                "; User Id="+user+"; Password="+password+"";
            try
            {
                MySqlConnection dbConecction = new MySqlConnection(conecctionWord);
                return dbConecction;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Message);
                return null;
            }
        }
    }
}
