﻿using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL
{
    public interface ServiviosDeIngresos
    {
        void RegistrarIngreso(Ingreso ingreso);
        void EliminarIngreso(int idIngreso);
        Ingreso BuscarIngreso(int idIngreso);
        string consultaIngresoPorRango(DateTime fechaInicial, DateTime fechaFinal);
        List<Ingreso> ObtenerIngresos();
        double ConsultaIngresosMensualesPorRango(int mesInicial, int mesFinal);
        double ConsultaIngresosAnuales(int año);
    }
}
