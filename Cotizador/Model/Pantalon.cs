using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Model
{
    class Pantalon:Prenda
    {
       private bool esChupin;

        public Pantalon()
        {
        }

        public Pantalon(bool esChupin, int cantidad)
        {
            this.esChupin = esChupin;
            this.Stock = cantidad;
        }

        public bool EsChupin { get => esChupin; set => esChupin = value; }
    }
}
