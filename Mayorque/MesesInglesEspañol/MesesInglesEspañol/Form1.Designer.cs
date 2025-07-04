namespace MesesInglesEspañol
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
            btnEspanol = new Button();
            btnIngles = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNmes = new TextBox();
            txtMes = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnEspanol
            // 
            btnEspanol.Location = new Point(214, 301);
            btnEspanol.Name = "btnEspanol";
            btnEspanol.Size = new Size(143, 43);
            btnEspanol.TabIndex = 0;
            btnEspanol.Text = "Español";
            btnEspanol.UseVisualStyleBackColor = true;
            btnEspanol.Click += btnEspanol_Click;
            // 
            // btnIngles
            // 
            btnIngles.Location = new Point(378, 301);
            btnIngles.Name = "btnIngles";
            btnIngles.Size = new Size(143, 42);
            btnIngles.TabIndex = 1;
            btnIngles.Text = "Ingles";
            btnIngles.UseVisualStyleBackColor = true;
            btnIngles.Click += btnIngles_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 122);
            label1.Name = "label1";
            label1.Size = new Size(127, 30);
            label1.TabIndex = 2;
            label1.Text = "Mes del año";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(219, 64);
            label2.Name = "label2";
            label2.Size = new Size(302, 30);
            label2.TabIndex = 3;
            label2.Text = "Meses del año Ingles y Español";
            // 
            // txtNmes
            // 
            txtNmes.Location = new Point(347, 129);
            txtNmes.Name = "txtNmes";
            txtNmes.Size = new Size(147, 23);
            txtNmes.TabIndex = 4;
            txtNmes.TextChanged += txtNmes_TextChanged;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(347, 233);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(147, 23);
            txtMes.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(289, 233);
            label3.Name = "label3";
            label3.Size = new Size(52, 30);
            label3.TabIndex = 6;
            label3.Text = "Mes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtMes);
            Controls.Add(txtNmes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIngles);
            Controls.Add(btnEspanol);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEspanol;
        private Button btnIngles;
        private Label label1;
        private Label label2;
        private TextBox txtNmes;
        private TextBox txtMes;
        private Label label3;
    }
}
