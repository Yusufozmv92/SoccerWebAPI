using Microsoft.EntityFrameworkCore;
using SoccerWebAPI.Entities;

namespace SoccerWebAPI.Contexts
{
    public class TeamsContext : DbContext
    {
        public TeamsContext(DbContextOptions<TeamsContext> options)
            : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
