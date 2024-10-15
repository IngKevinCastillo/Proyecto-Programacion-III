using BBL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Presentacion
{
    public class MenuOpciones
    {
        ServiviosApp ServiviosApp = new ServiviosApp();
        public MenuOpciones() { }
        public void RegistrarIngreso()
        {
            Console.Write("Digite el id del ingreso: "); int idIngreso = int.Parse(Console.ReadLine());
            Console.Write("Digite la descripcion del ingreso: "); string descripcionIngreso = Console.ReadLine();
            Console.Write("Digite la fecha del ingreso (DD-MM-YYYY): ");
            string fecha = Console.ReadLine();
            DateTime fechaIngreso;
            if (!DateTime.TryParseExact(fecha, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out fechaIngreso))
            {
                Console.WriteLine("Formato de fecha inválido. Debe ser DD-MM-YYYY.");
                return;
            }
            Console.Write("Digite el monto del ingreso: "); double monto = double.Parse(Console.ReadLine());
            Ingreso ingreso = new Ingreso(idIngreso, descripcionIngreso, fechaIngreso, monto);
            ServiviosApp.RegistrarIngreso(ingreso);
        }
        public void EliminarIngreso()
        {
            Console.Write("Digite el id del ingreso a eliminar: "); int idIngreso = int.Parse(Console.ReadLine());
            ServiviosApp.EliminarIngreso(idIngreso);
        }
        public void BuscarIngreso()
        {
            Console.Write("Digite el id del ingreso a eliminar: "); int idIngreso = int.Parse(Console.ReadLine());
            ServiviosApp.BuscarIngreso(idIngreso);
        }
        public void RegistrarEgreso()
        {
            Console.Write("Digite el id del egreso: "); int idEgreso = int.Parse(Console.ReadLine());
            Console.Write("Digite la descripcion del egreso: "); string descripcionGasto = Console.ReadLine();
            Console.Write("Digite la fecha del egreso (DD-MM-YYYY): "); string fecha = Console.ReadLine();
            DateTime fechaGasto;
            if (!DateTime.TryParseExact(fecha, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out fechaGasto))
            {
                Console.WriteLine("Formato de fecha inválido. Debe ser DD-MM-YYYY.");
                return;
            }
            Console.Write("Digite la categoria del gasto: "); string categoria = Console.ReadLine();
            Console.Write("Es un gasto prioritario?(SI/NO)"); string prioridadGasto = Console.ReadLine();
            Console.Write("Digite el monto del egreso: "); double monto = double.Parse(Console.ReadLine());
            Gasto gasto = new Gasto(idEgreso,descripcionGasto,categoria,prioridadGasto,fechaGasto,monto);
            ServiviosApp.RegistrarGasto(gasto);
        }
        public void EliminarEgreso()
        {
            Console.Write("Digite el id del egreso a eliminar: "); int idEgreso = int.Parse(Console.ReadLine());
            ServiviosApp.EliminarGasto(idEgreso);
        }
        public void BuscarEgreso()
        {
            Console.Write("Digite el id del egreso: "); int idEgreso = int.Parse(Console.ReadLine());
            ServiviosApp.BuscarGasto(idEgreso);
        }
        public void consultaGasto()
        {
            
        }
        public void ConsultaGastosAnuales()
        {
            
        }
        public void ConsultaGastosMensuales()
        {
            
        }
        public void consultaIngreso()
        {
            
        }
        public void ConsultaIngresosAnuales()
        {
            
        }
        public void ConsultaIngresosMensuales()
        {
            
        }
    }
}
