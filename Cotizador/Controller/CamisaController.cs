using Cotizador.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Controller
{
    class CamisaController
    {
        internal Camisa SetStock(bool esMangaCorta, bool esCuelloMao, int cantidad)
        {
            Camisa camisa = new Camisa(esMangaCorta, esCuelloMao, cantidad);
            return camisa;
           
        }
    }
}
