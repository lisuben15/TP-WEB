using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ServicioCarrito
    {
        List<Articulo> MiCarrito {  get; set; }
        public ServicioCarrito()
        {
            if (MiCarrito == null)
            {
                MiCarrito = new List<Articulo>();
            }
        }

        public void AgregarAlCarrito(Articulo articulo)
        {  
          
            MiCarrito.Add(articulo);
          
        }

        public List<Articulo> DevolverListaDeCarrito()
       {
            return MiCarrito;
       }
    }
}
