using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes.UI
{
    public partial class FrmMenu : Form
    {
        string nombre { get; set; } = "";
        Form? frActivo = null;
        public FrmMenu()
        {
            InitializeComponent();
        }

        public void CLoseForm()
        {
            if (frActivo != null)
            {
                if (nombre != frActivo.Name)
                {
                    frActivo.Close();
                    frActivo = null;
                    pnlTitulo.Visible = false;
                }
            }
        }

        public void ShowPanel(bool visible = true)
        {
            pnlApp.Visible = visible;
        }

        private void ShowForm(Form newForm, string titulo)
        {
            if (frActivo != null && frActivo.GetType() == newForm.GetType())
            {
                return;

            }
            CLoseForm();
            lblTitullo.Text = titulo;
            frActivo = newForm;

            frActivo.TopLevel = false;
            frActivo.FormBorderStyle = FormBorderStyle.None;
            frActivo.Dock = DockStyle.Fill;
            pnlApp.Controls.Add(frActivo);

            pnlApp.Visible = true;
            pnlTitulo.Visible = true;

            frActivo.Show();

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            pnlTitulo.Visible = false;
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            ShowForm(new EstudianteUI(this),"Gestion de Estudiantes");
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            ShowForm(new CursoUI(this), "Gestion de Cursos");
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            ShowForm(new FrmConsultas(this),"Gestion de Consultas");
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            CLoseForm();
        }
    }
}
