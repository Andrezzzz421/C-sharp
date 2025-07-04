namespace MesesInglesEspañol
{
    public partial class Form1 : Form
    {

        int nmes;
        string mes;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEspanol_Click(object sender, EventArgs e)
        {
            nmes = Convert.ToInt32(txtNmes.Text);

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

            txtMes.Text = mes;
        }

        private void btnIngles_Click(object sender, EventArgs e)
        {
            nmes = Convert.ToInt32(txtNmes.Text);

            if (nmes == 1)
                mes = "January";
            else if (nmes == 2)
                mes = "February";
            else if (nmes == 3)
                mes = "March";
            else if (nmes == 4)
                mes = "April";
            else if (nmes == 5)
                mes = "May";
            else if (nmes == 6)
                mes = "June";
            else if (nmes == 7)
                mes = "July";
            else if (nmes == 8)
                mes = "August";
            else if (nmes == 9)
                mes = "September";
            else if (nmes == 10)
                mes = "October";
            else if (nmes == 11)
                mes = "November";
            else if (nmes == 12)
                mes = "December";
            else
                mes = "Don't Exist";

            txtMes.Text = mes;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNmes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
