using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class RepositorioPrincipal<T>
    {
        protected string _nombreArchivo;
        public RepositorioPrincipal(string nombreArchivo)
        {
            _nombreArchivo = nombreArchivo;
        }
        public string guardarDatos(T entidad)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(_nombreArchivo, true);
                escritor.WriteLine(entidad.ToString());
                escritor.Close();
                return "datos almacenados correctamente";
            }
            catch (Exception ex)
            {
                return ("error al guardar " + ex.Message);
            }

        }
        public abstract List<T> cargarDatos();
        public abstract T buscarDato(int id);
        public abstract List<T> obtenerDatos();
        public abstract void eliminarDatos(int id);
    }
}
