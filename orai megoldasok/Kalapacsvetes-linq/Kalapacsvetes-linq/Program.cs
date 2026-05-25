using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalapacsvetes_linq
{
    class Sportolo
    {
        public int Helyezes { get; set; }
        public double Eredmeny { get; set; }
        public string Nev { get; set; }
        public string Orszagkod { get; set; }
        public string Helyszin { get; set; }
        public DateTime Datum { get; set; }
        public string Teljessor { get; set; } //a fájlba íráshoz kell

        public Sportolo(string sor)
        {
            Teljessor = sor;
            string[] reszek = sor.Split(';');
            Helyezes = Convert.ToInt32(reszek[0]);
            //Helyezes = int.Parse(reszek[0]);
            Eredmeny = Convert.ToDouble(reszek[1]);
            Nev = reszek[2];
            Orszagkod = reszek[3];
            Helyszin = reszek[4];
            Datum = Convert.ToDateTime(reszek[5]);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Sportolo> lista = new List<Sportolo>();
            StreamReader sr = new StreamReader("kalapacsvetes.txt");
            string elsosor = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Sportolo sor = new Sportolo(sr.ReadLine());
                lista.Add(sor);       
            }
            sr.Dispose();

            //4.feladat
            Console.WriteLine($"4. feladat: {lista.Count} dobás eredménye található.");

            //5.feladat
            var magyarok = from m in lista
                           where m.Orszagkod == "HUN"
                           select m.Eredmeny;

            //var magyarok_lambda = lista.Where(x => x.Orszagkod == "HUN").Select(x => x.Eredmeny);
            
            if (magyarok.Any())
            {
                double atlag = magyarok.Average();
                Console.WriteLine($"5. feladat: A magyar sportolók átlagosan {atlag:0.00} métert dobtak"); //atlag:F2
            }
            else
            {
                Console.WriteLine("5. feladat: Nincs magyar sportoló");
            }

            //6. feladat
            Console.WriteLine("6. feladat: Adjon meg egy évszámot!");
            int evszam = int.Parse(Console.ReadLine());
            var dobasok = from d in lista
                          where d.Datum.Year == evszam
                          select d;

            //var dobasok_lambda = lista.Where(d => d.Datum.Year == evszam);

            if (dobasok.Any())
            {
                Console.WriteLine($"{dobasok.Count()} darab dobás történt");
                foreach (var item in dobasok)
                {
                    Console.WriteLine(item.Nev);
                }
            }
            else
            {
                Console.WriteLine("Egy dobás sem volt ebben az évben.");
            }

            //7. feladat
            Console.WriteLine("7. feladat: Statisztika");
            var statisztika = from s in lista
                              group s by s.Orszagkod;

            //var statisztika_lambda = lista.GroupBy(s => s.Orszagkod);

            foreach (var item in statisztika)
            {
                Console.WriteLine($"{item.Key} - {item.Count()}");
            }

            //8. feladat
            var hungarians = from h in lista
                             where h.Orszagkod == "HUN"
                             select h;

            //var hungarians_lambda = lista.Where(x => x.Orszagkod == "HUN");

            StreamWriter sw = new StreamWriter("magyarok.txt", false, Encoding.UTF8);

            sw.WriteLine(elsosor);
            foreach (var item in hungarians)
            {
                sw.WriteLine(item.Teljessor);
            }
            sw.Dispose();
            
            Console.ReadKey();
        }
    }
}
