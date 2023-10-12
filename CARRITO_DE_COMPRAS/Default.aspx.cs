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

        public Articulo articulo { get; set; }

        public Página1()
        {
            listaCarrito = new List<Articulo>();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            // lo que traemos de la DB lo guardamos en la lista
            if (!IsPostBack)
            {
                ServicioArticulo servicioArticulo = new ServicioArticulo();
                ListaArticulo = servicioArticulo.ListarArticulosSP();
                Repetidor1.DataSource = ListaArticulo;
                Repetidor1.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            
            ServicioArticulo servicioArticulo = new ServicioArticulo();
            
            string valor = ((Button)sender).CommandArgument;
            articulo=servicioArticulo.detallarArticulo(valor);

            if (Session["listaCarrito"] != null)
            {
                listaCarrito = (List<Articulo>)Session["listaCarrito"];
            }

             listaCarrito.Add(articulo);
             Session["listaCarrito"] = listaCarrito;          
          

           
        }

    }
}