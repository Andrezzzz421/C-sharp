namespace NumerosPar
{
    public partial class Form1 : Form
    {
        private void DeterminarPar()
        {
            String res;

            int n = Convert.ToInt32(txtValor1.Text);

            if (n % 2 == 0)
                res = "El numero es par";
            else
                res = "El numero es impar";
            txtRes.Text = res;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            DeterminarPar();
        }
    }
}
