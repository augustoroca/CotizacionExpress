using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Model
{
    class Tienda
    {
        private string nombre;
        private string direccion;
        private static List<Camisa> camisas = new List<Camisa>();
        private static List<Pantalon> pantalones = new List<Pantalon>();

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        internal static List<Camisa> Camisas { get => camisas; set => camisas = value; }
        internal static List<Pantalon> Pantalones { get => pantalones; set => pantalones = value; }

        public Tienda()
        {
            Nombre = "Tejano";
            Direccion = "Av Colon 450";

        }

        public  void agregarCamisa (Camisa camisa)
        {
            Camisas.Add(camisa);

        }

        public void agregarPantalon(Pantalon pantalon)
        {
            Pantalones.Add(pantalon);

        }
    }
}
