namespace Backloggd.Components.Models
{
    public class Reviews
    {
        public string ReviewId { get; set; }    
      
        public string ReviewText { get; set; }
        public int Rating { get; set; }
        public User User { get; set; }
        public Spiel Spiel { get; set; }

    }
}
