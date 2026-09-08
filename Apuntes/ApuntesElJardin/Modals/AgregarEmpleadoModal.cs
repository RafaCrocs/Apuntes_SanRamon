using ApuntesEmpleados.BL;
using System;
using System.Windows.Forms;
using ApuntesEmpleados.Entities;

namespace ApuntesElJardin.Modals
{
    public partial class AgregarEmpleadoModal : Form
    {
        private EmpleadosBL empleadosBL = new EmpleadosBL();
        private LugaresTrabajoBL lugaresTrabajoBL = new LugaresTrabajoBL();

        public AgregarEmpleadoModal()
        {
            InitializeComponent();
        }



        private void CargarTrabajos()
        {
            cmbTrabajo.DataSource = lugaresTrabajoBL.Lugares_ObtenerTodos(out string mensaje);
            cmbTrabajo.DisplayMember = "NombreLugarTrabajo";
            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado nuevoEmpleado = new Empleado
                {
                    NombreCompleto = txtNombreCompleto.Text,
                    LugarTrabajo = cmbTrabajo.Text
                };

                if (empleadosBL.Empleado_Insertar(nuevoEmpleado, out string mensaje))
                {
                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el empleado. Por favor intente nuevamente.\n\nDetalles del error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarEmpleadoModal_Load(object sender, EventArgs e)
        {
            CargarTrabajos();
        }
    }
}
