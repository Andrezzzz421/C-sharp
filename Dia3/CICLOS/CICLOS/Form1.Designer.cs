namespace CICLOS
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
            btnMostrar = new Button();
            btnMostrar3 = new Button();
            btnMostrar2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(51, 153);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(236, 53);
            btnMostrar.TabIndex = 0;
            btnMostrar.Text = "Resultado";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnMostrar3
            // 
            btnMostrar3.Location = new Point(657, 153);
            btnMostrar3.Name = "btnMostrar3";
            btnMostrar3.Size = new Size(236, 53);
            btnMostrar3.TabIndex = 1;
            btnMostrar3.Text = "Resultado";
            btnMostrar3.UseVisualStyleBackColor = true;
            btnMostrar3.Click += btnMostrar3_Click;
            // 
            // btnMostrar2
            // 
            btnMostrar2.Location = new Point(358, 153);
            btnMostrar2.Name = "btnMostrar2";
            btnMostrar2.Size = new Size(236, 53);
            btnMostrar2.TabIndex = 2;
            btnMostrar2.Text = "Resultado";
            btnMostrar2.UseVisualStyleBackColor = true;
            btnMostrar2.Click += btnMostrar2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(115, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(437, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(157, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(701, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(192, 23);
            textBox3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 121);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(358, 121);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(657, 121);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 8;
            label3.Text = "label3";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(57, 223);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(230, 319);
            listBox1.TabIndex = 9;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(364, 223);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(230, 319);
            listBox2.TabIndex = 10;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(657, 236);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(230, 319);
            listBox3.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1046, 631);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnMostrar2);
            Controls.Add(btnMostrar3);
            Controls.Add(btnMostrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrar;
        private Button btnMostrar3;
        private Button btnMostrar2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
    }
}
