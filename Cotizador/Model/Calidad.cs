using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Model
{
    class Calidad
    {
        private int idCalidad;
        private string nombre;

        public int IdCalidad { get => idCalidad; set => idCalidad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
