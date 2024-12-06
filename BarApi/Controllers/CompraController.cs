using Microsoft.AspNetCore.Mvc;
using ProyectoData;
using SharedModels;
using System.Threading.Tasks;

namespace ProyectoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompraController : ControllerBase
    {
        private readonly CompraData _compraData;

        // Constructor para inyectar la capa de datos
        public CompraController(CompraData compraData)
        {
            _compraData = compraData;
        }

        // Obtener la lista de compras
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var compras = await _compraData.Lista();

            if (compras == null || compras.Count == 0)
            {
                return NotFound("No se encontraron compras.");
            }

            return Ok(compras);
        }

        // Obtener una compra por su ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var compra = await _compraData.Lista()
                                        .ContinueWith(t => t.Result.FirstOrDefault(c => c.IdCompra == id));

            if (compra == null)
            {
                return NotFound($"Compra con ID {id} no encontrada.");
            }

            return Ok(compra);
        }

        // Crear una nueva compra
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Compra compra)
        {
            if (compra == null)
            {
                return BadRequest("El objeto de compra no puede ser nulo.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool resultado = await _compraData.Crear(compra);

            if (!resultado)
            {
                return StatusCode(500, "Hubo un error al crear la compra.");
            }

            return CreatedAtAction(nameof(GetById), new { id = compra.IdCompra }, compra);
        }

        // Editar una compra existente
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Compra compra)
        {
            if (compra == null || compra.IdCompra != id)
            {
                return BadRequest("El ID de la compra no coincide.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool resultado = await _compraData.Editar(compra);

            if (!resultado)
            {
                return StatusCode(500, "Hubo un error al actualizar la compra.");
            }

            return NoContent();  // Si la actualización fue exitosa, se devuelve 204 No Content.
        }

        // Eliminar una compra por su ID
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            bool resultado = await _compraData.Eliminar(id);

            if (!resultado)
            {
                return NotFound($"Compra con ID {id} no encontrada.");
            }

            return NoContent();
        }
    }
}
