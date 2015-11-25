using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynaDataAccesLibrary
{
   public  class DaBase
    {
        private String connectionString;
        public DaBase (String connectionString)
        {
            this.connectionString = connectionString;
        }

        public void ExecuteNonQuery(string sql, Dictionary<string, string> parameters)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;
                foreach (var item in parameters)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

        }

    }
}
