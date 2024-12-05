using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; } // Ensure validation for 'Platillo', 'Bebida', 'Ingrediente' is handled
        public string Marca { get; set; }
        public decimal Precio { get; set; }
        public int CantidadDisponible { get; set; } = 0;
        public string Descripcion { get; set; }
        public DateTime? FechaCaducidad { get; set; }
    }
}
