namespace Productos.UI
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
            this.tb = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscarPrecioM = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnPrecioCompra = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFiltroCompra = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnBuscarCategoria = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCG = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnBuscarDis = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDisponible = new System.Windows.Forms.ComboBox();
            this.dgConsultas = new System.Windows.Forms.DataGridView();
            this.tb.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.Controls.Add(this.tabPage1);
            this.tb.Controls.Add(this.tabPage2);
            this.tb.Controls.Add(this.tabPage3);
            this.tb.Controls.Add(this.tabPage4);
            this.tb.Controls.Add(this.tabPage5);
            this.tb.Location = new System.Drawing.Point(174, 23);
            this.tb.Name = "tb";
            this.tb.SelectedIndex = 0;
            this.tb.Size = new System.Drawing.Size(435, 242);
            this.tb.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(427, 216);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nombre Contenga";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Location = new System.Drawing.Point(150, 96);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(111, 41);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Producto";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(113, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(186, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblPrecio);
            this.tabPage2.Controls.Add(this.txtFiltro);
            this.tabPage2.Controls.Add(this.btnBuscarPrecioM);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cmbFiltro);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(427, 216);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Precio Venta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(220, 28);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(117, 20);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Digite un Valor ";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(220, 51);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(172, 26);
            this.txtFiltro.TabIndex = 3;
            // 
            // btnBuscarPrecioM
            // 
            this.btnBuscarPrecioM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnBuscarPrecioM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarPrecioM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPrecioM.Location = new System.Drawing.Point(141, 135);
            this.btnBuscarPrecioM.Name = "btnBuscarPrecioM";
            this.btnBuscarPrecioM.Size = new System.Drawing.Size(94, 41);
            this.btnBuscarPrecioM.TabIndex = 2;
            this.btnBuscarPrecioM.Text = "buscar";
            this.btnBuscarPrecioM.UseVisualStyleBackColor = false;
            this.btnBuscarPrecioM.Click += new System.EventHandler(this.btnBuscarPrecioM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Escoja una opcion";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Mayor",
            "Menor",
            "Igual"});
            this.cmbFiltro.Location = new System.Drawing.Point(28, 51);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(172, 21);
            this.cmbFiltro.TabIndex = 0;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txtValor);
            this.tabPage3.Controls.Add(this.btnPrecioCompra);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.cmbFiltroCompra);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(427, 216);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Precio Compra";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(223, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Digite un Valor ";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(223, 53);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(172, 26);
            this.txtValor.TabIndex = 8;
            // 
            // btnPrecioCompra
            // 
            this.btnPrecioCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnPrecioCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecioCompra.Location = new System.Drawing.Point(169, 146);
            this.btnPrecioCompra.Name = "btnPrecioCompra";
            this.btnPrecioCompra.Size = new System.Drawing.Size(94, 41);
            this.btnPrecioCompra.TabIndex = 7;
            this.btnPrecioCompra.Text = "buscar";
            this.btnPrecioCompra.UseVisualStyleBackColor = false;
            this.btnPrecioCompra.Click += new System.EventHandler(this.btnPrecioCompra_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Escoja una opcion";
            // 
            // cmbFiltroCompra
            // 
            this.cmbFiltroCompra.FormattingEnabled = true;
            this.cmbFiltroCompra.Items.AddRange(new object[] {
            "Mayor",
            "Menor",
            "Igual"});
            this.cmbFiltroCompra.Location = new System.Drawing.Point(31, 53);
            this.cmbFiltroCompra.Name = "cmbFiltroCompra";
            this.cmbFiltroCompra.Size = new System.Drawing.Size(172, 21);
            this.cmbFiltroCompra.TabIndex = 5;
            this.cmbFiltroCompra.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroCompra_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnBuscarCategoria);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.cmbCG);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(427, 216);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Nombre Categoria";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnBuscarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCategoria.Location = new System.Drawing.Point(151, 104);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Size = new System.Drawing.Size(94, 41);
            this.btnBuscarCategoria.TabIndex = 3;
            this.btnBuscarCategoria.Text = "buscar";
            this.btnBuscarCategoria.UseVisualStyleBackColor = false;
            this.btnBuscarCategoria.Click += new System.EventHandler(this.btnBuscarCategoria_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Seleccione una categoria";
            // 
            // cmbCG
            // 
            this.cmbCG.FormattingEnabled = true;
            this.cmbCG.Location = new System.Drawing.Point(118, 38);
            this.cmbCG.Name = "cmbCG";
            this.cmbCG.Size = new System.Drawing.Size(177, 21);
            this.cmbCG.TabIndex = 0;
            this.cmbCG.SelectedIndexChanged += new System.EventHandler(this.cmbCG_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnBuscarDis);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.cmbDisponible);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(427, 216);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Disponibilidad";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnBuscarDis
            // 
            this.btnBuscarDis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnBuscarDis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDis.Location = new System.Drawing.Point(162, 105);
            this.btnBuscarDis.Name = "btnBuscarDis";
            this.btnBuscarDis.Size = new System.Drawing.Size(94, 41);
            this.btnBuscarDis.TabIndex = 4;
            this.btnBuscarDis.Text = "buscar";
            this.btnBuscarDis.UseVisualStyleBackColor = false;
            this.btnBuscarDis.Click += new System.EventHandler(this.btnBuscarDis_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(132, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Escoja la disponibilidad";
            // 
            // cmbDisponible
            // 
            this.cmbDisponible.FormattingEnabled = true;
            this.cmbDisponible.Items.AddRange(new object[] {
            "Todos",
            "Disponible",
            "No Disponible"});
            this.cmbDisponible.Location = new System.Drawing.Point(123, 60);
            this.cmbDisponible.Name = "cmbDisponible";
            this.cmbDisponible.Size = new System.Drawing.Size(177, 21);
            this.cmbDisponible.TabIndex = 1;
            this.cmbDisponible.SelectedIndexChanged += new System.EventHandler(this.cmbDisponible_SelectedIndexChanged);
            // 
            // dgConsultas
            // 
            this.dgConsultas.AllowUserToAddRows = false;
            this.dgConsultas.AllowUserToDeleteRows = false;
            this.dgConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgConsultas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsultas.Location = new System.Drawing.Point(62, 278);
            this.dgConsultas.Name = "dgConsultas";
            this.dgConsultas.ReadOnly = true;
            this.dgConsultas.Size = new System.Drawing.Size(678, 160);
            this.dgConsultas.TabIndex = 1;
            this.dgConsultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgConsultas_CellContentClick);
            // 
            // FrmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgConsultas);
            this.Controls.Add(this.tb);
            this.Name = "FrmConsultas";
            this.Text = "FrmConsultas";
            this.Load += new System.EventHandler(this.FrmConsultas_Load);
            this.tb.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tb;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgConsultas;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Button btnBuscarPrecioM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBuscarCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnPrecioCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFiltroCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDisponible;
        private System.Windows.Forms.Button btnBuscarDis;
    }
}