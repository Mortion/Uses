using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVOWinkelKar
{
    class DaBoodschapParameters : DaBase
    {
        private string sqlStringInsert = "INSERT INTO tbl_boodschappen (product,aantal,winkel) VALUES (@product,@aantal,@winkel)";
        private string sqlStringDelete = "DELETE FROM tbl_boodschappen WHERE ID=@ID";
        private string sqlStringSelect = "SELECT * FROM tbl_boodschappen";
        public bool Toevoegen(Boodschap boodschap)
        {
            int result = 0;
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sqlStringInsert;
                cmd.Parameters.AddWithValue("@product", boodschap.Beschrijving);
                cmd.Parameters.AddWithValue("@aantal", boodschap.Aantal);
                cmd.Parameters.AddWithValue("@winkel", boodschap.Winkel);
                connection.Open();
                result = cmd.ExecuteNonQuery();
                connection.Close();
            }
            return result == 1;

        }

        public void Verwijderen(int id)
        {
           
            Dictionary<string, string> parameters = new Dictionary<string,string>();
            parameters.Add("@ID", id.ToString());
            base.ExecuteNonQuery(sqlStringDelete, parameters);


        }

        public List<Boodschap> GetAllBoodschappen()
        {
            List<Boodschap> result = new List<Boodschap>();
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = connection.CreateCommand();

                cmd.CommandText = sqlStringSelect;
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Boodschap()
                    {
                        Aantal = (Int32)reader["aantal"],
                        Beschrijving = reader["product"].ToString(),
                        Winkel = reader["winkel"].ToString(),
                        ID = (Int32)reader["Id"]
                    });
                }
                connection.Close();
                return result;
            }
        }
    }
}

