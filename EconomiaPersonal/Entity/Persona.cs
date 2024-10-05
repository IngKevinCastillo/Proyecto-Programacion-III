using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Persona
    {
        public string NombrePersona { get; set; }
        public string ApellidoPersona {  get; set; }
        public string CorreoPersona {  get; set; }
        public Persona() { }
        public Persona(string nombre, string apellido, string correoElectronico)
        {
            NombrePersona = nombre;
            ApellidoPersona = apellido;
            CorreoPersona = correoElectronico;
        }
        public override string ToString()
        {
            return $"{NombrePersona};{ApellidoPersona};{CorreoPersona}";
        }
    }
}
