using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class MenuPrincipal
    {
        public void Menu()
        {
            int OP = 0;

            do
            {
                Console.WriteLine("*****CRUD de Personas*****");
                Console.WriteLine("1. Agregar una persona.");
                Console.WriteLine("2. Eliminar a una persona.");
                Console.WriteLine("3. Buscar a una persona.");
                Console.WriteLine("4. Lista de todas las personas.");
                Console.WriteLine("5. Modificar datos de un Persona");
                Console.WriteLine("6. Salir del programa.");
                Console.Write("Seleccione una opcion: ");
                OP = int.Parse(Console.ReadLine());

                switch (OP)
                {
                    case 1:
                        break;
                    default:
                        Console.WriteLine("Seleccione una opcion valida.");
                        break;
                }
            } while (OP != 6);
            Console.ReadKey();
        }
    }
}
