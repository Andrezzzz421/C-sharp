using Estudiantes.DAO;
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
    public partial class FrmConsultas : Form
    {
        private FrmMenu _mainmenu;
        private EstudianteDAO eDao = new EstudianteDAO();
        public FrmConsultas(FrmMenu main)
        {
            InitializeComponent();
            _mainmenu = main;
        }
        private void FillGrid()
        {
            var lista = eDao.GetDTO();
            dgConsultas.DataSource = lista;


            if (dgConsultas.Columns["Foto"] is DataGridViewImageColumn col)
            {
                col.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }

            dgConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgConsultas.RowTemplate.Height = 20;
            dgConsultas.Refresh();
        }

        private void Buscar(string filtro)
        {
            var lista = eDao.BuscarPorNombreoApellido(filtro);
            dgConsultas.DataSource = lista;

            if (dgConsultas.Columns["Foto"] is DataGridViewImageColumn col)
            {
                col.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }

        }
        private void FrmConsultas_Load(object sender, EventArgs e)
        {

            btnMayorEstatura.Visible = false;
            btnMenorEstatura.Visible = false;
            btnMayorPeso.Visible = false;
            btnMenorPeso.Visible = false;
            FillGrid();
        }

        private void btnBuscarNombreApellido_Click(object sender, EventArgs e)
        {
            string filtro = txtFiltro.Text.Trim();
            if (string.IsNullOrEmpty(filtro))
            {
                FillGrid();
            }
            else
            {
                Buscar(filtro);
            }
        }

        private void btnTipoSangre_Click(object sender, EventArgs e)
        {
            string tipo = txtFiltro.Text.Trim();
            if (string.IsNullOrEmpty(tipo))
            {
                FillGrid();
            }
            else
            {
                var lista = eDao.BuscarPorTipoSanguineo(tipo);
                dgConsultas.DataSource = lista;

                if (dgConsultas.Columns["Foto"] is DataGridViewImageColumn col)
                {
                    col.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
        }

        private void btnPorEstatatura_Click(object sender, EventArgs e)
        {
            bool mostrarBotones = !btnMayorEstatura.Visible;

            btnMayorEstatura.Visible = mostrarBotones;
            btnMenorEstatura.Visible = mostrarBotones;

            txtFiltro.Visible = !mostrarBotones;

            btnPorEstatatura.Text = mostrarBotones ? "Cancelar filtro por estatura" : "Filtrar por estatura";
        }

        private void btnMenorEstatura_Click(object sender, EventArgs e)
        {
            var lista = eDao.GetDTO().OrderBy(e => e.Estatura).ToList();
            dgConsultas.DataSource = lista;

            if (dgConsultas.Columns["Foto"] is DataGridViewImageColumn col)
                col.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void btnMayorEstatura_Click(object sender, EventArgs e)
        {
            var lista = eDao.GetDTO().OrderByDescending(e => e.Estatura).ToList();
            dgConsultas.DataSource = lista;

            if (dgConsultas.Columns["Foto"] is DataGridViewImageColumn col)
                col.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void btnPorPeso_Click(object sender, EventArgs e)
        {
            bool mostrarBotones = !btnMayorPeso.Visible;

            btnMayorPeso.Visible = mostrarBotones;
            btnMenorPeso.Visible = mostrarBotones;
            txtFiltro.Visible = !mostrarBotones;
            btnPorPeso.Text = mostrarBotones ? "Cancelar filtro por peso" : "Filtrar por peso";
        }

        private void btnMenorPeso_Click(object sender, EventArgs e)
        {
            var lista = eDao.GetDTO().OrderBy(e => e.Peso).ToList();
            dgConsultas.DataSource = lista;

            if (dgConsultas.Columns["Foto"] is DataGridViewImageColumn col)
            {
                col.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
        }

        private void btnMayorPeso_Click(object sender, EventArgs e)
        {
            var lista = eDao.GetDTO().OrderByDescending(e => e.Peso).ToList();
            dgConsultas.DataSource = lista;
            if (dgConsultas.Columns["Foto"] is DataGridViewImageColumn col)
            {
                col.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
        }
    }
}
