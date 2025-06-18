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
        public string Address { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string YearsOfExperience { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Today;
        public DateTime? SoftDeleteDate { get; set; }
        public DateTime? DateOfBirth { get; set; } 

    }


}
