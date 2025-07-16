namespace FactorialNumero
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bntResultado = new Button();
            bntResultado2 = new Button();
            bntResultado3 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(369, 69);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingrese un numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(172, 25);
            label2.TabIndex = 1;
            label2.Text = "Ingrese un numero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(722, 69);
            label3.Name = "label3";
            label3.Size = new Size(172, 25);
            label3.TabIndex = 2;
            label3.Text = "Ingrese un numero";
            // 
            // bntResultado
            // 
            bntResultado.Font = new Font("Segoe UI", 14.25F);
            bntResultado.Location = new Point(128, 100);
            bntResultado.Name = "bntResultado";
            bntResultado.Size = new Size(138, 43);
            bntResultado.TabIndex = 3;
            bntResultado.Text = "Resultado";
            bntResultado.UseVisualStyleBackColor = true;
            bntResultado.Click += button1_Click;
            // 
            // bntResultado2
            // 
            bntResultado2.Font = new Font("Segoe UI", 14.25F);
            bntResultado2.Location = new Point(487, 100);
            bntResultado2.Name = "bntResultado2";
            bntResultado2.Size = new Size(138, 43);
            bntResultado2.TabIndex = 4;
            bntResultado2.Text = "Resultado";
            bntResultado2.UseVisualStyleBackColor = true;
            bntResultado2.Click += bntResultado2_Click;
            // 
            // bntResultado3
            // 
            bntResultado3.Font = new Font("Segoe UI", 14.25F);
            bntResultado3.Location = new Point(813, 98);
            bntResultado3.Name = "bntResultado3";
            bntResultado3.Size = new Size(138, 43);
            bntResultado3.TabIndex = 5;
            bntResultado3.Text = "Resultado";
            bntResultado3.UseVisualStyleBackColor = true;
            bntResultado3.Click += bntResultado3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(97, 149);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(219, 334);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(454, 149);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(219, 334);
            listBox2.TabIndex = 7;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(769, 149);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(219, 334);
            listBox3.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F);
            textBox1.Location = new Point(190, 61);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "escriba";
            textBox1.Size = new Size(126, 33);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F);
            textBox2.Location = new Point(547, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(126, 33);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F);
            textBox3.Location = new Point(900, 59);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(126, 33);
            textBox3.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 559);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(bntResultado3);
            Controls.Add(bntResultado2);
            Controls.Add(bntResultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button bntResultado;
        private Button bntResultado2;
        private Button bntResultado3;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
