using BibliotecaLosSayayines.MODEL;
using Org.BouncyCastle.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaLosSayayines.UI
{
    public partial class FrmMenu : Form
    {

        private Usuario usuarioActual; 
        string nombre { get; set; } = "";


        public void CloseForm()
        {
            if (frActivo != null)
            {
                if (nombre != frActivo.Name)
                {
                    frActivo.Close();
                    frActivo = null; 
                }

            }
        }
        private void ShowForm(Form newForm, String titulo)
        {
            if (frActivo != null && frActivo.GetType() == newForm.GetType())
            {
                return;
            }

            CloseForm();
            frActivo = newForm; 
            frActivo.TopLevel = false;
            frActivo.FormBorderStyle = FormBorderStyle.None;
            frActivo.Dock = DockStyle.Fill;
            pnlApp.Controls.Add(frActivo);

            pnlApp.Visible = true; 

            frActivo.Show();
        }
        Form frActivo = null;
        private void CargarPermisos()
        {
            string rol = usuarioActual.Rol.ToLower();

            btnGestionLibros.Visible = false;
            btnGestionPrestamosLibros.Visible = false;
            btnAutores.Visible = false;
            btnGestionEditorial.Visible = false;
            btnGestionUsuarios.Visible = false;
            btnGeneros.Visible = false;
            btnClientes.Visible = false;
            btnCaategorias.Visible = false;
            btnDePrestamo.Visible = false;
            switch (rol)
            {
                case "admin":
                    btnGestionLibros.Visible = true;
                    btnGestionPrestamosLibros.Visible = true;
                    btnAutores.Visible = true;
                    btnGestionEditorial.Visible = true;
                    btnGestionUsuarios.Visible = true;
                    btnGeneros.Visible = true;
                    btnClientes.Visible = true;
                    btnCaategorias.Visible = true;
                    btnDePrestamo.Visible = true;
                    break;

                case "empleado":
                    btnGestionLibros.Visible = true;
                    btnGestionPrestamosLibros.Visible = true;
                    btnAutores.Visible = true;
                    btnGestionEditorial.Visible = true;
                    btnGeneros.Visible = true;
                    btnClientes.Visible = true;
                    btnDePrestamo.Visible = true;
                    btnGestionPrestamosLibros.Visible = true;
                    break;

                case "cliente":
                    btnGestionPrestamosLibros.Visible = true;
                    btnGestionUsuarios.Visible = true;
                    break;

                default:
                    MessageBox.Show("Rol desconocido. No se puede cargar el menú.");
                    break;
            }
        }


        public FrmMenu(Usuario u)
        {

            InitializeComponent();
            usuarioActual = u;

            lblNombre.Text = usuarioActual.Nombre;
            lblRol.Text = usuarioActual.Rol;


            try
            {
                if (usuarioActual.Foto != null && usuarioActual.Foto.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(usuarioActual.Foto))
                    {
                        PicFoto.Image = Image.FromStream(ms);
                        PicFoto.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                else
                {
                    PicFoto.Image = null;
                }
            }
            catch
            {
                PicFoto.Image = null;
            }
            CargarPermisos();
        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        { 

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        { 

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private int x, y;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            // Guardar las coordenadas donde se hizo clic
            x = e.X;
            y = e.Y;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {

            ShowForm(new FrmUsuario(), "Gestion de Usuarios");
        }

        private void BtnAutores_Click(object sender, EventArgs e)
        {
            ShowForm(new FrmAutor(), "Gestion de Autores");
        }

        private void BtnLibros_Click(object sender, EventArgs e)
        {
            ShowForm(new FrmLibro(), "Gestion de Libros");
        }

        private void BtnEditorial_Click(object sender, EventArgs e)
        {

            ShowForm(new FrmEditorial(), "Gestion de Editoriales");
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {

            ShowForm(new FrmClientes(), "Gestion de Clientes");
        }

        private void BtnCaategorias_Click(object sender, EventArgs e)
        {

            ShowForm(new FrmCategoria(), "Gestion de Categorias");
        }

        private void BtnGesLibros_Click(object sender, EventArgs e)
        {
            ShowForm(new FrmPrestamo(usuarioActual), "Gestion de Prestamos de Libros");
        }

        private void BtnGeneros_Click(object sender, EventArgs e)
        {

            ShowForm(new FrmGenero(), "Gestion de Generos");
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnDePrestamo_Click(object sender, EventArgs e)
        {

            ShowForm(new FrmDetPrestamo(), "Gestion de prestamos");

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {

        }

        private void BtnAbandonar_Click(object sender, EventArgs e)
        {

            DialogResult r = MessageBox.Show("¿Desea salir De la Aplicacion x?", "Confirmacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {


            // Verificar si el botón izquierdo del ratón está presionado (el valor 1 indica que está presionado)
            if (e.Button == MouseButtons.Left)
            {
                // Calcular la nueva posición del formulario
                // (e.X - x) es el desplazamiento horizontal
                // (e.Y - y) es el desplazamiento vertical
                this.Location = new Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));
            }
        }
    }
}
