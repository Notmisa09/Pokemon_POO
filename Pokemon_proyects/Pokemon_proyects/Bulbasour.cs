using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_proyects
{
    internal class Bulbasour : Pokemon, IAgua
    {
        public Bulbasour() { }

        public Bulbasour(int numpokedex,string nombre, string peso)
        {
            numPokedex = numpokedex;
            Nombre = nombre;
            Peso = peso;
        }

        public void atacarBurbuja()
        {
            Console.WriteLine($"{Nombre}: Ataque Burbuja!");
        }

        public void atacarHidrobomba()
        {
            Console.WriteLine($"{Nombre}: Ataque Hidrobomba!");
        }

        public override void AtacarMordizco()
        {
            Console.WriteLine($"{Nombre}: AtacarMordizco ");
        }


        public override void AtacarAraniazo()
        {
            Console.WriteLine($"{Nombre}: AtaqueAranazo");
        }


        public void atacarPistola_agua()
        {
            Console.WriteLine($"{Nombre}: Ataque pistola de agua!");
        }


        public override void AtacarPlacaje()
        {
            Console.WriteLine($"{Nombre}: AtacarPlacaje");
        }

    }
}
