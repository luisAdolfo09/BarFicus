using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Ingrediente
    {
        public int IdIngrediente { get; set; }
        public string Nombre { get; set; }
        public decimal CostoUnitario { get; set; }
        public int CantidadDisponible { get; set; } = 0;
        public string Descripcion { get; set; }
        public DateTime? FechaCaducidad { get; set; }
        public int? IdProducto { get; set; } // Nullable to support ON DELETE SET NULL
    }
}
