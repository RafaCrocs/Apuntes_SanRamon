using ApuntesElJardin.Modals;
using ApuntesEmpleados.BL;
using ApuntesEmpleados.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ApuntesElJardin.Forms
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados(ApuntesBL apuntesBL)
        {
            InitializeComponent();
            this.apuntesBL = apuntesBL;
        }
        public Empleado empleado;

        private EmpleadosBL empleadosBL = new EmpleadosBL();
        private ApuntesBL apuntesBL;
        private List<Empleado> empleados = new List<Empleado>();

        private LugaresTrabajoBL lugaresTrabajoBL = new LugaresTrabajoBL();

        private void CargarGrid()
        {

            empleados = empleadosBL.Empleados_ObtenerTodos(out string mensaje);
            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            gridEmpleados.DataSource = empleados;
        }

        private void CargarCombo()
        {
            cmbTrabajo.DataSource = lugaresTrabajoBL.Lugares_ObtenerTodos(out string mensaje);
            cmbTrabajo.DisplayMember = "NombreLugarTrabajo";
            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            CargarGrid();
            CargarCombo();
            gridEmpleados.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            gridEmpleados.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            gridEmpleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.TextLength >= 3)
            {
                var empleadosFiltro = empleados.Where(x => x.NombreCompleto.ToLower().Contains(txtNombre.Text.ToLower())).ToList();
                gridEmpleados.DataSource = empleadosFiltro;
            }
            else
            {
                gridEmpleados.DataSource = empleados;
            }
        }

        private void cmbTrabajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTrabajo.Text == "")
            {
                gridEmpleados.DataSource = empleados;
                return;
            }
            else
            {
                var empleadosFiltro = empleados.Where(x => x.LugarTrabajo.ToLower().Contains(cmbTrabajo.Text.ToLower())).ToList();
                gridEmpleados.DataSource = empleadosFiltro;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarEmpleadoModal modal = new AgregarEmpleadoModal();
                modal.ShowDialog();
                CargarGrid();

            }
            catch
            {
                MessageBox.Show("Error al agregar el empleado");
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            empleado = new Empleado()
            {
                IdEmpleado = int.Parse(gridEmpleados.Rows[e.RowIndex].Cells["IdEmpleado"].Value.ToString()),
                NombreCompleto = gridEmpleados.Rows[e.RowIndex].Cells["NombreCompleto"].Value.ToString()
            };

            apuntesBL.AgregarALista(empleado, out string mensaje);
            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
