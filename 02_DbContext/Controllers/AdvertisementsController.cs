using _02_DbContext.Data;
using _02_DbContext.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _02_DbContext.Controllers
{
    public class AdvertisementsController : Controller
    {
        private readonly ApplicationContext context;

        public AdvertisementsController(ApplicationContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            var products = await context.Advertisements.ToListAsync();

            return View(products);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (id == null) return BadRequest();

            Advertisement? advertisement = await context.Advertisements.FirstOrDefaultAsync(adv => adv.Id == id);
            if (advertisement != null) return NotFound();
            context.Advertisements.Remove(advertisement);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return BadRequest();

            Advertisement? advertisement = await context.Advertisements.FirstOrDefaultAsync(adv => adv.Id == id);
            if (advertisement != null)
                return NotFound();
            return View(advertisement);
        }
    }
}
