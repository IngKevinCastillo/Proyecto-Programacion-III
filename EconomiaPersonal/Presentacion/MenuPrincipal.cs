using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class MenuPrincipal
    {
        MenuOpciones menuOpciones = new MenuOpciones();
        public void Menu()
        {
            int OP = 0;

            do
            {
                Console.WriteLine("\n*****ECONOMIA PERSONAL*****");
                Console.WriteLine("1. Servicios de Ingresos.");
                Console.WriteLine("2. Servicios de Egresos.");
                Console.WriteLine("3. Servicios de Consulta.");
                Console.WriteLine("4. Salir del programa.\n");
                Console.Write("Seleccione una opcion: ");
                OP = int.Parse(Console.ReadLine());

                switch (OP)
                {
                    case 1:
                        ServiciosIngresos();
                        break;
                    case 2:
                        ServiciosEgresos();
                        break;
                    case 3:
                        ServiciosConsulta();
                        break;
                    case 4:
                        Console.WriteLine("SALIENDO DE LA APP.............");
                        break;
                    default:
                        Console.WriteLine("Seleccione una opcion valida.");
                        break;
                }
            } while (OP != 4);
            Console.ReadKey();
        }
        private void ServiciosIngresos()
        {
            int OP = 0;
            do
            {
                Console.WriteLine("\n*****SERVICIO INGRESOS*****");
                Console.WriteLine("1. Registrar Ingreso.");
                Console.WriteLine("2. Eliminar Ingreso.");
                Console.WriteLine("3. Buscar Ingreso.");
                Console.WriteLine("4. Regresar.\n");
                Console.Write("Seleccione una opcion: ");
                OP = int.Parse(Console.ReadLine());

                switch (OP)
                {
                    case 1:
                        menuOpciones.RegistrarIngreso();
                        break;
                    case 2:
                        menuOpciones.EliminarIngreso();
                        break;
                    case 3:
                        menuOpciones.BuscarIngreso();
                        break;
                    case 4:
                        Console.WriteLine("REGRESANDO A MENU PPALL.......");
                        break;
                    default:
                        Console.WriteLine("Seleccione una opcion valida.");
                        break;
                }
            } while (OP != 4);
        }
        private void ServiciosEgresos()
        {
            int OP = 0;
            do
            {
                Console.WriteLine("\n*****SERVICIO EGRESOS*****");
                Console.WriteLine("1. Registrar Egreso.");
                Console.WriteLine("2. Eliminar Egreso.");
                Console.WriteLine("3. Buscar Egreso.");
                Console.WriteLine("4. Regresar.\n");
                Console.Write("Seleccione una opcion: ");
                OP = int.Parse(Console.ReadLine());

                switch (OP)
                {
                    case 1:
                        menuOpciones.RegistrarEgreso();
                        break;
                    case 2:
                        menuOpciones.EliminarEgreso();
                        break;
                    case 3:
                        menuOpciones.BuscarEgreso();
                        break;
                    case 4:
                        Console.WriteLine("REGRESANDO A MENU PPALL.......");
                        break;
                    default:
                        Console.WriteLine("Seleccione una opcion valida.");
                        break;
                }
            } while (OP != 4);
        }
        private void ServiciosConsulta()
        {
            int OP = 0;
            do
            {
                Console.WriteLine("\n*****SERVICIO CONSULTAS*****");
                Console.WriteLine("1. Consultar Gastos.");
                Console.WriteLine("2. Consulta Gastos Anuales.");
                Console.WriteLine("3. Consulta Gastos Mensuales.");
                Console.WriteLine("4. Consultar Ingresos.");
                Console.WriteLine("5. Consulta Ingresos Anuales.");
                Console.WriteLine("6. Consulta Ingresos Mensuales.");
                Console.WriteLine("7. Regresar.\n");
                Console.Write("Seleccione una opcion: ");
                OP = int.Parse(Console.ReadLine());

                switch (OP)
                {
                    case 1:
                        menuOpciones.consultaGasto();
                        break;
                    case 2:
                        menuOpciones.ConsultaGastosMensuales();
                        break;
                    case 3:
                        menuOpciones.ConsultaGastosAnuales();
                        break;
                    case 4:
                        menuOpciones.consultaIngreso();
                        break;
                    case 5:
                        menuOpciones.ConsultaIngresosMensuales();
                        break;
                    case 6:
                        menuOpciones.ConsultaIngresosAnuales();
                        break;
                    case 7:
                        Console.WriteLine("REGRESANDO A MENU PPALL.......");
                        break;
                    default:
                        Console.WriteLine("Seleccione una opcion valida.");
                        break;
                }
            } while (OP != 7);
        }
    }
}
