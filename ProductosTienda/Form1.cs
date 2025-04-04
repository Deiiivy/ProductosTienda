using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosTienda
{
    public partial class Form1 : Form
    {
        private List<Producto> productos = new List<Producto>();

        public Form1()
        {
            InitializeComponent();

            cmbTipo.Items.Add("Electrónico");
            cmbTipo.Items.Add("Alimenticio");
            cmbTipo.Items.Add("Ropa");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrecio.Text, out decimal precio) && cmbTipo.SelectedItem != null)
            {
                Producto producto = ProductoFactory.CrearProducto(cmbTipo.SelectedItem.ToString(), txtNombre.Text, precio);
                productos.Add(producto);
                lstProductos.Items.Add($"{producto.Nombre} - {producto.CalcularPrecioFinal():C}");
            }
            else
            {
                MessageBox.Show("Ingrese datos válidos.");
            }
        }
    }
}
