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
    public partial class FrmClientes : Form
    {

        private void ClearText()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            TxtApellido.Text = "";
            TxtDocumento.Text = "";
            TxtDireccion.Text = "";
            TxtTelefono.Text = "";
            TxtCorreo.Text = "";
        }

        private void FillText(int id)
        {
            try
            {
                var x = UnitOfWork.cliente.GetById(id);
                if (x != null)
                {
                    txtId.Text = x.IdCliente.ToString();
                    txtNombre.Text = x.Nombre;
                    TxtApellido.Text = x.Apellido;
                    TxtDocumento.Text = x.Documento;
                    TxtTelefono.Text = x.Telefono;
                    TxtCorreo.Text = x.Correo;
                    TxtDireccion.Text = x.Direccion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillGrid()
        {
            try
            {
                dgCliente.AutoGenerateColumns = true;
                dgCliente.DataSource = UnitOfWork.categoria.GetAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool ValidateData()
        {
            if (txtNombre.Text.Trim() == "")
                throw new Exception("El nombre es obligatorio");
            if (TxtApellido.Text.Trim() == "")
                throw new Exception("El apellido es obligatorio");
            if (TxtDocumento.Text.Trim() == "")
                throw new Exception("El documento es obligatorio");
            if (TxtCorreo.Text.Trim() == "")
                throw new Exception("El correo es obligatorio");
            return true;
        }

        private Cliente CaptureData()
        {
            Cliente c = new Cliente();
            if (!string.IsNullOrWhiteSpace(txtId.Text))
                c.IdCliente = Convert.ToInt32(txtId.Text.Trim());
            c.Nombre = txtNombre.Text.Trim();
            c.Apellido = TxtApellido.Text.Trim();
            c.Documento = TxtDocumento.Text.Trim();
            c.Telefono = TxtTelefono.Text.Trim();
            c.Correo = TxtCorreo.Text.Trim();
            c.Direccion = TxtDireccion.Text.Trim();
            return c;
        }

        private void InsertData()
        {
            try
            {

                DialogResult r = MessageBox.Show("¿Desea guardar el cliente", "Confirmacion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (r == DialogResult.Yes)
                {
                    UnitOfWork.cliente.Add(CaptureData());
                    ClearText();
                    FillGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void UpdateData()
        {
            try
            {
                if (ValidateData())
                {
                    DialogResult r = MessageBox.Show("¿Desea actualizar el cliente", "Confirmacion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        UnitOfWork.cliente.Update(CaptureData());
                        ClearText();
                        FillGrid();
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void DeleteData()
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea eliminar el cliente?", "Confirmacion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    UnitOfWork.cliente.Delete(Convert.ToInt32(txtId.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
                DeleteData();
        }

        private void dgCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > 1)
            {
                FillText(Convert.ToInt32(dgCliente[0, e.RowIndex].Value));
            }
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
    }
}
