using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CARRITO_DE_COMPRAS
{
	public partial class Carrito : System.Web.UI.Page
	{
        public List<Articulo> listaCarrito { get; set; }

        ServicioCarrito servicioCarrito = new ServicioCarrito();
        protected void Page_Load(object sender, EventArgs e)
		{

            if(Session["listaCarrito"] != null)
            {
                listaCarrito = (List<Articulo>)Session["listaCarrito"];
            }
            else
            {
                listaCarrito = new List<Articulo>();
            }  
        }
	}
}