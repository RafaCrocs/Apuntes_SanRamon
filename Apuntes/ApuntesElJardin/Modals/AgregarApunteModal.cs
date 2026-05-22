using ApunteEmpleados.Entities;
using ApuntesElJardin.Forms;
using ApuntesEmpleados.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace ApuntesElJardin.Modals
{
    public partial class AgregarApunteModal : Form
    {
        public AgregarApunteModal()
        {
            InitializeComponent();
        }

        private ApuntesBL apuntesBL = new ApuntesBL();
        public Apunte nuevoApunte = new Apunte();

        private void BorrarCampos()
        {
            txtNombre.Text = string.Empty;
            txtMonto.Text = string.Empty;
            txtDetalle.Text = string.Empty;
            lblCadaUno.Text = string.Empty;
            lblCantidad.Text = string.Empty;
            cantidad = 0;
        }
        int cantidad = 0;

        List<int> codigos = new List<int>();

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDetalle.Text == string.Empty)
                {
                    MessageBox.Show("Agregue un detalle", "Detalle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                for (int i = 0; i < codigos.Count; i++)
                {
                    if (cantidad == 1)
                    {
                        nuevoApunte = new Apunte()
                        {
                            Origen = "Zarcereño",
                            IdEmpleado = codigos[i],
                            Monto = int.TryParse(txtMonto.Text, NumberStyles.Currency, new CultureInfo("es-CR"), out int monto) ? monto : 0,
                            Detalle = txtDetalle.Text,
                        };

                    }
                    else
                    {
                        nuevoApunte = new Apunte()
                        {
                            Origen = "Zarcereño",
                            IdEmpleado = codigos[i],
                            Monto = int.TryParse(lblCadaUno.Text.Replace("C/U: ", ""), NumberStyles.Currency, new CultureInfo("es-CR"), out int monto) ? monto : 0,
                            Detalle = txtDetalle.Text,
                        };

                    }

                    if (apuntesBL.AgregarApunte(nuevoApunte, out string mensaje))
                    {
                        MessageBox.Show("Apunte agregado correctamente");
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
                BorrarCampos();
                codigos.Clear();

            }
            catch
            {
                MessageBox.Show("Error al agregar el apunte");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            BorrarCampos();
            codigos.Clear();
        }

        private void btnVerApuntes_Click(object sender, EventArgs e)
        {
            frmApuntes frmApuntes = new frmApuntes();
            frmApuntes.Show();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmpleados modal = new frmEmpleados();
                modal.ShowDialog();
                if (modal.DialogResult == DialogResult.OK)
                {
                    if (txtNombre.Text.Contains(modal.empleado.NombreCompleto.ToString()))
                    {
                        MessageBox.Show("Esa persona ya esta agregada", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (modal.empleado != null)
                    {
                        if (txtNombre.Text != "")
                        {
                            txtNombre.Text += ", ";
                        }
                        codigos.Add(modal.empleado.IdEmpleado);
                        cantidad++;
                        txtNombre.Text += modal.empleado.NombreCompleto;
                        lblCantidad.Text = "Cantidad: ";
                        lblCantidad.Text += cantidad;
                    }
                    if (cantidad > 1 && txtMonto.Text != string.Empty)
                    {
                        lblCadaUno.Text = "C/U: ";
                        decimal.TryParse(txtMonto.Text, NumberStyles.Currency, new CultureInfo("es-CR"), out decimal monto2);
                        decimal CU = monto2 / cantidad;
                        lblCadaUno.Text += CU.ToString("C0", new CultureInfo("es-CR"));
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el empleado: " + ex.Message);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {

                frmApuntes frmApuntes = new frmApuntes();
                frmApuntes.Show();
            }
            catch
            {
                MessageBox.Show("Error al mostrar los apuntes");
            }
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            if (cantidad > 1)
            {
                lblCadaUno.Text = "C/U: ";
                decimal.TryParse(txtMonto.Text, NumberStyles.Currency, new CultureInfo("es-CR"), out decimal monto2);
                decimal CU = monto2 / cantidad;
                lblCadaUno.Text += CU.ToString("C0", new CultureInfo("es-CR"));
            }
        }

        private void txtMonto_Leave(object sender, EventArgs e)
        {
            decimal.TryParse(txtMonto.Text, NumberStyles.Currency, new CultureInfo("es-CR"), out decimal monto);
            txtMonto.Text = monto.ToString("C0", new CultureInfo("es-CR"));
            if (cantidad > 1)
            {
                lblCadaUno.Text = "C/U: ";
                decimal.TryParse(txtMonto.Text, NumberStyles.Currency, new CultureInfo("es-CR"), out decimal monto2);
                decimal CU = monto2 / cantidad;
                lblCadaUno.Text += CU.ToString("C0", new CultureInfo("es-CR"));
            }

        }
    }
}
