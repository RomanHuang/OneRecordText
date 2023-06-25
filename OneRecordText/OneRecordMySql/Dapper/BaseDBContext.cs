using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneRecordMySql.Dapper
{
    public class BaseDBContext
    {
        private string connectionString;
        public IDbConnection Connection { get; set; }
        //mysql数据库
        public BaseDBContext(string settings)
        {
            connectionString = settings;
            Connection = new MySqlConnection(connectionString);
        }


    }
}
