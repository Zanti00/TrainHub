using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainHub.Models
{
    public class MemberAttendances
    {
        public int Id { get; set; }
        public int MemberId { get; set; }

        [ForeignKey("MemberId")]
        public virtual Member Member { get; set; }
        [NotMapped]
        public string FirstName => Member?.FirstName;
        [NotMapped]
        public string LastName => Member?.LastName;
        [NotMapped]
        public string Email => Member?.Email;
        [NotMapped]
        public string PhoneNumber => Member?.PhoneNumber;
        [NotMapped]
        public string Status => Member?.Status;
        [NotMapped]
        public string MembershipType => Member?.MembershipType;
        [NotMapped]
        public DateTime StartDate => (DateTime)(Member?.StartDate);
        [NotMapped]
        public DateTime EndDate => (DateTime)(Member?.EndDate);
        public DateTime AttendanceDate { get; set; } = DateTime.Today;
        public TimeSpan? CheckInTime { get; set; }
        public TimeSpan? CheckOutTime { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}