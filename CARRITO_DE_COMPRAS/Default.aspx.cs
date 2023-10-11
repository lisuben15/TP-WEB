using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;

namespace CARRITO_DE_COMPRAS
{
    public partial class Página1 : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulo { get; set; }
        public List<Articulo> listaCarrito { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ServicioArticulo servicioArticulo = new ServicioArticulo();
            ListaArticulo = servicioArticulo.ListarArticulosSP(); // lo que traemos de la DB lo guardamos en la lista
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            
            //capturar articulo y guardar a listaCarrito
        }

    }
}