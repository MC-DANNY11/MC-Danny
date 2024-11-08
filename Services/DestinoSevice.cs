using System;
using System.Collections.Generic;
using System.Linq;
using MC_Danny.Models;
using System.Text;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MC_Danny.Services
{
    public class DestinoSevice
    {
        // Asegúrate de que solo haya una declaración de _httpClient
        private readonly HttpClient _httpClient;

        public DestinoSevice()
        {
            // Inicializa el HttpClient con la URL base de la API
            _httpClient = new HttpClient { BaseAddress = new Uri("http://mcdannyapi.somee.com/") };
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Destino>> GetDestinosAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/Destinos");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<List<Destino>>();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Error de conexión: " + ex.Message);
            }
        }

        public async Task<Destino> GetDestinoByIdAsync(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/Destinos/{id}");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<Destino>();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Error de conexión: " + ex.Message);
            }
        }
    }
}
