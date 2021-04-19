using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebAppClient.Models;
using WebAppClient.Services.Contracts;

namespace WebAppClient.Services.Implementations
{
    public class BarberService: IBarberService
    {
        private HttpClient HttpClient { get; }
        
        public BarberService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<IEnumerable<Barber>> GetBarber()
        {
            using var response = await this.HttpClient.GetAsync("api/barber");
            System.Console.WriteLine(response.ToString());
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            
            return JsonSerializer.Deserialize<IEnumerable<Barber>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<Barber> GetBarber(int id)
        {
            using var response = await this.HttpClient.GetAsync("api/barber/" + id);
            
            
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            
            return JsonSerializer.Deserialize<Barber>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<Barber> PutBarber(Barber barber)
        {
            var sendContent = new StringContent( JsonSerializer.Serialize(barber), Encoding.UTF8, "application/json");
            using var response = await this.HttpClient.PutAsync("api/barber",sendContent);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            
            return JsonSerializer.Deserialize<Barber>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<Barber> PatchBarber(Barber barber)
        {
            var sendContent = new StringContent( JsonSerializer.Serialize(barber), Encoding.UTF8, "application/json");
            using var response = await this.HttpClient.PatchAsync("api/barber",sendContent);

            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            
            return JsonSerializer.Deserialize<Barber>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}