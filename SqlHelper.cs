using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace EPED
{
    class SqlHelper
    {
        SqlConnection cn;
        public SqlHelper(string connectionString)
        {
            cn = new SqlConnection(connectionString);
        }


        public bool IsConnection
        {
            get
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                    cn.Open();

                return true;
            }
        }
    }
}
