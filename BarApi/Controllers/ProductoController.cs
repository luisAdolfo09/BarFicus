using Microsoft.AspNetCore.Mvc;
using ProyectoData;
using SharedModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly ProductoData _productoData;

        // Constructor para inyectar ProductoData
        public ProductoController(ProductoData productoData)
        {
            _productoData = productoData;
        }

        // GET: api/Producto
        [HttpGet]
        public async Task<ActionResult<List<Producto>>> GetProductos()
        {
            try
            {
                var productos = await _productoData.Lista();
                if (productos == null || productos.Count == 0)
                {
                    return NotFound("No se encontraron productos.");
                }
                return Ok(productos);
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, $"Error en el servidor: {ex.Message}");
            }
        }

        // GET: api/Producto/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Producto>> GetProducto(int id)
        {
            try
            {
                // Llamar al método para obtener un producto por su ID
                var producto = await _productoData.Lista(); // Puedes modificar este método para que retorne solo un producto por ID
                var productoBuscado = producto.Find(p => p.IdProducto == id); // Usando LINQ para buscar el producto por su ID

                if (productoBuscado == null)
                {
                    return NotFound($"Producto con ID {id} no encontrado.");
                }

                return Ok(productoBuscado);
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, $"Error en el servidor: {ex.Message}");
            }
        }

        // POST: api/Producto
        [HttpPost]
        public async Task<ActionResult> CrearProducto([FromBody] Producto nuevoProducto)
        {
            try
            {
                // Validar que el producto no sea nulo
                if (nuevoProducto == null)
                {
                    return BadRequest("El producto no puede ser nulo.");
                }

                var resultado = await _productoData.Crear(nuevoProducto);
                if (resultado)
                {
                    return CreatedAtAction(nameof(GetProducto), new { id = nuevoProducto.IdProducto }, nuevoProducto);
                }
                else
                {
                    return BadRequest("No se pudo crear el producto.");
                }
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, $"Error en el servidor: {ex.Message}");
            }
        }

        // PUT: api/Producto/5
        [HttpPut("{id}")]
        public async Task<ActionResult> EditarProducto(int id, [FromBody] Producto productoActualizado)
        {
            try
            {
                // Verificar que el ID coincida con el producto que se está actualizando
                if (productoActualizado.IdProducto != id)
                {
                    return BadRequest("El ID del producto no coincide con el ID en la URL.");
                }

                var resultado = await _productoData.Editar(productoActualizado);
                if (resultado)
                {
                    return Ok("Producto actualizado correctamente.");
                }
                else
                {
                    return BadRequest("No se pudo actualizar el producto.");
                }
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, $"Error en el servidor: {ex.Message}");
            }
        }

        // DELETE: api/Producto/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> EliminarProducto(int id)
        {
            try
            {
                var resultado = await _productoData.Eliminar(id);
                if (resultado)
                {
                    return Ok("Producto eliminado correctamente.");
                }
                else
                {
                    return BadRequest("No se pudo eliminar el producto.");
                }
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, $"Error en el servidor: {ex.Message}");
            }
        }
    }
}
