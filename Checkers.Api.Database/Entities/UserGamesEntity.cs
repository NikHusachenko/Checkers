namespace Checkers.Api.Database.Entities
{
    public class UserGamesEntity
    {
        public Guid UserId { get; set; }
        public UserEntity User { get; set; }

        public Guid GameId { get; set; }
        public GameEntity Game { get; set; }

        public int AvailableCheckers { get; set; }
        public int DestroyedCheckers { get; set; }
        public bool IsWiner { get; set; }
    }
}