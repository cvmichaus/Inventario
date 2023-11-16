using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Equipos
    {
        public int id_equipos { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool Activo { get; set; }
        public Empleados oEmpleados { get; set; }
        public string Memoria { get; set; }
        public string Procesador { get; set; }
        public string DDCapacidad { get; set; }
        public string DDMarca { get; set; }
        public string NumeroSerie { get; set; }
        public DateTime Fecha { get; set; }


    }
}
