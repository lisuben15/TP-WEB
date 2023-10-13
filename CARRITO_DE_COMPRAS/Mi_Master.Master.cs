using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace CARRITO_DE_COMPRAS
{
    public partial class Mi_Master : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Articulo> listaCarrito = (List<Articulo>)Session["listaCarrito"];
            if (Session["listaCarrito"] == null)
            {
                CartItemsCount.Text = "0";
            }
            else
            {
                CartItemsCount.Text = listaCarrito.Count.ToString();
            }
        }

        protected void btnCarrito_Click(object sender, EventArgs e)
        {
            Response.Redirect("Carrito.aspx");
        }

    }
}