namespace PotenciaDeUnNumero
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
            btnCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtValor1 = new TextBox();
            txtValo2 = new TextBox();
            txtResultado = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 12F);
            btnCalcular.Location = new Point(334, 264);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 32);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(327, 93);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 1;
            label1.Text = "Primer Numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(326, 179);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 2;
            label2.Text = "Segundo Numero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(144, 25);
            label3.Name = "label3";
            label3.Size = new Size(503, 30);
            label3.TabIndex = 3;
            label3.Text = "eleve un número a la potencia de otro número dado.";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(306, 128);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(168, 23);
            txtValor1.TabIndex = 4;
            // 
            // txtValo2
            // 
            txtValo2.Location = new Point(305, 217);
            txtValo2.Name = "txtValo2";
            txtValo2.Size = new Size(169, 23);
            txtValo2.TabIndex = 5;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(305, 348);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(169, 23);
            txtResultado.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(348, 324);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 7;
            label4.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txtResultado);
            Controls.Add(txtValo2);
            Controls.Add(txtValor1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtValor1;
        private TextBox txtValo2;
        private TextBox txtResultado;
        private Label label4;
    }
}
