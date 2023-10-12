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


        protected void Page_Load(object sender, EventArgs e)
        {
            ServicioArticulo servicioArticulo = new ServicioArticulo();
            ListaArticulo = servicioArticulo.ListarArticulosSP(); // lo que traemos de la DB lo guardamos en la lista
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            List<Articulo> listaCarrito = new List<Articulo>();

            articulo.Codigo = Request.QueryString["Codigo"];
            articulo.Nombre = Request.QueryString["Nombre"];
            articulo.Descripcion = Request.QueryString["Descripcion"];
            articulo.Precio =decimal.Parse(Request.QueryString["Precio"]);
            articulo.UrlImagen = Request.QueryString["Urlimagen"];
            //articulo.Marca.Descripcion = Request.QueryString["Marca"];
            // articulo.Categoria.Descripcion= Request.QueryString["Categoria"];
            articulo.Marca = new Marca { Descripcion = Request.QueryString["Marca"] }; 
            articulo.Categoria = new Categoria { Descripcion = Request.QueryString["Categoria"] }; 
            listaCarrito.Add(articulo);
            Session["listaCarrito"] = listaCarrito;
            Response.Redirect("Carrito.aspx");
            //capturar articulo y guardar a listaCarrito
        }

    }
}