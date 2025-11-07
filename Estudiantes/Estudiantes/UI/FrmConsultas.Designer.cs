namespace Estudiantes.UI
{
    partial class FrmConsultas
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
            btnPorPeso = new Button();
            btnPorEstatatura = new Button();
            btnTipoSangre = new Button();
            btnBuscarNombreApellido = new Button();
            panel2 = new Panel();
            btnMenorPeso = new Button();
            btnMayorPeso = new Button();
            btnMayorEstatura = new Button();
            btnMenorEstatura = new Button();
            dgConsultas = new DataGridView();
            txtFiltro = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgConsultas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(btnPorPeso);
            panel1.Controls.Add(btnPorEstatatura);
            panel1.Controls.Add(btnTipoSangre);
            panel1.Controls.Add(btnBuscarNombreApellido);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(804, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(141, 463);
            panel1.TabIndex = 0;
            // 
            // btnPorPeso
            // 
            btnPorPeso.BackColor = Color.Green;
            btnPorPeso.Dock = DockStyle.Top;
            btnPorPeso.FlatAppearance.BorderSize = 0;
            btnPorPeso.FlatStyle = FlatStyle.Popup;
            btnPorPeso.ForeColor = Color.White;
            btnPorPeso.Location = new Point(0, 141);
            btnPorPeso.Name = "btnPorPeso";
            btnPorPeso.Size = new Size(141, 47);
            btnPorPeso.TabIndex = 3;
            btnPorPeso.Text = "Por Peso";
            btnPorPeso.UseVisualStyleBackColor = false;
            btnPorPeso.Click += btnPorPeso_Click;
            // 
            // btnPorEstatatura
            // 
            btnPorEstatatura.BackColor = Color.Green;
            btnPorEstatatura.Dock = DockStyle.Top;
            btnPorEstatatura.FlatAppearance.BorderSize = 0;
            btnPorEstatatura.FlatStyle = FlatStyle.Popup;
            btnPorEstatatura.ForeColor = Color.White;
            btnPorEstatatura.Location = new Point(0, 94);
            btnPorEstatatura.Name = "btnPorEstatatura";
            btnPorEstatatura.Size = new Size(141, 47);
            btnPorEstatatura.TabIndex = 2;
            btnPorEstatatura.Text = "Por Estatura";
            btnPorEstatatura.UseVisualStyleBackColor = false;
            btnPorEstatatura.Click += btnPorEstatatura_Click;
            // 
            // btnTipoSangre
            // 
            btnTipoSangre.BackColor = Color.Green;
            btnTipoSangre.Dock = DockStyle.Top;
            btnTipoSangre.FlatAppearance.BorderSize = 0;
            btnTipoSangre.FlatStyle = FlatStyle.Popup;
            btnTipoSangre.ForeColor = Color.White;
            btnTipoSangre.Location = new Point(0, 47);
            btnTipoSangre.Name = "btnTipoSangre";
            btnTipoSangre.Size = new Size(141, 47);
            btnTipoSangre.TabIndex = 1;
            btnTipoSangre.Text = "Tipo de Sangre";
            btnTipoSangre.UseVisualStyleBackColor = false;
            btnTipoSangre.Click += btnTipoSangre_Click;
            // 
            // btnBuscarNombreApellido
            // 
            btnBuscarNombreApellido.BackColor = Color.Green;
            btnBuscarNombreApellido.Dock = DockStyle.Top;
            btnBuscarNombreApellido.FlatAppearance.BorderSize = 0;
            btnBuscarNombreApellido.FlatStyle = FlatStyle.Popup;
            btnBuscarNombreApellido.ForeColor = Color.White;
            btnBuscarNombreApellido.Location = new Point(0, 0);
            btnBuscarNombreApellido.Name = "btnBuscarNombreApellido";
            btnBuscarNombreApellido.Size = new Size(141, 47);
            btnBuscarNombreApellido.TabIndex = 0;
            btnBuscarNombreApellido.Text = "Por Nombre o Apellido";
            btnBuscarNombreApellido.UseVisualStyleBackColor = false;
            btnBuscarNombreApellido.Click += btnBuscarNombreApellido_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 255, 128);
            panel2.Controls.Add(btnMenorPeso);
            panel2.Controls.Add(btnMayorPeso);
            panel2.Controls.Add(btnMayorEstatura);
            panel2.Controls.Add(btnMenorEstatura);
            panel2.Controls.Add(dgConsultas);
            panel2.Controls.Add(txtFiltro);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(804, 463);
            panel2.TabIndex = 1;
            // 
            // btnMenorPeso
            // 
            btnMenorPeso.BackColor = Color.Green;
            btnMenorPeso.FlatAppearance.BorderSize = 0;
            btnMenorPeso.FlatStyle = FlatStyle.Popup;
            btnMenorPeso.ForeColor = Color.White;
            btnMenorPeso.Location = new Point(631, 94);
            btnMenorPeso.Name = "btnMenorPeso";
            btnMenorPeso.Size = new Size(100, 36);
            btnMenorPeso.TabIndex = 5;
            btnMenorPeso.Text = "Menor";
            btnMenorPeso.UseVisualStyleBackColor = false;
            btnMenorPeso.Click += btnMenorPeso_Click;
            // 
            // btnMayorPeso
            // 
            btnMayorPeso.BackColor = Color.Green;
            btnMayorPeso.FlatAppearance.BorderSize = 0;
            btnMayorPeso.FlatStyle = FlatStyle.Popup;
            btnMayorPeso.ForeColor = Color.White;
            btnMayorPeso.Location = new Point(631, 141);
            btnMayorPeso.Name = "btnMayorPeso";
            btnMayorPeso.Size = new Size(100, 36);
            btnMayorPeso.TabIndex = 4;
            btnMayorPeso.Text = "Mayor";
            btnMayorPeso.UseVisualStyleBackColor = false;
            btnMayorPeso.Click += btnMayorPeso_Click;
            // 
            // btnMayorEstatura
            // 
            btnMayorEstatura.BackColor = Color.Green;
            btnMayorEstatura.FlatAppearance.BorderSize = 0;
            btnMayorEstatura.FlatStyle = FlatStyle.Popup;
            btnMayorEstatura.ForeColor = Color.White;
            btnMayorEstatura.Location = new Point(515, 141);
            btnMayorEstatura.Name = "btnMayorEstatura";
            btnMayorEstatura.Size = new Size(100, 36);
            btnMayorEstatura.TabIndex = 3;
            btnMayorEstatura.Text = "Mayor";
            btnMayorEstatura.UseVisualStyleBackColor = false;
            btnMayorEstatura.Click += btnMayorEstatura_Click;
            // 
            // btnMenorEstatura
            // 
            btnMenorEstatura.BackColor = Color.Green;
            btnMenorEstatura.FlatAppearance.BorderSize = 0;
            btnMenorEstatura.FlatStyle = FlatStyle.Popup;
            btnMenorEstatura.ForeColor = Color.White;
            btnMenorEstatura.Location = new Point(515, 94);
            btnMenorEstatura.Name = "btnMenorEstatura";
            btnMenorEstatura.Size = new Size(100, 36);
            btnMenorEstatura.TabIndex = 2;
            btnMenorEstatura.Text = "Menor";
            btnMenorEstatura.UseVisualStyleBackColor = false;
            btnMenorEstatura.Click += btnMenorEstatura_Click;
            // 
            // dgConsultas
            // 
            dgConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgConsultas.Location = new Point(50, 301);
            dgConsultas.Name = "dgConsultas";
            dgConsultas.Size = new Size(731, 150);
            dgConsultas.TabIndex = 1;
            // 
            // txtFiltro
            // 
            txtFiltro.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFiltro.Location = new Point(304, 116);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.PlaceholderText = "Busquedas";
            txtFiltro.Size = new Size(205, 25);
            txtFiltro.TabIndex = 0;
            // 
            // FrmConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 463);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmConsultas";
            Text = "FrmConsultas";
            Load += FrmConsultas_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgConsultas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnPorPeso;
        private Button btnPorEstatatura;
        private Button btnTipoSangre;
        private Button btnBuscarNombreApellido;
        private Panel panel2;
        private DataGridView dgConsultas;
        private TextBox txtFiltro;
        private Button btnMenorPeso;
        private Button btnMayorPeso;
        private Button btnMayorEstatura;
        private Button btnMenorEstatura;
    }
}