using Estudiantes.DAO;
using Estudiantes.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes.UI
{
    public partial class CursoUI : Form
    {
        private CursoDAO c = new CursoDAO();
        private FrmMenu _mainFrom;

        public CursoUI(FrmMenu main)
        {
            InitializeComponent();
            _mainFrom = main;
        }
        
        private bool ValidateData()
        {
            if (txtNombre.Text.Trim() == "")
                throw new Exception("El campo Nombre es obligatorio.");
            return true;
        }
        private void FillData(int id)
        {
            try
            {
                var x = c.GetById(id);
                if (x != null)
                {
                    txtId.Text = x.IdCurso.ToString();
                    txtNombre.Text = x.Nombre;
                }
                else
                {
                    MessageBox.Show("No se encontró el curso con ese ID.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillGrid()
        {
            try
            {
                dgCursos.DataSource = null;
                dgCursos.DataSource = c.GetAll();
                dgCursos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar cursos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearData()
        {
            txtId.Text = "";
            txtNombre.Clear();
        }

        private Curso CaptureData()
        {
            return new Curso
            {
                IdCurso = string.IsNullOrWhiteSpace(txtId.Text) ? 0 : Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text
            };
        }

        private void AddData()
        {
            try
            {
                if (ValidateData())
                {

                var x = CaptureData();

                    if (MessageBox.Show("¿Desea agregar este curso?", "Confirmar",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        c.Add(x);
                        MessageBox.Show("Curso agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillGrid();
                        ClearData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateData()
        {
            try
            {
                if (ValidateData())
                {
                var x = CaptureData();

                    if (MessageBox.Show("¿Desea actualizar este curso?", "Confirmar",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        c.Update(x);
                        MessageBox.Show("Curso actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillGrid();
                        ClearData();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteData()
        {
            try
            {
                if (ValidateData())
                {

                    int id = Convert.ToInt32(txtId.Text);

                    if (MessageBox.Show("¿Desea eliminar este curso?", "Confirmar",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        c.Delete(id);
                        MessageBox.Show("Curso eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillGrid();
                        ClearData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CursoUI_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() != "")
                FillData(Convert.ToInt32(txtId.Text));
        }

        private void dgCursos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FillData(Convert.ToInt32(dgCursos[0, e.RowIndex].Value));
            }
        }
    }
}
    
