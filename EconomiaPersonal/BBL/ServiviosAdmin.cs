using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL
{
    public class ServiviosAdmin
    {
        private RepositorioUsuarios usuarios;

        public ServiviosAdmin()
        {
            usuarios = new RepositorioUsuarios(DAL.Configuracion.ARCHIVO_USUARIOS);
        }

        public void AgregarUsuario(Usuario usuario)
        {
            usuarios.guardarDatos(usuario);

        }

        public void EliminarUsuario(int idUsuario)
        {
            usuarios.eliminarDatos(idUsuario);
        }

        public Usuario BuscarUsuario(int idUsuario)
        {
            return usuarios.buscarDato(idUsuario);
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return usuarios.obtenerDatos();
        }
    }
}
