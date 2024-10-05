using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Proyeccion
    {
        public Proyeccion() { }
        public Proyeccion(int idProyeccion, string descipcionProyeccion, double montoProyeccion)
        {
            IdProyeccion = idProyeccion;
            DescipcionProyeccion = descipcionProyeccion;
            MontoProyeccion = montoProyeccion;
        }
        public Cuenta Cuenta { get; set; }
        public int IdProyeccion {  get; set; }
        public string DescipcionProyeccion { get; set; }
        public double MontoProyeccion { get;set; }
        public override string ToString()
        {
            return $"{IdProyeccion};{DescipcionProyeccion};{MontoProyeccion}";
        }
    }
}
