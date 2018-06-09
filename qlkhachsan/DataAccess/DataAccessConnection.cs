using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlkhachsan.DataAccess
{
    class DataAccessConnection
    {
        private static string DATABASE_URL = "Data Source=DESKTOP-PFL8S3U;Initial Catalog=qlks;Persist Security Info=True;User ID=sa;Password=1234";
        public static SqlConnection getConnection()
        {
            SqlConnection conn = null; ;
            conn = new SqlConnection(DATABASE_URL);

            return conn;
        }

    }
}
