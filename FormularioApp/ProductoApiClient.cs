using Newtonsoft.Json;
using SharedModels;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

public class ProductoApiClient
{
    private readonly HttpClient _httpClient;

    public ProductoApiClient()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("http://localhost:5151/api/producto"); // Cambia el puerto y URL según sea necesario
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    // Método para obtener la lista de productos
    public async Task<List<Producto>> ObtenerProductos()
    {
        var response = await _httpClient.GetAsync("");
        response.EnsureSuccessStatusCode(); // Lanza excepción si la respuesta no es exitosa
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<Producto>>(content);
    }

    // Método para crear un nuevo producto
    public async Task<bool> CrearProducto(Producto producto)
    {
        var json = JsonConvert.SerializeObject(producto);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync("", content);
        return response.IsSuccessStatusCode;
    }

    // Método para editar un producto existente
    public async Task<bool> EditarProducto(Producto producto)
    {
        var json = JsonConvert.SerializeObject(producto);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PutAsync("", content);
        return response.IsSuccessStatusCode;
    }

    // Método para eliminar un producto
    public async Task<bool> EliminarProducto(int id)
    {
        try
        {
            // Realizamos la llamada HTTP DELETE pasando el ID del producto
            var response = await _httpClient.DeleteAsync($"/{id}");

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
