using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebAppClient.Models;
using WebAppClient.Services.Contracts;

namespace WebAppClient.Services.Implementations
{
    public class LoyaltyService:ILoyaltyService
    {
        private HttpClient HttpClient { get; }
        
        public LoyaltyService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<IEnumerable<Loyalty>> GetLoyalty()
        {
            using var response = await this.HttpClient.GetAsync("api/loyalty");
            System.Console.WriteLine(response.ToString());
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            
            return JsonSerializer.Deserialize<IEnumerable<Loyalty>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<Loyalty> GetLoyalty(int id)
        {
            using var response = await this.HttpClient.GetAsync("api/loyalty/" + id);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            
            return JsonSerializer.Deserialize<Loyalty>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<Loyalty> PutLoyalty(Loyalty loyalty)
        {
            var sendContent = new StringContent( JsonSerializer.Serialize(loyalty), Encoding.UTF8, "application/json");
            using var response = await this.HttpClient.PutAsync("api/loyalty",sendContent);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            
            return JsonSerializer.Deserialize<Loyalty>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<Loyalty> PatchLoyalty(Loyalty loyalty)
        {
            var sendContent = new StringContent( JsonSerializer.Serialize(loyalty), Encoding.UTF8, "application/json");
            using var response = await this.HttpClient.PatchAsync("api/loyalty",sendContent);

            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            
            return JsonSerializer.Deserialize<Loyalty>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}