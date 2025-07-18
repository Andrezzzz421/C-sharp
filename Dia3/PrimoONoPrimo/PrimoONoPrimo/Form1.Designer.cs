namespace PrimoONoPrimo
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
            btnFor = new Button();
            btnWhile = new Button();
            btnDowhile = new Button();
            label1 = new Label();
            txtNumero = new TextBox();
            label2 = new Label();
            txtResultado = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnFor
            // 
            btnFor.Font = new Font("Segoe UI", 14.25F);
            btnFor.Location = new Point(296, 142);
            btnFor.Name = "btnFor";
            btnFor.Size = new Size(105, 41);
            btnFor.TabIndex = 0;
            btnFor.Text = "For";
            btnFor.UseVisualStyleBackColor = true;
            btnFor.Click += btnFor_Click;
            // 
            // btnWhile
            // 
            btnWhile.Font = new Font("Segoe UI", 14.25F);
            btnWhile.Location = new Point(439, 142);
            btnWhile.Name = "btnWhile";
            btnWhile.Size = new Size(105, 41);
            btnWhile.TabIndex = 1;
            btnWhile.Text = "While";
            btnWhile.UseVisualStyleBackColor = true;
            btnWhile.Click += btnWhile_Click;
            // 
            // btnDowhile
            // 
            btnDowhile.Font = new Font("Segoe UI", 14.25F);
            btnDowhile.Location = new Point(369, 189);
            btnDowhile.Name = "btnDowhile";
            btnDowhile.Size = new Size(105, 41);
            btnDowhile.TabIndex = 2;
            btnDowhile.Text = "Do While";
            btnDowhile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(325, 62);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 3;
            label1.Text = "Ingrese un numero";
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumero.Location = new Point(281, 90);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(263, 29);
            txtNumero.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(369, 249);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 5;
            label2.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(281, 286);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(263, 29);
            txtResultado.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(232, 9);
            label3.Name = "label3";
            label3.Size = new Size(355, 25);
            label3.TabIndex = 7;
            label3.Text = "Programa para saber si es un primo o no";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtResultado);
            Controls.Add(label2);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Controls.Add(btnDowhile);
            Controls.Add(btnWhile);
            Controls.Add(btnFor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFor;
        private Button btnWhile;
        private Button btnDowhile;
        private Label label1;
        private TextBox txtNumero;
        private Label label2;
        private TextBox txtResultado;
        private Label label3;
    }
}
