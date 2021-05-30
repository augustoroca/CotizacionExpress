using Cotizador.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Controller
{
    class CotizacionController
    {
        internal float Calcular(bool esMangaCorta,bool esCuelloMao, bool esPremium,float precio,int cantidad)
        {
            Camisa camisa = new Camisa();
            camisa.Precio = precio;
            if (esMangaCorta)
            {
                camisa.Precio = camisa.Precio - camisa.Precio * 10 / 100; 

            }
            if (esCuelloMao)
            {
                camisa.Precio = camisa.Precio + camisa.Precio * 3 / 100;

            }
            if (esPremium)
            {
                camisa.Precio = camisa.Precio + camisa.Precio * 30 / 100;
            }

            var total = camisa.Precio * cantidad;

            Cotizacion cotizacion = new Cotizacion();

            cotizacion.Fecha = new DateTime().Date;
            cotizacion.IdVendedor = 1;
            cotizacion.Prenda ="Camisa";
            cotizacion.Cantidad = cantidad;
            cotizacion.Total = total;
            

            return total;

             
        }

        internal float Calcular( bool esChupin,bool esPremium, float precio, int cantidad)
        {
            Pantalon pantalon = new Pantalon();
            pantalon.Precio = precio;
            if (esChupin)
            {
                pantalon.Precio = pantalon.Precio - pantalon.Precio * 12 / 100;

            }

            if (esPremium)
            {
                pantalon.Precio = pantalon.Precio + pantalon.Precio * 30 / 100;
            }

            var total = pantalon.Precio * cantidad;

            Cotizacion cotizacion = new Cotizacion();

            cotizacion.Fecha = new DateTime().Date;
            cotizacion.IdVendedor = 1;
            cotizacion.Prenda ="Pantalon";
            cotizacion.Cantidad = cantidad;
            cotizacion.Total = total;


            return total;
        }
    }
}
