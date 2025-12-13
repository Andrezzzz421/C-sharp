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
    public partial class FrmGenero : Form
    {
        private void ClearText()
        {
            txtId.Text = "";
            TxtNGenero.Text = "";
        }

        private void FillText(int id)
        {
            try
            {
                var x = UnitOfWork.genero.GetById(id);
                if (x != null)
                {
                    txtId.Text = x.id_genero.ToString();
                    TxtNGenero.Text = x.nombre;
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
                dgGenero.AutoGenerateColumns = true;
                dgGenero.DataSource = UnitOfWork.genero.GetAll();
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
            if (TxtNGenero.Text.Trim() == "")
                throw new Exception("El Genero Es obligatorio");

            return true;
        }
        private Genero CaptureData()
        {
            Genero g = new Genero();
            if (!String.IsNullOrWhiteSpace(txtId.Text))
                g.id_genero = Convert.ToInt32(txtId.Text);
            g.nombre = TxtNGenero.Text.Trim();

            return g;
        }

        private void InsertData()
        {
            try
            {
                if (ValidateData())
                {
                    DialogResult r = MessageBox.Show("¿Desea guardar el genero?", "Confirmacion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        UnitOfWork.genero.Add(CaptureData());
                        ClearText();
                        FillGrid();

                        MessageBox.Show("Genero guardado correctamente", "Informacion",
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
                    DialogResult r = MessageBox.Show("¿Desea actualizar el genero?", "Confirmacion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        UnitOfWork.genero.Update(CaptureData());
                        ClearText();
                        FillGrid();
                        MessageBox.Show("Genero actualizado correctamente", "Informacion",
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
                DialogResult r = MessageBox.Show("¿Desea eliminar el genero?", "Confirmacion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    UnitOfWork.genero.Delete(Convert.ToInt32(txtId.Text));
                    ClearText();
                    FillGrid();
                    MessageBox.Show("Genero eliminado correctamente", "Informacion",
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

        public FrmGenero()
        {
            InitializeComponent();
        }

        private void FrmGenero_Load(object sender, EventArgs e)
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

        private void dgGenero_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > 1)
            {
                FillText(Convert.ToInt32(dgGenero[0, e.RowIndex].Value));
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
