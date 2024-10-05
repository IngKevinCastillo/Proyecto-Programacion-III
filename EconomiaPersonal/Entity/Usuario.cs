using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Usuario : Persona
    {
        public Usuario() { }
        public Usuario(int idUsuario, string nombreUsuario, string contraseñaUsuario)
        {
            IdUsuario = idUsuario;
            NombreUsuario = nombreUsuario;
            ContraseñaUsuario = contraseñaUsuario;
        }
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ContraseñaUsuario { get; set; }
        public override string ToString()
        {
            return $"{base.ToString()};{IdUsuario};{NombreUsuario};{ContraseñaUsuario}";
        }
    }
}
