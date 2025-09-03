using EmpresaV1.HELPER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaV1.UI
{
    public partial class FrmMenu : Form
    {
        private Form formularioActivo = null;
        private void AbrirFormularioEnPanel(Form formularioHijo)
        {
            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = formularioHijo;

            formularioHijo.TopLevel = false; 
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill; 

            pnlApp.Controls.Clear(); 
            pnlApp.Controls.Add(formularioHijo); 

            formularioHijo.Show();
        }

        public FrmMenu()
        {
            InitializeComponent();
            CGHelper.Seed();
            EMHelpers.Seed();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlApp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmEmpleados());
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmCargos());
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmConsultas());
        }
    }
}
