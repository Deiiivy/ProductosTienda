using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProductosTienda
{
    public static class ProductoFactory
    {
        public static Producto CrearProducto(string tipo, string nombre, decimal precio)
        {
            if (tipo == "Electrónico")
            {
                return new ProductoElectrónico(nombre, precio);
            }
            else if (tipo == "Alimenticio")
            {
                return new ProductoAlimenticio(nombre, precio);
            }
            else if (tipo == "Ropa")
            {
                return new ProductoRopa(nombre, precio);
            }
            else
            {
                throw new ArgumentException("Tipo de producto no válido");
            }
        }
    }
}

