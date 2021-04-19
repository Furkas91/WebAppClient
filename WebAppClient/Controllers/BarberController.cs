using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppClient.Models;
using WebAppClient.Services.Contracts;

namespace WebAppClient.Controllers
{
    public class BarberController : Controller
    {
        private IBarberService BarberService { get; }
        
        public BarberController(IBarberService barberService)
        {
            BarberService = barberService;
        }
        public async Task<IActionResult> List()
        {
            return View(await this.BarberService.GetBarber());
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View(await this.BarberService.GetBarber());
        }
        [HttpPost]
        public async Task<IActionResult> Put(Barber barber)
        {
            await this.BarberService.PutBarber(barber);
            Console.Out.WriteLine(barber);
            return RedirectToAction("List");
        }
        
        // public async Task<IActionResult> List()
        // {
        //     return View(await this.BarberService.GetBarber());
        // }
        // public async Task<IActionResult> List()
        // {
        //     return View(await this.BarberService.GetBarber());
        // }
    }
}