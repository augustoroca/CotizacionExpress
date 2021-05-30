using Cotizador.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Controller
{
    class TiendaController
    {
        public Tienda GetTienda()
        {
            Tienda tienda = new Tienda();
            
            return tienda;
        }

        internal static object GetStockCamisa(bool esMangaCorta, bool esCuelloMao)
        {
            var prendas = Tienda.Camisas;
            foreach (var item in prendas)
            {
                if (item.EsMangaCorta == esMangaCorta && item.EsCuelloMao== esCuelloMao)
                {
                    return item.Stock;
                }
            }
            return 0;
                
        }

        internal static object GetStockPantalon(bool esChupin)
        {
            var prendas = Tienda.Pantalones;
            foreach (var item in prendas)
            {
                if (item.EsChupin== esChupin)
                {
                    return item.Stock;
                }
            }
            return 0;
        }

        internal void agregarPrenda(Camisa camisa)
        {
            Tienda tienda = new Tienda();
            tienda.agregarCamisa(camisa);
        }
        internal void agregarPrenda(Pantalon pantalon)
        {
            Tienda tienda = new Tienda();
            tienda.agregarPantalon(pantalon);
        }
    }
}
