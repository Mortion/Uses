using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace voorbeeldGebruikInterfaces
{
    class DaBoek : DaBase, IPersistance<Boek>
    {
        private string insertSQL = "INSERT INTO tbl_boeken (titel, isbn, auteur , jaartal) VALUES (@titel, @isbn, @auteur, @jaartal)";
        private string updateSQL = "UPDATE  tbl_boeken set titel = @titel, isbn = @isbn, auteur = @auteur, jaartal = @jaartal where id = @id";
        private string deleteSQL = "DELETE FROM tbl_boeken WHERE id = @id";
        private string selectAllSQL = "SELECT * FROM tbl_boeken";
        private string selectByIDSQL = "SELECT * FROM tbl_boeken WHERE Id = @id";

        public void Save(Boek b)
        {
            var parameters = new Dictionary<string, string>();
            if (b.Id == 0)
            {
                parameters.Add("@titel", b.Titel);
                parameters.Add("@isbn", b.ISBN);
                parameters.Add("@auteur", b.Auteur);
                parameters.Add("@jaartal", b.Jaartal.ToString());
                base.ExecuteNonQuery(insertSQL, parameters);
            }
            else
            {
                parameters.Add("@titel", b.Titel);
                parameters.Add("@isbn", b.ISBN);
                parameters.Add("@auteur", b.Auteur);
                parameters.Add("@jaartal", b.Jaartal.ToString());
                parameters.Add("id", b.Id.ToString());
                base.ExecuteNonQuery(updateSQL, parameters);
            }
        }

        public void Delete(int id)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("id", id.ToString());
            base.ExecuteNonQuery(deleteSQL, parameters);
        }

        public List<Boek> GetAll()
        {
            List<Boek> result = new List<Boek>();
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = selectAllSQL;
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Boek()
                    {
                        Id = (Int32)reader["id"],
                        Titel = reader["titel"].ToString(),
                        ISBN = reader["isbn"].ToString(),
                        Auteur = reader["auteur"].ToString(),
                        Jaartal = (Int32)reader["jaartal"]
                    });
                }
                connection.Close();
                return result;
            }
        }

        public Boek Get(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(selectByIDSQL, connection);
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                Boek boek = new Boek();
                boek.Titel = reader["titel"].ToString();
                boek.ISBN = reader["isbn"].ToString();
                boek.Auteur = reader["auteur"].ToString();
                boek.Jaartal = (Int32)reader["jaartal"];
                connection.Close();
                return boek;
            }
        }
    }
}
