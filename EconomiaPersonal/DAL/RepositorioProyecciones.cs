using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RepositorioProyecciones : RepositorioPrincipal<Proyeccion>
    {
        public RepositorioProyecciones(string nombreArchivo) : base(nombreArchivo)
        {
        }

        public override Proyeccion buscarDato(int id)
        {
            List<Proyeccion> proyecciones = cargarDatos();
            Proyeccion proyeccionConsultado = proyecciones.Find(proyeccionAConsultar => proyeccionAConsultar.IdProyeccion == id);
            return proyeccionConsultado;
        }

        public override List<Proyeccion> cargarDatos()
        {
            try
            {
                List<Entity.Proyeccion> proyecciones = new List<Entity.Proyeccion>();
                string linea;
                StreamReader lector = new StreamReader(_nombreArchivo);
                while (!lector.EndOfStream)
                {
                    linea = lector.ReadLine();
                    proyecciones.Add(Mapeo(linea));
                }
                lector.Close();
                return proyecciones;
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
                List<Proyeccion> proyecciones = cargarDatos();
                proyecciones.Remove(proyecciones.Find(ahorroAConsultar => ahorroAConsultar.IdProyeccion == id));
                using (StreamWriter escritor = new StreamWriter(_nombreArchivo, false))
                {
                    foreach (Proyeccion ListaProyeccionesNueva in proyecciones)
                    {
                        escritor.WriteLine(ListaProyeccionesNueva.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar un dato. El error esta en: {ex.ToString()}");
            }
        }

        public override List<Proyeccion> obtenerDatos()
        {
            List<Entity.Proyeccion> proyecciones = null;
            proyecciones = cargarDatos();
            return proyecciones;
        }

        private Proyeccion Mapeo(string linea)
        {
            Proyeccion proyeccion = new Proyeccion();
            proyeccion.IdProyeccion = int.Parse(linea.Split(';')[0]);
            proyeccion.DescipcionProyeccion = linea.Split(';')[1];
            proyeccion.MontoProyeccion = int.Parse(linea.Split(';')[2]);
            return proyeccion;
        }
    }
}
