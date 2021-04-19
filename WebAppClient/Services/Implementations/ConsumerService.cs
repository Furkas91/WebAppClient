using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebAppClient.Models;
using WebAppClient.Services.Contracts;

namespace WebAppClient.Services.Implementations
{
    public class ConsumerService:IConsumerService
    {
        private HttpClient HttpClient { get; }
        
        public ConsumerService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<IEnumerable<Consumer>> GetConsumer()
        {
            using var response = await this.HttpClient.GetAsync("api/consumer");
            
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            
            return JsonSerializer.Deserialize<IEnumerable<Consumer>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<Consumer> GetConsumer(int id)
        {
            using var response = await this.HttpClient.GetAsync("api/consumer/" + id);
            
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            
            return JsonSerializer.Deserialize<Consumer>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<Consumer> PutConsumer(Consumer consumer)
        {
            var sendContent = new StringContent( JsonSerializer.Serialize(consumer), Encoding.UTF8, "application/json");
            using var response = await this.HttpClient.PutAsync("api/consumer",sendContent);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            
            return JsonSerializer.Deserialize<Consumer>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<Consumer> PatchConsumer(Consumer consumer)
        {
            var sendContent = new StringContent( JsonSerializer.Serialize(consumer), Encoding.UTF8, "application/json");
            using var response = await this.HttpClient.PatchAsync("api/consumer",sendContent);

            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            
            return JsonSerializer.Deserialize<Consumer>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}