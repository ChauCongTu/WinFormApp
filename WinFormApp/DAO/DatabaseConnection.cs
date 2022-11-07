using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.DAO
{
    public class DatabaseConnection
    {
        public string _strConn = "Data Source=./;Initial Catalog=QLXEMAY;Integrated Security=True"; //Chuỗi kết nối
        public DatabaseConnection()
        {

        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_strConn);
        }
    }
}
