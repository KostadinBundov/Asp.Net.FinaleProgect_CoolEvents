using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Asp.Net.FinaleProgect.Data.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}
