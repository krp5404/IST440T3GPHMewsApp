using GPHMewsApp.Data;
using GPHMewsApp.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace GPHMewsApp.Controllers
{
    public class PatientViewModelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ViewPatient(int patientId)
        {
            /* DataDbContext gphDataDbContext = new DataDbContext();
             PatientViewModel modelResult = gphDataDbContext.FetchOne(patientId);
             return View("PatientDetails", modelResult);*/
            return View();
        }

    }
}
