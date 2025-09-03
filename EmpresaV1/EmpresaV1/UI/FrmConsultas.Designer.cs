namespace EmpresaV1.UI
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
            this.dgConsultas = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbFiltroNombre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarContenerNom = new System.Windows.Forms.Button();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiltroGenero = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnBuscarGenero = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarCargo = new System.Windows.Forms.Button();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.cmbFiltroSalario = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtFiltroSalario = new System.Windows.Forms.TextBox();
            this.btnBuscarSalario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultas)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgConsultas
            // 
            this.dgConsultas.BackgroundColor = System.Drawing.Color.White;
            this.dgConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsultas.Location = new System.Drawing.Point(57, 329);
            this.dgConsultas.Name = "dgConsultas";
            this.dgConsultas.Size = new System.Drawing.Size(749, 150);
            this.dgConsultas.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(135, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 271);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBuscarContenerNom);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmbFiltroNombre);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NombreEmpleado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBuscarGenero);
            this.tabPage2.Controls.Add(this.txtFiltroGenero);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cmbGenero);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Genero";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cmbCargo);
            this.tabPage3.Controls.Add(this.btnBuscarCargo);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(592, 245);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "NombreCargo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnBuscarSalario);
            this.tabPage4.Controls.Add(this.txtFiltroSalario);
            this.tabPage4.Controls.Add(this.lblSalario);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.cmbFiltroSalario);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(592, 245);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Salario";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(35, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // cmbFiltroNombre
            // 
            this.cmbFiltroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroNombre.FormattingEnabled = true;
            this.cmbFiltroNombre.Items.AddRange(new object[] {
            "Inicia",
            "Termina",
            "Contiene"});
            this.cmbFiltroNombre.Location = new System.Drawing.Point(35, 118);
            this.cmbFiltroNombre.Name = "cmbFiltroNombre";
            this.cmbFiltroNombre.Size = new System.Drawing.Size(150, 24);
            this.cmbFiltroNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filtro";
            // 
            // btnBuscarContenerNom
            // 
            this.btnBuscarContenerNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBuscarContenerNom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarContenerNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarContenerNom.ForeColor = System.Drawing.Color.White;
            this.btnBuscarContenerNom.Location = new System.Drawing.Point(260, 70);
            this.btnBuscarContenerNom.Name = "btnBuscarContenerNom";
            this.btnBuscarContenerNom.Size = new System.Drawing.Size(127, 45);
            this.btnBuscarContenerNom.TabIndex = 4;
            this.btnBuscarContenerNom.Text = "Buscar";
            this.btnBuscarContenerNom.UseVisualStyleBackColor = false;
            this.btnBuscarContenerNom.Click += new System.EventHandler(this.btnBuscarContenerNom_Click);
            // 
            // cmbGenero
            // 
            this.cmbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.cmbGenero.Location = new System.Drawing.Point(197, 56);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(204, 24);
            this.cmbGenero.TabIndex = 0;
            this.cmbGenero.SelectedIndexChanged += new System.EventHandler(this.cmbGenero_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Genero";
            // 
            // txtFiltroGenero
            // 
            this.txtFiltroGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroGenero.Location = new System.Drawing.Point(197, 117);
            this.txtFiltroGenero.Name = "txtFiltroGenero";
            this.txtFiltroGenero.Size = new System.Drawing.Size(204, 22);
            this.txtFiltroGenero.TabIndex = 2;
            this.txtFiltroGenero.Visible = false;
            // 
            // btnBuscarGenero
            // 
            this.btnBuscarGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBuscarGenero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarGenero.ForeColor = System.Drawing.Color.White;
            this.btnBuscarGenero.Location = new System.Drawing.Point(234, 161);
            this.btnBuscarGenero.Name = "btnBuscarGenero";
            this.btnBuscarGenero.Size = new System.Drawing.Size(127, 45);
            this.btnBuscarGenero.TabIndex = 5;
            this.btnBuscarGenero.Text = "Buscar";
            this.btnBuscarGenero.UseVisualStyleBackColor = false;
            this.btnBuscarGenero.Click += new System.EventHandler(this.btnBuscarGenero_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre del Cargo";
            // 
            // btnBuscarCargo
            // 
            this.btnBuscarCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBuscarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCargo.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCargo.Location = new System.Drawing.Point(226, 118);
            this.btnBuscarCargo.Name = "btnBuscarCargo";
            this.btnBuscarCargo.Size = new System.Drawing.Size(127, 45);
            this.btnBuscarCargo.TabIndex = 6;
            this.btnBuscarCargo.Text = "Buscar";
            this.btnBuscarCargo.UseVisualStyleBackColor = false;
            this.btnBuscarCargo.Click += new System.EventHandler(this.btnBuscarCargo_Click);
            // 
            // cmbCargo
            // 
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(201, 54);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(175, 21);
            this.cmbCargo.TabIndex = 7;
            // 
            // cmbFiltroSalario
            // 
            this.cmbFiltroSalario.FormattingEnabled = true;
            this.cmbFiltroSalario.Items.AddRange(new object[] {
            "Mayor",
            "Menor",
            "Igual"});
            this.cmbFiltroSalario.Location = new System.Drawing.Point(192, 36);
            this.cmbFiltroSalario.Name = "cmbFiltroSalario";
            this.cmbFiltroSalario.Size = new System.Drawing.Size(176, 21);
            this.cmbFiltroSalario.TabIndex = 0;
            this.cmbFiltroSalario.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroSalario_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(238, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Filtro Salario";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(247, 76);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(50, 16);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salario";
            this.lblSalario.Visible = false;
            // 
            // txtFiltroSalario
            // 
            this.txtFiltroSalario.Location = new System.Drawing.Point(192, 95);
            this.txtFiltroSalario.Name = "txtFiltroSalario";
            this.txtFiltroSalario.Size = new System.Drawing.Size(176, 20);
            this.txtFiltroSalario.TabIndex = 3;
            this.txtFiltroSalario.Visible = false;
            // 
            // btnBuscarSalario
            // 
            this.btnBuscarSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBuscarSalario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarSalario.ForeColor = System.Drawing.Color.White;
            this.btnBuscarSalario.Location = new System.Drawing.Point(218, 147);
            this.btnBuscarSalario.Name = "btnBuscarSalario";
            this.btnBuscarSalario.Size = new System.Drawing.Size(127, 45);
            this.btnBuscarSalario.TabIndex = 7;
            this.btnBuscarSalario.Text = "Buscar";
            this.btnBuscarSalario.UseVisualStyleBackColor = false;
            this.btnBuscarSalario.Click += new System.EventHandler(this.btnBuscarSalario_Click);
            // 
            // FrmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 502);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgConsultas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultas";
            this.Text = "FrmConsultas";
            this.Load += new System.EventHandler(this.FrmConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultas)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgConsultas;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFiltroNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscarContenerNom;
        private System.Windows.Forms.Button btnBuscarGenero;
        private System.Windows.Forms.TextBox txtFiltroGenero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnBuscarCargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Button btnBuscarSalario;
        private System.Windows.Forms.TextBox txtFiltroSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFiltroSalario;
    }
}