using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace voorbeeldGebruikInterfaces
{
    class DaKlant : DaBase, IPersistance<Klant>
    {        
        private string insertSQL = "INSERT INTO tbl_klanten (naam, adres) VALUES (@naam, @adres)";
        private string updateSQL = "UPDATE  tbl_klanten set naam = @naam, adres = @adres where id = @id";
        private string deleteSQL = "DELETE FROM tbl_klanten WHERE id = @id";
        private string selectAllSQL = "SELECT * FROM tbl_klanten";
        private string selectByIDSQL = "SELECT * FROM tbl_klanten WHERE Id = @id";

        public void Delete(int id)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            base.ExecuteNonQuery(deleteSQL, parameters);
        }

        public Klant Get(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(selectByIDSQL, connection);
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                Klant klant = new Klant();
                klant.Naam = reader["naam"].ToString();
                klant.Adres = reader["adres"].ToString();
                connection.Close();
                return klant;
            }
        }
        public List<Klant> GetAll()
        {
            List<Klant> result = new List<Klant>();
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = selectAllSQL;
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Klant()
                    {
                        Id = (Int32)reader["id"],
                        Naam = reader["naam"].ToString(),
                        Adres = reader["adres"].ToString(),
                    });
                }
                connection.Close();
                return result;
            }
        }

        public void Save(Klant b)
        {
            var parameters = new Dictionary<string, string>();
            if (b.Id == 0)
            {
                parameters.Add("@naam", b.Naam);
                parameters.Add("@adres", b.Adres);
                base.ExecuteNonQuery(insertSQL, parameters);
            }
            else
            {
                parameters.Add("@naam", b.Naam);
                parameters.Add("@adres", b.Adres);
                parameters.Add("id", b.Id.ToString());
                base.ExecuteNonQuery(updateSQL, parameters);
            }
        }
    }
}
