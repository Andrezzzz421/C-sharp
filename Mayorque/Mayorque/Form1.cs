namespace Mayorque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            int v1, v2;
            string res;

            v1 = Convert.ToInt32(txtValor1.Text);
            v2 = Convert.ToInt32(txtValor2.Text);

            if (v1 > v2)
                res = "El numero mayor es: " + v1;
            else if (v1 == v2)
                res = "Los numero son iguales";
            else
                res = "El numero mayor es: " + v2;


            txtResultado.Text = res;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
