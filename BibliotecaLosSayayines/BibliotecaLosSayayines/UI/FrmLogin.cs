using BibliotecaLosSayayines.DAO;
using BibliotecaLosSayayines.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaLosSayayines.UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            string dato = txtUser.Text.Trim();
            string pass = txtPassword.Text.Trim();

            UsuarioDAO dao = new UsuarioDAO();
            Usuario usuario = dao.Login(dato, pass);

            if (usuario != null)
            {
                MessageBox.Show("Bienvenido " + usuario.Nombre);

                FrmMenu menu = new FrmMenu(usuario);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario, Email o contraseña incorrectos");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private int x, y;


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            // Guardar las coordenadas donde se hizo clic
            x = e.X;
            y = e.Y;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnRecuperar_Click(object sender, EventArgs e)
        {
            FrmRecovery formRecuperacion = new FrmRecovery();
            formRecuperacion.Show();


        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea salir De la Aplicacion x?", "Confirmacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
             
            if (e.Button == MouseButtons.Left)
            { 
                this.Location = new Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));
            }
        }
    }
}
