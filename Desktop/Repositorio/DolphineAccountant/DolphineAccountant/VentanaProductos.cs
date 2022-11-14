using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;


namespace DolphineAccountant
{
    public partial class VentanaProductos : Form
    {
        public VentanaProductos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void VentanaProductos_Load(object sender, EventArgs e)
        {
            ProductosNegocio producto = new ProductosNegocio();
            dgvProductos.DataSource = producto.listar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoNegocio tipo = new TipoNegocio();
            cbTipo.DataSource = tipo.listar();
        }

        private void btnProductosGuardar_Click(object sender, EventArgs e)
        {
            CargaDeProducto Carga = new CargaDeProducto();
            Carga.ShowDialog();
        }
    }
    
}
