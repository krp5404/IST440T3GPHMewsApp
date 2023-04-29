using GPHMewsApp.Data;
using GPHMewsApp.Models;
using GPHMewsApp.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace GPHMewsApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataDbContext gphDataDbContext;

        public HomeController(DataDbContext gphDataDbContext)
        {
            this.gphDataDbContext = gphDataDbContext;
        }

        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;

        private readonly ILogger<HomeController> _logger;


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> PatientViewModelIndex()
        {
            var patients = await gphDataDbContext.PatientViewModels.ToListAsync();
            return View(patients);
        }

        [HttpPost]
        public ActionResult Verify(Clinician oClinician)
        {

            connectionString();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "Select * From Clinicians where Username='" + oClinician.Username + "' and Password='" + oClinician.Password + "'";
            dr = command.ExecuteReader();
            if (dr.Read())
            {
                connection.Close();
                ViewBag.Patient = oClinician.Username;
                ViewData["Patient"] = oClinician.Username;
                TempData["Patient"] = oClinician.Username;
                TempData.Keep();

                HttpContext.Session.SetString("Username", oClinician.Username.ToString());
                return RedirectToAction("SuccessPage", "Home");
            }
            else
            {
                connection.Close();
                return View("ErrorLoginPage");
            }

        }

        void connectionString()
        {
            connection.ConnectionString = "server=DESKTOP-2IG6JHT; database=gphmewsDB;Trusted_connection=true;TrustServerCertificate=True ";
        }


        public IActionResult SuccessPage()
        {
            ViewBag.username = HttpContext.Session.GetString("username");
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}