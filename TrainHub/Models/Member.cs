using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainHub.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Today;
        public DateTime? SoftDeleteDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string Status { get; set; }
        public string MembershipType { get; set; }

        public string? ProfileImagePath { get; set; }
        public string? ImageFileName { get; set; }
        public DateTime? ImageCapturedDate { get; set; }

        public int? TrainerID { get; set; }
        public virtual Trainer? Trainer { get; set; }

        [NotMapped]
        public string TrainerFullName => Trainer != null ? $"{Trainer.FirstName} {Trainer.LastName}" : "No Trainer Assigned";
    }
}
