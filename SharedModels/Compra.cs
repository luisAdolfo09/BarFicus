using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedModels
{
    public class Compra
    {
        public int IdCompra { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        // Clave foránea de Proveedor
        [ForeignKey("Proveedor")] // Indica que 'IdProveedor' es una clave foránea que referencia a la tabla Proveedor
        public int? IdProveedor { get; set; } // Nullable para permitir que pueda ser nulo

        [Range(0, double.MaxValue, ErrorMessage = "El total debe ser un valor positivo.")]
        public decimal Total { get; set; }

        [MaxLength(500, ErrorMessage = "La descripción no puede ser mayor a 500 caracteres.")]
        public string Descripcion { get; set; }

        // Relación con la entidad Proveedor
        public virtual Proveedor Proveedor { get; set; }
    }
}
