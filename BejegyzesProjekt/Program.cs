using System;
using System.Collections.Generic;
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
        static void Main(string[] args)
        {
        }
    }
}
