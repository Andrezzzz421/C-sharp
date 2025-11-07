namespace Estudiantes.UI
{
    partial class EstudianteUI
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
            txtDocumento = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            cbmTpSanguineo = new ComboBox();
            label1 = new Label();
            txtPeso = new TextBox();
            txtEstatura = new TextBox();
            txtCorreo = new TextBox();
            cbmCurso = new ComboBox();
            label2 = new Label();
            chcMinoria = new CheckBox();
            btnGuardar = new Button();
            btnNuevo = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            picImage = new PictureBox();
            picDeleteImage = new PictureBox();
            picSearchImage = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            picSearchAt = new PictureBox();
            dgEstudiantes = new DataGridView();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDeleteImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSearchImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSearchAt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Segoe UI", 9.75F);
            txtDocumento.Location = new Point(304, 39);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.PlaceholderText = "Documento";
            txtDocumento.Size = new Size(222, 25);
            txtDocumento.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9.75F);
            txtNombre.Location = new Point(564, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(222, 25);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 9.75F);
            txtApellido.Location = new Point(44, 102);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(222, 25);
            txtApellido.TabIndex = 2;
            // 
            // cbmTpSanguineo
            // 
            cbmTpSanguineo.Font = new Font("Segoe UI", 9.75F);
            cbmTpSanguineo.FormattingEnabled = true;
            cbmTpSanguineo.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            cbmTpSanguineo.Location = new Point(564, 167);
            cbmTpSanguineo.Name = "cbmTpSanguineo";
            cbmTpSanguineo.Size = new Size(222, 25);
            cbmTpSanguineo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(564, 147);
            label1.Name = "label1";
            label1.Size = new Size(99, 17);
            label1.TabIndex = 4;
            label1.Text = "Tipo Sanguineo";
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Segoe UI", 9.75F);
            txtPeso.Location = new Point(44, 167);
            txtPeso.Name = "txtPeso";
            txtPeso.PlaceholderText = "Peso";
            txtPeso.Size = new Size(222, 25);
            txtPeso.TabIndex = 5;
            // 
            // txtEstatura
            // 
            txtEstatura.Font = new Font("Segoe UI", 9.75F);
            txtEstatura.Location = new Point(564, 102);
            txtEstatura.Name = "txtEstatura";
            txtEstatura.PlaceholderText = "Estatura";
            txtEstatura.Size = new Size(222, 25);
            txtEstatura.TabIndex = 6;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 9.75F);
            txtCorreo.Location = new Point(304, 102);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(222, 25);
            txtCorreo.TabIndex = 7;
            // 
            // cbmCurso
            // 
            cbmCurso.Font = new Font("Segoe UI", 9.75F);
            cbmCurso.FormattingEnabled = true;
            cbmCurso.Location = new Point(308, 167);
            cbmCurso.Name = "cbmCurso";
            cbmCurso.Size = new Size(222, 25);
            cbmCurso.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(308, 147);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 9;
            label2.Text = "Curso";
            // 
            // chcMinoria
            // 
            chcMinoria.AutoSize = true;
            chcMinoria.Font = new Font("Segoe UI", 9.75F);
            chcMinoria.Location = new Point(44, 221);
            chcMinoria.Name = "chcMinoria";
            chcMinoria.Size = new Size(72, 21);
            chcMinoria.TabIndex = 10;
            chcMinoria.Text = "Minoria";
            chcMinoria.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Green;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 9.75F);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = Properties.Resources.Guardar;
            btnGuardar.Location = new Point(196, 264);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(14, 0, 0, 0);
            btnGuardar.Size = new Size(118, 36);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Green;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Popup;
            btnNuevo.Font = new Font("Segoe UI", 9.75F);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Image = Properties.Resources.Nuevo;
            btnNuevo.Location = new Point(44, 264);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Padding = new Padding(14, 0, 0, 0);
            btnNuevo.Size = new Size(118, 36);
            btnNuevo.TabIndex = 12;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Green;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Font = new Font("Segoe UI", 9.75F);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Image = Properties.Resources.Actualizar;
            btnActualizar.Location = new Point(348, 264);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Padding = new Padding(14, 0, 0, 0);
            btnActualizar.Size = new Size(118, 36);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI", 9.75F);
            btnEliminar.Image = Properties.Resources.borrar;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(500, 264);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Padding = new Padding(14, 0, 0, 0);
            btnEliminar.Size = new Size(118, 36);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // picImage
            // 
            picImage.Location = new Point(818, 39);
            picImage.Name = "picImage";
            picImage.Size = new Size(253, 212);
            picImage.TabIndex = 15;
            picImage.TabStop = false;
            // 
            // picDeleteImage
            // 
            picDeleteImage.Image = Properties.Resources.borrar;
            picDeleteImage.Location = new Point(1035, 264);
            picDeleteImage.Name = "picDeleteImage";
            picDeleteImage.Size = new Size(36, 33);
            picDeleteImage.SizeMode = PictureBoxSizeMode.Zoom;
            picDeleteImage.TabIndex = 16;
            picDeleteImage.TabStop = false;
            picDeleteImage.Click += picDeleteImage_Click;
            // 
            // picSearchImage
            // 
            picSearchImage.Image = Properties.Resources.buscar;
            picSearchImage.Location = new Point(993, 264);
            picSearchImage.Name = "picSearchImage";
            picSearchImage.Size = new Size(36, 33);
            picSearchImage.SizeMode = PictureBoxSizeMode.Zoom;
            picSearchImage.TabIndex = 17;
            picSearchImage.TabStop = false;
            picSearchImage.Click += picSearchImage_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // picSearchAt
            // 
            picSearchAt.Image = Properties.Resources.buscar;
            picSearchAt.Location = new Point(5, 39);
            picSearchAt.Name = "picSearchAt";
            picSearchAt.Size = new Size(33, 23);
            picSearchAt.SizeMode = PictureBoxSizeMode.Zoom;
            picSearchAt.TabIndex = 18;
            picSearchAt.TabStop = false;
            picSearchAt.Click += picSearchAt_Click;
            // 
            // dgEstudiantes
            // 
            dgEstudiantes.AllowUserToAddRows = false;
            dgEstudiantes.AllowUserToDeleteRows = false;
            dgEstudiantes.BackgroundColor = Color.White;
            dgEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEstudiantes.Location = new Point(44, 319);
            dgEstudiantes.Name = "dgEstudiantes";
            dgEstudiantes.ReadOnly = true;
            dgEstudiantes.Size = new Size(1027, 165);
            dgEstudiantes.TabIndex = 19;
            dgEstudiantes.CellDoubleClick += dgEstudiantes_CellDoubleClick;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 9.75F);
            txtId.Location = new Point(44, 39);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Id";
            txtId.Size = new Size(222, 25);
            txtId.TabIndex = 20;
            // 
            // EstudianteUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(1110, 496);
            Controls.Add(txtId);
            Controls.Add(dgEstudiantes);
            Controls.Add(picSearchAt);
            Controls.Add(picSearchImage);
            Controls.Add(picDeleteImage);
            Controls.Add(picImage);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnNuevo);
            Controls.Add(btnGuardar);
            Controls.Add(chcMinoria);
            Controls.Add(label2);
            Controls.Add(cbmCurso);
            Controls.Add(txtCorreo);
            Controls.Add(txtEstatura);
            Controls.Add(txtPeso);
            Controls.Add(label1);
            Controls.Add(cbmTpSanguineo);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtDocumento);
            ForeColor = Color.Black;
            Name = "EstudianteUI";
            Text = "EstudianteUI";
            Load += EstudianteUI_Load;
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDeleteImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSearchImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSearchAt).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgEstudiantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDocumento;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private ComboBox cbmTpSanguineo;
        private Label label1;
        private TextBox txtPeso;
        private TextBox txtEstatura;
        private TextBox txtCorreo;
        private ComboBox cbmCurso;
        private Label label2;
        private CheckBox chcMinoria;
        private Button btnGuardar;
        private Button btnNuevo;
        private Button btnActualizar;
        private Button btnEliminar;
        private PictureBox picImage;
        private PictureBox picDeleteImage;
        private PictureBox picSearchImage;
        private OpenFileDialog openFileDialog1;
        private PictureBox picSearchAt;
        private DataGridView dgEstudiantes;
        private TextBox txtId;
    }
}