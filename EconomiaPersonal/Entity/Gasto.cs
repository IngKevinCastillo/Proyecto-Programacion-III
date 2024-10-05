using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Gasto
    {
        public Gasto() { }
        public Gasto(int idGasto, string descripcionGasto, string categoria,string prioridadGasto, DateTime fechaGasto, double monto)
        {
            IdGasto = idGasto;
            DescripcionGasto = descripcionGasto;
            PrioridadGasto = prioridadGasto;
            Categoria = categoria;
            FechaGasto = fechaGasto;
            Monto = monto;
        }
        public Cuenta Cuenta { get; set; }
        public int IdGasto { get; set; }
        public string DescripcionGasto { get; set; }
        public string PrioridadGasto { get; set; }
        public string Categoria {  get; set; }
        public DateTime FechaGasto { get; set; }
        public double Monto { get; set; }
        public override string ToString()
        {
            return $"{IdGasto};{DescripcionGasto};{PrioridadGasto};{Categoria};{FechaGasto.ToString("yyyy-MM-dd")};{Monto}";
        }
    }
}
    