namespace BibliotecaLosSayayines.UI
{
    partial class FrmLibro
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxAutor = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.cbxEditorial = new System.Windows.Forms.ComboBox();
            this.txtAnioPubli = new System.Windows.Forms.TextBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgLibro = new System.Windows.Forms.DataGridView();
            this.picDeleteImage = new System.Windows.Forms.PictureBox();
            this.PicSearchImage = new System.Windows.Forms.PictureBox();
            this.picPortada = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeleteImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSearchImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 318);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = " Titulo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(101, 336);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(242, 22);
            this.txtTitulo.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 380);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Editorial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 277);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Categoria";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Disponible",
            "Prestado",
            "Inactivo",
            "Dañado"});
            this.cbxEstado.Location = new System.Drawing.Point(101, 475);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(242, 21);
            this.cbxEstado.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Location = new System.Drawing.Point(28, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 157);
            this.panel1.TabIndex = 37;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(2, 8);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(236, 143);
            this.txtDesc.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 457);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 339);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Año De Publicacion";
            // 
            // cbxAutor
            // 
            this.cbxAutor.FormattingEnabled = true;
            this.cbxAutor.Location = new System.Drawing.Point(26, 236);
            this.cbxAutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxAutor.Name = "cbxAutor";
            this.cbxAutor.Size = new System.Drawing.Size(243, 21);
            this.cbxAutor.TabIndex = 58;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(26, 297);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(242, 21);
            this.cbxCategoria.TabIndex = 59;
            // 
            // cbxEditorial
            // 
            this.cbxEditorial.FormattingEnabled = true;
            this.cbxEditorial.Location = new System.Drawing.Point(101, 401);
            this.cbxEditorial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxEditorial.Name = "cbxEditorial";
            this.cbxEditorial.Size = new System.Drawing.Size(242, 21);
            this.cbxEditorial.TabIndex = 60;
            // 
            // txtAnioPubli
            // 
            this.txtAnioPubli.Location = new System.Drawing.Point(26, 359);
            this.txtAnioPubli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAnioPubli.Multiline = true;
            this.txtAnioPubli.Name = "txtAnioPubli";
            this.txtAnioPubli.Size = new System.Drawing.Size(243, 22);
            this.txtAnioPubli.TabIndex = 61;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(382, 826);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFiltro.Multiline = true;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(248, 27);
            this.txtFiltro.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(380, 805);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 62;
            this.label8.Text = "Filtro";
            // 
            // btnFiltro
            // 
            this.btnFiltro.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFiltro.Location = new System.Drawing.Point(634, 826);
            this.btnFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(80, 26);
            this.btnFiltro.TabIndex = 64;
            this.btnFiltro.Text = "Buscar";
            this.btnFiltro.UseVisualStyleBackColor = false;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnEliminar);
            this.panel2.Controls.Add(this.BtnNuevo);
            this.panel2.Controls.Add(this.txtAnioPubli);
            this.panel2.Controls.Add(this.BtnActualizar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.BtnGuardar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbxCategoria);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbxAutor);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(424, 39);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 468);
            this.panel2.TabIndex = 67;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEliminar.Location = new System.Drawing.Point(152, 428);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(113, 31);
            this.BtnEliminar.TabIndex = 71;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNuevo.Location = new System.Drawing.Point(26, 392);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(113, 31);
            this.BtnNuevo.TabIndex = 70;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnActualizar.Location = new System.Drawing.Point(26, 428);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(113, 31);
            this.BtnActualizar.TabIndex = 69;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGuardar.Location = new System.Drawing.Point(152, 392);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(113, 31);
            this.BtnGuardar.TabIndex = 68;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.dgLibro);
            this.panel3.Location = new System.Drawing.Point(104, 534);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(611, 236);
            this.panel3.TabIndex = 68;
            // 
            // dgLibro
            // 
            this.dgLibro.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLibro.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgLibro.Location = new System.Drawing.Point(8, 13);
            this.dgLibro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgLibro.Name = "dgLibro";
            this.dgLibro.RowHeadersWidth = 51;
            this.dgLibro.RowTemplate.Height = 24;
            this.dgLibro.Size = new System.Drawing.Size(602, 219);
            this.dgLibro.TabIndex = 23;
            this.dgLibro.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLibro_CellContentDoubleClick);
            // 
            // picDeleteImage
            // 
            this.picDeleteImage.Image = global::BibliotecaLosSayayines.Properties.Resources.borrar__5_;
            this.picDeleteImage.Location = new System.Drawing.Point(221, 136);
            this.picDeleteImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picDeleteImage.Name = "picDeleteImage";
            this.picDeleteImage.Size = new System.Drawing.Size(45, 44);
            this.picDeleteImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDeleteImage.TabIndex = 66;
            this.picDeleteImage.TabStop = false;
            this.picDeleteImage.Click += new System.EventHandler(this.picDeleteImage_Click);
            // 
            // PicSearchImage
            // 
            this.PicSearchImage.Image = global::BibliotecaLosSayayines.Properties.Resources.busqueda;
            this.PicSearchImage.Location = new System.Drawing.Point(221, 87);
            this.PicSearchImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PicSearchImage.Name = "PicSearchImage";
            this.PicSearchImage.Size = new System.Drawing.Size(45, 44);
            this.PicSearchImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicSearchImage.TabIndex = 65;
            this.PicSearchImage.TabStop = false;
            this.PicSearchImage.Click += new System.EventHandler(this.PicSearchImage_Click);
            // 
            // picPortada
            // 
            this.picPortada.Location = new System.Drawing.Point(107, 72);
            this.picPortada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picPortada.Name = "picPortada";
            this.picPortada.Size = new System.Drawing.Size(110, 118);
            this.picPortada.TabIndex = 50;
            this.picPortada.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(107, 47);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 20);
            this.label9.TabIndex = 69;
            this.label9.Text = "Foto";
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Items.AddRange(new object[] {
            "Titulo",
            "Categoria",
            "Autor",
            "Editorial"});
            this.cbxFiltro.Location = new System.Drawing.Point(560, 778);
            this.cbxFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(156, 21);
            this.cbxFiltro.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(100, 258);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 20);
            this.label10.TabIndex = 72;
            this.label10.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(101, 275);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(242, 22);
            this.txtId.TabIndex = 71;
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Image = global::BibliotecaLosSayayines.Properties.Resources.boton;
            this.BtnSalir.Location = new System.Drawing.Point(731, 20);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(80, 35);
            this.BtnSalir.TabIndex = 73;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(831, 640);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cbxFiltro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.picDeleteImage);
            this.Controls.Add(this.PicSearchImage);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxEditorial);
            this.Controls.Add(this.picPortada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmLibro";
            this.Text = "FrmLibro";
            this.Load += new System.EventHandler(this.FrmLibro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeleteImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSearchImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picPortada;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxAutor;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.ComboBox cbxEditorial;
        private System.Windows.Forms.TextBox txtAnioPubli;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.PictureBox PicSearchImage;
        private System.Windows.Forms.PictureBox picDeleteImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgLibro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button BtnSalir;
    }
}