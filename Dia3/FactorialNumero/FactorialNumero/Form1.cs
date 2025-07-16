namespace FactorialNumero
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void FactorialFor()
        {

            try
            {
                listBox1.Items.Clear();
                int numero = Convert.ToInt32(textBox1.Text);

                long factorial = 1;
                for (int i = 1; i <= numero; i++)
                {
                    factorial *= i;
                    listBox1.Items.Add($"Factorial:{numero}={factorial}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FactorialWhile()
        {


            try
            {
                listBox2.Items.Clear();
                int numero = Convert.ToInt32(textBox2.Text);
                long factorial = 1;
                int i = 1;
                while (i <= numero)
                {
                    factorial *= i;
                    listBox2.Items.Add($"Factorial: {numero}={factorial}");
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FactorialDoWhile()
        { 
            try
            {
                listBox2.Items.Clear();
                int numero = Convert.ToInt32(textBox3.Text);
                long factorial = 1;
                int i = 1;

                do
                {
                    factorial *= i;
                    listBox3.Items.Add($"Factorial: {numero}={factorial}");
                    i++;
                } while (i <= numero);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FactorialFor();
        }

        private void bntResultado3_Click(object sender, EventArgs e)
        {
            FactorialDoWhile();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bntResultado2_Click(object sender, EventArgs e)
        {
            FactorialWhile();   
        }
    }
}
