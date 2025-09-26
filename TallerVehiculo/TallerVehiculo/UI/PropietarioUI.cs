using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerVehiculo.DAO;
using TallerVehiculo.Model;

namespace TallerVehiculo.UI
{
    public partial class PropietarioUI : Form
    {
        private PropietarioDAO dao = new PropietarioDAO(); 

        private void ClearData()
        {
            txtId.Text = "";
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            dtFechaNacimiento.Value = DateTime.Now;

        }
        
        private void FillGrid()
        {
            try
            {
                dgPropietarios.DataSource = null;
                dgPropietarios.DataSource = dao.GetAll();
                dgPropietarios.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillData(int id)
        {
            try
            {
                var x = dao.GetById(id);
                if (x != null)
                {
                    txtId.Text = x.Id.ToString();
                    txtNombre.Text = x.Nombre.ToUpper();
                    txtDireccion.Text = x.Direccion.ToUpper();
                    txtTelefono.Text = x.Telefono;
                    txtCorreo.Text = x.Correo;
                    dtFechaNacimiento.Value = x.FechaNacimiento;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateData()
        {
            if (txtId.Text.Trim() == "")
                throw new Exception("Falta el Id");
            if (txtNombre.Text.Trim() == "")
                throw new Exception("Falta el Nombre");
            if (txtDireccion.Text.Trim() == "")
                throw new Exception("Falta la Direccion");
            if (txtTelefono.Text.Trim() == "")
                throw new Exception("Falta el Telefono");
            if (txtCorreo.Text.Trim() == "")
                throw new Exception("Falta el Correo");
            return true;
        }

        private Propietario CaptureData()
        {
            Propietario p = new Propietario();
            p.Id = int.Parse(txtId.Text.Trim());
            p.Nombre = txtNombre.Text.Trim().ToUpper();
            p.Direccion = txtDireccion.Text.Trim().ToUpper();
            p.Telefono = txtTelefono.Text.Trim();
            p.Correo = txtCorreo.Text.Trim();
            p.FechaNacimiento = dtFechaNacimiento.Value;
            p.FechaCreacion = DateTime.Today;
            return p;
        }
        private void AddData()
        {
            try
            {
                if (ValidateData())
                {
                    var x = CaptureData();
                    if(MessageBox.Show("Desea Agregar?","Confirmar",MessageBoxButtons.OKCancel)
                        ==DialogResult.OK)
                    {
                        dao.Add(x);
                        FillGrid();
                        ClearData();
                    }
                }
            }catch(Exception ex)
            {
                   MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateData()
        {
            try
            {
                if (ValidateData())
                {
                    var x = CaptureData();
                    if (MessageBox.Show("Desea Actualizar?", "Confirmar", MessageBoxButtons.OKCancel)
                        == DialogResult.OK)
                    {
                        dao.Update(x);
                        FillGrid();
                        ClearData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteData()
        {
            try
            {
                var x = CaptureData();
                if(MessageBox.Show("Desea Eliminar?","Confimar",MessageBoxButtons.OKCancel)
                    == DialogResult.OK)
                {
                    if(dao.Delete(x.Id))
                    {
                        FillGrid();
                        ClearData();
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar, tiene vehiculos asociados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public PropietarioUI()
        {
            InitializeComponent();
        }

        private void PropietarioUI_Load(object sender, EventArgs e)
        {
            FillGrid();
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

        private void dgPropietarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f > -1)
                FillData(Convert.ToInt32(dgPropietarios[0, f].Value));
        }

        private void PropietarioUI_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
