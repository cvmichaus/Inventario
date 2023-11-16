using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Empleados
    {
        public int Id_Empleado { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public Departamentos oDepatamentos { get; set; }
        public Areas oAreas { get; set; }
        public Puestos oPuestos { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaRetiro { get; set; }

    }
}
