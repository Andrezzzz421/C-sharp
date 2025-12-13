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
    public partial class FrmDetPrestamo : Form
    {
        private void ClearText()
        {
            txtId.Text = "";
            cbxPrestamo.SelectedIndex = -1;
            cbxLibro.SelectedIndex = -1;
            lblFechaEntrega.Text = "";
        }

        private void FillLibro()
        {
            try
            {
                cbxLibro.DataSource = null;
                cbxLibro.DataSource = UnitOfWork.libro.GetAll();
                cbxLibro.DisplayMember = "Titulo";
                cbxLibro.ValueMember = "Id_Libro";
                cbxLibro.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FillCliente()
        {
            try
            {
                cbxPrestamo.DataSource = null;
                cbxPrestamo.DataSource = UnitOfWork.prestamo.GetAll();
                cbxPrestamo.DisplayMember = "IdPrestamo";
                cbxPrestamo.ValueMember = "IdPrestamo";
                cbxPrestamo.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void FillGrid()
        {
            try
            {
                DgDtPrestamo.AutoGenerateColumns = true;
                DgDtPrestamo.DataSource = UnitOfWork.detallePrestamo.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private DetallePrestamo CaptureData()
        {
            DetallePrestamo d = new DetallePrestamo();

            if (!string.IsNullOrWhiteSpace(txtId.Text))
                d.IdDetalle = Convert.ToInt32(txtId.Text);

            d.IdPrestamo = Convert.ToInt32(cbxPrestamo.SelectedValue);
            d.IdLibro = Convert.ToInt32(cbxLibro.SelectedValue);

            d.FechaDevolucionReal = Convert.ToDateTime(lblFechaEntrega.Text);

            d.Estado = "prestado"; 

            return d;
        }

        private void InsertData()
        {
            try
            {
                
                    DialogResult r = MessageBox.Show("¿Desea guardar el detalle del préstamo?",
                        "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        UnitOfWork.detallePrestamo.Add(CaptureData());
                        ClearText();
                        FillGrid();

                        MessageBox.Show("Detalle registrado exitosamente", "Confirmación",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FrmDetPrestamo()
        {
            InitializeComponent();


        }


        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void DgDtPrestamo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmDetPrestamo_Load(object sender, EventArgs e)
        { 
            FillGrid();
            FillCliente();
            FillLibro();
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void cbxPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPrestamo.SelectedItem is Prestamo p)
            {
                lblFechaEntrega.Text = p.FechaEntrega.ToString("yyyy-MM-dd");
            }
        }
    }
}
