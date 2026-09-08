using ApuntesEmpleados.Entities;
using ApuntesElJardin.Utils;
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
        public AgregarApunteModal(ApuntesBL apuntesBL)
        {
            InitializeComponent();
            this.apuntesBL = apuntesBL;
        }

        private ApuntesBL apuntesBL;
        public Apunte nuevoApunte = new Apunte();

        private int CantidadSeleccionados = 0;


        private void BorrarCampos()
        {
            txtNombre.Text = string.Empty;
            txtMonto.Text = string.Empty;
            txtDetalle.Text = string.Empty;
            lblCadaUno.Text = string.Empty;
            apuntesBL.LimpiarLista();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int montoPorPersona = apuntesBL.CalcularTotalCadaUno((int.TryParse(txtMonto.Text, NumberStyles.Currency, new CultureInfo("es-CR"), out int monto) ? monto : 0), CantidadSeleccionados);
            for (int i = 0; i < CantidadSeleccionados; i++)
            {
                nuevoApunte = new Apunte()
                {
                    IdEmpleado = apuntesBL.ObtenerListaPorApuntar()[i].IdEmpleado,
                    Monto = montoPorPersona,
                    Detalle = txtDetalle.Text
                };

                if(apuntesBL.AgregarApunte(nuevoApunte, out string mensaje))
                {
                    MessageBox.Show(mensaje);
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            BorrarCampos();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            BorrarCampos();
        }

        private void btnVerApuntes_Click(object sender, EventArgs e)
        {
            frmApuntes frmApuntes = new frmApuntes(apuntesBL);
            frmApuntes.Show();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            frmEmpleados modal = new frmEmpleados(apuntesBL);
            modal.ShowDialog();
            CantidadSeleccionados = apuntesBL.CantidadEnListaPorApunte();
            if (modal.DialogResult == DialogResult.OK)
            {

                txtNombre.Text = string.Empty;

                for (int i = 0; i < CantidadSeleccionados; i++)
                {
                    txtNombre.Text += apuntesBL.ObtenerListaPorApuntar()[i].NombreCompleto;
                    if (i < CantidadSeleccionados - 1)
                    {
                        txtNombre.Text += " | ";
                    }
                }
                if (txtMonto.Text != string.Empty && CantidadSeleccionados > 1)
                {
                    ActualizarPrecioCU();
                }


            }
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            ActualizarPrecioCU();
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {

                frmApuntes frmApuntes = new frmApuntes();
                frmApuntes.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los apuntes: " + ex.Message);
            }
        }


        private void txtMonto_Leave(object sender, EventArgs e)
        {
            int.TryParse(txtMonto.Text, NumberStyles.Currency, new CultureInfo("es-CR"), out int monto);
            txtMonto.Text = Formato.ConvertirMontoAMoneda(monto);
            ActualizarPrecioCU();

        }

        private void ActualizarPrecioCU()
        {
            if (CantidadSeleccionados > 1)
            {
                lblCadaUno.Text = "C/U: ";
                int.TryParse(txtMonto.Text, NumberStyles.Currency, new CultureInfo("es-CR"), out int monto2);
                int CU = apuntesBL.CalcularTotalCadaUno(monto2, CantidadSeleccionados);
                lblCadaUno.Text += Formato.ConvertirMontoAMoneda(CU);
            }
        }
    }
}
