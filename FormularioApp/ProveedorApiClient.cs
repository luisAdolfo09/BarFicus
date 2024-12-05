using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SharedModels;

public class ProveedorApiClient
{
    private readonly HttpClient _httpClient;

    public ProveedorApiClient()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("http://localhost:5000/api/proveedor"); // Cambia la URL por la URL de tu API
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    // Método para obtener la lista de proveedores
    public async Task<List<Proveedor>> ObtenerProveedores()
    {
        var response = await _httpClient.GetAsync("");
        response.EnsureSuccessStatusCode(); // Lanza excepción si la respuesta no es exitosa
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<Proveedor>>(content);
    }

    // Método para crear un nuevo proveedor
    public async Task<bool> CrearProveedor(Proveedor proveedor)
    {
        var json = JsonConvert.SerializeObject(proveedor);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync("", content);
        return response.IsSuccessStatusCode;
    }

    // Método para editar un proveedor existente
    public async Task<bool> EditarProveedor(Proveedor proveedor)
    {
        var json = JsonConvert.SerializeObject(proveedor);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PutAsync("", content);
        return response.IsSuccessStatusCode;
    }

    // Método para eliminar un proveedor
    public async Task<bool> EliminarProveedor(int id)
    {
        var response = await _httpClient.DeleteAsync($"/{id}");
        return response.IsSuccessStatusCode;
    }
}
