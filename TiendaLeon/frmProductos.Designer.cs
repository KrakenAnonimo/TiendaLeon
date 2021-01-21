
namespace TiendaLeon
{
    partial class frmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.pnlBarraSuperior = new System.Windows.Forms.Panel();
            this.lblClientes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.pnlRegistroClientes = new System.Windows.Forms.Panel();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.btnEditarP = new System.Windows.Forms.Button();
            this.btnGuardarP = new System.Windows.Forms.Button();
            this.txtPrecioP = new System.Windows.Forms.TextBox();
            this.txtCantidadP = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.pnlListaClientes = new System.Windows.Forms.Panel();
            this.ltbxProductos = new System.Windows.Forms.ListBox();
            this.pnlBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlBase.SuspendLayout();
            this.pnlRegistroClientes.SuspendLayout();
            this.pnlListaClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraSuperior
            // 
            this.pnlBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.pnlBarraSuperior.Controls.Add(this.lblClientes);
            this.pnlBarraSuperior.Controls.Add(this.pictureBox1);
            this.pnlBarraSuperior.Controls.Add(this.btnMinimizar);
            this.pnlBarraSuperior.Controls.Add(this.btnCerrar);
            this.pnlBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraSuperior.Name = "pnlBarraSuperior";
            this.pnlBarraSuperior.Size = new System.Drawing.Size(800, 35);
            this.pnlBarraSuperior.TabIndex = 1;
            this.pnlBarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraSuperior_MouseDown);
            // 
            // lblClientes
            // 
            this.lblClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblClientes.AutoSize = true;
            this.lblClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(357, 9);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(88, 21);
            this.lblClientes.TabIndex = 6;
            this.lblClientes.Text = "Productos";
            this.lblClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(725, -5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(761, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlBase
            // 
            this.pnlBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(183)))), ((int)(((byte)(181)))));
            this.pnlBase.Controls.Add(this.pnlRegistroClientes);
            this.pnlBase.Controls.Add(this.pnlListaClientes);
            this.pnlBase.Location = new System.Drawing.Point(6, 45);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(788, 251);
            this.pnlBase.TabIndex = 2;
            // 
            // pnlRegistroClientes
            // 
            this.pnlRegistroClientes.BackColor = System.Drawing.Color.White;
            this.pnlRegistroClientes.Controls.Add(this.btnEliminarP);
            this.pnlRegistroClientes.Controls.Add(this.btnEditarP);
            this.pnlRegistroClientes.Controls.Add(this.btnGuardarP);
            this.pnlRegistroClientes.Controls.Add(this.txtPrecioP);
            this.pnlRegistroClientes.Controls.Add(this.txtCantidadP);
            this.pnlRegistroClientes.Controls.Add(this.lblDocumento);
            this.pnlRegistroClientes.Controls.Add(this.lblApellido);
            this.pnlRegistroClientes.Controls.Add(this.lblNombre);
            this.pnlRegistroClientes.Controls.Add(this.label2);
            this.pnlRegistroClientes.Controls.Add(this.label1);
            this.pnlRegistroClientes.Controls.Add(this.txtNombreP);
            this.pnlRegistroClientes.Location = new System.Drawing.Point(16, 13);
            this.pnlRegistroClientes.Name = "pnlRegistroClientes";
            this.pnlRegistroClientes.Size = new System.Drawing.Size(334, 223);
            this.pnlRegistroClientes.TabIndex = 1;
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarP.FlatAppearance.BorderSize = 0;
            this.btnEliminarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEliminarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnEliminarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarP.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarP.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarP.Image")));
            this.btnEliminarP.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEliminarP.Location = new System.Drawing.Point(2, 190);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(101, 30);
            this.btnEliminarP.TabIndex = 22;
            this.btnEliminarP.Text = "Eliminar";
            this.btnEliminarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarP.UseVisualStyleBackColor = true;
            // 
            // btnEditarP
            // 
            this.btnEditarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarP.FlatAppearance.BorderSize = 0;
            this.btnEditarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEditarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnEditarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarP.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarP.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarP.Image")));
            this.btnEditarP.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEditarP.Location = new System.Drawing.Point(109, 190);
            this.btnEditarP.Name = "btnEditarP";
            this.btnEditarP.Size = new System.Drawing.Size(101, 30);
            this.btnEditarP.TabIndex = 21;
            this.btnEditarP.Text = "Editar";
            this.btnEditarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarP.UseVisualStyleBackColor = true;
            // 
            // btnGuardarP
            // 
            this.btnGuardarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarP.FlatAppearance.BorderSize = 0;
            this.btnGuardarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGuardarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnGuardarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarP.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarP.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarP.Image")));
            this.btnGuardarP.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGuardarP.Location = new System.Drawing.Point(230, 190);
            this.btnGuardarP.Name = "btnGuardarP";
            this.btnGuardarP.Size = new System.Drawing.Size(101, 30);
            this.btnGuardarP.TabIndex = 20;
            this.btnGuardarP.Text = "Guardar";
            this.btnGuardarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarP.UseVisualStyleBackColor = true;
            this.btnGuardarP.Click += new System.EventHandler(this.btnGuardarP_Click);
            // 
            // txtPrecioP
            // 
            this.txtPrecioP.Location = new System.Drawing.Point(83, 145);
            this.txtPrecioP.Margin = new System.Windows.Forms.Padding(0);
            this.txtPrecioP.Name = "txtPrecioP";
            this.txtPrecioP.Size = new System.Drawing.Size(224, 20);
            this.txtPrecioP.TabIndex = 15;
            // 
            // txtCantidadP
            // 
            this.txtCantidadP.Location = new System.Drawing.Point(83, 112);
            this.txtCantidadP.Name = "txtCantidadP";
            this.txtCantidadP.Size = new System.Drawing.Size(224, 20);
            this.txtCantidadP.TabIndex = 13;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(16, 148);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(48, 17);
            this.lblDocumento.TabIndex = 7;
            this.lblDocumento.Text = "Precio";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(16, 113);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(71, 17);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Cantidad";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(16, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 17);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tenga en cuenta los siguentes campos!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de Productos";
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(83, 77);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(224, 20);
            this.txtNombreP.TabIndex = 0;
            this.txtNombreP.Tag = "";
            // 
            // pnlListaClientes
            // 
            this.pnlListaClientes.BackColor = System.Drawing.Color.White;
            this.pnlListaClientes.Controls.Add(this.ltbxProductos);
            this.pnlListaClientes.Location = new System.Drawing.Point(356, 13);
            this.pnlListaClientes.Name = "pnlListaClientes";
            this.pnlListaClientes.Size = new System.Drawing.Size(417, 223);
            this.pnlListaClientes.TabIndex = 0;
            // 
            // ltbxProductos
            // 
            this.ltbxProductos.FormattingEnabled = true;
            this.ltbxProductos.Location = new System.Drawing.Point(4, 4);
            this.ltbxProductos.Name = "ltbxProductos";
            this.ltbxProductos.Size = new System.Drawing.Size(410, 212);
            this.ltbxProductos.TabIndex = 0;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 306);
            this.Controls.Add(this.pnlBase);
            this.Controls.Add(this.pnlBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductos";
            this.pnlBarraSuperior.ResumeLayout(false);
            this.pnlBarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlBase.ResumeLayout(false);
            this.pnlRegistroClientes.ResumeLayout(false);
            this.pnlRegistroClientes.PerformLayout();
            this.pnlListaClientes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraSuperior;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Panel pnlRegistroClientes;
        private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.Button btnEditarP;
        private System.Windows.Forms.Button btnGuardarP;
        private System.Windows.Forms.TextBox txtPrecioP;
        private System.Windows.Forms.TextBox txtCantidadP;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.Panel pnlListaClientes;
        private System.Windows.Forms.ListBox ltbxProductos;
    }
}