using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Servidores
    {
        public int Id { get; set; }
        public string NombreServidor { get; set; }
        public string IPServidor { get; set; }
        public string Base_Datos { get; set; }
        public bool Estatus_Servidor { get; set; }
    }
}
