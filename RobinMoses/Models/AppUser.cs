using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace RobinMoses.Models
{
    public class AppUser : IdentityUser
    {
        [NotMapped]
        public IList<string>? RoleNames { get; set; }
    }
}
