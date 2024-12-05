using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SharedModels;

public class EmpleadosApiClient
{
    private readonly HttpClient _httpClient;

    public EmpleadosApiClient()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("http://localhost:5000/api/empleado"); // Cambia la URL por la URL de tu API
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5000")  // Direcció n correcta del servidor
        };
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

    // Método para eliminar un empleado
    public async Task<bool> EliminarEmpleado(int id)
    {
        var response = await _httpClient.DeleteAsync($"/{id}");
        return response.IsSuccessStatusCode;
    }
}