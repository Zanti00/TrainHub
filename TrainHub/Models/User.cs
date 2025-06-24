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
        public string Username { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public bool isAdmin { get; set; } = false;
        public string Status { get; set; }
        public bool isDeleted { get; set; } = false;
        public DateTime? softDeleteDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Today;

        public string? ProfileImagePath { get; set; }
        public string? ImageFileName { get; set; }
        public DateTime? ImageCapturedDate { get; set; }
    }
}