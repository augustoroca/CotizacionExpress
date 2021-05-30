using Cotizador.Controller;
using Cotizador.Model;
using Cotizador.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cotizador
{
    public partial class FrmCotizador : Form
    {
        public FrmCotizador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHistorial frm = new FrmHistorial();
            frm.ShowDialog();
            
        }

        private void FrmCotizador_Load(object sender, EventArgs e)
        {
            TiendaController tiendaController = new TiendaController();
            VendedorController vendedorController = new VendedorController();

            var tienda = tiendaController.GetTienda();
            lblNombreTienda.Text = tienda.Nombre;
            lblDireccionTienda.Text = tienda.Direccion;

            var vendedor = vendedorController.GetVendedor();
            lblNombreApellido.Text = vendedor.NombreApellido;
            lblCodVendedor.Text = vendedor.IdVendedor.ToString();

           

            CamisaController camisa = new CamisaController();
            var MangaCortaCuelloMao = camisa.SetStock(true,true,200);
            tiendaController.agregarPrenda(MangaCortaCuelloMao);


            CamisaController camisa2 = new CamisaController();
            var MangaCortaCuelloNormal = camisa2.SetStock(true, false, 300);
            tiendaController.agregarPrenda(MangaCortaCuelloNormal);


            CamisaController camisa3 = new CamisaController();
            var MangaLargaCuelloMao = camisa3.SetStock(false, true, 150);
            tiendaController.agregarPrenda(MangaLargaCuelloMao);

            CamisaController camisa4 = new CamisaController();
            var MangaLargaCuelloNormal = camisa4.SetStock(false, false, 350);
            tiendaController.agregarPrenda(MangaLargaCuelloNormal);

            PantalonController pantalon = new PantalonController();
            var pantalonChupin = pantalon.SetStock(true,1500);
            tiendaController.agregarPrenda(pantalonChupin);

            PantalonController pantalon1 = new PantalonController();
           var pantalonNormal = pantalon1.SetStock(false, 500);
            tiendaController.agregarPrenda(pantalonNormal);
                
            lblStock.Text = calcularStock();
        }

        private string calcularStock()
        {
            if (rbCamisa.Checked)
            {
                return TiendaController.GetStockCamisa(chkMangaCorta.Checked, chkCuelloMao.Checked).ToString();
            }
            else
            {
                return TiendaController.GetStockPantalon(chkChupin.Checked).ToString();
            }    
            
        }

        private void rbPantalon_CheckedChanged(object sender, EventArgs e)
        {
            chkCuelloMao.Checked = false;
            chkMangaCorta.Checked = false;

            chkCuelloMao.Enabled = false;
            chkMangaCorta.Enabled = false;

            chkChupin.Enabled = true;
            chkChupin.Checked = false;

        }

        private void rbCamisa_CheckedChanged(object sender, EventArgs e)
        {
            chkCuelloMao.Checked = false;
            chkMangaCorta.Checked = false;

            chkCuelloMao.Enabled = true;
            chkMangaCorta.Enabled = true;

            chkChupin.Enabled = false;
            chkChupin.Checked = false;

        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            CotizacionController cotizacionController = new CotizacionController();
            float precio = Convert.ToSingle(txtPrecioUnitario.Text);
            int cantidad = Convert.ToInt16(txtCantidad.Text);

            if (rbCamisa.Checked)
            {
                lblTotal.Text=cotizacionController.Calcular(chkMangaCorta.Checked,chkCuelloMao.Checked,rbPremium.Checked,precio,cantidad).ToString();
            }
            else
            {
                lblTotal.Text = cotizacionController.Calcular(chkChupin.Checked, rbPremium.Checked,precio,cantidad).ToString();
            }
           

        }
    }
}
