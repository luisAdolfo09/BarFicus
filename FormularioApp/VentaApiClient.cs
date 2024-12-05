using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SharedModels;

public class VentasApiClient
{
    private readonly HttpClient _httpClient;

    public VentasApiClient()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("http://localhost:5000/api/venta"); // Cambia la URL por la URL de tu API
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    // Método para obtener la lista de ventas
    public async Task<List<Venta>> ObtenerVentas()
    {
        var response = await _httpClient.GetAsync("");
        response.EnsureSuccessStatusCode(); // Lanza excepción si la respuesta no es exitosa
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<Venta>>(content);
    }

    // Método para crear una nueva venta
    public async Task<bool> CrearVenta(Venta venta)
    {
        var json = JsonConvert.SerializeObject(venta);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync("", content);
        return response.IsSuccessStatusCode;
    }

    // Método para editar una venta existente
    public async Task<bool> EditarVenta(Venta venta)
    {
        var json = JsonConvert.SerializeObject(venta);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PutAsync("", content);
        return response.IsSuccessStatusCode;
    }

    // Método para eliminar una venta
    public async Task<bool> EliminarVenta(int id)
    {
        var response = await _httpClient.DeleteAsync($"/{id}");
        return response.IsSuccessStatusCode;
    }
}
