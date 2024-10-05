using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RepositorioIngresos : RepositorioPrincipal<Entity.Ingreso>
    {
        public RepositorioIngresos(string nombreArchivo) : base(nombreArchivo)
        {
        }
        public override Ingreso buscarDato(int id)
        {
            List<Ingreso> ingresos = cargarDatos();
            Ingreso ingresoConsultado = ingresos.Find(ingresoAConsultar => ingresoAConsultar.IdIngreso == id);
            return ingresoConsultado;
        }
        public override List<Ingreso> cargarDatos()
        {
            try
            {
                List<Entity.Ingreso> ingresos = new List<Entity.Ingreso>();
                string linea;
                StreamReader lector = new StreamReader(_nombreArchivo);
                while (!lector.EndOfStream)
                {
                    linea = lector.ReadLine();
                    ingresos.Add(Mapeo(linea));
                }
                lector.Close();
                return ingresos;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al mostra los datos. El error esta en: {ex.Message}");
                return null;
            }
        }
        public override void eliminarDatos(int id)
        {
            try
            {
                List<Ingreso> ingresos = cargarDatos();
                ingresos.RemoveAll(ingresoAEliminar => ingresoAEliminar.IdIngreso == id);
                using (StreamWriter escritor = new StreamWriter(_nombreArchivo, false))
                {
                    foreach (Ingreso ListaIngresosNueva in ingresos)
                    {
                        escritor.WriteLine(ListaIngresosNueva.ToString());
                    }
                }
            }
            catch ( Exception ex)
            {
                Console.WriteLine($"Error al eliminar un dato. El error esta en: {ex.ToString()}");
            }
        }
        public override List<Ingreso> obtenerDatos()
        {
            List<Entity.Ingreso> ingresos = null;
            ingresos = cargarDatos();
            return ingresos;
        }
        private Ingreso Mapeo(string linea)
        {
            Ingreso ingreso = new Ingreso();
            ingreso.IdIngreso = int.Parse(linea.Split(';')[0]);
            ingreso.DescripcionIngreso = linea.Split(';')[1];
            ingreso.FechaIngreso = DateTime.Parse(linea.Split(';')[2]);
            ingreso.Monto = double.Parse(linea.Split(';')[3]);
            return ingreso;
        }
        /*
         public double totalGasto()
        {
            double totalGastos = 0;
            foreach (var gasto in Gastos)
            {
                totalGastos += gasto.Monto;
            }
            return totalGastos;
        }
        public double totalIngresos()
        {
            double totalIngresos = 0;
            foreach (var ingreso in Ingresos)
            {
                totalIngresos += ingreso.Monto;
            }
         */
    }
}
