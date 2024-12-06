using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public int? IdCliente { get; set; } // Nullable to support ON DELETE SET NULL
        public int Id_Empleado { get; set; }
        public decimal Total { get; set; }
        public string Descripcion { get; set; }
    }
}
