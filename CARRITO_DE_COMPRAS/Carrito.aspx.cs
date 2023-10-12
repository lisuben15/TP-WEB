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
        protected void Page_Load(object sender, EventArgs e)
		{
           
                if (Session["listaCarrito"] != null)
                {
                    List<Articulo> listaCarrito = (List<Articulo>)Session["listaCarrito"];
                    
                }
                else
                {
                      
                    
                }
            
            
        }
	}
}