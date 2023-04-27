using GPHMewsApp.Data;
using GPHMewsApp.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

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
