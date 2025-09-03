using EmpresaV1.DAO;
using EmpresaV1.HELPER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaV1.UI
{
    public partial class FrmConsultas : Form
    {
        private void CargarCategoria()
        {
            CargoDAO categoriaDao = new CargoDAO();
            var listaCategoria = categoriaDao.GetAll();

            cmbCargo.DataSource = listaCategoria;
            cmbCargo.DisplayMember = "Nombre";
            cmbCargo.ValueMember = "Id";
        }

        public FrmConsultas()
        {
            InitializeComponent();
        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            CargarCategoria();
        }

        private void btnBuscarContenerNom_Click(object sender, EventArgs e)
        {
            string texto = txtNombre.Text.Trim();
            string tipo = cmbFiltroNombre.SelectedItem?.ToString() ?? "contiene";

            var resultado = EMHelpers.BuscarPorNombre(texto, tipo);

            dgConsultas.DataSource = null;
            dgConsultas.DataSource = resultado;

            if (resultado.Count == 0)
            {
                MessageBox.Show("No se encontraron empleados.");
            }
        }

        private void btnBuscarGenero_Click(object sender, EventArgs e)
        {
            string generoSeleccionado = cmbGenero.SelectedItem?.ToString() ?? "";
            string generoPersonalizado = "";

            if (generoSeleccionado.ToLower() == "otro")
            {
                if (string.IsNullOrWhiteSpace(txtFiltroGenero.Text))
                {
                    MessageBox.Show("Por favor escribe un género personalizado.");
                    return; 
                }
                generoPersonalizado = txtFiltroGenero.Text.Trim();
            }

            var resultado = EMHelpers.BuscarPorGenero(generoSeleccionado, generoPersonalizado);

            dgConsultas.DataSource = null;
            dgConsultas.DataSource = resultado;

            if (resultado.Count == 0)
            {
                MessageBox.Show("No se encontraron empleados con ese género.");
            }
        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (cmbGenero.SelectedItem != null &&
                cmbGenero.SelectedItem.ToString().ToLower() == "otro")
            {
                txtFiltroGenero.Visible = true;
            }
            else
            {
                txtFiltroGenero.Visible = false;
                txtFiltroGenero.Text = ""; 
            }
        }

        private void btnBuscarCargo_Click(object sender, EventArgs e)
        {
            string nombreCargo =cmbCargo.Text;


            var resultado = EMHelpers.BuscarPorCargo(nombreCargo);

            dgConsultas.DataSource = null;
            dgConsultas.DataSource = resultado;
        }

        private void cmbFiltroSalario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroSalario.SelectedItem != null && cmbFiltroSalario.SelectedItem.ToString() == "Igual")
            {
                lblSalario.Visible = true;
                txtFiltroSalario.Visible = true;
            }
            else
            {
                lblSalario.Visible = false;
                txtFiltroSalario.Visible = false;
            }
        }

        private void btnBuscarSalario_Click(object sender, EventArgs e)
        {
            string orden = cmbFiltroSalario.SelectedItem?.ToString() ?? "";

            if (orden.ToLower() == "igual")
            {
                if (double.TryParse(txtFiltroSalario.Text, out double salario))
                {
                    dgConsultas.DataSource = null;
                    dgConsultas.DataSource = EMHelpers.OrdenarPorSalario(orden, salario);
                }
                else
                {
                    MessageBox.Show("Por favor ingresa un número válido.");
                }
            }
            else
            {
                dgConsultas.DataSource = null;
                dgConsultas.DataSource = EMHelpers.OrdenarPorSalario(orden);
            }
        }
    }
}

