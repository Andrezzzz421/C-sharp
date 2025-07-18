namespace PrimoONoPrimo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PrimoFor()
        {
            try
            {
                int n = Convert.ToInt32(txtNumero.Text);
                bool esPrimo = true;

                if (n <= 1)
                {
                    esPrimo = false;
                }
                else
                {
                    for (int i = 2; i <= Math.Sqrt(n); i++)
                    {
                        if (n % i == 0)
                        {
                            esPrimo = false;
                            break;
                        }
                    }
                }

                txtResultado.Text = esPrimo ? "Es primo" : "No es primo"; //esto es una especie de if pero abreviado
                                                                          //if          else 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }


        private void PrimoWhile()
        {
            try
            {
                int n = Convert.ToInt32(txtNumero.Text);
                bool esPrimo = true;
                int i = 2;
                if (n <= 1)
                {
                    esPrimo = false;
                }
                else
                {
                    while (i <= Math.Sqrt(n))
                    {
                        if (n % i == 0)
                        {
                            esPrimo = false;
                            break;
                        }
                        i++;
                    }
                }

                txtResultado.Text = esPrimo ? "Es primo" : "No es primo";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void DoWhile()
        {

        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            PrimoFor();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            PrimoWhile();
        }
    }
}
