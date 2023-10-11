using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Carrito
    {

        public List<Articulo> Carritolista {  get; set; }

        public int Cantidad {  get; set; }

        public decimal Total { get; set; }

    }
}
