using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
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
            throw new NotImplementedException();
        }
        public double ConsultaGastosAnualesPorRango(DateTime fechaInicial, DateTime fechaFinal)
        {
            throw new NotImplementedException();
        }
        public double ConsultaGastosMensualesPorRango(DateTime fechaInicial, DateTime fechaFinal)
        {
            throw new NotImplementedException();
        }
        public string consultaIngresoPorRango(DateTime fechaInicial, DateTime fechaFinal)
        {
            throw new NotImplementedException();
        }
        public double ConsultaIngresosAnualesPorRango(DateTime fechaInicial, DateTime fechaFinal)
        {
            throw new NotImplementedException();
        }
        public string ConsultaIngresosMensualesPorRango(DateTime fechaInicial, DateTime fechaFinal)
        {
            throw new NotImplementedException();
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
    }
}
