using GPHMewsApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GPHMewsApp.Controllers
{
    public class CliniciansController : Controller
    {
        private readonly DataDbContext gphDataDbContext;

        public CliniciansController(DataDbContext gphDataDbContext)
        {
            this.gphDataDbContext = gphDataDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ClinicianIndex() {
            var clinicians = await gphDataDbContext.Clinicians.ToListAsync();

            return View(); 
        }


    }
}
