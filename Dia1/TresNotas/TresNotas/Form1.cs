namespace TresNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string name;
            double v1, v2, v3, v4, defi;

            name = Convert.ToString(txtNombre.Text);

            v1 = Convert.ToDouble(txtV1.Text);
            v2 = Convert.ToDouble(txtV2.Text);
            v3 = Convert.ToDouble(txtV3.Text);
            v4 = Convert.ToDouble(txtV4.Text);

            defi = (v1 * 0.25) + (v2 * 0.15) + (v3 * 0.15) + (v4 * 0.45);

            txtDefinitiva.Text = defi.ToString("##.##");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
