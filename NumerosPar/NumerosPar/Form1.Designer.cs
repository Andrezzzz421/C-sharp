namespace NumerosPar
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
            Label label1;
            label2 = new Label();
            txtValor1 = new TextBox();
            btnRes = new Button();
            txtRes = new TextBox();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 53);
            label1.Name = "label1";
            label1.Size = new Size(354, 32);
            label1.TabIndex = 0;
            label1.Text = "Determinar si un numero es par";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(241, 122);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 1;
            label2.Text = "Numero";
            // 
            // txtValor1
            // 
            txtValor1.BackColor = Color.White;
            txtValor1.BorderStyle = BorderStyle.FixedSingle;
            txtValor1.ForeColor = Color.Black;
            txtValor1.Location = new Point(315, 120);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(183, 23);
            txtValor1.TabIndex = 2;
            txtValor1.TextChanged += textBox1_TextChanged;
            // 
            // btnRes
            // 
            btnRes.BackColor = Color.Silver;
            btnRes.Location = new Point(255, 186);
            btnRes.Name = "btnRes";
            btnRes.Size = new Size(243, 50);
            btnRes.TabIndex = 3;
            btnRes.Text = "Determinar";
            btnRes.UseVisualStyleBackColor = false;
            btnRes.Click += btnRes_Click;
            // 
            // txtRes
            // 
            txtRes.BackColor = Color.White;
            txtRes.Location = new Point(326, 276);
            txtRes.Name = "txtRes";
            txtRes.Size = new Size(183, 23);
            txtRes.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(241, 276);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 4;
            label3.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRes);
            Controls.Add(label3);
            Controls.Add(btnRes);
            Controls.Add(txtValor1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtValor1;
        private Button btnRes;
        private TextBox txtRes;
        private Label label3;
    }
}
