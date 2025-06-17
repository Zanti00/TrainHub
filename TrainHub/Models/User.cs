using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainHub.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string isAdmin { get; set; }
    }
}