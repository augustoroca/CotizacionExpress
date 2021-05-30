using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Model
{
    class Cotizacion
    {
        private int idCotizacion;
        private DateTime fecha;
        private int idVendedor;
        private string prenda;
        private int cantidad;
        private float total;

        public int IdCotizacion { get => idCotizacion; set => idCotizacion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int IdVendedor { get => idVendedor; set => idVendedor = value; }
        public string Prenda { get => prenda; set => prenda = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float Total { get => total; set => total = value; }
    }
}
