using Estudiantes.DAO;
using Estudiantes.DTO;
using Estudiantes.HELPER;
using Estudiantes.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes.UI
{
    public partial class EstudianteUI : Form
    {
        private CursoDAO cDao = new CursoDAO();
        private EstudianteDAO eDao = new EstudianteDAO();
        private FrmMenu _mainForm;
        private void SearchImage()
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image|*.jpg;*.jpeg;*.png;*.bmp";
            if (op.ShowDialog() == DialogResult.OK)
            {
                picImage.Image = Image.FromFile(op.FileName);
            }
        }

        private void DeleteImage()
        {
            picImage.Image = null;
            picImage.ImageLocation = null;
        }

        private void FillEstudiante()
        {
            try
            {
                var lista = eDao.GetDTO();
                BindingSource bs = new BindingSource();
                bs.DataSource = lista;
                dgEstudiantes.DataSource = bs;
                if (dgEstudiantes.Columns["Foto"] is DataGridViewImageColumn col)
                {
                    col.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
                dgEstudiantes.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los estudiantes: " + ex.Message);
            }
        }
        private void FillCurso()
        {
            try
            {
                cbmCurso.DataSource = null;
                cbmCurso.DataSource = cDao.GetAll();
                cbmCurso.DisplayMember = "Nombre";
                cbmCurso.ValueMember = "IdCurso";
                cbmCurso.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los cursos: " + ex.Message);
            }
        }
        private void ClearData()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtDocumento.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtEstatura.Clear();
            txtPeso.Clear();
            cbmCurso.SelectedIndex = 0;
            cbmTpSanguineo.SelectedIndex = 0;
            chcMinoria.Checked = false;
            picImage.Image = null;
        }

        private void FillData(int id)
        {
            try
            {
                var x = eDao.GetById(id);
                if (x != null)
                {
                    txtId.Text = x.IdEstudiante.ToString();
                    txtDocumento.Text = x.Documento;
                    txtNombre.Text = x.Nombre;
                    txtApellido.Text = x.Apellido;
                    txtCorreo.Text = x.Correo;
                    txtEstatura.Text = x.Estatura.ToString();
                    txtPeso.Text = x.Peso.ToString();
                    cbmCurso.SelectedValue = x.IdCurso;
                    chcMinoria.Checked = x.Minoria;
                    cbmTpSanguineo.SelectedItem = x.TipoSanguineo;
                    if (x.Foto != null && x.Foto.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(x.Foto))
                        {
                            picImage.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        picImage.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
        private bool ValidateData()
        {

            if (txtDocumento.Text.Trim() == "")
                throw new Exception("El campo Documento es obligatorio.");
            if (txtNombre.Text.Trim() == "")
                throw new Exception("El campo Nombre es obligatorio.");
            if (txtApellido.Text.Trim() == "")
                throw new Exception("El campo Apellido es obligatorio.");
            if (txtCorreo.Text.Trim() == "")
                throw new Exception("El campo Correo es obligatorio.");
            if (txtPeso.Text.Trim() == "")
                throw new Exception("El campo Peso es obligatorio.");
            if (txtEstatura.Text.Trim() == "")
                throw new Exception("El campo Estatura es obligatorio.");
            return true;
        }

        private Estudiante CaptureData(bool isUpdate = false)
        {
            Estudiante est = new Estudiante();

            if (isUpdate && !string.IsNullOrWhiteSpace(txtId.Text))
            {
                est.IdEstudiante = Convert.ToInt32(txtId.Text);
            }

            est.Documento = txtDocumento.Text;
            est.Nombre = txtNombre.Text;
            est.Apellido = txtApellido.Text;
            est.Correo = txtCorreo.Text;
            est.Peso = Convert.ToDecimal(txtPeso.Text);
            est.Estatura = Convert.ToDecimal(txtEstatura.Text);
            est.Minoria = chcMinoria.Checked;
            est.IdCurso = Convert.ToInt32(cbmCurso.SelectedValue);
            if (cbmTpSanguineo.SelectedItem != null)
                est.TipoSanguineo = cbmTpSanguineo.SelectedItem.ToString();
            else
                est.TipoSanguineo = string.Empty;


            if (picImage.Image != null)
            {
                est.Foto = APHelper.toByteArray(picImage.Image);
            }
            else
            {
                est.Foto = null;
            }


            return est;
        }

        private void AddData()
        {
            try
            {
                if (ValidateData())
                {
                    var x = CaptureData();
                    if (MessageBox.Show("Desea agregar este estudiante?", "Confirmar",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        eDao.Add(x);
                        FillEstudiante();
                        ClearData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el estudiante: " + ex.Message);
            }
        }

        private void UpdateData()
        {
            try
            {
                if (ValidateData())
                {
                    var x = CaptureData(true);
                    if (MessageBox.Show("Desea actualizar este estudiante?", "Confirmar",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        eDao.Update(x);
                        FillEstudiante();
                        ClearData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el estudiante: " + ex.Message);
            }
        }

        private void DeleteData()
        {
            try
            {
                var x = CaptureData(true);
                if (MessageBox.Show("Desea Eliminar este estudiante?", "Confirmar", MessageBoxButtons.OKCancel)
                    == DialogResult.OK)
                {
                    if (eDao.Delete(x.IdEstudiante))
                    {
                        FillEstudiante();
                        ClearData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el estudiante: " + ex.Message);
            }
        }

        public EstudianteUI(FrmMenu main)
        {
            InitializeComponent();
            _mainForm = main;
        }

        private void EstudianteUI_Load(object sender, EventArgs e)
        {
            cDao.GetAll();
            FillCurso();
            FillEstudiante();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void picSearchImage_Click(object sender, EventArgs e)
        {
            SearchImage();
        }

        private void picDeleteImage_Click(object sender, EventArgs e)
        {
            DeleteImage();
        }

        private void dgEstudiantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f > -1)
                FillData(Convert.ToInt32(dgEstudiantes[0, f].Value));
        }

        private void picSearchAt_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() != "")
                FillData(Convert.ToInt32(txtId.Text));

        }
    }
}
