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
    public partial class FrmRecovery : Form
    {
        private Usuario usuarioencontrado;
        public FrmRecovery()
        {
            InitializeComponent();
        }

        private void FrmRecovery_Load(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDAO dao = new UsuarioDAO();
                var user = dao.GetByUserOrEmail(TxtDato.Text.Trim());
                if (user != null)
                {
                    LblResultado.Text = "Usuario encontrado: " + user.Nombre;
                    LblResultado.ForeColor = Color.Green;

                    TxtNuevaContra.Enabled = true;
                    BtnActualizar.Enabled = true;
                }
                else
                {
                    LblResultado.Text = "No existe ese usuario o correo.";
                    LblResultado.ForeColor = Color.Red;

                    TxtNuevaContra.Enabled = false;
                    BtnActualizar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {


            try
            {
                UsuarioDAO dao = new UsuarioDAO();
                bool ok = dao.UpdatePassword(TxtDato.Text.Trim(), TxtNuevaContra.Text.Trim());

                if (ok)
                {
                    MessageBox.Show("Contraseña actualizada correctamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la contraseña", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private int x, y;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            // Guardar las coordenadas donde se hizo clic
            x = e.X;
            y = e.Y;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
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
    

