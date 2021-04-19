using System.Collections.Generic;
using System.Threading.Tasks;
using WebAppClient.Models;

namespace WebAppClient.Services.Contracts
{
    public interface ILoyaltyService
    {
        Task<IEnumerable<Loyalty>> GetLoyalty();
        Task<Loyalty> GetLoyalty(int id);
        Task<Loyalty> PutLoyalty(Loyalty loyalty);
        Task<Loyalty> PatchLoyalty(Loyalty loyalty);
    }
}