namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        double v1, res;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            v1 = Convert.ToDouble(txtCelsius.Text);

            res = v1 + 273.15;

            txtResultado.Text = res.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            v1 = Convert.ToDouble(txtCelsius.Text);

            res = (v1 * 9 / 5) + 32;

            txtResultado.Text=res.ToString();

        }
    }
}
