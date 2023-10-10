using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;
namespace CARRITO_DE_COMPRAS
{
    public partial class ArticulosListar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServicioArticulo servicioArticulo = new ServicioArticulo();
            dgvArticulos.DataSource = servicioArticulo.ListarArticulosSP();
            dgvArticulos.DataBind(); // PARA ENLAZAR LOS DATOS
        }
    }
}