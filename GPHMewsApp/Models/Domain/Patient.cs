namespace GPHMewsApp.Models.Domain
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string BirthDate { get; set; }
        public int ClinicianId { get; set; }
    }
}
