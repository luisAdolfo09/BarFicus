using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SharedModels;

public class IngredientePlatilloApiClient
{
    private readonly HttpClient _httpClient;

    public IngredientePlatilloApiClient()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("http://localhost:5000/api/ingredientePlatillo"); // Cambia la URL por la URL de tu API
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    // Método para obtener la lista de IngredientesPlatillo
    public async Task<List<IngredientePlatillo>> ObtenerIngredientesPlatillo(int _idPlatillo)
    {
        var response = await _httpClient.GetAsync("");
        response.EnsureSuccessStatusCode(); // Lanza excepción si la respuesta no es exitosa
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<IngredientePlatillo>>(content);
    }

    // Método para crear una nueva relación entre Ingrediente y Platillo
    public async Task<bool> CrearIngredientePlatillo(IngredientePlatillo ingredientePlatillo)
    {
        var json = JsonConvert.SerializeObject(ingredientePlatillo);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync("", content);
        return response.IsSuccessStatusCode;
    }

    // Método para editar una relación existente entre Ingrediente y Platillo
    public async Task<bool> EditarIngredientePlatillo(IngredientePlatillo ingredientePlatillo)
    {
        var json = JsonConvert.SerializeObject(ingredientePlatillo);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PutAsync("", content);
        return response.IsSuccessStatusCode;
    }

    // Método para eliminar una relación entre Ingrediente y Platillo
    public async Task<bool> EliminarIngredientePlatillo(int idPlatillo, int idIngrediente)
    {
        var response = await _httpClient.DeleteAsync($"/{idPlatillo}/{idIngrediente}");
        return response.IsSuccessStatusCode;
    }
}
