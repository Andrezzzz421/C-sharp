namespace factorial
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
            txtSerie1 = new TextBox();
            txtSerie2 = new TextBox();
            btnMostrar1 = new Button();
            lstResultadoSerie1 = new ListBox();
            lstResultadoSerie2 = new ListBox();
            btnMostrar2 = new Button();
            txtResultadoSerie1 = new TextBox();
            txtResultadoSerie2 = new TextBox();
            txtResultado1 = new TextBox();
            txtResultado2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 137);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "FOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(365, 119);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "WHILE";
            label2.Click += label2_Click;
            // 
            // txtSerie1
            // 
            txtSerie1.Location = new Point(85, 129);
            txtSerie1.Name = "txtSerie1";
            txtSerie1.Size = new Size(100, 23);
            txtSerie1.TabIndex = 3;
            txtSerie1.TextChanged += textBox1_TextChanged;
            // 
            // txtSerie2
            // 
            txtSerie2.Location = new Point(413, 116);
            txtSerie2.Name = "txtSerie2";
            txtSerie2.Size = new Size(100, 23);
            txtSerie2.TabIndex = 4;
            // 
            // btnMostrar1
            // 
            btnMostrar1.Location = new Point(43, 545);
            btnMostrar1.Name = "btnMostrar1";
            btnMostrar1.Size = new Size(161, 38);
            btnMostrar1.TabIndex = 6;
            btnMostrar1.Text = "Mostrar";
            btnMostrar1.UseVisualStyleBackColor = true;
            btnMostrar1.Click += btnMostrar1_Click;
            // 
            // lstResultadoSerie1
            // 
            lstResultadoSerie1.FormattingEnabled = true;
            lstResultadoSerie1.Location = new Point(52, 213);
            lstResultadoSerie1.Name = "lstResultadoSerie1";
            lstResultadoSerie1.Size = new Size(161, 259);
            lstResultadoSerie1.TabIndex = 9;
            // 
            // lstResultadoSerie2
            // 
            lstResultadoSerie2.FormattingEnabled = true;
            lstResultadoSerie2.Location = new Point(393, 213);
            lstResultadoSerie2.Name = "lstResultadoSerie2";
            lstResultadoSerie2.Size = new Size(161, 259);
            lstResultadoSerie2.TabIndex = 10;
            // 
            // btnMostrar2
            // 
            btnMostrar2.Location = new Point(393, 532);
            btnMostrar2.Name = "btnMostrar2";
            btnMostrar2.Size = new Size(161, 38);
            btnMostrar2.TabIndex = 12;
            btnMostrar2.Text = "Mostrar";
            btnMostrar2.UseVisualStyleBackColor = true;
            btnMostrar2.Click += btnMostrar2_Click;
            // 
            // txtResultadoSerie1
            // 
            txtResultadoSerie1.Location = new Point(52, 178);
            txtResultadoSerie1.Name = "txtResultadoSerie1";
            txtResultadoSerie1.Size = new Size(161, 23);
            txtResultadoSerie1.TabIndex = 14;
            // 
            // txtResultadoSerie2
            // 
            txtResultadoSerie2.Location = new Point(393, 166);
            txtResultadoSerie2.Name = "txtResultadoSerie2";
            txtResultadoSerie2.Size = new Size(161, 23);
            txtResultadoSerie2.TabIndex = 15;
            // 
            // txtResultado1
            // 
            txtResultado1.Location = new Point(43, 501);
            txtResultado1.Name = "txtResultado1";
            txtResultado1.Size = new Size(161, 23);
            txtResultado1.TabIndex = 17;
            // 
            // txtResultado2
            // 
            txtResultado2.Location = new Point(393, 488);
            txtResultado2.Name = "txtResultado2";
            txtResultado2.Size = new Size(161, 23);
            txtResultado2.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 617);
            Controls.Add(txtResultado2);
            Controls.Add(txtResultado1);
            Controls.Add(txtResultadoSerie2);
            Controls.Add(txtResultadoSerie1);
            Controls.Add(btnMostrar2);
            Controls.Add(lstResultadoSerie2);
            Controls.Add(lstResultadoSerie1);
            Controls.Add(btnMostrar1);
            Controls.Add(txtSerie2);
            Controls.Add(txtSerie1);
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
        private TextBox txtSerie1;
        private TextBox txtSerie2;
        private Button btnMostrar1;
        private ListBox lstResultadoSerie1;
        private ListBox lstResultadoSerie2;
        private Button btnMostrar2;
        private TextBox txtResultadoSerie1;
        private TextBox txtResultadoSerie2;
        private TextBox txtResultado1;
        private TextBox txtResultado2;
    }
}
