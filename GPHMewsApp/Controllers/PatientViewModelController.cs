using GPHMewsApp.Data;
using GPHMewsApp.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using System.Collections.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace GPHMewsApp.Controllers
{
    
    public class PatientViewModelController : Controller
    {
        private readonly DataDbContext gphDataDbContext;

        public PatientViewModelController(DataDbContext gphDataDbContext)
        {
            this.gphDataDbContext = gphDataDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AlertSettings()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> PatientViewModelIndex()
        {
            var patients = await gphDataDbContext.PatientViewModels.ToListAsync();
     
            return View(patients);
        }

        [HttpGet]
        public async Task<IActionResult> AllAlerts()
        {
            var patients = await gphDataDbContext.PatientViewModels.ToListAsync();

            return View(patients);
        }

        [HttpGet]
        public async Task<IActionResult> PatientIndex()
        {
            var patients = await gphDataDbContext.Patients.ToListAsync();
            return View(patients);
        }

        [HttpGet]
        public async Task<IActionResult> ViewOnePatient(int id) {
            var patient = await gphDataDbContext.PatientViewModels.FirstOrDefaultAsync(x => x.PatientId == id);
            if (patient != null)
            {
                return View(patient);
            }
            else {
                return View("PatientViewModelIndex");
            }
            
        }

        
        
        /*[HttpGet]
        public async Task<IActionResult> ViewClinicianAlerts(int id)
        {
            var alerts = await gphDataDbContext.PatientViewModels.Where(x => x.ClinicianId == id).ToListAsync();
            if (alerts != null)
            {
                return View(alerts);
            }
            
            

        }*/

    }
}
