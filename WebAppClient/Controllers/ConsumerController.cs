using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppClient.Models;
using WebAppClient.Services.Contracts;

namespace WebAppClient.Controllers
{
    public class ConsumerController : Controller
    {
        private IConsumerService ConsumerService { get; }
        private ILoyaltyService LoyaltyService { get; }
        public ConsumerController(IConsumerService consumerService, ILoyaltyService loyaltyService)
        {
            ConsumerService = consumerService;
            LoyaltyService = loyaltyService;
        }
        public async  Task<IActionResult> List()
        {
            return View(await this.ConsumerService.GetConsumer());
        }
      
        public async Task<IActionResult> AddConsumer()
        {
            return View(await  this.LoyaltyService.GetLoyalty());
        }

        [HttpPost]
        public async Task<IActionResult> Put(Consumer consumer)
        {
            System.Console.WriteLine(" fdfsdf"  + consumer.LoyaltyId);
            await this.ConsumerService.PutConsumer(consumer);
            return RedirectToAction("List");
        }
    }
}