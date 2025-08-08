namespace DataGridView
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picBandera = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBandera = new System.Windows.Forms.TextBox();
            this.BtnCambiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBandera)).BeginInit();
            this.SuspendLayout();
            // 
            // dg1
            // 
            this.dg1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg1.BackgroundColor = System.Drawing.Color.White;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Location = new System.Drawing.Point(39, 255);
            this.dg1.MultiSelect = false;
            this.dg1.Name = "dg1";
            this.dg1.Size = new System.Drawing.Size(515, 142);
            this.dg1.TabIndex = 0;
            this.dg1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg1_CellContentDoubleClick);
            this.dg1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg1_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(96, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(193, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 74);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(193, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(51, 124);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 5;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(51, 160);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(134, 36);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // picBandera
            // 
            this.picBandera.Image = global::DataGridView.Properties.Resources._5832453223e3b;
            this.picBandera.Location = new System.Drawing.Point(363, 34);
            this.picBandera.Name = "picBandera";
            this.picBandera.Size = new System.Drawing.Size(181, 166);
            this.picBandera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBandera.TabIndex = 7;
            this.picBandera.TabStop = false;
            this.picBandera.Click += new System.EventHandler(this.picBandera_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bandera";
            // 
            // txtBandera
            // 
            this.txtBandera.Location = new System.Drawing.Point(363, 207);
            this.txtBandera.Name = "txtBandera";
            this.txtBandera.Size = new System.Drawing.Size(181, 20);
            this.txtBandera.TabIndex = 9;
            this.txtBandera.TextChanged += new System.EventHandler(this.txtBandera_TextChanged);
            // 
            // BtnCambiar
            // 
            this.BtnCambiar.Location = new System.Drawing.Point(273, 207);
            this.BtnCambiar.Name = "BtnCambiar";
            this.BtnCambiar.Size = new System.Drawing.Size(75, 23);
            this.BtnCambiar.TabIndex = 10;
            this.BtnCambiar.Text = "cambiar";
            this.BtnCambiar.UseVisualStyleBackColor = true;
            this.BtnCambiar.Click += new System.EventHandler(this.BtnCambiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.BtnCambiar);
            this.Controls.Add(this.txtBandera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picBandera);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBandera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox picBandera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBandera;
        private System.Windows.Forms.Button BtnCambiar;
    }
}

