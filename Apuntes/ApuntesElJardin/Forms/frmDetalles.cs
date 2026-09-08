using ApuntesElJardin.Utils;
using ApuntesEmpleados.BL;
using ApuntesEmpleados.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Resources;

namespace ApuntesElJardin.Forms
{
    public partial class frmDetalles : Form
    {
        public frmDetalles(Empleado empleado, ApuntesBL apuntesBL)
        {
            InitializeComponent();
            this.empleado = empleado;
            this.apuntesBL = apuntesBL;
        }

        private readonly ApuntesBL apuntesBL;

        private List<Apunte> apuntes = new List<Apunte>();
        private readonly Empleado empleado;

        private void CargarDatos()
        {
            apuntes = apuntesBL.Apuntes_ObtenerPorEmpleado(empleado, out string mensaje);
            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGrid()
        {
            gridDetalles.DataSource = apuntes.Select(a => new
            {
                a.IdApunte,
                a.Empleado.NombreCompleto,
                a.Detalle,
                a.Monto,
                a.Fecha
            }).ToList();
        }
        private void frmDetalles_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarGrid();
            gridDetalles.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            gridDetalles.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            gridDetalles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            lblNombre.Text = empleado.NombreCompleto;
        }

        private void gridDetalles_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridDetalles.Columns[e.ColumnIndex].Name == "Monto" && e.Value != null)
            {
                int monto = (int)e.Value;
                e.Value = Formato.ConvertirMontoAMoneda(monto);
                e.FormattingApplied = true;
            }
        }

        private void gridDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || gridDetalles.Columns[e.ColumnIndex].Name != "Pagar")
            {
                return;
            }
            int idApunte = Convert.ToInt32(gridDetalles.Rows[e.RowIndex].Cells["IdApunte"].Value);
            if (MessageBox.Show("¿Está seguro que desea pagar este apunte?\n" + gridDetalles.Rows[e.RowIndex].Cells["NombreCompleto"].Value.ToString() + "\nMonto: " + Formato.ConvertirMontoAMoneda(gridDetalles.Rows[e.RowIndex].Cells["Monto"].Value), "Confirmar Pago", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (apuntesBL.PagarApunte(idApunte, out string mensaje))
                {
                    MessageBox.Show("Apunte pagado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
