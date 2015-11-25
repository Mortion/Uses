using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voorbeeldGebruikInterfaces
{
    public class DaBase
    {
        protected string _connectionString = "Data Source=localhost;Initial Catalog=BoodschappenDB;Integrated Security=True;Pooling=False";
     
      
        public void ExecuteNonQuery(string sql, Dictionary<string,string> parameters){

            using (var connection = new SqlConnection(_connectionString))
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
