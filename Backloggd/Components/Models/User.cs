namespace Backloggd.Components.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public List<Spiel> Wunschliste { get; set; } 
        public List<Review> EigeneReviews { get; set; } = new List<Review>(); //Liste Aller Reviews, die vom User erstellt sind
    }
}
