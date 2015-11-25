using System;

namespace voorbeeldGebruikInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            DaKlant daklant = new DaKlant();
            Klant klant = new Klant();
            DaBoek daBoek = new DaBoek();
            Boek boek = new Boek();


            //Gegevens van een klant toevoegen
            Console.Write("Voer de naam van de klant in aub" + Environment.NewLine + "Naam van de klant: ");
            klant.Naam = Console.ReadLine();
            Console.Write(Environment.NewLine + "Voer het adres van de klant in aub" + Environment.NewLine + "Adres van de klant: ");
            klant.Adres = Console.ReadLine();
            daklant.Save(klant);
            Console.WriteLine(Environment.NewLine + "Toegevoegd!");


            //Gegevens van een boek toevoegen
            //Console.Write("Voer de titel in aub" + Environment.NewLine + "Titel: ");
            //boek.Titel = Console.ReadLine();
            //Console.Write(Environment.NewLine + "Voer de ISBN in aub" + Environment.NewLine + "ISBN: ");
            //boek.ISBN = Console.ReadLine();
            //Console.Write(Environment.NewLine + "Voer de auteur in aub" + Environment.NewLine + "Auteur: ");
            //boek.Auteur = Console.ReadLine();
            //Console.Write(Environment.NewLine + "Voer het jaar in aub" + Environment.NewLine + "jaartal: ");
            //boek.Jaartal = int.Parse(Console.ReadLine());
            //daBoek.Save(boek);
            //Console.WriteLine(Environment.NewLine + "Toegevoegd!");


            //Gegevens van een klant bewerken
            //Console.Write("Voer de klant-id in aub" + Environment.NewLine + "Klant-id: ");
            //klant.Id = int.Parse(Console.ReadLine());
            //Console.Write(Environment.NewLine + "Voer de naam van de klant in aub" + Environment.NewLine + "Naam van de klant: ");
            //klant.Naam = Console.ReadLine();
            //Console.Write(Environment.NewLine + "Voer het adres van de klant in aub" + Environment.NewLine + "Adres van de klant: ");
            //klant.Adres = Console.ReadLine();
            //daklant.Save(klant);
            //Console.WriteLine(Environment.NewLine + "Bewerkt!");


            //Gegevens van een boek bewerken
            //Console.Write("Voer de boek-id in aub" + Environment.NewLine + "Boek-id: ");
            //boek.Id = int.Parse(Console.ReadLine());
            //Console.Write(Environment.NewLine + "Voer de titel in aub" + Environment.NewLine + "Titel: ");
            //boek.Titel = Console.ReadLine();
            //Console.Write(Environment.NewLine + "Voer de ISBN in aub" + Environment.NewLine + "ISBN: ");
            //boek.ISBN = Console.ReadLine();
            //Console.Write(Environment.NewLine + "Voer de auteur in aub" + Environment.NewLine + "Auteur: ");
            //boek.Auteur = Console.ReadLine();
            //Console.Write(Environment.NewLine + "Voer het jaar in aub" + Environment.NewLine + "Jaar: ");
            //boek.Jaartal = int.Parse(Console.ReadLine());
            //daBoek.Save(boek);
            //Console.WriteLine(Environment.NewLine + "Bewerkt!");


            //Klant verwijderen
            //Console.Write("Voer de klant-id in aub, die u wil verwijderen" + Environment.NewLine + "Klant-id: ");
            //klant.Id = int.Parse(Console.ReadLine());
            //daklant.Delete(klant.Id);
            //Console.WriteLine(Environment.NewLine + "Verwijderd!");


            //Boek verwijderen
            //Console.Write("Voer de boek-id in aub, die u wil verwijderen" + Environment.NewLine + "Boek-id: ");
            //boek.Id = int.Parse(Console.ReadLine());
            //daBoek.Delete(boek.Id);
            //Console.WriteLine(Environment.NewLine + "Verwijderd!");


            //Klant vinden via ID
            //Console.Write("Voer de klant-id in aub, die u wil vinden" + Environment.NewLine + "Klant-id: ");
            //klant.Id = int.Parse(Console.ReadLine());
            //Console.WriteLine(Environment.NewLine + daklant.Get(klant.Id));


            //Boek vinden via ID
            //Console.Write("Voer de boek-id in aub, die u wil vinden" + Environment.NewLine + "Boek-id: ");
            //boek.Id = int.Parse(Console.ReadLine());
            //Console.WriteLine(Environment.NewLine + daBoek.Get(boek.Id));


            //List van de klanten
            //Console.Write("Wil u alle klanten bekijken?" + Environment.NewLine + "Ja (J) of Nee (N): ");
            //string antwoord = Console.ReadLine();
            //if (antwoord.ToUpper() == "J")
            //{
            //    Console.WriteLine();
            //    foreach (var item in daklant.GetAll())
            //    {
            //        Console.WriteLine(item);
            //    }
            //}


            //List van de boeken
            //Console.Write("Wil u alle boeken bekijken?" + Environment.NewLine + "Ja (J) of Nee (N): ");
            //string antwoord = Console.ReadLine();
            //if (antwoord.ToUpper() == "J")
            //{
            //    Console.WriteLine();
            //    foreach (var item in daBoek.GetAll())
            //    {
            //        Console.WriteLine(item);
            //    }
            //}


            Console.ReadKey();
        }
    }
}
