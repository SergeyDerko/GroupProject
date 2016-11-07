using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _503_DATA_BASE
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
                @"data source=(LocalDb)\MSSQLLocalDB;Initial Catalog=TestNewEntityDataBase;Integrated Security=True;";
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "select * from Customer";
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        var table = new DataTable();
                        table.Load(reader);
                    }
                }
            }


        }
    }
}

