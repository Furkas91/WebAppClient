using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppClient.Models;
using WebAppClient.Services.Contracts;

namespace WebAppClient.Controllers
{
    public class HaircutController:Controller
    {
        private IHaircutService HaircutService { get; }
        
        public HaircutController(IHaircutService haircutService)
        {
            HaircutService = haircutService;
        }
        public async Task<IActionResult> ListHaircuts()
        {
            return View(await this.HaircutService.GetHaircut());
        }
        public async Task<IActionResult> InfoHaircut(int id)
        {
            return View(await this.HaircutService.GetHaircut(id));
        }
        
        public async Task<IActionResult> AddHaircut()
        {
            return View(await this.HaircutService.GetHaircut());
        }
        [HttpPost]
        public async Task<IActionResult> Put(Haircut haircut)
        {
            await this.HaircutService.PutHaircut(haircut);
            //Console.Out.WriteLine(Barber);
            return RedirectToAction("ListHaircuts");
        }
    }
}