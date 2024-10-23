using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RepositorioUsuarios : RepositorioPrincipal<Usuario>
    {
        public RepositorioUsuarios(string nombreArchivo) : base(nombreArchivo)
        {
        }
        public override Usuario buscarDato(int id)
        {
            List<Usuario> usuarios = cargarDatos();
            Usuario usuarioConsultado = usuarios.Find(usuarioAConsultar => usuarioAConsultar.IdUsuario == id);
            return usuarioConsultado;
        }

        public override List<Usuario> cargarDatos()
        {
            try
            {
                List<Entity.Usuario> usuarios = new List<Entity.Usuario>();
                string linea;
                StreamReader lector = new StreamReader(_nombreArchivo);
                while (!lector.EndOfStream)
                {
                    linea = lector.ReadLine();
                    usuarios.Add(Mapeo(linea));
                }
                lector.Close();
                return usuarios;
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
                List<Usuario> usuarios = cargarDatos();
                usuarios.RemoveAll(usuarioAEliminar => usuarioAEliminar.IdUsuario == id);
                using (StreamWriter escritor = new StreamWriter(_nombreArchivo, false))
                {
                    foreach (Usuario ListaUsuariosNueva in usuarios)
                    {
                        escritor.WriteLine(ListaUsuariosNueva.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar un dato. El error esta en: {ex.ToString()}");
            }
        }

        public override List<Usuario> obtenerDatos()
        {
            List<Entity.Usuario> usuarios = cargarDatos();
            return usuarios;
        }
        private Usuario Mapeo(string linea)
        {
            Usuario usuario = new Usuario();
            usuario.NombrePersona = linea.Split(';')[0];
            usuario.ApellidoPersona = linea.Split(';')[1];
            usuario.CorreoPersona = linea.Split(';')[2];
            usuario.IdUsuario = int.Parse(linea.Split(';')[3]);
            usuario.NombreUsuario = linea.Split(';')[4];
            usuario.ContraseñaUsuario = linea.Split(';')[5];
            return usuario;
        }
    }
}
