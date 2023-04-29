namespace GPHMewsApp.Models.Domain
{
    public class Admission
    {
        public int AdmissionId { get; set; }
        public int PatientId { get; set; }
        public string DateAdmitted { get; set; }
        public string AdmittedBy { get; set; }
        public string RoomNumber { get; set; }
        public string BedNumber { get; set; }
        public string VisitReason { get; set; }
    }
}
