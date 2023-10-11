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
        protected void Page_Load(object sender, EventArgs e)
        {
            Codigo = Request.QueryString["Codigo"];
            ServicioArticulo servicioArticulo = new ServicioArticulo();
           articulo = servicioArticulo.detallarArticulo(Codigo);
        }
    }
}