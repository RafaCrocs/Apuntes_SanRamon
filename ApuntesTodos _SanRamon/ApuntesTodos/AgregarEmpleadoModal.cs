using System;
using System.Windows.Forms;
using ApuntesTodos.Entities;
using ApuntesTodos.BL;

namespace ApuntesElJardin.Modals
{
    public partial class AgregarEmpleadoModal : Form
    {
        private EmpleadosBL empleadosBL = new EmpleadosBL();

        public AgregarEmpleadoModal()
        {
            InitializeComponent();
        }

        private void CargarTrabajos()
        {
            cmbTrabajo.DataSource = new List<string> { "Zarcereño", "Restaurante", "Souvenir", "Finca" };
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text) ||
                    string.IsNullOrWhiteSpace(cmbTrabajo.Text))
                {
                    MessageBox.Show("Por favor complete todos los campos.");
                    return;
                }

                Empleado empleado = new Empleado
                {
                    NombreCompleto = txtNombreCompleto.Text.Trim(),
                    LugarTrabajo = cmbTrabajo.Text.Trim()
                };

                if (empleadosBL.Empleado_Insertar(empleado, out string mensaje))
                {
                    MessageBox.Show(mensaje);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }
            catch
            {
                MessageBox.Show("Ocurrió un error al guardar el empleado. Por favor intente nuevamente.");
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
