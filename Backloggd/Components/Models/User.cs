namespace Backloggd.Components.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public List<Spiel> Backlog { get; set; }
        public List<Reviews> Reviews { get; set; } = new List<Reviews>();
    }
}
