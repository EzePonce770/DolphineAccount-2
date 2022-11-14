using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace DolphineAccountant
{
    public partial class CargaDeProducto : Form
    {
        public CargaDeProducto()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProductosCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProductosGuadar_Click(object sender, EventArgs e)
        {   
            producto Produc = new producto();
            ProductosNegocio negocio = new ProductosNegocio();

            try
            {
                   Produc.Nombre =  txtCargaNombre.Text;
                   Produc.Descripcion = txtCargaDescripcion.Text;
                   Produc.Marca = txtCargaMarca.Text;
                   Produc.Precio = int.Parse(txtMarcaPrecio.Text);
                   Produc.Stock = int.Parse(txtCargaStock.Text);

                   negocio.agregar(Produc);
                   MessageBox.Show("Agregado correctyamente");
                   Close();

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.ToString());
            }
        }

       
    }
}

