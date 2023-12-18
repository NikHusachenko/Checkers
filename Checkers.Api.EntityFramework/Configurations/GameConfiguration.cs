using Checkers.Api.Common;
using Checkers.Api.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Checkers.Api.EntityFramework.Configurations
{
    public class GameConfiguration : IEntityTypeConfiguration<GameEntity>
    {
        public void Configure(EntityTypeBuilder<GameEntity> builder)
        {
            builder.ToTable(DatabaseTableNames.GAME_TABLE_NAME).HasKey(game => game.Id); 
        }
    }
}