using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL
{
    public class Servivios : ServiciosDeProyecciones//, ServiciosDeGastos, ServiviosDeIngresos
    {
        public Servivios(RepositorioProyecciones proyecciones) : base(proyecciones)
        {
        }
    }
}
