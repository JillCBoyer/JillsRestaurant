using Microsoft.AspNetCore.Identity;

namespace JillsRestaurant.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Order>? Orders { get; set; }
    }
}
