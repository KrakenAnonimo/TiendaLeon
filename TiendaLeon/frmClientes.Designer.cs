
namespace TiendaLeon
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.pnlBarraSuperior = new System.Windows.Forms.Panel();
            this.lblClientes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.pnlRegistroClientes = new System.Windows.Forms.Panel();
            this.btnEditarC = new System.Windows.Forms.Button();
            this.btnGuardarC = new System.Windows.Forms.Button();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pnlListaClientes = new System.Windows.Forms.Panel();
            this.lbxCliente = new System.Windows.Forms.ListBox();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
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
            this.pnlBarraSuperior.TabIndex = 0;
            this.pnlBarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraSuperior_MouseDown);
            // 
            // lblClientes
            // 
            this.lblClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblClientes.AutoSize = true;
            this.lblClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(362, 9);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(72, 21);
            this.lblClientes.TabIndex = 6;
            this.lblClientes.Text = "Clientes";
            this.lblClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
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
            this.pnlBase.Size = new System.Drawing.Size(788, 296);
            this.pnlBase.TabIndex = 1;
            // 
            // pnlRegistroClientes
            // 
            this.pnlRegistroClientes.BackColor = System.Drawing.Color.White;
            this.pnlRegistroClientes.Controls.Add(this.cbxGenero);
            this.pnlRegistroClientes.Controls.Add(this.btnEditarC);
            this.pnlRegistroClientes.Controls.Add(this.btnGuardarC);
            this.pnlRegistroClientes.Controls.Add(this.txtCelular);
            this.pnlRegistroClientes.Controls.Add(this.txtDocumento);
            this.pnlRegistroClientes.Controls.Add(this.txtApellido);
            this.pnlRegistroClientes.Controls.Add(this.lblGenero);
            this.pnlRegistroClientes.Controls.Add(this.lblCelular);
            this.pnlRegistroClientes.Controls.Add(this.lblDocumento);
            this.pnlRegistroClientes.Controls.Add(this.lblApellido);
            this.pnlRegistroClientes.Controls.Add(this.lblNombre);
            this.pnlRegistroClientes.Controls.Add(this.label2);
            this.pnlRegistroClientes.Controls.Add(this.label1);
            this.pnlRegistroClientes.Controls.Add(this.txtNombre);
            this.pnlRegistroClientes.Location = new System.Drawing.Point(16, 13);
            this.pnlRegistroClientes.Name = "pnlRegistroClientes";
            this.pnlRegistroClientes.Size = new System.Drawing.Size(334, 272);
            this.pnlRegistroClientes.TabIndex = 1;
            // 
            // btnEditarC
            // 
            this.btnEditarC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarC.FlatAppearance.BorderSize = 0;
            this.btnEditarC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEditarC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnEditarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarC.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarC.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarC.Image")));
            this.btnEditarC.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEditarC.Location = new System.Drawing.Point(133, 238);
            this.btnEditarC.Name = "btnEditarC";
            this.btnEditarC.Size = new System.Drawing.Size(101, 30);
            this.btnEditarC.TabIndex = 21;
            this.btnEditarC.Text = "Editar";
            this.btnEditarC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarC.UseVisualStyleBackColor = true;
            // 
            // btnGuardarC
            // 
            this.btnGuardarC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarC.FlatAppearance.BorderSize = 0;
            this.btnGuardarC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGuardarC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnGuardarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarC.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarC.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarC.Image")));
            this.btnGuardarC.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGuardarC.Location = new System.Drawing.Point(230, 238);
            this.btnGuardarC.Name = "btnGuardarC";
            this.btnGuardarC.Size = new System.Drawing.Size(101, 30);
            this.btnGuardarC.TabIndex = 20;
            this.btnGuardarC.Text = "Guardar";
            this.btnGuardarC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarC.UseVisualStyleBackColor = true;
            this.btnGuardarC.Click += new System.EventHandler(this.btnGuardarC_Click);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(83, 177);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(224, 20);
            this.txtCelular.TabIndex = 17;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(107, 145);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(0);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(200, 20);
            this.txtDocumento.TabIndex = 15;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(83, 112);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(224, 20);
            this.txtApellido.TabIndex = 13;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(16, 210);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(56, 17);
            this.lblGenero.TabIndex = 11;
            this.lblGenero.Text = "Genero";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(16, 180);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(54, 17);
            this.lblCelular.TabIndex = 9;
            this.lblCelular.Text = "Celular";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(16, 148);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(86, 17);
            this.lblDocumento.TabIndex = 7;
            this.lblDocumento.Text = "Documento";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(16, 115);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(61, 17);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido";
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
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de Cliente";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(224, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Tag = "";
            // 
            // pnlListaClientes
            // 
            this.pnlListaClientes.BackColor = System.Drawing.Color.White;
            this.pnlListaClientes.Controls.Add(this.lbxCliente);
            this.pnlListaClientes.Location = new System.Drawing.Point(356, 13);
            this.pnlListaClientes.Name = "pnlListaClientes";
            this.pnlListaClientes.Size = new System.Drawing.Size(417, 272);
            this.pnlListaClientes.TabIndex = 0;
            // 
            // lbxCliente
            // 
            this.lbxCliente.FormattingEnabled = true;
            this.lbxCliente.Location = new System.Drawing.Point(4, 4);
            this.lbxCliente.Name = "lbxCliente";
            this.lbxCliente.Size = new System.Drawing.Size(410, 264);
            this.lbxCliente.TabIndex = 0;
            // 
            // cbxGenero
            // 
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbxGenero.Location = new System.Drawing.Point(83, 206);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(121, 21);
            this.cbxGenero.TabIndex = 22;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 349);
            this.Controls.Add(this.pnlBase);
            this.Controls.Add(this.pnlBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClientes";
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
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Panel pnlListaClientes;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Panel pnlRegistroClientes;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnEditarC;
        private System.Windows.Forms.Button btnGuardarC;
        private System.Windows.Forms.ListBox lbxCliente;
        private System.Windows.Forms.ComboBox cbxGenero;
    }
}