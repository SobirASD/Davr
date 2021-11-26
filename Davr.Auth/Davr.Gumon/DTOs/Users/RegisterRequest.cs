using System.ComponentModel.DataAnnotations;
using Davr.Gumon.Entities;

namespace Davr.Gumon.DTOs.Users
{
    public class RegisterRequest
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Username { get; set; }        
        
        public string MiddleName { get; set; }
        public int BranchId { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public Role Role { get; set; }
    }
}