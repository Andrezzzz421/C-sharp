namespace BibliotecaLosSayayines.UI
{
    partial class FrmMenu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDePrestamo = new System.Windows.Forms.Button();
            this.BtnAbandonar = new System.Windows.Forms.Button();
            this.btnGeneros = new System.Windows.Forms.Button();
            this.btnGestionPrestamosLibros = new System.Windows.Forms.Button();
            this.btnCaategorias = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnGestionEditorial = new System.Windows.Forms.Button();
            this.btnGestionLibros = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.btnGestionUsuarios = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PicFoto = new System.Windows.Forms.PictureBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlApp = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1375, 53);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libreria Los Sayajines";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnDePrestamo);
            this.panel1.Controls.Add(this.BtnAbandonar);
            this.panel1.Controls.Add(this.btnGeneros);
            this.panel1.Controls.Add(this.btnGestionPrestamosLibros);
            this.panel1.Controls.Add(this.btnCaategorias);
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.btnGestionEditorial);
            this.panel1.Controls.Add(this.btnGestionLibros);
            this.panel1.Controls.Add(this.btnAutores);
            this.panel1.Controls.Add(this.btnGestionUsuarios);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1002);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDePrestamo
            // 
            this.btnDePrestamo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDePrestamo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDePrestamo.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnDePrestamo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnDePrestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDePrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDePrestamo.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDePrestamo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDePrestamo.Location = new System.Drawing.Point(0, 628);
            this.btnDePrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.btnDePrestamo.Name = "btnDePrestamo";
            this.btnDePrestamo.Size = new System.Drawing.Size(200, 40);
            this.btnDePrestamo.TabIndex = 14;
            this.btnDePrestamo.Text = "Detalle Prestamo";
            this.btnDePrestamo.UseVisualStyleBackColor = false;
            this.btnDePrestamo.Click += new System.EventHandler(this.btnDePrestamo_Click);
            // 
            // BtnAbandonar
            // 
            this.BtnAbandonar.BackColor = System.Drawing.Color.Transparent;
            this.BtnAbandonar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAbandonar.FlatAppearance.BorderSize = 0;
            this.BtnAbandonar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnAbandonar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnAbandonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbandonar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbandonar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAbandonar.Image = global::BibliotecaLosSayayines.Properties.Resources.cerrar_sesion__2_;
            this.BtnAbandonar.Location = new System.Drawing.Point(0, 963);
            this.BtnAbandonar.Name = "BtnAbandonar";
            this.BtnAbandonar.Size = new System.Drawing.Size(200, 39);
            this.BtnAbandonar.TabIndex = 21;
            this.BtnAbandonar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAbandonar.UseVisualStyleBackColor = false;
            this.BtnAbandonar.Click += new System.EventHandler(this.BtnAbandonar_Click);
            // 
            // btnGeneros
            // 
            this.btnGeneros.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGeneros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeneros.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnGeneros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnGeneros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGeneros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneros.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGeneros.Location = new System.Drawing.Point(0, 588);
            this.btnGeneros.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeneros.Name = "btnGeneros";
            this.btnGeneros.Size = new System.Drawing.Size(200, 40);
            this.btnGeneros.TabIndex = 19;
            this.btnGeneros.Text = "Gestion Generos ";
            this.btnGeneros.UseVisualStyleBackColor = false;
            this.btnGeneros.Click += new System.EventHandler(this.BtnGeneros_Click);
            // 
            // btnGestionPrestamosLibros
            // 
            this.btnGestionPrestamosLibros.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGestionPrestamosLibros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionPrestamosLibros.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnGestionPrestamosLibros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnGestionPrestamosLibros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGestionPrestamosLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionPrestamosLibros.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionPrestamosLibros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionPrestamosLibros.Location = new System.Drawing.Point(0, 548);
            this.btnGestionPrestamosLibros.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestionPrestamosLibros.Name = "btnGestionPrestamosLibros";
            this.btnGestionPrestamosLibros.Size = new System.Drawing.Size(200, 40);
            this.btnGestionPrestamosLibros.TabIndex = 19;
            this.btnGestionPrestamosLibros.Text = "Prestamos Libros";
            this.btnGestionPrestamosLibros.UseVisualStyleBackColor = false;
            this.btnGestionPrestamosLibros.Click += new System.EventHandler(this.BtnGesLibros_Click);
            // 
            // btnCaategorias
            // 
            this.btnCaategorias.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCaategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaategorias.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnCaategorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnCaategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCaategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaategorias.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaategorias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCaategorias.Location = new System.Drawing.Point(0, 508);
            this.btnCaategorias.Margin = new System.Windows.Forms.Padding(4);
            this.btnCaategorias.Name = "btnCaategorias";
            this.btnCaategorias.Size = new System.Drawing.Size(200, 40);
            this.btnCaategorias.TabIndex = 20;
            this.btnCaategorias.Text = "Gestion Categoria\r\n";
            this.btnCaategorias.UseVisualStyleBackColor = false;
            this.btnCaategorias.Click += new System.EventHandler(this.BtnCaategorias_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientes.Location = new System.Drawing.Point(0, 468);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(200, 40);
            this.btnClientes.TabIndex = 18;
            this.btnClientes.Text = "Gestion Clientes\r\n\r\n";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // btnGestionEditorial
            // 
            this.btnGestionEditorial.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGestionEditorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionEditorial.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnGestionEditorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnGestionEditorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGestionEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionEditorial.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionEditorial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionEditorial.Location = new System.Drawing.Point(0, 428);
            this.btnGestionEditorial.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestionEditorial.Name = "btnGestionEditorial";
            this.btnGestionEditorial.Size = new System.Drawing.Size(200, 40);
            this.btnGestionEditorial.TabIndex = 20;
            this.btnGestionEditorial.Text = "Gestion Editorial";
            this.btnGestionEditorial.UseVisualStyleBackColor = false;
            this.btnGestionEditorial.Click += new System.EventHandler(this.BtnEditorial_Click);
            // 
            // btnGestionLibros
            // 
            this.btnGestionLibros.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGestionLibros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionLibros.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnGestionLibros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnGestionLibros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGestionLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionLibros.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionLibros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionLibros.Location = new System.Drawing.Point(0, 388);
            this.btnGestionLibros.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestionLibros.Name = "btnGestionLibros";
            this.btnGestionLibros.Size = new System.Drawing.Size(200, 40);
            this.btnGestionLibros.TabIndex = 18;
            this.btnGestionLibros.Text = "Gestion Libros";
            this.btnGestionLibros.UseVisualStyleBackColor = false;
            this.btnGestionLibros.Click += new System.EventHandler(this.BtnLibros_Click);
            // 
            // btnAutores
            // 
            this.btnAutores.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAutores.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnAutores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnAutores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutores.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAutores.Location = new System.Drawing.Point(0, 348);
            this.btnAutores.Margin = new System.Windows.Forms.Padding(4);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(200, 40);
            this.btnAutores.TabIndex = 18;
            this.btnAutores.Text = "Gestion Autores";
            this.btnAutores.UseVisualStyleBackColor = false;
            this.btnAutores.Click += new System.EventHandler(this.BtnAutores_Click);
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGestionUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionUsuarios.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnGestionUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnGestionUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGestionUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionUsuarios.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionUsuarios.Location = new System.Drawing.Point(0, 308);
            this.btnGestionUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(200, 40);
            this.btnGestionUsuarios.TabIndex = 13;
            this.btnGestionUsuarios.Text = "Gestion Usuarios";
            this.btnGestionUsuarios.UseVisualStyleBackColor = false;
            this.btnGestionUsuarios.Click += new System.EventHandler(this.BtnUsuario_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.PicFoto);
            this.panel4.Controls.Add(this.lblRol);
            this.panel4.Controls.Add(this.lblNombre);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 308);
            this.panel4.TabIndex = 12;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // PicFoto
            // 
            this.PicFoto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PicFoto.Location = new System.Drawing.Point(27, 43);
            this.PicFoto.Name = "PicFoto";
            this.PicFoto.Size = new System.Drawing.Size(146, 150);
            this.PicFoto.TabIndex = 3;
            this.PicFoto.TabStop = false;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRol.Location = new System.Drawing.Point(23, 253);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(161, 22);
            this.lblRol.TabIndex = 11;
            this.lblRol.Text = "Detalle De Usuario";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(10, 211);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(190, 29);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre Usuario";
            // 
            // pnlApp
            // 
            this.pnlApp.AutoScroll = true;
            this.pnlApp.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlApp.Location = new System.Drawing.Point(200, 53);
            this.pnlApp.Name = "pnlApp";
            this.pnlApp.Size = new System.Drawing.Size(1175, 1002);
            this.pnlApp.TabIndex = 16;
            this.pnlApp.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 1055);
            this.Controls.Add(this.pnlApp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlApp;
        private System.Windows.Forms.PictureBox PicFoto;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnGeneros;
        private System.Windows.Forms.Button btnGestionPrestamosLibros;
        private System.Windows.Forms.Button btnCaategorias;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnGestionEditorial;
        private System.Windows.Forms.Button btnGestionLibros;
        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.Button btnGestionUsuarios;
        private System.Windows.Forms.Button BtnAbandonar;
        private System.Windows.Forms.Button btnDePrestamo;
    }
}