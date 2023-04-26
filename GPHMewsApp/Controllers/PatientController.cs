using GPHMewsApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GPHMewsApp.Controllers
{
    public class PatientController : Controller
    {
        private readonly DataDbContext gphDataDbContext;

        public PatientController(DataDbContext gphDataDbContext)
        {
            this.gphDataDbContext = gphDataDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> PatientIndex()
        {
            var patients = await gphDataDbContext.Patients.ToListAsync();
            return View(patients);
        }


    }
}
