using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBWork
{
    public class DBConnector
    {
        private string _connectionString = "Data Source = ADMIN-ПК; Initial Catalog = Library; Integrated Security=true;";

        public List<string> GetResult(string query)
        {
            List<string> result = new List<string>();
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = _connectionString;
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    using (var reader = command.ExecuteReader())
                    {    
                        while (reader.Read())
                        {
                            string temp = "";
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                if (i == reader.FieldCount - 1)
                                {
                                    temp += (reader[i]);
                                }
                                else
                                {
                                    temp += (reader[i] + ";");
                                }
                            }
                            result.Add(temp);
                        }
                    }
                }
            }
            return result;
        }
    }
}
