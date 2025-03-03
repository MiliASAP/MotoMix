using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MotoMix.Data
{
    public class MotoMixDbContext : IdentityDbContext
    {
        public MotoMixDbContext(DbContextOptions<MotoMixDbContext>options)
            :base(options)
        {
            
        }

        public DbSet<MotoMix.Models.Car> Cars { get; set; } = default!;
        public DbSet<MotoMix.Models.IdentityUser> Users { get; set; } = default!;
    }
}
