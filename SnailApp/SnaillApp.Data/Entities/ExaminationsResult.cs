using System;

namespace SnailApp.Data.Entities
{
    public class ExaminationsResult : BaseEntity
    {
        public int AppointmentId { set; get; }
        public virtual Appointment Appointment { get; set; }
        public DateTime ExaminationDate { set; get; }
        public DateTime? Re_Examination { set; get; }
        public string Results { set; get; }
        public string DoctorAdvice { set; get; }
        public string Examination_File { get; set; }
    }
}
