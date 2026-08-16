using ApuntesElJardin.Modals;
using ApuntesTodos.BL;
using ApuntesTodos.Entities;

namespace ApuntesTodos
{
    public partial class ApuntesTodos : Form
    {
        public ApuntesTodos()
        {
            InitializeComponent();
        }

        private ApuntesBL apuntesBL = new ApuntesBL();
        private List<Apuntes> listaApuntes = new List<Apuntes>();

        private void CargarGrid()
        {
            listaApuntes = apuntesBL.Apuntes_ObtenerTodos();
            gridApuntes.DataSource = listaApuntes;
        }
        private void CargarCombos()
        {
            cmbTrabajo.DataSource = new List<String> { "", "Souvenir", "Zarcereño", "Restaurante" };
        }

        private void ApuntesTodos_Load(object sender, EventArgs e)
        {
            CargarGrid();
            CargarCombos();
            gridApuntes.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            gridApuntes.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            gridApuntes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void gridApuntes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridApuntes.Columns[e.ColumnIndex].Name != "NombreCompleto" && gridApuntes.Columns[e.ColumnIndex].Name != "LugarTrabajo" && gridApuntes.Columns[e.ColumnIndex].Name != "Pagado" && gridApuntes.Columns[e.ColumnIndex].Name != "Detalles")
            {
                decimal valor = Convert.ToDecimal(e.Value);
                e.Value = valor.ToString("C0", new System.Globalization.CultureInfo("es-CR"));
                e.FormattingApplied = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.TextLength >= 3)
            {
                var listaFiltrada = listaApuntes.Where(a => a.NombreCompleto.ToLower().Contains(txtNombre.Text.ToLower())).ToList();
                gridApuntes.DataSource = listaFiltrada;
            }
            else
            {
                gridApuntes.DataSource = listaApuntes;
            }
        }

        private void cmbTrabajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTrabajo.Text != "")
            {
                var listaFiltrada = listaApuntes.Where(a => a.LugarTrabajo.ToLower().Contains(cmbTrabajo.Text.ToLower())).ToList();
                gridApuntes.DataSource = listaFiltrada;
            }
            else
            {
                gridApuntes.DataSource = listaApuntes;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void gridApuntes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (gridApuntes.Columns[e.ColumnIndex].Name == "Pagado")
            {
                int idSelecionado = Convert.ToInt32(gridApuntes.Rows[e.RowIndex].Cells["IdEmpleado"].Value);
                if (MessageBox.Show("¿Confirma que desea pagar los apuntes de este empleado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (apuntesBL.PagarApuntesSalario(idSelecionado))
                    {
                        MessageBox.Show("Apuntes pagados correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Algo malio sal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (gridApuntes.Columns[e.ColumnIndex].Name == "Detalles")
            {
                int idSelecionado = Convert.ToInt32(gridApuntes.Rows[e.RowIndex].Cells["IdEmpleado"].Value);
                string nombreEmpleado = gridApuntes.Rows[e.RowIndex].Cells["NombreCompleto"].Value.ToString();

                frmDetalles detallesForm = new frmDetalles(idSelecionado, nombreEmpleado);
                detallesForm.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHistorial frmHistorial = new frmHistorial();
            frmHistorial.Show();
        }

        private void btnAgreagrColaborador_Click(object sender, EventArgs e)
        {
            AgregarEmpleadoModal modal = new AgregarEmpleadoModal();
            modal.ShowDialog();
            CargarGrid();
        }
    }
}
