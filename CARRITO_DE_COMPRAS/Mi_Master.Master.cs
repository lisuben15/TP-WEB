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
        List<Articulo> listaCarrito {  get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            listaCarrito = (List<Articulo>)Session["listaCarrito"];
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

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
           string Palabra = txtBusqueda.Text;
            ServicioArticulo servicioArticulo = new ServicioArticulo();
            Session["listaArticulo"] = servicioArticulo.FiltrarArticulos(Palabra);          
            Response.Redirect("Default.aspx");

        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            Session["listaArticulo"] = null;
            Response.Redirect("Default.aspx");
        }
    }
}