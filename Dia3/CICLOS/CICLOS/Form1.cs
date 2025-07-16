namespace CICLOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TablaFor()
        {
            try
            {
                listBox1.Items.Clear();
                int numero = Convert.ToInt32(textBox1.Text);

                for (int i = 1; i < 21; i++)
                {
                    int producto = numero * i;
                    listBox1.Items.Add($"{numero}X{i}={producto}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TablaWhile()
        {
            listBox2.Items.Clear();
            int numero = Convert.ToInt32(textBox2.Text);
            int i = 1;
            try
            {
                while (i < 21)
                {
                    int producto = numero * i;
                    listBox2.Items.Add($"{numero}X{i}={producto}"); i++;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TablaDoWhile()
        {
            try
            {
                listBox3.Items.Clear();
                int numero = Convert.ToInt32(textBox3.Text);
                int i = 1;
                do
                {
                    int producto = numero * i;
                    listBox3.Items.Add($"{numero}X{i}={producto}"); i++;

                } while (i < 21);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            TablaFor();
        }

        private void btnMostrar2_Click(object sender, EventArgs e)
        {
            TablaWhile();
        }

        private void btnMostrar3_Click(object sender, EventArgs e)
        {
            TablaDoWhile(); 
        }
    }
}
