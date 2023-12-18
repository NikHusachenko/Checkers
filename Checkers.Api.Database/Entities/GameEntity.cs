using Checkers.Api.Database.Enums;

namespace Checkers.Api.Database.Entities
{
    public class GameEntity
    {
        public Guid Id { get; set; }
        public GameType Type { get; set; }

        public DateTime? StartedOn { get; set; }
        public DateTime? EndedOn { get; set; }
        
        public List<UserGamesEntity> Users { get; set; }

        public GameEntity()
        {
            Users = new List<UserGamesEntity>();
        }
    }
}