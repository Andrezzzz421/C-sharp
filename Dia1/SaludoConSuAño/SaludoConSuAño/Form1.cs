namespace SaludoConSuAño
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name;
            int edad, anios, res;

            name = Convert.ToString(textBox1.Text);
            edad = Convert.ToInt32(textBox2.Text);

            anios = DateTime.Now.Year;
            res = anios - edad;
            
            textBox3.Text = Convert.ToString("HOLA "+name+" Tu edada es "+res);
        }
    }
}
