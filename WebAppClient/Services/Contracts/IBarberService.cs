using System.Collections.Generic;
using System.Threading.Tasks;
using WebAppClient.Models;

namespace WebAppClient.Services.Contracts
{
    public interface IBarberService
    {
        Task<IEnumerable<Barber>> GetBarber();
        Task<Barber> GetBarber(int id);
        Task<Barber> PutBarber(Barber barber);
        Task<Barber> PatchBarber(Barber barber);
    }
}