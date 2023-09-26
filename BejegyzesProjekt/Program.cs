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

        }
        static void Main(string[] args)
        {
        }
    }
}
