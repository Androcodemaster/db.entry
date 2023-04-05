using System.ComponentModel;
using System.Collections.Generic;
namespace wawi

{
    internal class Program
    {
        class Produkt
        {
            public int produktid { get; set; }
            public string produktname { get; set; }
            public string produktinformation { get; set; }
            public double Preis { get; set; }
            public bool imVerkauf { get; set; }

        }

        static class db
        {
            static Produkt[] produkts;
            static db()
            {
                produkts = new Produkt[5];

                produkts[0] = new Produkt() { produktid = 1, produktname = "Akku", produktinformation = "AC 12/24V", Preis = 18.5, imVerkauf = true };
                produkts[1] = new Produkt() { produktid = 2, produktname = "PCx", produktinformation = "Neueware siehe Anlage", Preis = 899.90, imVerkauf = true };
                produkts[2] = new Produkt() { produktid = 3, produktname = "Kable", produktinformation = "Diverse Kabel s.A.", Preis = 7.99, imVerkauf = true };
                produkts[3] = new Produkt() { produktid = 4, produktname = "Monitor", produktinformation = "55''", Preis = 165.99, imVerkauf = true };
                produkts[4] = new Produkt() { produktid = 5, produktname = "MT Kit", produktinformation = "Maus und Tastatur", Preis = 65.99, imVerkauf = false };
            }
            public static Produkt[] takeProduct()
            {

                return produkts;
            }
        }
        static void Main(string[] args)
        {
            Produkt[] produkts = db.takeProduct();

            foreach (var p in produkts)
            {
                Console.WriteLine($"Warenlist : {p.produktid}-{p.produktname}--{p.produktinformation}--{p.Preis}");

            }

            Console.WriteLine("Möchten Sie weitere Produkte eingeben? J/N");
            string b = Convert.ToString(Console.ReadLine());

            if (b == "j")
            {
                Console.WriteLine("Wie viele Produkt möchten Sie eingeben?:");
                int produktid = Convert.ToInt32(Console.ReadLine());
                int[] pid = new int[produktid];

                for (int i = 0; i < produktid; i++)
                {
                    Console.Write("Bitte Geben neue Produktid ein: ");
                    string eingabe = Console.ReadLine();
                    pid[i] = Convert.ToInt32(eingabe);
                    Console.WriteLine(pid[i]);

                    Console.WriteLine("Bitte Geben Sie Produktname ein :");
                    string pn = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Bitte Geben Sie Produktinformation ein :");
                    string pi = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Bitte Geben Sie Produktpreis ein :");
                    string ppreis = Convert.ToString(Console.ReadLine());

                    Console.WriteLine($"Warenlist addiert : {eingabe} {pn} {pi} {ppreis}");
                }


            }
            else
            {
                Console.WriteLine("Ich leite Sie wieder an Warenlist ein:");

                foreach (var p in produkts)
                {
                    Console.WriteLine($"Warenlist : {p.produktid}-{p.produktname}--{p.produktinformation}--{p.Preis}");

                }
            }


            Console.ReadLine();
        }
    }
}
