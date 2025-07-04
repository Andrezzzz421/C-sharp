namespace Mesanio
{
    public partial class Form1 : Form
    {

        int nmes;
        string mes;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerif_Click(object sender, EventArgs e)
        {

            nmes = Convert.ToInt32(textBox1.Text);

            if (nmes == 1)
                mes = "Enero";
            else if (nmes == 2)
                mes = "Febrero";
            else if (nmes == 3)
                mes = "Marzo";
            else if (nmes == 4)
                mes = "Abril";
            else if (nmes == 5)
                mes = "Mayo";
            else if (nmes == 6)
                mes = "Junio";
            else if (nmes == 7)
                mes = "Julio";
            else if (nmes == 8)
                mes = "Agosto";
            else if (nmes == 9)
                mes = "Septiembre";
            else if (nmes == 10)
                mes = "Octubre";
            else if (nmes == 11)
                mes = "Noviembre";
            else if (nmes == 12)
                mes = "Diciembre";
            else
                mes = "No existe";

            textBox2.Text = mes;
        }

        private void btnVerSwitch_Click(object sender, EventArgs e)
        {
            nmes = Convert.ToInt32(textBox1.Text);

            switch (nmes)
            {
                case 1:
                    mes = "Enero";
                    break;
                case 2:
                    mes = "Febrero";
                    break;
                case 3:
                    mes = "Marzo";
                    break;
                case 4:
                    mes = "Abril";
                    break;
                case 5:
                    mes = "Mayo";
                    break;
                case 6:
                    mes = "Junio";
                    break;
                case 7:
                    mes = "Julio";
                    break;
                case 8:
                    mes = "Agosto";
                    break;
                case 9:
                    mes = "Septiembre";
                    break;
                case 10:
                    mes = "Octubre";
                    break;
                case 11:
                    mes = "Noviembre";
                    break;
                case 12:
                    mes = "Diciembre";
                    break;
                default:
                    mes = "NO EXISTE";
                    break;

            }
            textBox2.Text = mes;
        }
    }
}