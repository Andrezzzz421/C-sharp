namespace PotenciaDeUnNumero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int v1, v2, res;

            v1 = Convert.ToInt32(txtValor1.Text);
            v2 = Convert.ToInt32(txtValo2.Text);

            res = (int)Math.Pow(v1, v2);

            txtResultado.Text = res.ToString();
        }
    }
}
