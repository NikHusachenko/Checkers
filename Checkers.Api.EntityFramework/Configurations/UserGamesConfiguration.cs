using Checkers.Api.Common;
using Checkers.Api.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Checkers.Api.EntityFramework.Configurations
{
    public class UserGamesConfiguration : IEntityTypeConfiguration<UserGamesEntity>
    {
        public void Configure(EntityTypeBuilder<UserGamesEntity> builder)
        {
            builder.ToTable(DatabaseTableNames.USER_GAMES_TABLE_NAME).HasKey(ug => new { ug.UserId, ug.GameId });

            builder.HasOne<UserEntity>(ug => ug.User)
                .WithMany(user => user.Games)
                .HasForeignKey(ug => ug.UserId);

            builder.HasOne<GameEntity>(ug => ug.Game)
                .WithMany(game => game.Users)
                .HasForeignKey(ug => ug.GameId);
        }
    }
}