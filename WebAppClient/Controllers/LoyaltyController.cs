using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppClient.Models;
using WebAppClient.Services.Contracts;

namespace WebAppClient.Controllers
{
    public class LoyaltyController : Controller
    {
        // GET
        private ILoyaltyService LoyaltyService { get; }
        
        public LoyaltyController(ILoyaltyService loyaltyService)
        {
            LoyaltyService = loyaltyService;
        }
        public async Task<IActionResult> ListLoyalties()
        {
            return View(await this.LoyaltyService.GetLoyalty());
        }

      
        [HttpPost]
        public async Task<IActionResult> Put(Loyalty loyalty)
        {
            Console.Out.WriteLine(loyalty);
            await this.LoyaltyService.PutLoyalty(loyalty);
            return RedirectToAction("ListLoyalties");
        }

    }
}