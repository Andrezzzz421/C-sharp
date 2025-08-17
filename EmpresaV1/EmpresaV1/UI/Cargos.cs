using EmpresaV1.DAO;
using EmpresaV1.HELPER;
using EmpresaV1.MODEL;
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
    public partial class Cargos : Form
    {
        private CargoDAO dao = new CargoDAO();
        bool isDraggin = false;
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

        private void fillGrid()
        {
            BindingSource bs = new BindingSource();
            dgCargos.AutoGenerateColumns = false;
            var x = dao.GetAll();
            bs.DataSource = x;
            dgCargos.DataSource = bs;
            dgCargos.Refresh();
        }

        private void Clear()
        {
            txtId.Clear();
            txtNombre.Clear();
            chcEstado.Checked = false;
        }

        private void FillData(int id)
        {
            var obj = dao.GetById(id);
            if (obj != null)
            {
                Clear();
                txtId.Text = obj.Id.ToString();
                txtNombre.Text = obj.Nombre.ToString();
                chcEstado.Checked = obj.Estado; 
            }
        }

        private Cargo Capture()
        {
            Cargo x = new Cargo();
            x.Id = Convert.ToInt32(txtId.Text);
            x.Nombre= txtNombre.Text.ToUpper();
            x.Estado = chcEstado.Checked;
            return x;
        }

        private void Add()
        {
            try
            {
                var cia = MessageBox.Show("¿Desea agregar el cargo?", "Confirmación", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cia == DialogResult.Yes)
                {
                    dao.Add(Capture());
                    Clear();
                    fillGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el cargo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update()
        {
            try
            {
                var cia = MessageBox.Show("¿Desea actualizar el cargo?", "Confirmación", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cia == DialogResult.Yes)
                {
                    dao.Update(Capture());
                    Clear();
                    fillGrid();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete()
        {
            try
            {
                var cia = MessageBox.Show("¿Desea eliminar el cargo?", "Confirmación", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);  
                if (cia == DialogResult.Yes)
                {
                    dao.Delete(Capture().Id);
                    Clear();
                    fillGrid();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Initializer()
        {
            CGHelper.Seed();
            fillGrid(); 
        }
        public Cargos()
        {
            InitializeComponent();
        }

        private void Cargos_Load(object sender, EventArgs e)
        {
            Initializer();
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

        private void picSearch_Click(object sender, EventArgs e)
        {
            if(txtId.Text.Trim() != "")
            {
                FillData(Convert.ToInt32(txtId.Text));
            }
        }

        private void dgCargos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if(f > -1)
                FillData(Convert.ToInt32(dgCargos[0,f].Value));
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Empleados frm = new Empleados();
            frm.Show();
            this.Hide();
        }

        private void Cargos_MouseDown(object sender, MouseEventArgs e)
        {
            isDraggin = true;
            startPoint = e.Location;
        }

        private void Cargos_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraggin)
            {
                Point p = this.PointToScreen(e.Location);
                this.Location = new Point(this.Left + (p.X - this.Left - startPoint.X),
                                          this.Top + (p.Y - this.Top - startPoint.Y));
            }
        }

        private void Cargos_MouseUp(object sender, MouseEventArgs e)
        {
            isDraggin = false;
        }
    }
}
