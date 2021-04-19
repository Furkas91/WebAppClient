using System.Collections.Generic;
using System.Threading.Tasks;
using WebAppClient.Models;

namespace WebAppClient.Services.Contracts
{
    public interface IConsumerService
    {
        Task<IEnumerable<Consumer>> GetConsumer();
        Task<Consumer> GetConsumer(int id);
        Task<Consumer> PutConsumer(Consumer consumer);
        Task<Consumer> PatchConsumer(Consumer consumer);
    }
}