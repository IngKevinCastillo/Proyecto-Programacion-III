using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL
{
    internal abstract class ServiciosDeGastos
    {
        private RepositorioGastos gastos;
        public ServiciosDeGastos()
        {
            gastos = new RepositorioGastos(DAL.Configuracion.ARCHIVO_GASTOS);
        }

        public void RegistrarGasto(Gasto gasto)
        {
            gastos.guardarDatos(gasto);
        }
        public void EliminarGasto(int idGasto)
        {
            gastos.eliminarDatos(idGasto);
        }
        public Gasto BuscarGasto(int idGasto)
        {
            return gastos.buscarDato(idGasto);
        }
        public string consultaGastoPorRango(DateTime fechaInicial, DateTime fechaFinal)
        {
            return null;
        } 
        public List<Gasto> ObtenerGastos()
        {
            return gastos.obtenerDatos();
        }
        public double ConsultaGastosMensualesPorRango(DateTime fechaInicial, DateTime fechaFinal)
        {
            return 0.0;
        }
        public double ConsultaGastosAnualesPorRango(DateTime fechaInicial, DateTime fechaFinal)
        {
            return 0.0;
        }
        //string Estadisticas();//pendiente
    }

}
