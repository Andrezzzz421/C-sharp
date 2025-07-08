namespace Ejercicio3
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            int cent;
            double metr;

            cent = Convert.ToInt32(txtCentimetros.Text);

            metr = cent / 100;

            txtMetros.Text = metr.ToString();

        }
    }
}
