using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cuenta
    {
        public Cuenta() { }
        public Usuario UsuarioCuenta {  get; set; }
        public List<Proyeccion> proyecciones {  get; set; }
        public List<Gasto> gastos { get; set; }
        public List<Ingreso> ingresos { get; set; }
    }
}
