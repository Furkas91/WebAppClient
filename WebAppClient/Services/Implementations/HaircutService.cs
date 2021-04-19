using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebAppClient.Models;
using WebAppClient.Services.Contracts;

namespace WebAppClient.Services.Implementations
{
    public class HaircutService:IHaircutService
    {
        private HttpClient HttpClient { get; }
        
        public HaircutService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<IEnumerable<Haircut>> GetHaircut()
        {
            using var response = await this.HttpClient.GetAsync("api/haircut");
            System.Console.WriteLine(response.ToString());
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            
            return JsonSerializer.Deserialize<IEnumerable<Haircut>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<Haircut> GetHaircut(int id)
        {
            using var response = await this.HttpClient.GetAsync("api/haircut/" + id);
            
            
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            
            return JsonSerializer.Deserialize<Haircut>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<Haircut> PutHaircut(Haircut haircut)
        {
            var sendContent = new StringContent( JsonSerializer.Serialize(haircut), Encoding.UTF8, "application/json");
            using var response = await this.HttpClient.PutAsync("api/haircut",sendContent);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            
            return JsonSerializer.Deserialize<Haircut>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<Haircut> PatchHaircut(Haircut haircut)
        {
            var sendContent = new StringContent( JsonSerializer.Serialize(haircut), Encoding.UTF8, "application/json");
            using var response = await this.HttpClient.PatchAsync("api/haircut",sendContent);

            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            
            return JsonSerializer.Deserialize<Haircut>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}