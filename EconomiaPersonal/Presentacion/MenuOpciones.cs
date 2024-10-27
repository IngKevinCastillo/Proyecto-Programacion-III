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
        ServiviosAdmin ServiviosAdmin = new ServiviosAdmin();
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
            Console.Write("Digite el id del ingreso a buscar: "); int idIngreso = int.Parse(Console.ReadLine());
            Console.WriteLine("\n" + ServiviosApp.BuscarIngreso(idIngreso));
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
            Console.WriteLine("\n" + ServiviosApp.BuscarGasto(idEgreso));
        }
        public void consultaGasto()
        {
            Console.Write("Digite la fecha inicial (DD-MM-YYYY): "); string fecha = Console.ReadLine();
            DateTime fechaGastoInicial;
            if (!DateTime.TryParseExact(fecha, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out fechaGastoInicial))
            {
                Console.WriteLine("Formato de fecha inválido. Debe ser DD-MM-YYYY.");
                return;
            }
            Console.Write("Digite la fecha final (DD-MM-YYYY): "); string fecha2 = Console.ReadLine();
            DateTime fechaGastoFinal;
            if (!DateTime.TryParseExact(fecha2, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out fechaGastoFinal))
            {
                Console.WriteLine("Formato de fecha inválido. Debe ser DD-MM-YYYY.");
                return;
            }
            Console.WriteLine("\n" + ServiviosApp.consultaGastoPorRango(fechaGastoInicial,fechaGastoFinal));
        }
        public void ConsultaGastosAnuales()
        {
            Console.Write("Digite el anio a consultar: "); int año = int.Parse(Console.ReadLine());
            Console.WriteLine("\n" + ServiviosApp.ConsultaGastosAnuales(año));
        }
        public void ConsultaGastosMensuales()
        {
            Console.Write("Digite el mes inicial: "); int fechaInicial = int.Parse(Console.ReadLine());
            Console.Write("Digite el mes final: "); int fechaFinal = int.Parse(Console.ReadLine());
            Console.WriteLine("\n" + ServiviosApp.ConsultaGastosMensualesPorRango(fechaInicial, fechaFinal));
        }
        public void consultaIngreso()
        {
            Console.Write("Digite la fecha inicial (DD-MM-YYYY): "); string fecha = Console.ReadLine();
            DateTime fechaIngresoInicial;
            if (!DateTime.TryParseExact(fecha, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out fechaIngresoInicial))
            {
                Console.WriteLine("Formato de fecha inválido. Debe ser DD-MM-YYYY.");
                return;
            }
            Console.Write("Digite la fecha final (DD-MM-YYYY): "); string fecha2 = Console.ReadLine();
            DateTime fechaIngresoFinal;
            if (!DateTime.TryParseExact(fecha2, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out fechaIngresoFinal))
            {
                Console.WriteLine("Formato de fecha inválido. Debe ser DD-MM-YYYY.");
                return;
            }
            Console.WriteLine("\n" + ServiviosApp.consultaIngresoPorRango(fechaIngresoInicial, fechaIngresoFinal));
        }
        public void ConsultaIngresosAnuales()
        {
            Console.Write("Digite el anio a consultar: "); int año = int.Parse(Console.ReadLine());
            Console.WriteLine("\n" + ServiviosApp.ConsultaIngresosAnuales(año));
        }
        public void ConsultaIngresosMensuales()
        {
            Console.Write("Digite el mes inicial: "); int fechaInicial = int.Parse(Console.ReadLine());
            Console.Write("Digite el mes final: "); int fechaFinal = int.Parse(Console.ReadLine());
            Console.WriteLine("\n" + ServiviosApp.ConsultaIngresosMensualesPorRango(fechaInicial, fechaFinal));
        }
        public void AgregarUsuario()
        {
            Usuario usuario = null;
            Console.Write("Digite el nombre de la persona: "); string nombrePersona = Console.ReadLine();
            Console.Write("Digite el apellido de la persona: "); string apellidoPersona = Console.ReadLine();
            Console.Write("Digite el correo de la persona: "); string correoPersona = Console.ReadLine();
            Console.Write("Digite el id del usuario: "); int idUsuario = int.Parse(Console.ReadLine());
            Console.Write("Digite el nombre del usuario: "); string nombreUsuario = Console.ReadLine();
            Console.Write("Digite la contraseña del usuario: "); string contraseñaUsuario = Console.ReadLine();
            usuario = new Usuario(nombrePersona,apellidoPersona,correoPersona, idUsuario,nombreUsuario,contraseñaUsuario);
            ServiviosAdmin.AgregarUsuario(usuario);
        }
        public void EliminarUsuario()
        {
            Console.Write("Digite el id del usuario a eliminar: "); int idUsuario = int.Parse(Console.ReadLine());
            ServiviosAdmin.EliminarUsuario(idUsuario);
        }
        public void BuscarUsuario()
        {
            Console.Write("Digite el id del usuario a buscar: "); int idUsuario = int.Parse(Console.ReadLine());
            Console.WriteLine(ServiviosAdmin.BuscarUsuario(idUsuario).ToString());
        }
    }
}
