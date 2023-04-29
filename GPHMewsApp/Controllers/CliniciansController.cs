using GPHMewsApp.Data;
using GPHMewsApp.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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

            return View(clinicians); 
        }

      


    }
}
