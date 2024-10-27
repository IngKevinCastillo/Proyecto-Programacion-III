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
        public Usuario(string nombre, string apellido, string correoElectronico, int idUsuario, string nombreUsuario, string contraseñaUsuario)
        {
            base.NombrePersona = nombre;
            base.ApellidoPersona = apellido;
            base.CorreoPersona = correoElectronico;
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
