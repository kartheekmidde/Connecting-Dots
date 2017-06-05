using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace ConnectingDots.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameViewModel> GameViewModels { get; set; }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}