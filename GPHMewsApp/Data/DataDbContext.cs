using GPHMewsApp.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace GPHMewsApp.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Patient> Patients { get; set; }
    }
}
