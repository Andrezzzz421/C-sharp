namespace BibliotecaLosSayayines.UI
{
    partial class FrmDetPrestamo
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
            this.DgDtPrestamo = new System.Windows.Forms.DataGridView();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.cbxPrestamo = new System.Windows.Forms.ComboBox();
            this.cbxLibro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgDtPrestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.DgDtPrestamo);
            this.panel2.Location = new System.Drawing.Point(151, 313);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 206);
            this.panel2.TabIndex = 106;
            // 
            // DgDtPrestamo
            // 
            this.DgDtPrestamo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgDtPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDtPrestamo.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgDtPrestamo.Location = new System.Drawing.Point(2, 6);
            this.DgDtPrestamo.Margin = new System.Windows.Forms.Padding(2);
            this.DgDtPrestamo.Name = "DgDtPrestamo";
            this.DgDtPrestamo.RowHeadersWidth = 51;
            this.DgDtPrestamo.RowTemplate.Height = 24;
            this.DgDtPrestamo.Size = new System.Drawing.Size(520, 198);
            this.DgDtPrestamo.TabIndex = 23;
            this.DgDtPrestamo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgDtPrestamo_CellContentDoubleClick);
            this.DgDtPrestamo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgDtPrestamo_CellContentDoubleClick);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGuardar.Location = new System.Drawing.Point(351, 261);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(113, 31);
            this.BtnGuardar.TabIndex = 102;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(225, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 101;
            this.label5.Text = "Fecha Devolucion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 99;
            this.label3.Text = "Id Prestamo";
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Image = global::BibliotecaLosSayayines.Properties.Resources.boton;
            this.BtnSalir.Location = new System.Drawing.Point(693, 10);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(80, 35);
            this.BtnSalir.TabIndex = 109;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // cbxPrestamo
            // 
            this.cbxPrestamo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbxPrestamo.FormattingEnabled = true;
            this.cbxPrestamo.Location = new System.Drawing.Point(228, 148);
            this.cbxPrestamo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxPrestamo.Name = "cbxPrestamo";
            this.cbxPrestamo.Size = new System.Drawing.Size(157, 21);
            this.cbxPrestamo.TabIndex = 112;
            this.cbxPrestamo.SelectedIndexChanged += new System.EventHandler(this.cbxPrestamo_SelectedIndexChanged);
            // 
            // cbxLibro
            // 
            this.cbxLibro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbxLibro.FormattingEnabled = true;
            this.cbxLibro.Location = new System.Drawing.Point(446, 96);
            this.cbxLibro.Margin = new System.Windows.Forms.Padding(2);
            this.cbxLibro.Name = "cbxLibro";
            this.cbxLibro.Size = new System.Drawing.Size(157, 21);
            this.cbxLibro.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(443, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 114;
            this.label2.Text = "Libro";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(225, 73);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(21, 20);
            this.lbl.TabIndex = 97;
            this.lbl.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(228, 96);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(163, 20);
            this.txtId.TabIndex = 113;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevo.Location = new System.Drawing.Point(229, 261);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(113, 31);
            this.btnNuevo.TabIndex = 116;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Location = new System.Drawing.Point(348, 217);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(35, 13);
            this.lblFechaEntrega.TabIndex = 117;
            this.lblFechaEntrega.Text = "label4";
            // 
            // FrmDetPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(782, 563);
            this.Controls.Add(this.lblFechaEntrega);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.cbxLibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cbxPrestamo);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDetPrestamo";
            this.Text = "FrmDetPrestamo";
            this.Load += new System.EventHandler(this.FrmDetPrestamo_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgDtPrestamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgDtPrestamo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.ComboBox cbxPrestamo;
        private System.Windows.Forms.ComboBox cbxLibro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblFechaEntrega;
    }
}