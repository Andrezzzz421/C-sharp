namespace Ejercicio3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConvertir = new Button();
            txtCentimetros = new TextBox();
            txtMetros = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(348, 198);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(106, 49);
            btnConvertir.TabIndex = 0;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // txtCentimetros
            // 
            txtCentimetros.Location = new Point(291, 134);
            txtCentimetros.Name = "txtCentimetros";
            txtCentimetros.Size = new Size(213, 23);
            txtCentimetros.TabIndex = 1;
            // 
            // txtMetros
            // 
            txtMetros.Location = new Point(291, 303);
            txtMetros.Name = "txtMetros";
            txtMetros.Size = new Size(213, 23);
            txtMetros.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 107);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 3;
            label1.Text = "Centimetros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 272);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 4;
            label2.Text = "Metros";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(291, 44);
            label3.Name = "label3";
            label3.Size = new Size(213, 30);
            label3.TabIndex = 5;
            label3.Text = "Centimetros a Metros";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMetros);
            Controls.Add(txtCentimetros);
            Controls.Add(btnConvertir);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvertir;
        private TextBox txtCentimetros;
        private TextBox txtMetros;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
