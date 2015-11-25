using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CVOWinkelKar
{
    class DaBoodschap
    {
        public void Toevoegen(Boodschap boodschap)
        {
            SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=BoodschappenDB;Integrated Security=True;Pooling=False");
            SqlCommand cmd = connection.CreateCommand();
            string sqlString = "INSERT INTO tbl_boodschappen (product,aantal,winkel) VALUES ('"+boodschap.Beschrijving+"',"+boodschap.Aantal+",'"+boodschap.Winkel+"')"; 
            cmd.CommandText = sqlString;
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void Verwijderen(int id)
        {
            SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=BoodschappenDB;Integrated Security=True;Pooling=False");
            SqlCommand cmd = connection.CreateCommand();
            string sqlString = "DELETE FROM tbl_boodschappen WHERE ID=" + id;
            cmd.CommandText = sqlString;
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public List<Boodschap> GetAllBoodschappen()
        {
            List<Boodschap> result = new List<Boodschap>();
            SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=BoodschappenDB;Integrated Security=True;Pooling=False");
            SqlCommand cmd = connection.CreateCommand();
            string sqlString = "SELECT * FROM tbl_boodschappen";
            cmd.CommandText = sqlString;
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
