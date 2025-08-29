using Productos.DAO;
using Productos.HELPERS;
using Productos.MODEL;
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
    public partial class FrmProductos : Form
    {
        private ProductoDAO dao = new ProductoDAO();
        private String rutaImagen = "";
        private void CargarCategoria()
        {
            CategoriaDAO categoriaDao = new CategoriaDAO();
            var listaCategoria = categoriaDao.GetAll();

            cmbCategoria.DataSource = listaCategoria;
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "Id";
        }

        private void CloseForm()
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
                picFoto.Image = Image.FromFile(rutaImagen);
            }
        }

        private void DeleteImage()
        {
            picFoto.Image = null;
            rutaImagen = "";
        }

        private void FillGrid()
        {
            var lista = dao.GetDTO();
            BindingSource bs = new BindingSource();
            bs.DataSource = lista;
            dgProductos.DataSource = bs;
            if (dgProductos.Columns["Foto"] is DataGridViewImageColumn col)
            {
                col.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            dgProductos.Refresh();
        }

        private void Clear()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtCantidad.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            cmbCategoria.SelectedIndex = -1;
            picFoto.Image = null;
            chcDisponible.Checked = false;
        }

        private void FillData(int id)
        {
            var obj = dao.GetById(id);
            if(obj != null)
            {
                txtId.Text = obj.Id.ToString();
                txtNombre.Text = obj.Nombre;
                txtCantidad.Text = obj.Cantidad.ToString();
                txtPrecioCompra.Text = obj.PrecioCompra.ToString();
                txtPrecioVenta.Text = obj.PrecioVenta.ToString();
                cmbCategoria.SelectedValue = obj.Categoria;
                chcDisponible.Checked = obj.Disponible;
                if (obj.Foto != null)
                {
                    picFoto.Image = HELPproductos.toImage(obj.Foto);
                }
            }
        }

        private Producto Capture()
        {
            Producto x = new Producto();
            x.Id = Convert.ToInt32(txtId.Text);
            x.Nombre = txtNombre.Text;
            x.Cantidad = Convert.ToInt32(txtCantidad.Text);
            x.PrecioCompra = Convert.ToDouble(txtPrecioCompra.Text);
            x.PrecioVenta = Convert.ToDouble(txtPrecioVenta.Text);
            x.Categoria = Convert.ToInt32(cmbCategoria.SelectedValue);
            x.Disponible = chcDisponible.Checked;
            if (!string.IsNullOrEmpty(rutaImagen))
            {
                x.Foto = HELPproductos.ToBytes(rutaImagen);
            }
            return x;
        }

        private void Add()
        {
            try
            {
                var prd = MessageBox.Show("¿Desea agregar el producto?", "Confirmación"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (prd == DialogResult.Yes)
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
                var prd = MessageBox.Show("¿Desea actualizar el producto?", "Confirmación"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (prd == DialogResult.Yes)
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
                var prd = MessageBox.Show("¿Desea eliminar el producto?", "Confirmación"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (prd == DialogResult.Yes)
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

        private void Initializaer()
        {

            CargarCategoria();
            FillGrid();
            cmbCategoria.SelectedIndex = -1;
        }

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            Initializaer();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            CloseForm();
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

        private void picBuscarImg_Click(object sender, EventArgs e)
        {
            SearchImage();
        }

        private void picBorrarImg_Click(object sender, EventArgs e)
        {
            DeleteImage();
        }

        private void picBuscarpr_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() != "")
                FillData(Convert.ToInt32(txtId.Text));
        }

        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f > 0 )
                FillData(Convert.ToInt32(dgProductos[0, f].Value));
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoria frm = new FrmCategoria();
            frm.ShowDialog();
            this.Hide();
        }
    }
}
