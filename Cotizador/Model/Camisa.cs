using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Model
{
    class Camisa:Prenda
    {
        private bool esMangaCorta;
        private bool esCuelloMao;

        public Camisa()
        {
        }

        public Camisa(bool esMangaCorta, bool esCuelloMao, int cantidad)
        {
            this.esMangaCorta = esMangaCorta;
            this.esCuelloMao = esCuelloMao;
            this.Stock = cantidad;
        }

        public bool EsMangaCorta { get => esMangaCorta; set => esMangaCorta = value; }
        public bool EsCuelloMao { get => esCuelloMao; set => esCuelloMao = value; }
    }
}
