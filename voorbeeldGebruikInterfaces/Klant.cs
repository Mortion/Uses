namespace voorbeeldGebruikInterfaces
{
    public class Klant
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Adres { get; set; }

        public override string ToString()
        {
            return this.Naam + ", " + this.Adres;
        }
    }
}
