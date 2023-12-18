using Checkers.Api.Database.Entities;
using Checkers.Api.EntityFramework.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Checkers.Api.EntityFramework
{
    public class ApplicationContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<GameEntity> Games { get; set; }
        public DbSet<UserGamesEntity> UserGames { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new GameConfiguration());
            modelBuilder.ApplyConfiguration(new UserGamesConfiguration());
        }
    }
}