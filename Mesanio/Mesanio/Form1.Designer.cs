namespace Mesanio
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnVerSwitch = new Button();
            label3 = new Label();
            btnVerif = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 160);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(129, 275);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 1;
            label2.Text = "Mes";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(187, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(187, 275);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 23);
            textBox2.TabIndex = 3;
            // 
            // btnVerSwitch
            // 
            btnVerSwitch.Location = new Point(380, 252);
            btnVerSwitch.Name = "btnVerSwitch";
            btnVerSwitch.Size = new Size(109, 46);
            btnVerSwitch.TabIndex = 5;
            btnVerSwitch.Text = "Switch";
            btnVerSwitch.UseVisualStyleBackColor = true;
            btnVerSwitch.Click += btnVerSwitch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(216, 66);
            label3.Name = "label3";
            label3.Size = new Size(226, 45);
            label3.TabIndex = 6;
            label3.Text = "Meses del año";
            // 
            // btnVerif
            // 
            btnVerif.Location = new Point(380, 145);
            btnVerif.Name = "btnVerif";
            btnVerif.Size = new Size(109, 47);
            btnVerif.TabIndex = 7;
            btnVerif.Text = "IF";
            btnVerif.UseVisualStyleBackColor = true;
            btnVerif.Click += btnVerif_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerif);
            Controls.Add(label3);
            Controls.Add(btnVerSwitch);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnVerSwitch;
        private Label label3;
        private Button btnVerif;
    }
}
