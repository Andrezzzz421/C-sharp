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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos.UI
{
    public partial class FrmCategoria : Form
    {
        private CategoriaDAO dao = new CategoriaDAO();
        bool isDragging = false;
        Point startPoint;

        private void CloseForm()
        {
            DialogResult x = MessageBox.Show("¿Desea cerrar el formulario?", "Confirmación",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FillGrid()
        {
            BindingSource bs = new BindingSource();
            dgCategoria.AutoGenerateColumns = false;
            var x =dao.GetAll();
            bs.DataSource = x;
            dgCategoria.DataSource = bs;
            dgCategoria.Refresh();
        }
        private void Clear()
        {
            txtId.Clear();
            txtNombre.Clear();

        }

        private void FillData(int id)
        {
            var obj = dao.GetById(id);
            if (obj != null)
            {
                txtId.Text = obj.Id.ToString();
                txtNombre.Text = obj.Nombre;
            }
        }

        private Categoria Capture()
        {
            Categoria x = new Categoria();
            x.Id = Convert.ToInt32(txtId.Text);
            x.Nombre = txtNombre.Text;
            return x;
        }

        private void Add()
        {
            try
            {
                var ct = MessageBox.Show("¿Desea agregar la categoría?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(ct == DialogResult.Yes)
                {
                    dao.Add(Capture());
                    Clear();
                    FillGrid();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al agregar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update()
        {
            try
            {
                var ct = MessageBox.Show("¿Desea actualizar la categoría?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ct == DialogResult.Yes)
                {
                    dao.Update(Capture());
                    Clear();
                    FillGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete()
        {
            try
            {
                var ct = MessageBox.Show("¿Desea eliminar la categoría?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ct == DialogResult.Yes)
                {
                    dao.Delete(Capture().Id);
                    Clear();
                    FillGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Initializer()
        {

            FillGrid();
        }
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            Initializer();
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

        private void picBuscarct_Click(object sender, EventArgs e)
        {
            if(txtId.Text.Trim() != "")
            {
                FillData(Convert.ToInt32(txtId.Text));
            }
        }

        private void dgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f >= 0)
            {
                FillData(Convert.ToInt32(dgCategoria[0, f].Value));
            }
        }

        private void FrmCategoria_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void FrmCategoria_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = this.PointToScreen(e.Location);
                this.Location = new Point(this.Left + (p.X - this.Left - startPoint.X),
                                            this.Top + (p.Y - this.Top - startPoint.Y));
            }
        }

        private void FrmCategoria_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            startPoint = e.Location;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            frm.Show();
            this.Hide();
        }
    }
}
