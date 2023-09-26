using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProjekt
{
    internal class Program
    {
        List<Bejegyzes> lista= new List<Bejegyzes>();
        List<Bejegyzes> lista2= new List<Bejegyzes>();

        public void Feladat2_b()
        {
            Console.WriteLine("Kérem adja meg hány darab bejegyzést szeretne létrehozni! ");
            int darab = int.Parse(Console.ReadLine());
            if (darab < 0)
            {
                Console.WriteLine("Hiba, nem természetes számot adott meg");
            }
            else
            {
                for (int i = 0; i < darab; i++)
                {
                    Console.WriteLine("Kérem adja meg a szerzőt");
                    string szerzo = Console.ReadLine();
                    Console.WriteLine("Kérem adja meg a tartalmát");
                    string tartalom = Console.ReadLine();
                    DateTime dateTime = DateTime.Now;
                    Bejegyzes bejegyz = new Bejegyzes(szerzo, tartalom, dateTime);
                    lista.Add(bejegyz);
                }
            }
        }

        public void Feladat2_c()
        {
            StreamReader sr = new StreamReader("bejegyzesek.csv");
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(';');
                string szerzo = sor[0];
                string tartalom = sor[1];
                Bejegyzes bejegyz = new Bejegyzes(szerzo,tartalom, DateTime.Now);
                lista.Add(bejegyz);
            }
        }

        public void Feladat2_d()
        {
            Random r = new Random();
            for (int i = 0; i < lista.Count*20; i++)
            {
                lista[r.Next(0, lista.Count)].Like();
            }
        }

        public void Feladat2_e()
        {
            Console.WriteLine("Adja meg mire szeretné módosítani a 2. bejegyzés szövegét.");
            string tart = Console.ReadLine();
            lista[2].szerkesztes(tart);
        }

        public void Feladat2_f()
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        public void Feladat3_a()
        {
            int szamlalo = 0;
            foreach (var item in lista)
            {
                if (szamlalo < item.Likeok)
                {
                    szamlalo = item.Likeok;
                }
            }
            Console.WriteLine($"A legnépszerűbb bejegyzés {szamlalo} likeot kapott.");
        }

        public void Feladat3_b()
        {
            foreach (var item in lista)
            {
                if (item.Likeok > 35)
                {
                    Console.WriteLine("Van olyan bejegyzes aminek 35-nél több likeot kapott"); ;
                }
                else
                {
                    Console.WriteLine("Nincs olyan bejegyzes ami 35-nél több likeot kapott");
                }
            }
        }
        
        public void Feladat3_c()
        {
            int szamlalo = 0;
            foreach (var item in lista)
            {
                if (item.Likeok < 15)
                {
                    szamlalo++;
                }
            }
            Console.WriteLine($"{szamlalo} bejegyzes van amit kevesebb mint 15 likeot kapott.");
        }
        public void Feladat3_d()
        {
            var ujlista = lista.OrderBy(x => x.Likeok).Reverse();
            StreamWriter sw = new StreamWriter("bejegyzesek_rendezett.txt");
            foreach (var item in ujlista)
            {
                Console.WriteLine(item);
                sw.WriteLine(item);
            }
        }

        public void Feladatok()
        {
            Feladat2_b();
            Feladat2_c();
            Feladat2_d();
            Feladat2_e();
            Feladat2_f();
            Feladat3_a();
            Feladat3_b();
            Feladat3_c();
            Feladat3_d();
        }

        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
