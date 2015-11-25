using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace voorbeeldGebruikInterfaces
{
    class DaKlant : DaBase, IPersistance<Klant>
    {
        private string insertSQL = "";
        private string updateSQL = "";
        private string deleteSQL = "";
        private string selectAllSQL = "";
        private string selectByIDSQL = "";


        public void Delete(int id)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("ID", id.ToString());
            base.ExecuteNonQuery(deleteSQL, parameters);
        }

        public Klant Get()
        {
            throw new NotImplementedException();
        }

        public List<Klant> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Klant b)
        {
            var parameters = new Dictionary<string, string>();

            if (b.Id ==0)
            {
                
            }
            else
            {
                parameters.Add("ID", b.Id.ToString());
                base.ExecuteNonQuery("Update * FROM tbl_klanten", parameters);
            }
       
            base.ExecuteNonQuery("DELETE * FROM tbl_klanten", parameters);
        }
    }
}
