using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Sistemas
    {
        public int Id_sistemas { get; set; }
        public string Nombre_Sistema { get; set; }
        public bool Estatus_Sistema { get; set; }
        public Proveedores oProveedores { get; set; }
    }
}
