using LabPOO.DAO;
using LabPOO.Helpers;
using LabPOO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabPOO.UI
{
    public partial class FrmLibros : Form
    {
        private LibroDAO dao = new LibroDAO();
        private int cantidadRegistrada = 0;
        private String rutaImagen = "";

        private void closeForm()
        {
            DialogResult x = MessageBox.Show("Desea Salir?", "Libreria",
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
                picPortada.Image = Image.FromFile(rutaImagen);
            }
        }
        private void DeleteImage()
        {
            picPortada.Image = null;
            rutaImagen = "";
        }

        private void FillGrid()
        {
            BindingSource bs = new BindingSource();
            grdInformacion.AutoGenerateColumns = false;
            var x = dao.GetAll();
            bs.DataSource = x;
            grdInformacion.DataSource = bs;
            grdInformacion.Refresh();
            cantidadRegistrada = x.Count;
        }

        private void FillData(int id)
        {
            var obj = dao.GetById(id);
            if (obj != null)
            {
                Clear();
                txtId.Text = obj.Id.ToString();
                txtTitulo.Text = obj.Titulo.ToString();
                txtAniodePublicacion.Text = obj.AnioPublicacion.ToString();
                txtAutor.Text = obj.Autor.ToString();
                txtSinopsis.Text = obj.Sinopsis.ToString();
                cbxGenero.Text = obj.Genero.ToString();
                if (obj.Portada != null && obj.Portada != "")
                    picPortada.Image = Image.FromFile(obj.Portada);
            }

        }
        private void BooksCounter()
        {
            lblLibrosRegistrados.Text = $"Libros Registrados:{cantidadRegistrada}";
        }

        private void Clear()
        {
            txtAniodePublicacion.Clear();
            txtAutor.Clear();
            txtTitulo.Clear();
            txtEditorial.Clear();
            txtId.Clear();
            txtSinopsis.Clear();
            cbxGenero.SelectedIndex = 0;
            DeleteImage();
        }
        private Libro Capture()
        {
            Libro x = new Libro();
            x.Id = Convert.ToInt32(txtId.Text);
            x.Titulo = txtTitulo.Text.ToUpper();
            x.Autor = txtAutor.Text.ToUpper();
            x.Editorial = txtEditorial.Text.ToUpper();
            x.Genero = cbxGenero.Text;
            x.AnioPublicacion = Convert.ToInt32(txtAniodePublicacion.Text);
            x.Portada = rutaImagen;
            x.Sinopsis = txtSinopsis.Text;
            return x;
        }

        private void Add()
        {
            try
            {

                var dia = MessageBox.Show("Desea agregar?", "Libreria",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dia == DialogResult.Yes)
                {
                    dao.Add(Capture());
                    Clear();
                    FillGrid();
                    BooksCounter();
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
                var dia = MessageBox.Show("Desea actualizar el registro?",
                    "Libreria",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dia == DialogResult.Yes)
                {
                    dao.Update(Capture());
                    Clear();
                    FillGrid();
                    BooksCounter();
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
                var dia = MessageBox.Show("Desea eliminar el registro?",
                    "Libreria",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dia == DialogResult.Yes)
                {
                    dao.Delete(Capture().Id);
                    Clear();
                    FillGrid();
                    BooksCounter();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Initializer()
        {
            WMHelper.Seed();
            FillGrid();
            cbxGenero.SelectedIndex = 0;
            BooksCounter();
        }
        public FrmLibros()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        private void FrmLibros_Load(object sender, EventArgs e)
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

        private void picBuscarImagen_Click(object sender, EventArgs e)
        {
            SearchImage();
        }

        private void picBorrarImagen_Click(object sender, EventArgs e)
        {
            DeleteImage();
        }

        private void picBusc_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() != "")
                FillData(Convert.ToInt32(txtId.Text));
        }
        private void grdInformacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f > -1)
                FillData(Convert.ToInt32(grdInformacion[0, f].Value));
        }

        private void txtSinopsis_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
