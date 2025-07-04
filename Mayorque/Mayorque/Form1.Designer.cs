namespace Mayorque
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
            btnComparar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            txtResultado = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnComparar
            // 
            btnComparar.Location = new Point(214, 261);
            btnComparar.Name = "btnComparar";
            btnComparar.Size = new Size(138, 41);
            btnComparar.TabIndex = 0;
            btnComparar.Text = "Comparar";
            btnComparar.UseVisualStyleBackColor = true;
            btnComparar.Click += btnComparar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 54);
            label1.Name = "label1";
            label1.Size = new Size(155, 30);
            label1.TabIndex = 1;
            label1.Text = "Primer Numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 134);
            label2.Name = "label2";
            label2.Size = new Size(177, 30);
            label2.TabIndex = 2;
            label2.Text = "Segundo Numero";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(287, 54);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(179, 23);
            txtValor1.TabIndex = 3;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(287, 141);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(179, 23);
            txtValor2.TabIndex = 4;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(287, 210);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(179, 23);
            txtResultado.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(105, 203);
            label3.Name = "label3";
            label3.Size = new Size(154, 30);
            label3.TabIndex = 6;
            label3.Text = "Numero Mayor";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 450);
            Controls.Add(label3);
            Controls.Add(txtResultado);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnComparar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnComparar;
        private Label label1;
        private Label label2;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private TextBox txtResultado;
        private Label label3;
    }
}
