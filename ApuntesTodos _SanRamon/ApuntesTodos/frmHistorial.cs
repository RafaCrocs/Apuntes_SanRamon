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
            gridHistorial.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            gridHistorial.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            gridHistorial.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            listaHistorial = historialBL.ObtenerHistorial();
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
            DateTime fechaInicio = dateTimePicker1.Value.Date;
            DateTime fechaFin = dateTimePicker2.Value.Date.AddDays(1);
            var listaFiltrada = historialBL.BuscarEntreFechas(fechaInicio, fechaFin);
            if (txtNombre.Text.Length >= 3)
            {
                listaFiltrada = listaFiltrada.FindAll(h => h.NombreCompleto.ToLower().Contains(txtNombre.Text.ToLower()));
                gridHistorial.DataSource = listaFiltrada;
            }
            else
            {
                gridHistorial.DataSource = listaFiltrada;
            }
            //Total en tabla
            decimal total = 0;
            foreach (var item in listaFiltrada)
            {
                total += item.Monto;
            }
            lblTotal.Text = "Total en tabla: " + total.ToString("C0", new System.Globalization.CultureInfo("es-CR"));
        }

        private void btnLimpiarFecha_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            if (txtNombre.Text.Length >= 3)
            {
                var ListaFiltrada = listaHistorial.FindAll(h => h.NombreCompleto.ToLower().Contains(txtNombre.Text.ToLower()));
                gridHistorial.DataSource = ListaFiltrada;


            }
            else
            {
                gridHistorial.DataSource = listaHistorial;
            }
            lblTotal.Text = "";
            txtNombre.Text = "";
            CargarGrid();
        }
    }
}
