﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosTienda
{
    public abstract class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public abstract decimal CalcularPrecioFinal();
    }
}
