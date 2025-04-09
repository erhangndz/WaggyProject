using Microsoft.AspNetCore.Identity;

namespace WaggyProject.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string? ImageUrl { get; set; }
    }
}
