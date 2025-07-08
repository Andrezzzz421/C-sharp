namespace Ejercicio2
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
            label4 = new Label();
            label5 = new Label();
            txtV4 = new TextBox();
            txtV5 = new TextBox();
            txtV3 = new TextBox();
            txtV2 = new TextBox();
            txtV1 = new TextBox();
            label6 = new Label();
            txtPromedio = new TextBox();
            btnpromedio = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(295, 19);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Primera Nota";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 81);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Segunda Nota";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 135);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "Tercera Nota";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 256);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 3;
            label4.Text = "Quinta Nota";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(295, 197);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 4;
            label5.Text = "Cuarta Nota";
            // 
            // txtV4
            // 
            txtV4.Location = new Point(295, 215);
            txtV4.Name = "txtV4";
            txtV4.Size = new Size(143, 23);
            txtV4.TabIndex = 5;
            // 
            // txtV5
            // 
            txtV5.Location = new Point(296, 274);
            txtV5.Name = "txtV5";
            txtV5.Size = new Size(143, 23);
            txtV5.TabIndex = 6;
            // 
            // txtV3
            // 
            txtV3.Location = new Point(295, 153);
            txtV3.Name = "txtV3";
            txtV3.Size = new Size(143, 23);
            txtV3.TabIndex = 7;
            // 
            // txtV2
            // 
            txtV2.Location = new Point(295, 99);
            txtV2.Name = "txtV2";
            txtV2.Size = new Size(143, 23);
            txtV2.TabIndex = 8;
            // 
            // txtV1
            // 
            txtV1.Location = new Point(295, 37);
            txtV1.Name = "txtV1";
            txtV1.Size = new Size(144, 23);
            txtV1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(296, 368);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 10;
            label6.Text = "Promedio";
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(296, 386);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(143, 23);
            txtPromedio.TabIndex = 11;
            // 
            // btnpromedio
            // 
            btnpromedio.Location = new Point(296, 316);
            btnpromedio.Name = "btnpromedio";
            btnpromedio.Size = new Size(143, 39);
            btnpromedio.TabIndex = 12;
            btnpromedio.Text = "Promedio";
            btnpromedio.UseVisualStyleBackColor = true;
            btnpromedio.Click += btnpromedio_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnpromedio);
            Controls.Add(txtPromedio);
            Controls.Add(label6);
            Controls.Add(txtV1);
            Controls.Add(txtV2);
            Controls.Add(txtV3);
            Controls.Add(txtV5);
            Controls.Add(txtV4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtV4;
        private TextBox txtV5;
        private TextBox txtV3;
        private TextBox txtV2;
        private TextBox txtV1;
        private Label label6;
        private TextBox txtPromedio;
        private Button btnpromedio;
    }
}
