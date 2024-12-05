using Newtonsoft.Json;
using SharedModels;
using System.Net.Http.Headers;
using System.Text;

public class EmpleadosApiClient
{
    private readonly HttpClient _httpClient;

    public EmpleadosApiClient()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("http://localhost:5151/api/empleado"); // Asegúrate de usar el puerto correcto (5151 en este caso)
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    // Método para obtener la lista de empleados
    public async Task<List<Empleados>> ObtenerEmpleados()
    {
        var response = await _httpClient.GetAsync("");
        response.EnsureSuccessStatusCode(); // Lanza excepción si la respuesta no es exitosa
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<Empleados>>(content);
    }

    // Método para crear un nuevo empleado
    public async Task<bool> CrearEmpleado(Empleados empleado)
    {
        var json = JsonConvert.SerializeObject(empleado);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync("", content);
        return response.IsSuccessStatusCode;
    }

    // Método para editar un empleado existente
    public async Task<bool> EditarEmpleado(Empleados empleado)
    {
        var json = JsonConvert.SerializeObject(empleado);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PutAsync("", content);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> EliminarEmpleado(int id)
    {
        try
        {
            // Realizamos la llamada HTTP DELETE pasando el ID del empleado
            var response = await _httpClient.DeleteAsync($"/api/empleado/{id}");

            // Verificamos si la respuesta fue exitosa
            if (response.IsSuccessStatusCode)
            {
                return true;  // Eliminación exitosa
            }
            else
            {
                // Si la eliminación falla, obtenemos el mensaje de error
                var errorMessage = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Error al eliminar: {errorMessage}");
                return false;  // Falla en la eliminación
            }
        }
        catch (Exception ex)
        {
            // En caso de excepción, podemos registrar el error
            Console.WriteLine($"Ocurrió un error al intentar eliminar: {ex.Message}");
            return false;  // Error en el proceso
        }
    }
}
