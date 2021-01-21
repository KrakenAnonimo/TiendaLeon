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
using TiendaLeon.Dato;
using TiendaLeon.Entidad;

namespace TiendaLeon
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMin2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]


        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            clClienteE objCliente = new clClienteE();
            objCliente.Nombre = txtNombre.Text;
            objCliente.Apellido = txtApellido.Text;
            objCliente.Documento = int.Parse(txtDocumento.Text);
            objCliente.Telefono = int.Parse(txtCelular.Text);
            objCliente.Genero = cbxGenero.SelectedItem.ToString();

            clClienteD objClienteD = new clClienteD();
            int resultado = objClienteD.mtdRegistrarCliente(objCliente);

            lbxCliente.Items.Add(txtNombre.Text + " " + txtApellido.Text + " " + txtCelular.Text);

            if (resultado>0)
            {
                //Mensaje
                MessageBox.Show("El cliente fue registrado correctamente! :D","COMPLETADO!");

            }
            else
            {
                MessageBox.Show("Ocurrio un problema al registrar el cliente, verifique los campos requeridos :C", "Que Paso?");
            }
        }
    }
}
