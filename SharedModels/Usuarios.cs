using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Usuarios
    {
        public int Id_Usuario { get; set; }
        public string? Nombre { get; set; }

        public bool Activo { get; set; }
        public string? Correo {  get; set; }
        public string? Clave { get; set; }

    }
}
