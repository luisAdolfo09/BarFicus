using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SharedModels;

public class DetallesCompraApiClient
{
    private readonly HttpClient _httpClient;

    public DetallesCompraApiClient()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("http://localhost:5000/api/detalleCompra"); // Cambia la URL por la URL de tu API
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    // Método para obtener la lista de detalles de compras
    public async Task<List<DetalleCompra>> ObtenerDetallesCompra(int _idCompra)
    {
        var response = await _httpClient.GetAsync("");
        response.EnsureSuccessStatusCode(); // Lanza excepción si la respuesta no es exitosa
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<DetalleCompra>>(content);
    }

    // Método para crear un nuevo detalle de compra
    public async Task<bool> CrearDetalleCompra(DetalleCompra detalleCompra)
    {
        var json = JsonConvert.SerializeObject(detalleCompra);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync("", content);
        return response.IsSuccessStatusCode;
    }

    // Método para editar un detalle de compra existente
    public async Task<bool> EditarDetalleCompra(DetalleCompra detalleCompra)
    {
        var json = JsonConvert.SerializeObject(detalleCompra);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PutAsync("", content);
        return response.IsSuccessStatusCode;
    }

    // Método para eliminar un detalle de compra
    public async Task<bool> EliminarDetalleCompra(int id)
    {
        var response = await _httpClient.DeleteAsync($"/{id}");
        return response.IsSuccessStatusCode;
    }
}
