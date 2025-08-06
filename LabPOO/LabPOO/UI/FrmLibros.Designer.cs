namespace LabPOO.UI
{
    partial class FrmLibros
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
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            txtId = new TextBox();
            txtTitulo = new TextBox();
            cbxGenero = new ComboBox();
            txtAniodePublicacion = new TextBox();
            txtSinopsis = new TextBox();
            txtEditorial = new TextBox();
            txtAutor = new TextBox();
            picBusc = new PictureBox();
            picPortada = new PictureBox();
            picBorrarImagen = new PictureBox();
            picBuscarImagen = new PictureBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            grdInformacion = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            openFileDialog1 = new OpenFileDialog();
            lblLibrosRegistrados = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBusc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPortada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBorrarImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBuscarImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdInformacion).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(66, 130, 179);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 61);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 41, 15);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(735, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(64, 61);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 9);
            label1.Name = "label1";
            label1.Size = new Size(34, 40);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(38, 86);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "ID";
            txtId.Size = new Size(245, 23);
            txtId.TabIndex = 1;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(38, 115);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PlaceholderText = "Titulo";
            txtTitulo.Size = new Size(245, 23);
            txtTitulo.TabIndex = 2;
            // 
            // cbxGenero
            // 
            cbxGenero.FormattingEnabled = true;
            cbxGenero.Items.AddRange(new object[] { "Infantil", "Aventura", "Ciencia Ficcion", "paranormal", "Novela" });
            cbxGenero.Location = new Point(37, 144);
            cbxGenero.Name = "cbxGenero";
            cbxGenero.Size = new Size(246, 23);
            cbxGenero.TabIndex = 4;
            // 
            // txtAniodePublicacion
            // 
            txtAniodePublicacion.Location = new Point(39, 173);
            txtAniodePublicacion.Name = "txtAniodePublicacion";
            txtAniodePublicacion.PlaceholderText = "Año de publicacion";
            txtAniodePublicacion.Size = new Size(244, 23);
            txtAniodePublicacion.TabIndex = 4;
            // 
            // txtSinopsis
            // 
            txtSinopsis.Location = new Point(39, 213);
            txtSinopsis.Multiline = true;
            txtSinopsis.Name = "txtSinopsis";
            txtSinopsis.PlaceholderText = "Sinopsis";
            txtSinopsis.ScrollBars = ScrollBars.Both;
            txtSinopsis.Size = new Size(494, 99);
            txtSinopsis.TabIndex = 7;
            txtSinopsis.TextChanged += txtSinopsis_TextChanged;
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(289, 144);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.PlaceholderText = "Editorial";
            txtEditorial.Size = new Size(244, 23);
            txtEditorial.TabIndex = 6;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(289, 115);
            txtAutor.Name = "txtAutor";
            txtAutor.PlaceholderText = "Autor";
            txtAutor.Size = new Size(244, 23);
            txtAutor.TabIndex = 5;
            // 
            // picBusc
            // 
            picBusc.Image = Properties.Resources.ss;
            picBusc.Location = new Point(289, 86);
            picBusc.Name = "picBusc";
            picBusc.Size = new Size(31, 32);
            picBusc.TabIndex = 9;
            picBusc.TabStop = false;
            picBusc.Click += picBusc_Click;
            // 
            // picPortada
            // 
            picPortada.Location = new Point(586, 67);
            picPortada.Name = "picPortada";
            picPortada.Size = new Size(202, 245);
            picPortada.SizeMode = PictureBoxSizeMode.Zoom;
            picPortada.TabIndex = 11;
            picPortada.TabStop = false;
            // 
            // picBorrarImagen
            // 
            picBorrarImagen.Image = Properties.Resources.delete;
            picBorrarImagen.Location = new Point(720, 281);
            picBorrarImagen.Name = "picBorrarImagen";
            picBorrarImagen.Size = new Size(33, 31);
            picBorrarImagen.TabIndex = 12;
            picBorrarImagen.TabStop = false;
            picBorrarImagen.Click += picBorrarImagen_Click;
            // 
            // picBuscarImagen
            // 
            picBuscarImagen.Image = Properties.Resources.ss;
            picBuscarImagen.Location = new Point(681, 281);
            picBuscarImagen.Name = "picBuscarImagen";
            picBuscarImagen.Size = new Size(33, 32);
            picBuscarImagen.TabIndex = 13;
            picBuscarImagen.TabStop = false;
            picBuscarImagen.Click += picBuscarImagen_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.SteelBlue;
            btnNuevo.FlatStyle = FlatStyle.Popup;
            btnNuevo.Location = new Point(41, 318);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(118, 39);
            btnNuevo.TabIndex = 14;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Location = new Point(165, 318);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 39);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.SteelBlue;
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Location = new Point(291, 318);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(118, 39);
            btnActualizar.TabIndex = 16;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.BackgroundImageLayout = ImageLayout.None;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(415, 318);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(118, 39);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // grdInformacion
            // 
            grdInformacion.AllowUserToAddRows = false;
            grdInformacion.AllowUserToDeleteRows = false;
            grdInformacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdInformacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdInformacion.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            grdInformacion.Location = new Point(37, 408);
            grdInformacion.MultiSelect = false;
            grdInformacion.Name = "grdInformacion";
            grdInformacion.ReadOnly = true;
            grdInformacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdInformacion.Size = new Size(739, 142);
            grdInformacion.TabIndex = 18;
            grdInformacion.CellContentDoubleClick += grdInformacion_CellContentClick;
            grdInformacion.CellDoubleClick += grdInformacion_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Titulo";
            Column2.HeaderText = "Nombre";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Genero";
            Column3.HeaderText = "Genero";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Autor";
            Column4.HeaderText = "Autor";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblLibrosRegistrados
            // 
            lblLibrosRegistrados.AutoSize = true;
            lblLibrosRegistrados.ForeColor = SystemColors.AppWorkspace;
            lblLibrosRegistrados.Location = new Point(37, 380);
            lblLibrosRegistrados.Name = "lblLibrosRegistrados";
            lblLibrosRegistrados.Size = new Size(103, 15);
            lblLibrosRegistrados.TabIndex = 19;
            lblLibrosRegistrados.Text = "Libros Registrados";
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(lblLibrosRegistrados);
            Controls.Add(grdInformacion);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(picBuscarImagen);
            Controls.Add(picBorrarImagen);
            Controls.Add(picBusc);
            Controls.Add(txtAutor);
            Controls.Add(txtEditorial);
            Controls.Add(txtSinopsis);
            Controls.Add(txtAniodePublicacion);
            Controls.Add(cbxGenero);
            Controls.Add(txtTitulo);
            Controls.Add(txtId);
            Controls.Add(panel1);
            Controls.Add(picPortada);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLibros";
            Text = "FrmLibros";
            Load += FrmLibros_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBusc).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPortada).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBorrarImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBuscarImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdInformacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox txtId;
        private TextBox txtTitulo;
        private ComboBox cbxGenero;
        private TextBox txtAniodePublicacion;
        private TextBox txtSinopsis;
        private TextBox txtEditorial;
        private TextBox txtAutor;
        private PictureBox picBusc;
        private PictureBox picPortada;
        private PictureBox picBorrarImagen;
        private PictureBox picBuscarImagen;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnEliminar;
        private OpenFileDialog openFileDialog1;
        private Label lblLibrosRegistrados;
        private DataGridView grdInformacion;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}