using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Ingreso
    {
        public Ingreso() { }
        public Ingreso(int idIngreso, string descripcionIngreso, DateTime fechaIngreso, double monto)
        {
            IdIngreso = idIngreso;
            DescripcionIngreso = descripcionIngreso;
            FechaIngreso = fechaIngreso;
            Monto = monto;
        }
        public Cuenta Cuenta { get; set; }
        public int IdIngreso { get; set; }
        public string DescripcionIngreso {  get; set; }
        public DateTime FechaIngreso { get; set; }
        public double Monto { get; set; } = 0;
        public override string ToString()
        {
            return $"{IdIngreso};{DescripcionIngreso};{FechaIngreso.ToString("yyyy-MM-dd")};{Monto}";
        }
    }
}
