using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_proyects
{
    public abstract class Pokemon
    {
        public int numPokedex { set; get; }
        public string Nombre { set; get; }
        public string Peso { set; get; }
        public string Sexo { set; get; }
        public int Temporada { set; get; }
        public string Debilidad_elemental { set; get; }

        public abstract void AtacarPlacaje();
        public abstract void AtacarAraniazo();
        public abstract void AtacarMordizco();
    }
}
