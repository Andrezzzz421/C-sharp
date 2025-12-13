using BibliotecaLosSayayines.DAO;
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
    public partial class FrmUsuario : Form
    {

        private void SearchImage()
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image|*.jpg;*.jpeg;*.png;*.bmp";
            if (op.ShowDialog() == DialogResult.OK)
            {
                picFoto.Image = Image.FromFile(op.FileName);
            }
        }

        private void DeleteImage()
        {
            picFoto.Image = null;
            picFoto.ImageLocation = null;
        }

        private void ClearText()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtUser.Text = "";
            txtContra.Text = "";
            txtCorreo.Text = "";
            cbxRol.SelectedIndex = -1;
            txtTelefono.Text = "";
            picFoto.Image = null;
            chkEstado.Checked = false;
        }

        private void FillText(int id)
        {
            try
            {
                var x = UnitOfWork.usuario.GetById(id);
                if (x != null)
                {
                    txtId.Text = x.IdUsuario.ToString();
                    txtNombre.Text = x.Nombre;
                    txtApellido.Text = x.Apellido;
                    txtUser.Text = x.NombreUsuario;
                    txtContra.Text = x.Password;
                    txtCorreo.Text = x.Email;
                    cbxRol.SelectedItem = x.Rol;
                    txtTelefono.Text = x.Telefono;
                    if (x.Foto != null && x.Foto.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(x.Foto))
                        {
                            picFoto.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        picFoto.Image = null;
                    }
                    chkEstado.Checked = x.Estado;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FillGrid()
        {
            try
            {
                dgUsuario.AutoGenerateColumns = true;
                dgUsuario.DataSource = UnitOfWork.usuario.GetAll();
                if (dgUsuario.Columns["Foto"] is DataGridViewImageColumn col)
                {
                    col.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
                dgUsuario.Columns["Estado"].Visible = false;
                dgUsuario.Columns["EstadoDescripcion"].HeaderText = "Estado";
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
            if (txtNombre.Text.Trim() == "")
                throw new Exception("El nombre es obligatorio");
            if (txtApellido.Text.Trim() == "")
                throw new Exception("El apellido es obligatorio");
            if (txtUser.Text.Trim() == "")
                throw new Exception("El nombre de usuario es obligatorio");
            if (txtContra.Text.Trim() == "")
                throw new Exception("La contraseña es obligatoria");
            if (txtCorreo.Text.Trim() == "")
                throw new Exception("El correo es obligatorio");

            return true;

        }

        private Usuario CaptureData()
        {
            Usuario u = new Usuario();
            if (!string.IsNullOrWhiteSpace(txtId.Text))
                u.IdUsuario = Convert.ToInt32(txtId.Text.Trim());
            u.Nombre = txtNombre.Text.Trim();
            u.Apellido = txtApellido.Text.Trim();
            u.NombreUsuario = txtUser.Text.Trim();
            u.Password = txtContra.Text.Trim();
            u.Email = txtCorreo.Text.Trim();
            u.Rol = cbxRol.SelectedItem?.ToString();
            u.Telefono = txtTelefono.Text.Trim();
            if (picFoto.Image != null)
            {
                u.Foto = BSHelper.toByteArray(picFoto.Image);
            }
            else
            {
                u.Foto = null;
            }
            u.Estado = chkEstado.Checked;
            return u;
        }

        private void InsertData()
        {
            try
            {
                if (ValidateData())
                {
                    DialogResult r = MessageBox.Show("¿Desea guardar el usuario?", "Confirmacion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        UnitOfWork.usuario.Add(CaptureData());
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
                    DialogResult r = MessageBox.Show("¿Desea actualizar el usuario?", "Confirmacion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        UnitOfWork.usuario.Update(CaptureData());
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
                DialogResult r = MessageBox.Show("¿Desea eliminar el usuario?", "Confirmacion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    UnitOfWork.usuario.Delete(Convert.ToInt32(txtId.Text));
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
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            FillGrid();
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

        private void dgUsuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > 1)
                FillText(Convert.ToInt32(dgUsuario[0, e.RowIndex].Value));

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
