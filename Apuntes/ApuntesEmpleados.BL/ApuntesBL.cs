using ApuntesEmpleados.Entities;
using ApuntesEmpleados.DAL.BD;
using ApuntesEmpleados.Entities;
using ApuntesEmpleados.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApuntesEmpleados.BL
{
    public class ApuntesBL
    {

        private ApuntesDAL apuntesDAL = new ApuntesDAL();
        private List<Empleado> Empleados_listaPorIngresarApunte = new List<Empleado>();


        public List<Apunte> Apuntes_ObtenerPorOrigen(out string mensaje)
        {
            return apuntesDAL.Apuntes_PorOrigen(AppConfig.Instance.Origen, out mensaje);
        }

        public List<Apunte> Apuntes_ObtenerPorEmpleado(Empleado empleado, out string mensaje)
        {
            return apuntesDAL.ObtenerApuntesPorEmpleado(empleado, AppConfig.Instance.Origen, out mensaje);
        }

        public bool AgregarApunte(Apunte apunte, out string mensaje)
        {
            if (string.IsNullOrEmpty(apunte.IdEmpleado.ToString()))
            {
                mensaje = "Debe seleccionar al menos un colaborador";
                return false;
            }
            if (apunte.Monto <= 0)
            {
                mensaje = "El monto debe ser mayor a cero";
                return false;
            }
            if (string.IsNullOrEmpty(apunte.Detalle))
            {
                mensaje = "El detalle no pueden estar vacío";
                return false;
            }

            apunte.Origen = AppConfig.Instance.Origen;


            return apuntesDAL.AgregarApunte(apunte, out mensaje);
        }

        public bool PagarApunte(int idApunte, out string mensaje)
        {
            return apuntesDAL.PagarApunte(idApunte, AppConfig.Instance.Origen, out mensaje);
        }

        public bool PagarTodoApuntesEmpleado(int IdEmpleado, out string mensaje)
        {
            return apuntesDAL.PagarTodoApuntesEmpleado(IdEmpleado, AppConfig.Instance.Origen, out mensaje);
        }

        public int CalcularTotalCadaUno(int monto, int cantidadEnLista)
        {
            try
            {
                int total = 0;
                if (cantidadEnLista > 0)
                {
                    total = monto / cantidadEnLista;
                }
                return total;
            }
            catch (DivideByZeroException ex)
            {
                return 0;
            }


        }

        public void AgregarALista(Empleado empleado, out string mensaje)
        {
            mensaje = string.Empty;
            if (empleado.NombreCompleto == null || empleado.IdEmpleado == null)
            {
                mensaje = "El nombre del colaborador no pueden ser nulos.";
                return;
            }
            for (int i = 0; i < Empleados_listaPorIngresarApunte.Count; i++)
            {
                if (Empleados_listaPorIngresarApunte[i].IdEmpleado == empleado.IdEmpleado)
                {
                    mensaje = "Ese colaborador ya está ingresado.";
                    return;
                }
            }
            Empleados_listaPorIngresarApunte.Add(empleado);
        }

        public List<Empleado> ObtenerListaPorApuntar()
        {
            return Empleados_listaPorIngresarApunte;
        }

        public void LimpiarLista()
        {
            Empleados_listaPorIngresarApunte.Clear();
        }

        public int CantidadEnListaPorApunte()
        {
            return Empleados_listaPorIngresarApunte.Count;
        }


    }
}