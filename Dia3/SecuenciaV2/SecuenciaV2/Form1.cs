namespace SecuenciaV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SerieFor()
        {
            try
            {
                int n = Convert.ToInt32(txtNserie.Text);
                float sum = 0;
                int divisor = 1;
                int numerador = 1;
                lstSerie.Items.Clear();
                for (int i = 1; i <= n; i++)
                {

                    txtSerie.Text += $"{numerador}/{divisor}+";
                    lstSerie.Items.Add(numerador + "/" + divisor);
                    sum += (float)numerador / divisor;
                    numerador++;
                    divisor += 2;

                    txtSuma.Text = sum.ToString("F4");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SerieWhile()
        {
            try
            {
                int n = Convert.ToInt32(txtNserie2.Text);
                float sum = 0;
                int divisor = 1;
                int numerador = 1;
                int i = 1;
                lstSerie2.Items.Clear();
                while (i <= n)
                {
                    txtSerie2.Text += $"{numerador}/{divisor}+";
                    lstSerie2.Items.Add(numerador + "/" + divisor);
                    sum += (float)numerador / divisor;
                    numerador++;
                    divisor += 2;
                    i++;

                    txtSuma2.Text = sum.ToString("F4");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void SerieDoWhile()
        {
            try
            {
                int n = Convert.ToInt32(txtNserie3.Text);
                float sum = 0;
                int divisor = 1;
                int numerador = 1;
                int i = 1;
                lstSerie3.Items.Clear();
                while (i <= n)
                {
                    txtSerie3.Text += $"{numerador}/{divisor}+";
                    lstSerie3.Items.Add(numerador + "/" + divisor);
                    sum += (float)numerador / divisor;
                    numerador++;
                    divisor += 2;
                    i++;

                    txtSuma3.Text = sum.ToString("F4");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnResultadoFor_Click(object sender, EventArgs e)
        {
            SerieFor();
        }

        private void btnResultadoWhile_Click(object sender, EventArgs e)
        {
            SerieWhile();
        }

        private void btnBotonDoWhile_Click(object sender, EventArgs e)
        {
            SerieDoWhile();
        }
    }
}
