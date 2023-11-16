using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuarios
    {
        public int Id_usuario { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
        public bool Estatus { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public Perfil oPerfil { get; set; }
    }
}
