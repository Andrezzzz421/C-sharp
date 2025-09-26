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
using TallerVehiculo.DTO;
using TallerVehiculo.Model;

namespace TallerVehiculo.UI
{
    public partial class VehiculoUI : Form
    {    
        private MarcaDAO mrDAO = new MarcaDAO();
        private PropietarioDAO prDAO = new PropietarioDAO();
        private VehiculoDAO vDAO = new VehiculoDAO();

        private void SearchImage()
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image|*.png";
            if (op.ShowDialog() == DialogResult.OK)
            {
                picImage.ImageLocation= op.FileName;
            }
        }

        private void DeleteImage()
        {
            picImage.ImageLocation = null;
        }

        private void FillMarcas()
        {
            try
            {
                cmbMarca.DataSource = null;
                cmbMarca.DataSource = mrDAO.GetAll();
                cmbMarca.DisplayMember = "Nombre";
                cmbMarca.ValueMember = "Id";
                cmbMarca.Refresh();
            }
            catch(Exception )
            {
            }
        }

        private void FillPropietarios()
        {
            try
            {
                
                cbmPropietario.DataSource = null;
                cbmPropietario.DataSource = new PropietarioDAO().GetAll();
                cbmPropietario.DisplayMember = "Nombre";
                cbmPropietario.ValueMember = "Id";
                cbmPropietario.Refresh();
            }
            catch (Exception)
            {
            }
        }

        private void FillVehiculos()
        {
            try
            {
                dgVehiculo.DataSource = null;
                dgVehiculo.DataSource = vDAO.GetAllDTO();
                dgVehiculo.Refresh();
            }
            catch (Exception)
            {
            }
        }
        public VehiculoUI()
        {
            InitializeComponent();
        }

        private void VehiculoUI_Load(object sender, EventArgs e)
        {

           mrDAO.GetAll();
           prDAO.GetAll();
           FillMarcas();
           FillPropietarios();
           FillVehiculos();
        }
        private void ClearData()
        {
            txtPlaca.Text = "";
            txtColor.Clear();
            txtModelo.Clear();
            cbmPropietario.SelectedValue = 0;
            cmbMarca.SelectedValue = 0;
        }

        private void FillData(string id)
        {
            try
            {
                var x = vDAO.GetById(id);
                if (x != null)
                {
                    txtPlaca.Text = x.Placa.ToUpper();
                    txtColor.Text = x.Color.ToUpper();
                    txtModelo.Text = x.Modelo.ToUpper();
                    cmbMarca.SelectedValue = x.IdMarca;
                    cbmPropietario.SelectedValue = x.IdPropietario;
                    picImage.ImageLocation = x.Foto;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateData()
        {
            if(txtPlaca.Text.Trim() == "")
                throw new Exception("Falta la Placa");
            if (txtColor.Text.Trim() == "")
                throw new Exception("Falta el Color");
            if (txtModelo.Text.Trim() == "")
                throw new Exception("Falta el Modelo");
            if(txtAnioProduccion.Text.Trim() == "")
                throw new Exception("Falta el Año de Producción");
            return true;
        }

        private Vehiculo CaptureData()
        {
            Vehiculo ob = new Vehiculo();
            ob.Placa = txtPlaca.Text.ToUpper();
            ob.Color = txtColor.Text.ToUpper();
            ob.Modelo = txtModelo.Text.ToUpper();
            ob.AnioProduccion = Convert.ToInt32(txtAnioProduccion.Text);
            ob.Foto = picImage.ImageLocation;
            ob.IdMarca = Convert.ToInt32(cmbMarca.SelectedValue);
            ob.IdPropietario = Convert.ToInt32(cbmPropietario.SelectedValue);
            return ob;
        }

        private void AddData()
        {
            try
            {
                if (ValidateData())
                {
                    var x = CaptureData();
                    if(MessageBox.Show("Desea Agregar?","Confirmar",MessageBoxButtons.OKCancel)==
                        DialogResult.OK)
                    {
                        vDAO.Add(x);
                        FillVehiculos();
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
                    if (MessageBox.Show("Desea Actualizar?", "Confirmar", MessageBoxButtons.OKCancel) ==
                        DialogResult.OK)
                    {
                        vDAO.Update(x);
                        FillVehiculos();
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
                if (MessageBox.Show("Desea Eliminar?", "Confimar", MessageBoxButtons.OKCancel)
                    == DialogResult.OK)
                {
                    if (vDAO.Delete(x.Placa))
                    {
                        FillVehiculos();
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

        private void dgVehiculo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if(f > -1)
                FillData(dgVehiculo[0,f].Value.ToString());
        }

        private void VehiculoUI_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
