namespace GPHMewsApp.Models.Domain
{
    public class PatientViewModel
    {
        public int PatientId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string BirthDate { get; set; }
        public int ClinicianId { get; set; }
        public string DateAdmitted { get; set;}
        public string AdmittedBy { get; set; }
        public string RoomNumber { get; set;}
        public string BedNumber { get; set;}
        public string VisitReason { get; set;}
        public string AVPU { get; set; }
        public int SystolicBP { get; set;}
        public int HeartRate { get; set;}
        public int RespRate { get; set;}
        public decimal Temperature { get; set;}


    }
}
