using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Model
{
    class Vendedor
    {
        private string nombre;
        private string apellido;
        private int idVendedor;
        private string nombreApellido;

        public Vendedor()
        {
            Nombre = "Augusto";
            Apellido = "Roca";
            IdVendedor = 1;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int IdVendedor { get => idVendedor; set => idVendedor = value; }
        public string NombreApellido { get => Nombre + " "+ Apellido; set => nombreApellido = value; }
    }
}
