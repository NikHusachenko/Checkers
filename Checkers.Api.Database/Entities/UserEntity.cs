namespace Checkers.Api.Database.Entities
{
    public class UserEntity
    {
        public Guid Id { get; set; }
        public string Login { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public List<UserGamesEntity> Games { get; set; }

        public UserEntity()
        {
            Games = new List<UserGamesEntity>();
        }
    }
}