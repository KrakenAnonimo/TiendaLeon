﻿using System;
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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
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

        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            clProductoE objCliente = new clProductoE();
            objCliente.Nombre = txtNombreP.Text;
            objCliente.Precio = int.Parse(txtPrecioP.Text);
            objCliente.Cantidad = int.Parse(txtCantidadP.Text);

            clProductoD objClienteD = new clProductoD();
            int resultado = objClienteD.mtdRegistrarProducto(objCliente);

            ltbxProductos.Items.Add(txtNombreP.Text + " " + txtCantidadP.Text + " " + txtPrecioP.Text);

            if (resultado > 0)
            {
                //Mensaje
                MessageBox.Show("El producto fue registrado correctamente! :D", "COMPLETADO!");

            }
            else
            {
                MessageBox.Show("Ocurrio un problema al registrar el producto, verifique los campos requeridos :C", "Que Paso?");
            }
        }
    }
}
