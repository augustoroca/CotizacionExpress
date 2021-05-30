using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Model
{
    class Prenda
    {
        
        private int nombre;
        private int idCalidad;
        private float precio;
        private int stock;

       
        public int Nombre { get => nombre; set => nombre = value; }
        public int IdCalidad { get => idCalidad; set => idCalidad = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
