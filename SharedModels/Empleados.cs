using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Empleados
    {
        public int IdEmpleado { get; set; }
        public string? PrimerNombre { get; set; }
        public string? PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public string? Puesto { get; set; }
        public int Antiguedad { get; set; }
        public string? CedulaIdentidad { get; set; }
        public int Telefono { get; set; }
    }
}
