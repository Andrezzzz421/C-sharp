using Productos.DAO;
using Productos.HELPERS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos.UI
{
    public partial class FrmConsultas : Form
    {
        private void CargarCategoria()
        {
            CategoriaDAO categoriaDao = new CategoriaDAO();
            var listaCategoria = categoriaDao.GetAll();

            cmbCG.DataSource = listaCategoria;
            cmbCG.DisplayMember = "Nombre";
            cmbCG.ValueMember = "Id";
        }
        public FrmConsultas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            var resultado = HELPproductos.BuscarPorNombre(nombre);

            dgConsultas.DataSource = null;
            dgConsultas.DataSource = resultado;

            if (dgConsultas.Columns["Foto"] is DataGridViewImageColumn col)
            {
                col.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }

            if (resultado.Count == 0)
            {
                MessageBox.Show("No se encontraron productos con ese nombre.");
            }
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltro.SelectedItem != null && cmbFiltro.SelectedItem.ToString() == "Igual")
            {
                lblPrecio.Visible = true;
                txtFiltro.Visible = true;
            }
            else
            {
                lblPrecio.Visible = false;
                txtFiltro.Visible = false;
            }
        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            lblPrecio.Visible = false;
            txtFiltro.Visible = false;
            CargarCategoria();

        }

        private void btnBuscarPrecioM_Click(object sender, EventArgs e)
        {
            string orden = cmbFiltro.SelectedItem?.ToString() ?? "";

            if (orden.ToLower() == "igual")
            {
                if (double.TryParse(txtFiltro.Text, out double precio))
                {
                    dgConsultas.DataSource = null;
                    dgConsultas.DataSource = HELPproductos.OrdenarPorPrecioVenta(orden,precio);
                }
                else
                {
                    MessageBox.Show("Por favor ingresa un número válido.");
                }
            }
            else
            {
                dgConsultas.DataSource = null;
                dgConsultas.DataSource = HELPproductos.OrdenarPorPrecioVenta(orden);
            }
        }

        private void cmbCG_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnBuscarCategoria_Click_1(object sender, EventArgs e)
        {
            string nombreCategoria = cmbCG.Text;


            var resultado = HELPproductos.BuscarPorCategoria(nombreCategoria);

            dgConsultas.DataSource = null;
            dgConsultas.DataSource = resultado;
        }
    }
}
