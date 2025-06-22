using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainHub.Models
{
    public class TrainerAttendances
    {
        public int Id { get; set; }
        public int TrainerId { get; set; }

        [ForeignKey("TrainerId")]
        public virtual Trainer Trainer { get; set; }
        [NotMapped]
        public string FirstName => Trainer?.FirstName;
        [NotMapped]
        public string LastName => Trainer?.LastName;
        [NotMapped]
        public string Email => Trainer?.Email;
        [NotMapped]
        public string PhoneNumber => Trainer?.PhoneNumber;
        [NotMapped]
        public string Status => Trainer?.Status;
        [NotMapped]
        public string Specialization => Trainer?.Specialization;
        [NotMapped]
        public string YearsOfExperience => Trainer?.YearsOfExperience;
        [NotMapped]
        public string Availability => Trainer?.Availability;
        [NotMapped]
        public string HourlyRate => Trainer?.HourlyRate.ToString("C2");
        public DateTime AttendanceDate { get; set; } = DateTime.Today;
        public TimeSpan? CheckInTime { get; set; }
        public TimeSpan? CheckOutTime { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
