using EmpresaV1.DAO;
using EmpresaV1.HELPER;
using EmpresaV1.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaV1.UI
{
    public partial class Empleados : Form
    {
        private EmpleadoDAO dao = new EmpleadoDAO();
        private String rutaImagen = "";
        bool isDraggin = false;
        Point startPoint;
        private void CargarCargos()
        {
            CargoDAO cargoDao = new CargoDAO();
            var listacargos = cargoDao.GetAll();

            cmbCargo.DataSource = listacargos;
            cmbCargo.DisplayMember = "Nombre";
            cmbCargo.ValueMember = "Id";
        }
        private void CLoseForm()
        {
            DialogResult x = MessageBox.Show("¿Desea cerrar el formulario?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void SearchImage()
        {
            var x = openFileDialog1.ShowDialog();
            if (x == DialogResult.OK)
            {
                rutaImagen = openFileDialog1.FileName;
                picimage.Image = Image.FromFile(rutaImagen);
            }
        }

        private void DeleteImage()
        {
            picimage.Image = null;
            rutaImagen = "";
        }
        private void FillGrid()
        {
            var lista = dao.GetDTO();
            BindingSource bs = new BindingSource();
            bs.DataSource = lista;
            dgEmpleados.DataSource = bs;
            if (dgEmpleados.Columns["Foto"] is DataGridViewImageColumn col)
            {
                col.ImageLayout = DataGridViewImageCellLayout.Zoom; 
            }
            dgEmpleados.Refresh();
        }
        

        private void Clear()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();
            cmbCargo.SelectedIndex = -1;
            dtNacimiento.Value = DateTime.Now;
            dtFechcontra.Value = DateTime.Now;
            txtSalario.Clear();
            chcEstado.Checked = false;
            picimage.Image = null;

        }

        private void FillData(int id)
        {
            var obj = dao.GetById(id);
            if (obj != null)
            {
                Clear();
                txtId.Text = obj.Id.ToString();
                txtNombre.Text = obj.Nombre.ToString();
                txtApellido.Text = obj.Apellido.ToString();
                txtDocumento.Text = obj.DocumentoIdentidad.ToString();
                cmbCargo.SelectedValue = obj.Cargo;
                dtNacimiento.Value = obj.FechaNacimiento;
                dtFechcontra.Value = obj.FechaContratacion;
                txtSalario.Text = obj.Salario.ToString();
                chcEstado.Checked = obj.Estado;
                if (obj.Foto != null)
                    picimage.Image = EMHelpers.toImage(obj.Foto);
            }
        }

        private Empleado Capture()
        {
            Empleado x = new Empleado();
            x.Id = Convert.ToInt32(txtId.Text);
            x.Nombre = txtNombre.Text.ToUpper();
            x.Apellido = txtApellido.Text.ToUpper();
            x.DocumentoIdentidad = txtDocumento.Text;
            x.Cargo = Convert.ToInt32(cmbCargo.SelectedValue);
            x.FechaContratacion = dtFechcontra.Value;
            x.Estado = chcEstado.Checked;
            x.FechaNacimiento = dtNacimiento.Value;
            x.Salario = Convert.ToDouble(txtSalario.Text);
            if (!string.IsNullOrEmpty(rutaImagen))
                x.Foto = EMHelpers.ToBytes(rutaImagen);
            return x;
        }

        private void Add()
        {
            try
            {
                var emp = MessageBox.Show("Desea agregar?", "Confirmacion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (emp == DialogResult.Yes)
                {
                    dao.Add(Capture());
                    Clear();
                    FillGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update()
        {
            try
            {
                var emp = MessageBox.Show("Desea Actualizar?", "Confirmacion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (emp == DialogResult.Yes)
                {
                    dao.Update(Capture());
                    Clear();
                    FillGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete()
        {
            try
            {
                var emp = MessageBox.Show("Desea agregar?", "Confirmacion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (emp == DialogResult.Yes)
                {
                    dao.Delete(Capture().Id);
                    Clear();
                    FillGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Initializer()
        {
            EMHelpers.Seed();
            CargarCargos();
            FillGrid();
            cmbCargo.SelectedIndex = -1;

        }

        public Empleados()
        {
            InitializeComponent();
        }
        private void Empleados_Load(object sender, EventArgs e)
        {
            Initializer();
        }
        private void btnCargos_Click(object sender, EventArgs e)
        {
            Cargos frm = new Cargos();
            frm.Show();
            this.Hide();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            CLoseForm();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void picSearchimg_Click(object sender, EventArgs e)
        {
            SearchImage();
        }

        private void picDeleteimg_Click(object sender, EventArgs e)
        {
            DeleteImage();
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() != "")
                FillData(Convert.ToInt32(txtId.Text));
        }

        private void dgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f > -1)
                FillData(Convert.ToInt32(dgEmpleados[0, f].Value));

        }

        private void Empleados_MouseDown(object sender, MouseEventArgs e)
        {
            isDraggin = true;
            startPoint = e.Location;
        }

        private void Empleados_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraggin)
            {
                Point p = this.PointToScreen(e.Location);
                this.Location = new Point(this.Left + (p.X - this.Left - startPoint.X),
                                  this.Top + (p.Y - this.Top - startPoint.Y));
            }

            }

        private void Empleados_MouseUp(object sender, MouseEventArgs e)
        {
            isDraggin = false;
        }
    }
}

