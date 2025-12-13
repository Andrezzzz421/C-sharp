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
    public partial class FrmEditorial : Form
    {

        private void ClearText()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtPais.Text = "";
            txtTelefono.Text = "";

        }

        private void FillText(int id)
        {
            try
            {
                var x = UnitOfWork.editorial.GetById(id);
                if (x != null)
                {
                    txtId.Text = x.id_editorial.ToString();
                    txtNombre.Text = x.nombre;
                    txtPais.Text = x.pais;
                    txtTelefono.Text = x.telefono;
                }
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
                DgEditorial.AutoGenerateColumns = true;
                DgEditorial.DataSource = UnitOfWork.editorial.GetAll();
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
            if (txtPais.Text.Trim() == "")
                throw new Exception("El pais es obligatorio");
            if (txtTelefono.Text.Trim() == "")
                throw new Exception("El telefono es obligatorio");
            return true;
        }

        private Editorial CaptureData()
        {
            Editorial e = new Editorial();
            if (!String.IsNullOrWhiteSpace(txtId.Text))
                e.id_editorial = Convert.ToInt32(txtId.Text);
            e.nombre = txtNombre.Text.Trim();
            e.pais = txtPais.Text.Trim();
            e.telefono = txtTelefono.Text.Trim();
            return e;
        }

        private void InsertData()
        {
            try
            {
                if (ValidateData())
                {
                    DialogResult r = MessageBox.Show("¿Desea guardar la editorial?", "Confirmacion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        UnitOfWork.editorial.Add(CaptureData());
                        ClearText();
                        FillGrid();

                        MessageBox.Show("Editorial guardada exitosamente", "Informacion",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
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
                    DialogResult r = MessageBox.Show("¿Desea actualizar la editorial?", "Confirmacion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        UnitOfWork.editorial.Update(CaptureData());
                        ClearText();
                        FillGrid();
                        MessageBox.Show("Editorial actualizada exitosamente", "Informacion",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void DeleteData()
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea eliminar la editorial?", "Confirmacion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    UnitOfWork.editorial.Delete(Convert.ToInt32(txtId.Text));
                    ClearText();
                    FillGrid();
                    MessageBox.Show("Editorial eliminada exitosamente", "Informacion",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public FrmEditorial()
        {
            InitializeComponent();
        }


        private void FrmEditorial_Load(object sender, EventArgs e)
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

        private void DgEditorial_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > 1)
                FillText(Convert.ToInt32(DgEditorial[0, e.RowIndex].Value));

        }

        private void DgEditorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
