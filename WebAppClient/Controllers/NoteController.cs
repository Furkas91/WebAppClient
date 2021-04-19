using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppClient.Models;
using WebAppClient.Services.Contracts;

namespace WebAppClient.Controllers
{
    public class NoteController : Controller
    {
        // GET
        private INoteService NoteService { get; }
        private IConsumerService ConsumerService { get; }
        private IBarberService BarberService { get; }
        private IHaircutService HaircutService { get; }
        
        public NoteController(INoteService noteService, IConsumerService consumerService, IBarberService barberService, IHaircutService haircutService)
        {
            NoteService = noteService;
            ConsumerService = consumerService;
            BarberService = barberService;
            HaircutService = haircutService;
        }

        public async Task<IActionResult> Notes()
        {
            
            return View(await this.NoteService.GetNote());
        }

        [HttpGet]
        public async Task<IActionResult> AddNote()
        {
            return View(new HelpObjects(await  this.ConsumerService.GetConsumer(),
                await  this.BarberService.GetBarber(),
                await this.HaircutService.GetHaircut()));
        }
        [HttpPost]
        public async Task<IActionResult> Put(Note note)
        {
            await this.NoteService.PutNote(note);
            //Console.Out.WriteLine(note);
            return RedirectToAction("Notes");
        }
    }
}