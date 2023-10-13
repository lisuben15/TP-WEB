using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CARRITO_DE_COMPRAS
{
	public partial class Carrito : System.Web.UI.Page
	{
        public List<Articulo> listaCarrito { get; set; }
        public List<Articulo> listaAux {  get; set; }

        public Carrito()
        {
            listaAux = new List<Articulo>();        
        }
        protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {

                if (Session["listaCarrito"] != null)
                {
                    listaCarrito = (List<Articulo>)Session["listaCarrito"];

                    if (listaAux != null)
                    {
                        foreach (var item in listaAux)
                        {
                            listaCarrito.Add(item);
                        }
                    }

                    Repetidor2.DataSource = listaCarrito;
                    Repetidor2.DataBind();
                }
                else
                {
                    listaCarrito = new List<Articulo>(); // justifica lo null
                }
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            string valor = ((Button)sender).CommandArgument;
            
            listaCarrito = (List<Articulo>)Session["listaCarrito"];
            foreach (var item in listaCarrito)
            {
                if(item.Codigo != valor)
                {
                    listaAux.Add(item);
                }
            }
            Session["listaCarrito"] = listaAux;
            Response.Redirect("Carrito.aspx");
        }
    }
}