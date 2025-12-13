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
    public partial class FrmAutor : Form
    {

        private void FillGenero()
        {
            try
            {
                cbxGenero.DataSource = null;
                cbxGenero.DataSource = UnitOfWork.genero.GetAll();
                cbxGenero.DisplayMember = "nombre";
                cbxGenero.ValueMember = "id_genero";
                cbxGenero.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void ClearText()
        {
            txtId.Text = "";
            TxtNombre.Text = "";
            TxtPaisOrigen.Text = "";
            dtFechaN.Text = "";
            cbxGenero.SelectedIndex = -1;
        }

        private void FillText(int id)
        {
            try
            {
                var x = UnitOfWork.autor.GetById(id);
                if (x != null)
                {
                    txtId.Text = x.id_autor.ToString();
                    TxtNombre.Text = x.nombre;
                    TxtPaisOrigen.Text = x.pais_origen;
                    dtFechaN.Text = x.fehcanacimiento.ToString();
                    cbxGenero.SelectedValue = x.id_genero;
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
                DgAutor.AutoGenerateColumns = true;
                DgAutor.DataSource = UnitOfWork.autor.GetDTO();
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
            if (TxtNombre.Text.Trim() == "")
                throw new Exception("El nombre es obligatorio");
            if (TxtApellido.Text.Trim() == "")
                throw new Exception("El apellido es obligatorio");
            if (TxtApellido.Text.Trim() == "")
                throw new Exception("El pais de origen es obligatorio");
            if (TxtPaisOrigen.Text.Trim() == "")
                throw new Exception("La fecha de nacimiento es obligatoria");

            return true;
        }

        private Autor CaptureData()
        {
            Autor a = new Autor();
            if (!string.IsNullOrWhiteSpace(txtId.Text))
                a.id_autor = Convert.ToInt32(txtId.Text);
            a.nombre = TxtNombre.Text.Trim();
            a.apellido = TxtApellido.Text.Trim();
            a.pais_origen = TxtPaisOrigen.Text.Trim();
            a.fehcanacimiento = Convert.ToDateTime(dtFechaN.Text);
            a.id_genero = Convert.ToInt32(cbxGenero.SelectedValue);
            a.biografia = TxtBiografia.Text.Trim();

            return a;
        }

        private void InsertData()
        {
            try
            {
                if (ValidateData())
                {
                    DialogResult r = MessageBox.Show("¿Desea guardar el autor?", "Confirmacion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        UnitOfWork.autor.Add(CaptureData());
                        ClearText();
                        FillGrid();
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
                    DialogResult r = MessageBox.Show("¿Desea actualizar el autor?", "Confirmacion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        UnitOfWork.autor.Update(CaptureData());
                        ClearText();
                        FillGrid();
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
                DialogResult r = MessageBox.Show("¿Desea eliminar el autor?", "Confirmacion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    UnitOfWork.autor.Delete(Convert.ToInt32(txtId.Text));
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
        public FrmAutor()
        {
            InitializeComponent();
        }

        private void FrmAutor_Load(object sender, EventArgs e)
        {
            FillGrid();
            FillGenero();
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

        private void DgAutor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > 1)
                FillText(Convert.ToInt32(DgAutor[0, e.RowIndex].Value));

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
