using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SharedModels;

public class DetalleVentaApiClient
{
    private readonly HttpClient _httpClient;

    public DetalleVentaApiClient()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("http://localhost:5000/api/detalleVenta"); // Cambia la URL por la URL de tu API
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    // Método para obtener la lista de detalles de ventas
    public async Task<List<DetalleVenta>> ObtenerDetallesVenta()
    {
        var response = await _httpClient.GetAsync("");
        response.EnsureSuccessStatusCode(); // Lanza excepción si la respuesta no es exitosa
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<DetalleVenta>>(content);
    }

    // Método para crear un nuevo detalle de venta
    public async Task<bool> CrearDetalleVenta(DetalleVenta detalleVenta)
    {
        var json = JsonConvert.SerializeObject(detalleVenta);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync("", content);
        return response.IsSuccessStatusCode;
    }

    // Método para editar un detalle de venta existente
    public async Task<bool> EditarDetalleVenta(DetalleVenta detalleVenta)
    {
        var json = JsonConvert.SerializeObject(detalleVenta);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PutAsync("", content);
        return response.IsSuccessStatusCode;
    }

    // Método para eliminar un detalle de venta
    public async Task<bool> EliminarDetalleVenta(int id)
    {
        var response = await _httpClient.DeleteAsync($"/{id}");
        return response.IsSuccessStatusCode;
    }

    internal async Task ObtenerDetallesVenta(int idVenta)
    {
        throw new NotImplementedException();
    }
}
