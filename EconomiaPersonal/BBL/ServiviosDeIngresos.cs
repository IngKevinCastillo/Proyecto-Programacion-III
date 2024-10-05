using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL
{
    public abstract class ServiviosDeIngresos
    {
        private RepositorioIngresos ingresos;

        public ServiviosDeIngresos()
        {
            ingresos = new RepositorioIngresos(DAL.Configuracion.ARCHIVO_INGRESOS);
        }

        public void RegistrarIngreso(Ingreso ingreso)
        {
            ingresos.guardarDatos(ingreso);
        }
        public void EliminarIngreso(int idIngreso)
        {
            ingresos.eliminarDatos(idIngreso);
        }
        public Ingreso BuscarIngreso(int idIngreso)
        {
            return ingresos.buscarDato(idIngreso);
        }
        public string consultaIngresoPorRango(DateTime fechaInicial, DateTime fechaFinal)
        {
            return null;
        }
        public List<Ingreso> ObtenerIngresos()
        {
            return ingresos.obtenerDatos();
        }
        public string ConsultaIngresosMensualesPorRango(DateTime fechaInicial, DateTime fechaFinal)
        {
            return null;
        }
        public double ConsultaIngresosAnualesPorRango(DateTime fechaInicial, DateTime fechaFinal)
        {
            return 0.0;
        }
    }
}
