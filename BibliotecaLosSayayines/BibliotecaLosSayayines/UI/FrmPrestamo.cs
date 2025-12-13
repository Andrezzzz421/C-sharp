using BibliotecaLosSayayines.DAO;
using BibliotecaLosSayayines.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BibliotecaLosSayayines.UI
{
    public partial class FrmPrestamo : Form
    {
        private Usuario usuarioActual;
        private int x, y;

        private void ClearText()
        {
            txtId.Text = "";
            cbxCliente.SelectedIndex = -1;
            txtObservaciones.Text = "";
            LoadFechas();
        }
        private void FillText(int id)
        {
            try
            {
                var x = UnitOfWork.prestamo.GetById(id);
                if (x != null)
                {
                    txtId.Text = x.IdPrestamo.ToString();
                    cbxCliente.SelectedValue = x.IdCliente;
                    txtObservaciones.Text = x.Observaciones;
                    lblFechaPrestamo.Text = x.FechaPrestamo.ToString("yyyy-MM-dd HH:mm:ss");
                    lblEntrega.Text = x.FechaEntrega.ToString("yyyy-MM-dd HH:mm:ss");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillGrid()
        {
            try
            {
                dgPrestamo.AutoGenerateColumns = true;
                dgPrestamo.DataSource = UnitOfWork.prestamo.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Prestamo CaptureData()
        {
            Prestamo p = new Prestamo();

            if (!string.IsNullOrWhiteSpace(txtId.Text))
                p.IdPrestamo = Convert.ToInt32(txtId.Text);

            p.IdCliente = Convert.ToInt32(cbxCliente.SelectedValue);
            p.IdUsuario = usuarioActual.IdUsuario;
            p.Observaciones = txtObservaciones.Text;
            p.FechaEntrega = DateTime.Now.AddDays(20);

            return p;
        }
        private void InsertData()
        {
            try
            {
                    DialogResult r = MessageBox.Show("¿Desea registrar el préstamo?",
                        "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        UnitOfWork.prestamo.Add(CaptureData());
                        ClearText();
                        FillGrid();

                        MessageBox.Show("Préstamo registrado exitosamente",
                            "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillCliente()
        {
            try
            {
                cbxCliente.DataSource = null;
                cbxCliente.DataSource = UnitOfWork.cliente.GetAll();
                cbxCliente.DisplayMember = "Nombre";
                cbxCliente.ValueMember = "IdCliente";
                cbxCliente.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public FrmPrestamo(Usuario u)
        {
            InitializeComponent();
            FillCliente();
            usuarioActual = u;

        }
        private void LoadFechas()
        {
            DateTime fPrestamo = DateTime.Now;
            DateTime fEntrega = fPrestamo.AddDays(20);

            lblFechaPrestamo.Text = fPrestamo.ToString("dd/MM/yyyy");
            lblEntrega.Text = fEntrega.ToString("dd/MM/yyyy");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ClearText();
            FillCliente();
        }


        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void dgPrestamo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dgPrestamo.Rows[e.RowIndex].Cells[0].Value);
                FillText(id);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea salir del formulario de Préstamo?", "Confirmacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}