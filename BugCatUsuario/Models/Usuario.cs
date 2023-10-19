using System;
using System.Globalization;

namespace BugCatUsuario.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }  
        public string usuario { get; set; }  
        public string contraseña { get; set; }
        public string? correo { get; set; }
        public string nombre { get; set; }
        public string? apellido { get; set; }
        public string? estado { get; set; }
        public List<Tarjeta>? tarjeta { get; set; }

    }
}
