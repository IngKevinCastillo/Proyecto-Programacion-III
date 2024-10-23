using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL
{
    internal interface ServiciosDeGastos
    {
        void RegistrarGasto(Gasto gasto);
        void EliminarGasto(int idGasto);
        Gasto BuscarGasto(int idGasto);
        string consultaGastoPorRango(DateTime fechaInicial, DateTime fechaFinal);
        List<Gasto> ObtenerGastos();
        double ConsultaGastosMensualesPorRango(int mesInicial, int mesFinal);
        double ConsultaGastosAnuales(int año);
    }

}
