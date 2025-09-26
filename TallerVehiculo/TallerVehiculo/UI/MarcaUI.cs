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
    public partial class MarcaUI : Form
    {
        private MarcaDAO dao = new MarcaDAO();

        private void ClearData()
        {
            txtId.Text = "";
            txtNombre.Clear();
            txtPaisOrigen.Clear();
        }

        private void FillGrid()
        {
            try
            {
                dgMarcas.DataSource = null;
                dgMarcas.DataSource = dao.GetAll();
                dgMarcas.Refresh();

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
                    txtNombre.Text = x.Nombre;
                    txtPaisOrigen.Text = x.PaisOrigen;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateData() 
        {
            if (txtId.Text.Trim() == "")
                throw new Exception("Falta el ID");
            if (txtNombre.Text.Trim() == "")
                throw new Exception("Falta el Nombre");
            if (txtPaisOrigen.Text.Trim() == "")
                throw new Exception("Falta el Pais de Origen");
            return true;
        }

        private Marca CaptureData()
        {
            Marca ob = new Marca();
            ob.Id = Convert.ToInt32(txtId.Text);
            ob.Nombre = txtNombre.Text;
            ob.PaisOrigen = txtPaisOrigen.Text;
            ob.FechaCreacion = DateTime.Today;
            return ob;
        }

        private void AddData()
        {
            try
            {
                if (ValidateData())
                {
                    var x = CaptureData();
                    if (MessageBox.Show("Desea Agregar?", "Confirmar", MessageBoxButtons.OKCancel)
                        == DialogResult.OK)
                    {
                        dao.Add(x);
                        FillGrid();
                        ClearData();
                    }
                }
            }catch (Exception ex)
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
                    if (MessageBox.Show("Desea Modificar?", "Confirmar", MessageBoxButtons.OKCancel)
                        == DialogResult.OK)
                    {
                        dao.Update(x);
                        FillGrid();
                        ClearData();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteData()
        {
            try
            {
                if(ValidateData())
                {
                    var x = CaptureData();
                    if (MessageBox.Show("Desea Eliminar?", "Confirmar", MessageBoxButtons.OKCancel)
                        == DialogResult.OK)
                    {
                        dao.Delete(x.Id);
                        FillGrid();
                        ClearData();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public MarcaUI()
        {
            InitializeComponent();
        }

        private void MarcaUI_Load(object sender, EventArgs e)
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

        private void dgMarcas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if(f >= 0)
            {
                FillData(Convert.ToInt32(dgMarcas[0, f].Value));
            }
        }

        private void MarcaUI_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
