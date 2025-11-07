namespace Estudiantes.UI
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
            pnlMenu = new Panel();
            btnConsultas = new Button();
            btnCursos = new Button();
            btnEstudiantes = new Button();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            pnlTitulo = new Panel();
            lblClose = new Label();
            lblTitullo = new Label();
            pnlApp = new Panel();
            pnlMenu.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(128, 255, 128);
            pnlMenu.Controls.Add(btnConsultas);
            pnlMenu.Controls.Add(btnCursos);
            pnlMenu.Controls.Add(btnEstudiantes);
            pnlMenu.Controls.Add(panel4);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(172, 550);
            pnlMenu.TabIndex = 0;
            // 
            // btnConsultas
            // 
            btnConsultas.BackColor = Color.Green;
            btnConsultas.Dock = DockStyle.Bottom;
            btnConsultas.FlatAppearance.BorderSize = 0;
            btnConsultas.FlatStyle = FlatStyle.Flat;
            btnConsultas.ForeColor = Color.White;
            btnConsultas.Location = new Point(0, 498);
            btnConsultas.Name = "btnConsultas";
            btnConsultas.Size = new Size(172, 52);
            btnConsultas.TabIndex = 2;
            btnConsultas.Text = "Consultas";
            btnConsultas.UseVisualStyleBackColor = false;
            btnConsultas.Click += btnConsultas_Click;
            // 
            // btnCursos
            // 
            btnCursos.BackColor = Color.Green;
            btnCursos.Dock = DockStyle.Top;
            btnCursos.FlatAppearance.BorderSize = 0;
            btnCursos.FlatStyle = FlatStyle.Flat;
            btnCursos.ForeColor = Color.White;
            btnCursos.Location = new Point(0, 162);
            btnCursos.Name = "btnCursos";
            btnCursos.Size = new Size(172, 52);
            btnCursos.TabIndex = 1;
            btnCursos.Text = "Gestion deCursos";
            btnCursos.UseVisualStyleBackColor = false;
            btnCursos.Click += btnCursos_Click;
            // 
            // btnEstudiantes
            // 
            btnEstudiantes.BackColor = Color.Green;
            btnEstudiantes.Dock = DockStyle.Top;
            btnEstudiantes.FlatAppearance.BorderSize = 0;
            btnEstudiantes.FlatStyle = FlatStyle.Flat;
            btnEstudiantes.ForeColor = Color.White;
            btnEstudiantes.Location = new Point(0, 110);
            btnEstudiantes.Name = "btnEstudiantes";
            btnEstudiantes.Size = new Size(172, 52);
            btnEstudiantes.TabIndex = 0;
            btnEstudiantes.Text = " Gestion de Estudiantes";
            btnEstudiantes.UseVisualStyleBackColor = false;
            btnEstudiantes.Click += btnEstudiantes_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(172, 110);
            panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(128, 255, 128);
            pnlTitulo.Controls.Add(lblClose);
            pnlTitulo.Controls.Add(lblTitullo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(172, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1076, 57);
            pnlTitulo.TabIndex = 1;
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.Dock = DockStyle.Right;
            lblClose.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClose.Location = new Point(1029, 0);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(47, 54);
            lblClose.TabIndex = 1;
            lblClose.Text = "X";
            lblClose.Click += lblClose_Click;
            // 
            // lblTitullo
            // 
            lblTitullo.AutoSize = true;
            lblTitullo.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitullo.ForeColor = Color.Black;
            lblTitullo.Location = new Point(291, 9);
            lblTitullo.Name = "lblTitullo";
            lblTitullo.Size = new Size(91, 38);
            lblTitullo.TabIndex = 0;
            lblTitullo.Text = "label2";
            // 
            // pnlApp
            // 
            pnlApp.BackColor = Color.FromArgb(128, 255, 128);
            pnlApp.Dock = DockStyle.Fill;
            pnlApp.Location = new Point(172, 57);
            pnlApp.Name = "pnlApp";
            pnlApp.Size = new Size(1076, 493);
            pnlApp.TabIndex = 2;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 550);
            Controls.Add(pnlApp);
            Controls.Add(pnlTitulo);
            Controls.Add(pnlMenu);
            Name = "FrmMenu";
            Text = "FrmMenu";
            Load += FrmMenu_Load;
            pnlMenu.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Button btnConsultas;
        private Button btnCursos;
        private Button btnEstudiantes;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Panel pnlTitulo;
        private Panel pnlApp;
        private Label lblClose;
        private Label lblTitullo;
    }
}