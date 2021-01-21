using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaLeon
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        frmClientes objClientes = new frmClientes();
        frmEgresos objEgresos = new frmEgresos();
        frmProductos objProductos = new frmProductos();
        frmVentas objVentas = new frmVentas();
        
        private void btnOpciones_Click(object sender, EventArgs e)
        {
            if (MenuLateral.Width == 42)
            {
                MenuLateral.Width = 500;
            }
            else
                MenuLateral.Width = 42;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro/a que deseas salir?", "Salir :c", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /*Codigo para mover la pestaña*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]


        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            objProductos.Show();
            PanelClientes.Hide();
            objEgresos.Hide();
            objVentas.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

            
            objProductos.Hide();
            objEgresos.Hide();
            objVentas.Hide();
        }

        private void btnEgresos_Click(object sender, EventArgs e)
        {
            objEgresos.Show();
            PanelClientes.Hide();
            objProductos.Hide();
            objVentas.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            objVentas.Show();
            PanelClientes.Hide();
            objProductos.Hide();
            objEgresos.Hide();
        }

        private void btnClientes_MouseClick(object sender, MouseEventArgs e)
        {
            PanelClientes.Show();
        }

        private void btnRtClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnLtClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnDtClientes_Click(object sender, EventArgs e)
        {

        }
    }
}
