using BibliotecaLosSayayines.DAO;
using BibliotecaLosSayayines.DTO;
using BibliotecaLosSayayines.HELPER;
using BibliotecaLosSayayines.MODEL;
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

namespace BibliotecaLosSayayines.UI
{
    public partial class FrmLibro : Form
    {


        private void Buscar()
        {
            string criterio = cbxFiltro.SelectedItem.ToString();
            string texto = txtFiltro.Text.Trim();

            LibroDAO daol = new LibroDAO();
            List<LibroDTO> lista = new List<LibroDTO>();

            if (string.IsNullOrWhiteSpace(texto))
            {
                lista = daol.GetDTO();
                dgLibro.DataSource = lista;
                return;
            }
            switch (criterio)
            {
                case "Titulo":
                    lista = daol.FindByTitle(texto);
                    break;

                case "Categoria":
                    lista = daol.FindByCategory(texto);
                    break;

                case "Autor":
                    lista = daol.FindByAuthor(texto);
                    break;

                case "Editorial":
                    lista = daol.FindByPublisher(texto);
                    break;
            }

            dgLibro.DataSource = lista;
        }


        private void SearchImage()
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image|*.jpg;*.jpeg;*.png;*.bmp";
            if (op.ShowDialog() == DialogResult.OK)
            {
                picPortada.Image = Image.FromFile(op.FileName);
            }
        }

        private void DeleteImage()
        {
            picPortada.Image = null;
            picPortada.ImageLocation = null;
        }
        private void FillAutor()
        {
            try
            {
                cbxAutor.DataSource = null;
                cbxAutor.DataSource = UnitOfWork.autor.GetAll();
                cbxAutor.DisplayMember = "nombre";
                cbxAutor.ValueMember = "id_autor";
                cbxAutor.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FillEditorial()
        {
            try
            {
                cbxEditorial.DataSource = null;
                cbxEditorial.DataSource = UnitOfWork.editorial.GetAll();
                cbxEditorial.DisplayMember = "nombre";
                cbxEditorial.ValueMember = "id_editorial";
                cbxEditorial.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void FillCategoria()
        {
            try
            {
                cbxCategoria.DataSource = null;
                cbxCategoria.DataSource = UnitOfWork.categoria.GetAll();
                cbxCategoria.DisplayMember = "nombre";
                cbxCategoria.ValueMember = "id_categoria";
                cbxCategoria.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void ClearText()
        {
            txtId.Text = "";
            txtTitulo.Text = "";
            txtDesc.Text = "";
            txtAnioPubli.Text = "";
            cbxAutor.SelectedValue = 0;
            cbxCategoria.SelectedValue = 0;
            cbxEditorial.SelectedValue = 0;
            cbxEstado.SelectedValue = 0;
            picPortada.Image = null;
        }

        private void FillText(int id)
        {
            try
            {
                var x = UnitOfWork.libro.GetById(id);
                if (x != null)
                {
                    txtId.Text = x.Id_libro.ToString();
                    txtTitulo.Text = x.Titulo;
                    txtAnioPubli.Text = x.AnioPublicacion.ToString();
                    txtDesc.Text = x.Descripcion;
                    cbxAutor.SelectedValue = x.Id_autor;
                    cbxCategoria.SelectedValue = x.Id_Categoria;
                    cbxEditorial.SelectedValue = x.Id_editorial;

                    cbxEstado.SelectedItem = x.Estado;
                    if (x.Portada != null && x.Portada.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(x.Portada))
                        {
                            picPortada.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        picPortada.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FillGrid(string name = "", string filter = "title")
        {
            try
            {
                dgLibro.AutoGenerateColumns = true;

                if (string.IsNullOrWhiteSpace(name))
                    dgLibro.DataSource = UnitOfWork.libro.GetDTO();
                else
                {
                    if (filter == "Titulo")
                        dgLibro.DataSource = UnitOfWork.libro.FindByTitle(name);
                    else if (filter == "Categoria")
                        dgLibro.DataSource = UnitOfWork.libro.FindByCategory(name);
                    else if (filter == "Autor")
                        dgLibro.DataSource = UnitOfWork.libro.FindByAuthor(name);
                    else if (filter == "Editorial")
                        dgLibro.DataSource = UnitOfWork.libro.FindByPublisher(name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool ValidateData()
        {
            if (txtTitulo.Text.Trim() == "")
                throw new Exception("El titulo no puede estar vacio");
            if (txtAnioPubli.Text.Trim() == "")
                throw new Exception("El año de publicacion no puede estar vacio");
            if (txtDesc.Text.Trim() == "")
                throw new Exception("La descripcion no puede estar vacia");
            if (cbxAutor.SelectedIndex == -1)
                throw new Exception("Debe seleccionar un autor");
            if (cbxEditorial.SelectedIndex == -1)
                throw new Exception("Debe seleccionar una editorial");
            if (cbxCategoria.SelectedIndex == -1)
                throw new Exception("Debe seleccionar una categoria");
            return true;
        }

        private Libro CaptureData()
        {
            Libro l = new Libro();
            if (!string.IsNullOrWhiteSpace(txtId.Text))
                l.Id_libro = Convert.ToInt32(txtId.Text);
            l.Titulo = txtTitulo.Text.Trim();
            l.AnioPublicacion = Convert.ToInt32(txtAnioPubli.Text.Trim());
            l.Descripcion = txtDesc.Text.Trim();
            l.Id_autor = Convert.ToInt32(cbxAutor.SelectedValue);
            l.Id_editorial = Convert.ToInt32(cbxEditorial.SelectedValue);
            l.Id_Categoria = Convert.ToInt32(cbxCategoria.SelectedValue);
            l.Estado = cbxEstado.SelectedItem.ToString();
            if (picPortada.Image != null)
            {
                l.Portada = BSHelper.toByteArray(picPortada.Image);
            }
            else
            {
                l.Portada = null;
            }
            return l;
        }

        private void InsertData()
        {
            try
            {
                if (ValidateData())
                {
                    DialogResult result = MessageBox.Show("¿Desea agregar este libro?", "Confirmar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        UnitOfWork.libro.Add(CaptureData());
                        ClearText();
                        FillGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void UpdateData()
        {
            try
            {
                if (ValidateData())
                {
                    DialogResult r = MessageBox.Show("¿Desea actualizar este libro?", "Confirmar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        UnitOfWork.libro.Update(CaptureData());
                        ClearText();
                        FillGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DeleteData()
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea eliminar este libro?", "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    UnitOfWork.libro.Delete(Convert.ToInt32(txtId.Text));
                    ClearText();
                    FillGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public FrmLibro()
        {
            InitializeComponent();
        }

        private void FrmLibro_Load(object sender, EventArgs e)
        {
            FillGrid();
            FillEditorial();
            FillAutor();
            FillCategoria();
        }
         

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void PicSearchImage_Click(object sender, EventArgs e)
        {
            SearchImage();
        }

        private void picDeleteImage_Click(object sender, EventArgs e)
        {
            DeleteImage();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {

            try
            {
                Buscar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void dgLibro_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > 1)
                FillText(Convert.ToInt32(dgLibro[0, e.RowIndex].Value));

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea salir De la Aplicacion x?", "Confirmacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
