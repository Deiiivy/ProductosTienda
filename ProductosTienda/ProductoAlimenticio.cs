using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosTienda
{
    public class ProductoAlimenticio : Producto
    {
        public ProductoAlimenticio(string nombre, decimal precio) : base(nombre, precio) { }

        public override decimal CalcularPrecioFinal()
        {
            return Precio * 0.95m; 
        }
    }
}
