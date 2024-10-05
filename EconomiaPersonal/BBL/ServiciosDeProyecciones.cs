using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL
{
    public abstract class ServiciosDeProyecciones
    {
        private RepositorioProyecciones proyecciones;

        public ServiciosDeProyecciones()
        {
            proyecciones = new RepositorioProyecciones(DAL.Configuracion.ARCHIVO_PROYECCIONES);
        }

        public bool RegistrarProyeccion(Proyeccion proyeccion)
        {
            proyecciones.guardarDatos(proyeccion);
            return true;
        }
        public bool EliminarProyeccion(int idProyeccion)
        {
            proyecciones.eliminarDatos(idProyeccion);
            return true;
        }
        public Proyeccion BuscarProyeccion(int idProyeccion)
        {
            return proyecciones.buscarDato(idProyeccion);
        }
        public List<Proyeccion> ObtenerProyeccion()
        {
            return proyecciones.obtenerDatos();
        }
    }
}
