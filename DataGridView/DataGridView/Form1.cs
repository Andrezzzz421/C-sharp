using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        private String rutaImagen="";
        private List<Paises> ls = new List<Paises>();
        public void fillgrid()
        {
            dg1.DataSource = null;
            dg1.DataSource = ls;
            dg1.Refresh();
        }
        public void fillData(string cod)
        {
            foreach (Paises ob in ls)

            {
                if (ob.Codigo == cod)

                {
                    txtCodigo.Text = ob.Codigo;
                    txtNombre.Text = ob.Nombre;
                    txtBandera.Text = ob.Bandera;
                    if (ob.Bandera != "" && ob.Bandera != null)
                    {
                        picBandera.Image = Image.FromFile(ob.Bandera);

                    }
                    break;
                }
            }
        }
        private void SearchImage()
        {
            var x = openFileDialog1.ShowDialog();
            if (x == DialogResult.OK)
            {
                rutaImagen = openFileDialog1.FileName;
                picBandera.Image = Image.FromFile(rutaImagen);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text.Trim() != "" && txtNombre.Text.Trim() != "")
                {
                    Paises obj = new Paises();
                    obj.Codigo = txtCodigo.Text;
                    obj.Nombre = txtNombre.Text;
                    obj.activo = chkActivo.Checked;
                    obj.Bandera = txtBandera.Text;
                    ls.Add(obj);
                    fillgrid();
                }

            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
        }

        private void picBandera_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                txtBandera.Text = openFileDialog1.FileName; 
                picBandera.Image =  Image.FromFile(txtBandera.Text);
              

            }

        }

        private void dg1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                fillData(dg1[0, e.RowIndex].Value.ToString());

            }
        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            SearchImage();
        }

        private void txtBandera_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
