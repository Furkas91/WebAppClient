using System.Collections.Generic;
using System.Threading.Tasks;
using WebAppClient.Models;

namespace WebAppClient.Services.Contracts
{
    public interface IHaircutService
    {
        Task<IEnumerable<Haircut>> GetHaircut();
        Task<Haircut> GetHaircut(int id);
        Task<Haircut> PutHaircut(Haircut haircut);
        Task<Haircut> PatchHaircut(Haircut haircut);
    }
}