using GPHMewsApp.Models;
using GPHMewsApp.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace GPHMewsApp.Controllers
{
    public class HomeController : Controller
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
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
                return View("SuccessPage");
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