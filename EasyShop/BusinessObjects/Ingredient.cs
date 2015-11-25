namespace BusinessObjects
{
    public class Ingredient : Product
    {
        public int Id { get; set; }
        public string Hoeveelheid { get; set; }


        public Ingredient()
        {
            
        }


        public override string ToString() => $"{Beschrijving}: {Hoeveelheid}";

    }
}