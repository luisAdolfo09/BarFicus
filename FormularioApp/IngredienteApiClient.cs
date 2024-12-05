using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SharedModels;

public class IngredienteApiClient
{
    private readonly HttpClient _httpClient;

    public IngredienteApiClient()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("http://localhost:5000/api/ingrediente"); // Cambia la URL por la URL de tu API
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    // Método para obtener la lista de ingredientes
    public async Task<List<Ingrediente>> ObtenerIngredientes()
    {
        var response = await _httpClient.GetAsync("");
        response.EnsureSuccessStatusCode(); // Lanza excepción si la respuesta no es exitosa
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<Ingrediente>>(content);
    }

    // Método para crear un nuevo ingrediente
    public async Task<bool> CrearIngrediente(Ingrediente ingrediente)
    {
        var json = JsonConvert.SerializeObject(ingrediente);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync("", content);
        return response.IsSuccessStatusCode;
    }

    // Método para editar un ingrediente existente
    public async Task<bool> EditarIngrediente(Ingrediente ingrediente)
    {
        var json = JsonConvert.SerializeObject(ingrediente);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PutAsync("", content);
        return response.IsSuccessStatusCode;
    }

    // Método para eliminar un ingrediente
    public async Task<bool> EliminarIngrediente(int id)
    {
        var response = await _httpClient.DeleteAsync($"/{id}");
        return response.IsSuccessStatusCode;
    }
}
