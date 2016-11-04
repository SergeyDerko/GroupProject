using System.Data;
using System.Data.SqlClient;

namespace _504_ado.net
{
    class Program
    {
        static void Main()
        {
            string connectionString = @"data source=(LocalDb)\MSSQLLocalDB;Initial Catalog=TestNewEntityDataBase;Integrated Security=True;";
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
