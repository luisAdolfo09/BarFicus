using SharedModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using System;
using System.ComponentModel.DataAnnotations;

public class Compra
{
    public int IdCompra { get; set; }

    [Required]
    public DateTime Fecha { get; set; }

    // El campo IdProveedor se mantiene, pero no es una clave foránea.
    public int? IdProveedor { get; set; }  // Aquí se mantiene el ID del proveedor, pero no es una clave foránea.

    [Range(0, double.MaxValue, ErrorMessage = "El total debe ser un valor positivo.")]
    public decimal Total { get; set; }

    [MaxLength(500, ErrorMessage = "La descripción no puede ser mayor a 500 caracteres.")]
    public string Descripcion { get; set; }
}


