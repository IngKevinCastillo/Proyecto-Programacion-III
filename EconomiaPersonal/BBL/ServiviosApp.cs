using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BBL
{
    public class ServiviosApp : ServiviosDeIngresos, ServiciosDeGastos
    {
        private RepositorioIngresos ingresos;
        private RepositorioGastos gastos;
        public ServiviosApp()
        {
            gastos = new RepositorioGastos(Configuracion.ARCHIVO_GASTOS);
            ingresos = new RepositorioIngresos(Configuracion.ARCHIVO_INGRESOS);
        }
        public Gasto BuscarGasto(int idGasto)
        {
            return gastos.buscarDato(idGasto);
        }
        public Ingreso BuscarIngreso(int idIngreso)
        {
            return ingresos.buscarDato(idIngreso);
        }
        public string consultaGastoPorRango(DateTime fechaInicial, DateTime fechaFinal)
        {
            List<Gasto> listagastos = ObtenerGastos();
            List<Gasto> gastosEncontrados = new List<Gasto>();
            foreach (Gasto item in listagastos)
            {
                if (item.FechaGasto >= fechaInicial && item.FechaGasto <= fechaFinal)
                {
                    gastosEncontrados.Add(item);
                }
            }
            if (gastosEncontrados.Count == 0)
            {
                return "No se encontraron gastos en el rango de fechas especificado.";
            }
            StringBuilder resultado = new StringBuilder();
            foreach (Gasto gasto in gastosEncontrados)
            {
                resultado.AppendLine($"{gasto.IdGasto}; {gasto.DescripcionGasto}; {gasto.Categoria}; {gasto.FechaGasto.ToString("dd-MM-yyyy")}; {gasto.Monto}");
            }
            return resultado.ToString();
        }

        public double ConsultaGastosAnuales(int año)
        {
            List<Gasto> gastos = ObtenerGastos();
            List<Gasto> datosSeleccionados = gastos.Where(gasto => gasto.FechaGasto.Year == año).ToList();
            return datosSeleccionados.Sum(dato => dato.Monto);
        }
        public double ConsultaGastosMensualesPorRango(int mesInicial, int mesFinal)
        {
            List<Gasto> gastos = ObtenerGastos();
            List<Gasto> gastosEncontrados = new List<Gasto>();
            var totalMesesSeleccionado = gastos.Where(gasto => gasto.FechaGasto.Month >= mesInicial && gasto.FechaGasto.Month <= mesFinal);
            foreach (var item in totalMesesSeleccionado)
            {
                gastosEncontrados.Add(item);
            }
            return gastosEncontrados.Sum(gasto => gasto.Monto);
        }
        public string consultaIngresoPorRango(DateTime fechaInicial, DateTime fechaFinal)
        {
            List<Ingreso> listaIngresos = ObtenerIngresos();
            List<Ingreso> ingresosEncontrados = new List<Ingreso>();
            foreach (Ingreso item in listaIngresos)
            {
                if (item.FechaIngreso >= fechaInicial && item.FechaIngreso <= fechaFinal)
                {
                    ingresosEncontrados.Add(item);
                }
            }
            if (ingresosEncontrados.Count == 0)
            {
                return "No se encontraron ingresos en el rango de fechas especificado.";
            }
            StringBuilder resultado = new StringBuilder();
            foreach (Ingreso ingreso in ingresosEncontrados)
            {
                resultado.AppendLine($"{ingreso.IdIngreso}; {ingreso.DescripcionIngreso}; {ingreso.FechaIngreso.ToString("dd-MM-yyyy")}; {ingreso.Monto}");
            }
            return resultado.ToString();
        }
        public double ConsultaIngresosAnuales(int año)
        {
            List<Ingreso> ingresos = ObtenerIngresos();
            List<Ingreso> datosSeleccionados = ingresos.Where(ingreso => ingreso.FechaIngreso.Year == año).ToList();
            return datosSeleccionados.Sum(dato => dato.Monto);
        }
        public double ConsultaIngresosMensualesPorRango(int mesInicial, int mesFinal)
        {
            List<Ingreso> ingresos = ObtenerIngresos();
            List<Ingreso> ingresosEncontrados = new List<Ingreso>();
            var totalMesesSeleccionado = ingresos.Where(ingreso => ingreso.FechaIngreso.Month >= mesInicial && ingreso.FechaIngreso.Month <= mesFinal);
            foreach (var item in totalMesesSeleccionado)
            {
                ingresosEncontrados.Add(item);
            }
            return ingresosEncontrados.Sum(ingreso => ingreso.Monto);
        }
        public void EliminarGasto(int idGasto)
        {
            ingresos.eliminarDatos(idGasto);
        }
        public void EliminarIngreso(int idIngreso)
        {
            ingresos.eliminarDatos(idIngreso);
        }
        public List<Gasto> ObtenerGastos()
        {
            return gastos.obtenerDatos();
        }
        public List<Ingreso> ObtenerIngresos()
        {
            return ingresos.obtenerDatos();
        }
        public void RegistrarGasto(Gasto gasto)
        {
           gastos.guardarDatos(gasto);
        }
        public void RegistrarIngreso(Ingreso ingreso)
        {
            ingresos.guardarDatos(ingreso);
        }
        public string consulaIngresoPorDia()
        {
            return null;
        }
        public string consulaGastoPorDia()
        {
            return null;
        }
    }
}
