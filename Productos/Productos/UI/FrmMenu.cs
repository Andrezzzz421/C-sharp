using Productos.HELPERS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos.UI
{
    public partial class FrmMenu : Form
    {
        private Form formularioActivo = null;
        private void AbrirFormularioEnPanel(Form formularioHijo)
        {
            if (formularioActivo != null)
                formularioActivo.Close(); // Cierra el que ya estaba abierto

            formularioActivo = formularioHijo;

            formularioHijo.TopLevel = false; // No será ventana independiente
            formularioHijo.FormBorderStyle = FormBorderStyle.None; // Sin bordes
            formularioHijo.Dock = DockStyle.Fill; // Que ocupe todo el panel

            pnlApp.Controls.Clear(); // Limpia el panel
            pnlApp.Controls.Add(formularioHijo); // Agrega el nuevo formulario
            //pnlApp.Tag = formularioHijo; // Opcional
            formularioHijo.Show();
        }

        public FrmMenu()
        {

            InitializeComponent();
            HELPproductos.Seed();
            HELPcategoria.Seed();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlApp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmProductos());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmCategoria());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmConsultas());
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
