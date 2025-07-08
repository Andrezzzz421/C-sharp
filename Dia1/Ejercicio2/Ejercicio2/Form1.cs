namespace Ejercicio2
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

        private void btnpromedio_Click(object sender, EventArgs e)
        {
            double v1, v2, v3, v4, v5, pr;

            v1 = Convert.ToDouble(txtV1.Text);
            v2 = Convert.ToDouble(txtV2.Text);
            v3 = Convert.ToDouble(txtV3.Text);
            v4 = Convert.ToDouble(txtV4.Text);
            v5 = Convert.ToDouble(txtV5.Text);

            pr = (v1 + v2 + v3 + v4 + v5) / 5;

            txtPromedio.Text = pr.ToString();


        }
    }
}
