using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_proyects
{
    internal class Pikachu : Pokemon, IElectrico
    {
        public Pikachu()
        {

        }

        public Pikachu(int numpokedex, string nombre, string peso)
        {
            Nombre = nombre;
            numPokedex = numpokedex;
            Peso = peso;
        }

        public override void AtacarAraniazo()
        {
            Console.WriteLine($"{Nombre}: AtaqueAranazo");
        }

        public void atacarImpactrueno()
        {
            Console.WriteLine($"{Nombre}: atacarImpactrueno");
        }

        public override void AtacarMordizco()
        {
            Console.WriteLine($"{Nombre}: AtacarMordizco ");
        }

        public override void AtacarPlacaje()
        {
            Console.WriteLine($"{Nombre}: AtacarPlacaje");
        }

        public void atacarPunioTrueno()
        {
            Console.WriteLine($"{Nombre}: atacarPunioTrueno");
        }
    }
}
