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
    public partial class frmHistorial : Form
    {
        public frmHistorial()
        {
            InitializeComponent();
        }

        private HistorialBL historialBL = new HistorialBL();
        private List<Historial> listaHistorial = new List<Historial>();

        private void CargarGrid()
        {
            listaHistorial = historialBL.ObtenerHistorial();
            gridHistorial.DataSource = null;
            gridHistorial.DataSource = listaHistorial;
        }
        private void frmHistorial_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length >= 3)
            {
                var ListaFiltrada = listaHistorial.FindAll(h => h.NombreCompleto.ToLower().Contains(txtNombre.Text.ToLower()));
                gridHistorial.DataSource = ListaFiltrada;
            }
            else
            {
                gridHistorial.DataSource = listaHistorial;
            }
        }

        private void gridHistorial_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridHistorial.Columns[e.ColumnIndex].Name == "Monto" && e.Value != null)
            {
                int monto = (int)e.Value;
                e.Value = monto.ToString("C0", new System.Globalization.CultureInfo("es-CR"));
                e.FormattingApplied = true;
            }
        }

        private void btnBuscarFechas_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dateTimePicker1.Value;
            DateTime fechaFin = dateTimePicker2.Value;
            var listaFiltrada = historialBL.BuscarEntreFechas(fechaInicio, fechaFin);
            gridHistorial.DataSource = listaFiltrada;
        }
    }
}
