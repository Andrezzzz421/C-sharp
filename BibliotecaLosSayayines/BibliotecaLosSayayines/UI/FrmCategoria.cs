using BibliotecaLosSayayines.DAO;
using BibliotecaLosSayayines.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaLosSayayines.UI
{
    public partial class FrmCategoria : Form
    {

        private void ClearText()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }

        private void FillText(int id)
        {
            try
            {
                var x = UnitOfWork.categoria.GetById(id);
                if (x != null)
                {
                    txtId.Text = x.id_categoria.ToString();
                    txtNombre.Text = x.nombre;
                    txtDescripcion.Text = x.descripcion;
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
                dgCategoria.AutoGenerateColumns = true;
                dgCategoria.DataSource = UnitOfWork.categoria.GetAll();

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
                throw new Exception("Debe Colocar el nombre");
            if (txtDescripcion.Text.Trim() == "")
                throw new Exception("Debe Colocar la Descripcion");
            return true;
        }

        private Categoria CaptureData()
        {
            Categoria c = new Categoria();

            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                c.id_categoria = Convert.ToInt32(txtId.Text);
            }

            c.nombre = txtNombre.Text;
            c.descripcion = txtDescripcion.Text;

            return c;
        }

        private void InsertData()
        {
            try
            {
                if (ValidateData())
                {
                    DialogResult r = MessageBox.Show("¿Desea guardar la categoria?", "Confirmacion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        UnitOfWork.categoria.Add(CaptureData());
                        ClearText();
                        FillGrid();

                        MessageBox.Show("Categoria guardada exitosamente", "Confirmacion",
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
                    DialogResult r = MessageBox.Show("¿Desea actualizar la categoria?", "Confirmacion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        UnitOfWork.categoria.Update(CaptureData());
                        ClearText();
                        FillGrid();
                        MessageBox.Show("Categoria actualizada exitosamente", "Confirmacion",
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
                DialogResult r = MessageBox.Show("¿Desea eliminar la categoria?", "Confirmacion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    UnitOfWork.categoria.Delete(int.Parse(txtId.Text));
                    ClearText();
                    FillGrid();
                    MessageBox.Show("Categoria eliminada exitosamente", "Confirmacion",
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
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void dgCategoria_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > 1)
                FillText(Convert.ToInt32(dgCategoria[0, e.RowIndex].Value));
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
