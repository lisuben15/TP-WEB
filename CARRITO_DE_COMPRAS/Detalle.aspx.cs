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
    public partial class Detalle : System.Web.UI.Page
    {
        public string Codigo { get; set; }
        public Articulo articulo { get; set; }
        public int imageIndex { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Codigo = Request.QueryString["Codigo"];
            ServicioArticulo servicioArticulo = new ServicioArticulo();
            articulo = servicioArticulo.detallarArticulo(Codigo);
            List<string> Imagenes = servicioArticulo.ListarImagenes(articulo.Id);
            if (!IsPostBack) {
                if (Session["imageIndex"] != null)
                {
                    int imgIndex = (int)Session["imageIndex"];
                    articulo.UrlImagen = Imagenes[imgIndex];
                }
                else
                {
                    articulo.UrlImagen = Imagenes[0];
                    imageIndex = 0;
                    Session["imageIndex"] = 0;
                }
            }
        }
        public void btnNextUrl_Click(object sender, EventArgs e)
        {
            ServicioArticulo servicioArticulo = new ServicioArticulo();
            List<string> Imagenes = servicioArticulo.ListarImagenes(articulo.Id);
            int imgIndex = (int)Session["imageIndex"];
            if (imgIndex == Imagenes.Count - 1)
            {
                Session["imageIndex"] = 0;
            }
            else
            {
                Session["imageIndex"] = imgIndex+1;
            }
            articulo.UrlImagen = Imagenes[(int)Session["imageIndex"]];
        }
        public void btnPreviousUrl_Click(object sender, EventArgs e)
        {
            ServicioArticulo servicioArticulo = new ServicioArticulo();
            List<string> Imagenes = servicioArticulo.ListarImagenes(articulo.Id);
            int imgIndex = (int)Session["imageIndex"];
            if (imgIndex == 0)
            {
                Session["imageIndex"] = Imagenes.Count-1;
            }
            else
            {
                Session["imageIndex"] = imgIndex-1;
            }
            articulo.UrlImagen = Imagenes[(int)Session["imageIndex"]];
        }
    }
}