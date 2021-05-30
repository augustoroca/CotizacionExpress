using Cotizador.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Controller
{
    class PantalonController
    {
        internal Pantalon SetStock(bool esChupin, int cantidad)
        {
            Pantalon pantalon = new Pantalon(esChupin, cantidad);
            return pantalon;         
            
        }
    }
}
