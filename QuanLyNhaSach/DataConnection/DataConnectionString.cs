using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DataConnection
{
    internal class DataConnectionString
    {
        public static string ConnectionString = @"Data Source=TRANNGHIEP;Initial Catalog=QLNhaSach;Integrated Security=True";
    
        public static void dataSet(string connectionString)
        {
            DataSet ds = new DataSet();

        }
    }
}
