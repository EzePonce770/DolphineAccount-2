using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using negocio;
using dominio;



namespace DolphineAccountant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState |= FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible |= true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void AbrirFormInPanel (object FormHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();  

        }



        // APERTURA DE VENTANAS
        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new VentanaVentas());

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new VentanaCompras());
        }


        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new VentanaProductos());
        
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new VentanaReportes());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new VentanaClientes());
        }
    }
}
