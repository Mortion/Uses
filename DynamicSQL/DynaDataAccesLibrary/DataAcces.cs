using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynaDataAccesLibrary
{
    public class DataAcces : IDataAdapter<object>
    {

        private string insertSQL = "INSERT INTO ";
        private string updateSQL = "";
        private string deleteSQL = "DELETE FROM";
        private string selectAllSQL = "SELECT * FROM ";
        private string selectByIDSQL = "SELECT * FROM ";
        private string tableName;


        public DataAcces(string tableName)
        {
            this.tableName = tableName;

            insertSQL += " " + tableName;
            deleteSQL += " " + tableName;
            selectAllSQL += " " + tableName;
            selectByIDSQL += " " + tableName;
        }

       

        public void AddAll(List<object> items)
        {
            insertSQL += "(";
            int count = 1;
            foreach (var type in items.GetType().GetProperties())
            {
                insertSQL += type.PropertyTypeà;
                if (count != 1)
                {
                    insertSQL += ",";   
                }
                count++;
            }
            insertSQL += ") VALUES(";
            count = 1;
            foreach (var item in items)
            {
                insertSQL += "@" + item.GetType().ToString();
                if (count != 1)
                {
                    insertSQL += ",";
                }
                count++;
            }
            insertSQL += ") ";

            Console.WriteLine(insertSQL);
        }

        public void AddSingle(object item)
        {
            throw new NotImplementedException();
        }

        public void Delete(object item)
        {
            throw new NotImplementedException();
        }

        public List<object> GetAll()
        {
            throw new NotImplementedException();
        }

        public object GetSingle(object item)
        {
            throw new NotImplementedException();
        }

        public void Update(object item)
        {
            throw new NotImplementedException();
        }
    }
}
