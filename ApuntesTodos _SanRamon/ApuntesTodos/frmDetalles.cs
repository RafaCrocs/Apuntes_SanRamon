using ApuntesTodos.BL;
using ApuntesTodos.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ApuntesTodos
{
    public partial class frmDetalles : Form
    {
        private int idSeleccionado;
        private string nombreEmpleado;

        public frmDetalles(int idSeleccionado, string Nombre)
        {
            InitializeComponent();
            this.idSeleccionado = idSeleccionado;
            this.nombreEmpleado = Nombre;
        }

        private DetallesBL detallesBL = new DetallesBL();
        private List<Detalles> listaDetalles = new List<Detalles>();
        private void frmDetalles_Load(object sender, EventArgs e)
        {
            CargarGrid();
            CargarCombo();
            lblNombre.Text = "Detalles de " + nombreEmpleado;
        }

        private void CargarGrid()
        {
            listaDetalles = detallesBL.Detalles_ObtenerPorEmpleado(idSeleccionado);

            gridDetalles.DataSource = listaDetalles;

            gridDetalles.RowsDefaultCellStyle.BackColor = Color.LightYellow;
            gridDetalles.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            gridDetalles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void CargarCombo()
        {
            cmbTrabajo.DataSource = new List<String> { "", "Souvenir", "MiniMarket", "Restaurante", "Heladeria" };
        }

        private void cmbTrabajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listaFiltrada = listaDetalles.Where(d => d.Origen.ToLower().Contains(cmbTrabajo.Text.ToLower())).ToList();
            gridDetalles.DataSource = listaFiltrada;
        }

        private void gridDetalles_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridDetalles.Columns[e.ColumnIndex].Name == "Monto")
            {
                decimal valor = Convert.ToDecimal(e.Value);
                e.Value = valor.ToString("C0", new System.Globalization.CultureInfo("es-CR"));
                e.FormattingApplied = true;
            }
        }

        private void gridDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 )
            {
                return;
            }
            if(gridDetalles.Columns[e.ColumnIndex].Name == "Pagar")
            {
                int idApunte = Convert.ToInt32(gridDetalles.Rows[e.RowIndex].Cells["IdApunte"].Value);
                string origen = gridDetalles.Rows[e.RowIndex].Cells["Origen"].Value.ToString()!;
                bool resultado = detallesBL.PagarApunte(idApunte, origen, out string mensaje);
                if (resultado)
                {
                    MessageBox.Show(mensaje);
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }
    }
}
