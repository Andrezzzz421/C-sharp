namespace RaizDeUnNumero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num, raiz;

            num = Convert.ToDouble(txtV1.Text);

            raiz = Math.Sqrt(num);

            txtRaiz.Text = raiz.ToString();
        }
    }
}
