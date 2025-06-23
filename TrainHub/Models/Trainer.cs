using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainHub.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; } 
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string YearsOfExperience { get; set; }
        public string Specialization { get; set; }
        public string Availability { get; set; }
        public decimal HourlyRate { get; set; }
        public string Status { get; set; }
        public DateTime DateOfBirth { get; set; }

        public DateTime? CreatedDate { get; set; } = DateTime.Today;
        public bool IsDeleted { get; set; } = false;
        public DateTime? SoftDeleteDate { get; set; }

        public string? ProfileImagePath { get; set; }
        public string? ImageFileName { get; set; }
        public DateTime? ImageCapturedDate { get; set; }

        public virtual ICollection<Member> Members { get; set; } = new List<Member>();
    }


}