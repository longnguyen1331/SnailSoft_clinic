using System;

namespace SnailApp.Data.Entities
{
    public class Clinic_Notification : BaseEntity
    {
        public int ClinicID { set; get; }
        public string NotificationName { set; get; }
        public string NoticeContent { set; get; }
        public int NoticeType { set; get; }
        public Guid ContentID { set; get; }
    }
}
