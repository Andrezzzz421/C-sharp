namespace factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SumatoriaFor()
        {
            int n = Convert.ToInt32(txtSerie1.Text);
            float sum = 0;
            int divisor = 1;
            lstResultadoSerie1.Items.Clear();
            for (int i = 1; i <= n; i++)
            {

                txtResultadoSerie1.Text += $"1/{divisor}+";
                lstResultadoSerie1.Items.Add(1 + "/" + divisor);
                sum += 1f / divisor;
                divisor += 2;

                txtResultado1.Text = sum.ToString("F4");

            }
        }

        private void SumatoriaWhile()
        {
            try
            {
                lstResultadoSerie2.Items.Clear();
                int n = Convert.ToInt32(txtSerie2.Text);
                float sum = 0;
                int divisor = 1;
                int i = 1;
                while (i <= n)
                {

                    txtResultadoSerie2.Text += $"1/{divisor}+";
                    lstResultadoSerie2.Items.Add(1 + "/" + divisor);
                    sum += 1f / divisor;
                    divisor += 2;
                    i++;
  
                }
                txtResultado2.Text = sum.ToString("F4");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar1_Click(object sender, EventArgs e)
        {
            SumatoriaFor();
        }

        private void btnMostrar2_Click(object sender, EventArgs e)
        {
            SumatoriaWhile();
        }
    }
}
