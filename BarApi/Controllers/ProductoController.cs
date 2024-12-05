using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoData; // Asegúrate de tener un ProductoData similar al EmpleadoData
using SharedModels;

namespace ProyectoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly ProductoData _productoData;

        // Constructor para inyección de dependencia
        public ProductoController(ProductoData productoData)
        {
            _productoData = productoData;
        }

        // GET: api/producto
        [HttpGet]
        public async Task<IActionResult> Lista()
        {
            // Obtiene la lista de productos desde la capa de datos
            List<Producto> lista = await _productoData.Lista();

            // Si la lista está vacía, responde con un código 204 (No Content)
            if (lista == null || lista.Count == 0)
            {
                return NoContent();
            }

            // Si tiene datos, responde con un código 200 (OK)
            return Ok(lista);
        }

        // POST: api/producto
        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] Producto objeto)
        {
            // Valida que el objeto no sea nulo
            if (objeto == null)
            {
                return BadRequest("El producto no puede ser nulo");
            }

            // Llama a la capa de datos para crear el producto
            bool respuesta = await _productoData.Crear(objeto);

            // Si la creación es exitosa, responde con un código 201 (Created) y los detalles
            if (respuesta)
            {
                return CreatedAtAction(nameof(Lista), new { id = objeto.IdProducto }, objeto);
            }

            // Si la creación falla, responde con un código 500 (Internal Server Error)
            return StatusCode(StatusCodes.Status500InternalServerError, new { isSuccess = respuesta });
        }

        // PUT: api/producto
        [HttpPut]
        public async Task<IActionResult> Editar([FromBody] Producto objeto)
        {
            // Valida que el objeto no sea nulo
            if (objeto == null)
            {
                return BadRequest("El producto no puede ser nulo");
            }

            // Llama a la capa de datos para editar el producto
            bool respuesta = await _productoData.Editar(objeto);

            // Si la edición es exitosa, responde con un código 200 (OK)
            if (respuesta)
            {
                return Ok(new { isSuccess = respuesta });
            }

            // Si la edición falla, responde con un código 404 (Not Found) si el producto no existe
            return NotFound(new { isSuccess = false, message = "Producto no encontrado" });
        }

        // DELETE: api/producto/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            // Llama a la capa de datos para eliminar el producto
            bool respuesta = await _productoData.Eliminar(id);

            // Si la eliminación es exitosa, responde con un código 200 (OK)
            if (respuesta)
            {
                return Ok(new { isSuccess = respuesta });
            }

            // Si la eliminación falla, responde con un código 404 (Not Found) si el producto no existe
            return NotFound(new { isSuccess = false, message = "Producto no encontrado" });
        }
    }
}
