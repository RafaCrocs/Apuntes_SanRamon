using ApuntesEmpleados.Entities;
using ApuntesElJardin.Utils;
using ApuntesEmpleados.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApuntesElJardin.Forms
{
    public partial class frmApuntes : Form
    {
        public frmApuntes(ApuntesBL apuntesBL)
        {
            this.apuntesBL = apuntesBL;
            this.lugaresTrabajoBL = lugaresTrabajoBL;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            InitializeComponent();
        }

        private readonly ApuntesBL apuntesBL;

        private List<Apunte> apuntes = new List<Apunte>();
        private LugaresTrabajoBL lugaresTrabajoBL = new LugaresTrabajoBL();

        private void Apuntes_ObtenerPorOrigen()
        {
            apuntes = apuntesBL.Apuntes_ObtenerPorOrigen(out string mensaje);
            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarGrid(List<Apunte> listaApuntes)
        {
            gridApuntes.DataSource = listaApuntes.Select(a => new
            {
                a.IdEmpleado,
                a.Empleado.NombreCompleto,
                a.Empleado.LugarTrabajo,
                a.Monto
            }).ToList();
        }

        private void CargarCombos()
        {
            cmbTrabajo.DataSource = lugaresTrabajoBL.Lugares_ObtenerTodos(out string mensaje);
            cmbTrabajo.DisplayMember = "NombreLugarTrabajo";
            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmApuntes_Load(object sender, EventArgs e)
        {
            CargarCombos();
            Apuntes_ObtenerPorOrigen();
            CargarGrid(apuntes);
            gridApuntes.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            gridApuntes.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            gridApuntes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void gridApuntes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridApuntes.Columns[e.ColumnIndex].Name == "Monto" && e.Value != null)
            {
                int monto = Convert.ToInt32(e.Value);
                e.Value = Formato.ConvertirMontoAMoneda(monto);
                e.FormattingApplied = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            filtrarGrid();
        }

        private void filtrarGrid()
        {
            if (txtNombre.Text.Length >= 3)
            {
                CargarGrid(apuntes.FindAll(a => a.Empleado.NombreCompleto.IndexOf(txtNombre.Text, StringComparison.OrdinalIgnoreCase) >= 0));
            }
            else
            {
                CargarGrid(apuntes);
            }
        }

        private void gridApuntes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) return;
            if (gridApuntes.Columns[e.ColumnIndex].Name == "PagarTodo")
            {
                if (MessageBox.Show("¿Está seguro que desea pagar este apunte?\n" + "Colaborador: " + gridApuntes.Rows[e.RowIndex].Cells["NombreCompleto"].Value.ToString() + "\nMonto: " + Formato.ConvertirMontoAMoneda(gridApuntes.Rows[e.RowIndex].Cells["Monto"].Value), "Confirmar Pago", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int idEmpleado = Convert.ToInt32(gridApuntes.Rows[e.RowIndex].Cells["IdEmpleado"].Value);
                    if(apuntesBL.PagarTodoApuntesEmpleado(idEmpleado, out string mensaje))
                    {
                        Apuntes_ObtenerPorOrigen();
                        MessageBox.Show(mensaje, "Pago exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        filtrarGrid();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error de pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if(gridApuntes.Columns[e.ColumnIndex].Name == "Detalles")
            {
                Empleado empleado = new Empleado
                {
                    IdEmpleado = Convert.ToInt32(gridApuntes.Rows[e.RowIndex].Cells["IdEmpleado"].Value),
                    NombreCompleto = gridApuntes.Rows[e.RowIndex].Cells["NombreCompleto"].Value.ToString()
                };

                frmDetalles detalles = new frmDetalles(empleado, apuntesBL);
                detalles.ShowDialog();
                Apuntes_ObtenerPorOrigen();
                if (txtNombre.Text.Length >= 3)
                {
                    CargarGrid(apuntes.FindAll(a => a.Empleado.NombreCompleto.IndexOf(txtNombre.Text, StringComparison.OrdinalIgnoreCase) >= 0));
                    return;
                }
                else
                {
                    CargarGrid(apuntes);
                }
            }
        }

        private void cmbTrabajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTrabajo.Text == "")
            {
                CargarGrid(apuntes);
                return;
            }
            else
            {
                var empleadosFiltro = apuntes.Where(x => x.Empleado.LugarTrabajo.ToLower().Contains(cmbTrabajo.Text.ToLower())).ToList();
                CargarGrid(empleadosFiltro);
            }
        }

        private void btnVerHistorial_Click(object sender, EventArgs e)
        {
            try
            {
                frmHistorial historial = new frmHistorial();
                historial.Show();

            }
            catch
            {
                    MessageBox.Show("Error al abrir el historial");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
