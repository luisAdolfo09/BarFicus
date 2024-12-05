using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SharedModels;

public class ComprasApiClient
{
    private readonly HttpClient _httpClient;

    public ComprasApiClient()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("http://localhost:5000/api/compra"); // Cambia la URL por la URL de tu API
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    // Método para obtener la lista de compras
    public async Task<List<Compra>> ObtenerCompras()
    {
        var response = await _httpClient.GetAsync("");
        response.EnsureSuccessStatusCode(); // Lanza excepción si la respuesta no es exitosa
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<Compra>>(content);
    }

    // Método para crear una nueva compra
    public async Task<bool> CrearCompra(Compra compra)
    {
        var json = JsonConvert.SerializeObject(compra);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync("", content);
        return response.IsSuccessStatusCode;
    }

    // Método para editar una compra existente
    public async Task<bool> EditarCompra(Compra compra)
    {
        var json = JsonConvert.SerializeObject(compra);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PutAsync("", content);
        return response.IsSuccessStatusCode;
    }

    // Método para eliminar una compra
    public async Task<bool> EliminarCompra(int id)
    {
        var response = await _httpClient.DeleteAsync($"/{id}");
        return response.IsSuccessStatusCode;
    }
}
