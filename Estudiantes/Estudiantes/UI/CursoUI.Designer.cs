namespace Estudiantes.UI
{
    partial class CursoUI
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
            txtId = new TextBox();
            txtNombre = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            dgCursos = new DataGridView();
            pictureBox1 = new PictureBox();
            picBuscar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgCursos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBuscar).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(68, 96);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Id";
            txtId.Size = new Size(312, 23);
            txtId.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(68, 176);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(311, 23);
            txtNombre.TabIndex = 2;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Green;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Popup;
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(68, 233);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Padding = new Padding(14, 0, 0, 0);
            btnNuevo.Size = new Size(118, 36);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Green;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(197, 233);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(14, 0, 0, 0);
            btnGuardar.Size = new Size(118, 36);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Green;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(326, 233);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Padding = new Padding(14, 0, 0, 0);
            btnActualizar.Size = new Size(118, 36);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Location = new Point(455, 233);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Padding = new Padding(14, 0, 0, 0);
            btnEliminar.Size = new Size(118, 36);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgCursos
            // 
            dgCursos.AllowUserToAddRows = false;
            dgCursos.AllowUserToDeleteRows = false;
            dgCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCursos.Location = new Point(68, 275);
            dgCursos.Name = "dgCursos";
            dgCursos.ReadOnly = true;
            dgCursos.Size = new Size(648, 142);
            dgCursos.TabIndex = 6;
            dgCursos.CellContentClick += dgCursos_CellDoubleClick;
            dgCursos.CellDoubleClick += dgCursos_CellDoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(508, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 171);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // picBuscar
            // 
            picBuscar.Image = Properties.Resources.buscar;
            picBuscar.Location = new Point(386, 96);
            picBuscar.Name = "picBuscar";
            picBuscar.Size = new Size(28, 23);
            picBuscar.SizeMode = PictureBoxSizeMode.Zoom;
            picBuscar.TabIndex = 8;
            picBuscar.TabStop = false;
            picBuscar.Click += picBuscar_Click;
            // 
            // CursoUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(picBuscar);
            Controls.Add(pictureBox1);
            Controls.Add(dgCursos);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Name = "CursoUI";
            Text = "CursoUI";
            Load += CursoUI_Load;
            ((System.ComponentModel.ISupportInitialize)dgCursos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBuscar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtNombre;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnEliminar;
        private DataGridView dgCursos;
        private PictureBox pictureBox1;
        private PictureBox picBuscar;
    }
}