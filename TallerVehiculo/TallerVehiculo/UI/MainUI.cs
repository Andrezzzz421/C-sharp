using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerVehiculo.DAO;
using TallerVehiculo.Helpers;

namespace TallerVehiculo.UI
{
    public partial class MainUI : Form
    {
        MarcaDAO mrDAO = new MarcaDAO();
        PropietarioDAO prDAO = new PropietarioDAO();
        VehiculoDAO vDAO = new VehiculoDAO();
        string nombre { get; set; } = "";
        public void CloseForm()
        {
            if (frActivo != null)
            {
                if (nombre != frActivo.Name)
                {
                    frActivo.Close();
                    frActivo = null;
                    pnlTitulo.Visible = false;
                    pnlDashboard.Visible = true;
                }
            }
        }

        public void ShowData()
        {
            lblVehiculos.Text = vDAO.Count().ToString();
           lblPropietarios.Text = prDAO.Count().ToString();
            lblMarcas.Text = mrDAO.Count().ToString();
        }
        public void ShowPanel(bool visible = true)
        {
            pnlApp.Visible = visible;
        }

        Form frActivo = null;


        private void ShowForm(Form newForm,String titulo)
        {
            if (frActivo != null && frActivo.GetType() == newForm.GetType())
            {
                return;
            }

            CloseForm();
            pnlDashboard.Visible = false;

            lblTitle.Text = titulo;
            frActivo = newForm;
            frActivo.TopLevel = false;
            frActivo.FormBorderStyle = FormBorderStyle.None;
            frActivo.Dock = DockStyle.Fill;
            pnlApp.Controls.Add(frActivo);

            pnlApp.Visible = true;
            pnlTitulo.Visible = true;

            frActivo.Show();
        }

        private void Initializer()
        {
            APHelper.Seed();
        }
        public MainUI()
        {
            InitializeComponent();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            Initializer();
            ShowData();
            pnlTitulo.Visible = false;
            pnlDashboard.Visible = true;

        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            ShowForm(new VehiculoUI(), "Gestión de Vehículos");
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            ShowForm(new MarcaUI(), "Gestión de Marcas");
        }

        private void btnPropietarios_Click(object sender, EventArgs e)
        {
            ShowForm(new PropietarioUI(), "Gestión de Propietarios");
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void pnlApp_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
