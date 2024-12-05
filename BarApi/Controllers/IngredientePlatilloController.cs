using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoData; // Asegúrate de tener una clase IngredientePlatilloData que maneje la lógica de datos
using SharedModels;

namespace ProyectoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientePlatilloController : ControllerBase
    {
        private readonly IngredientePlatilloData _ingredientePlatilloData;

        // Constructor para inyección de dependencia
        public IngredientePlatilloController(IngredientePlatilloData ingredientePlatilloData)
        {
            _ingredientePlatilloData = ingredientePlatilloData;
        }

        // GET: api/ingredienteplatillo
        [HttpGet]
        public async Task<IActionResult> Lista()
        {
            // Obtiene la lista de relaciones entre ingredientes y platillos
            List<IngredientePlatillo> lista = await _ingredientePlatilloData.Lista();

            // Si la lista está vacía, responde con un código 204 (No Content)
            if (lista == null || lista.Count == 0)
            {
                return NoContent();
            }

            // Si tiene datos, responde con un código 200 (OK)
            return Ok(lista);
        }

        // POST: api/ingredienteplatillo
        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] IngredientePlatillo objeto)
        {
            // Valida que el objeto no sea nulo
            if (objeto == null)
            {
                return BadRequest("La relación entre el ingrediente y el platillo no puede ser nula");
            }

            // Llama a la capa de datos para crear la relación
            bool respuesta = await _ingredientePlatilloData.Crear(objeto);

            // Si la creación es exitosa, responde con un código 201 (Created) y los detalles
            if (respuesta)
            {
                return CreatedAtAction(nameof(Lista), new { id = $"{objeto.IdPlatillo}-{objeto.IdIngrediente}" }, objeto);
            }

            // Si la creación falla, responde con un código 500 (Internal Server Error)
            return StatusCode(StatusCodes.Status500InternalServerError, new { isSuccess = respuesta });
        }

        // PUT: api/ingredienteplatillo
        [HttpPut]
        public async Task<IActionResult> Editar([FromBody] IngredientePlatillo objeto)
        {
            // Valida que el objeto no sea nulo
            if (objeto == null)
            {
                return BadRequest("La relación entre el ingrediente y el platillo no puede ser nula");
            }

            // Llama a la capa de datos para editar la relación
            bool respuesta = await _ingredientePlatilloData.Editar(objeto);

            // Si la edición es exitosa, responde con un código 200 (OK)
            if (respuesta)
            {
                return Ok(new { isSuccess = respuesta });
            }

            // Si la edición falla, responde con un código 404 (Not Found) si la relación no existe
            return NotFound(new { isSuccess = false, message = "Relación entre ingrediente y platillo no encontrada" });
        }

        // DELETE: api/ingredienteplatillo/{idPlatillo}/{idIngrediente}
        [HttpDelete("{idPlatillo}/{idIngrediente}")]
        public async Task<IActionResult> Eliminar(int idPlatillo, int idIngrediente)
        {
            // Llama a la capa de datos para eliminar la relación entre el platillo y el ingrediente
            bool respuesta = await _ingredientePlatilloData.Eliminar(idPlatillo, idIngrediente);

            // Si la eliminación es exitosa, responde con un código 200 (OK)
            if (respuesta)
            {
                return Ok(new { isSuccess = respuesta });
            }

            // Si la eliminación falla, responde con un código 404 (Not Found) si la relación no existe
            return NotFound(new { isSuccess = false, message = "Relación entre ingrediente y platillo no encontrada" });
        }
    }
}
