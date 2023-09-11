using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_proyects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Nome = false;

            while (Nome == false)
            {
                Pikachu pikachu = new Pikachu(1, "Pikachu","12kg");
                pikachu.atacarImpactrueno();
                pikachu.AtacarAraniazo();
                pikachu.atacarPunioTrueno();
             

                Console.WriteLine("---------------------------------------");

                Bulbasour bulbasour = new Bulbasour(2, "Bulbasour", "22kg");
                bulbasour.AtacarAraniazo();
                bulbasour.atacarBurbuja();
                bulbasour.atacarPistola_agua();
                Console.WriteLine(@"bulbasour.Peso");

                Console.WriteLine("---------------------------------------");

                Nome = true;
                Console.ReadKey();
             
            }

        }
    }
}
