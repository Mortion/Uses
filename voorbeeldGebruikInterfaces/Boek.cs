namespace voorbeeldGebruikInterfaces
{
    class Boek
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string ISBN { get; set; }
        public string Auteur { get; set; }
        public int Jaartal { get; set; }

        public override string ToString()
        {
            return this.Titel + ", " + this.ISBN + ", " + this.Auteur + ", " + this.Jaartal;
        }
    }
}
