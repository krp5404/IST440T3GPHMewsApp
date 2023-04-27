using GPHMewsApp.Models.Domain;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace GPHMewsApp.Data
{
    public class DataDbContext : DbContext
    {
        //private string connectionString = "server=DESKTOP-2IG6JHT; database=gphmewsDB;Trusted_connection=true;TrustServerCertificate=true  ";
        public DataDbContext()
        {
        }

        public DataDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Clinician> Clinicians { get; set; }
        
       


       /* public PatientViewModel FetchOne(int Id) {
            
            //access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Patients P JOIN Admissions A ON P.PatientId = A.PatientId JOIN Vitals V ON V.PatientId = A.PatientId where P.PatientId = @Id";

                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                cmd.Parameters.AddWithValue("@Id", System.Data.SqlDbType.Int).Value = Id;

                connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                PatientViewModel pvmodel = new PatientViewModel();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        pvmodel.PatientId = dr.GetInt32(0);
                        pvmodel.LastName = dr.GetString(1);
                        pvmodel.FirstName = dr.GetString(2);
                        pvmodel.BirthDate = dr.GetString(3);
                        pvmodel.ClinicianId = dr.GetInt32(4);
                        pvmodel.DateAdmitted = dr.GetString(7);
                        pvmodel.AdmittedBy = dr.GetString(8);
                        pvmodel.RoomNumber = dr.GetString(9);
                        pvmodel.BedNumber = dr.GetString(10);
                        pvmodel.VisitReason = dr.GetString(11);
                        pvmodel.AVPU = dr.GetString(14);
                        pvmodel.Temperature = dr.GetDecimal(15);
                        pvmodel.HeartRate = dr.GetInt32(16);
                        pvmodel.RespRate = dr.GetInt32(17);
                        pvmodel.SystolicBP = dr.GetInt32(18);


                    }
                }
                return pvmodel;
            }*/
            
            

          
        
        
    }
}
