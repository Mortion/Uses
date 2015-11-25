using System.Collections.Generic;

namespace BusinessObjects
{
    public class Recept
    {

        public int Id { get; set; }
        public string Naam { get; set; }
        public List<Ingredient> Ingredienten { get; set; }

        public Recept()
        {
            
        }


    }
}