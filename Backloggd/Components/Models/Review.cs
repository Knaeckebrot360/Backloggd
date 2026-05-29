namespace Backloggd.Components.Models
{
    public class Review
    {
        public int ReviewId { get; set; }


        
        public string ReviewText { get; set; }
        public int Rating { get; set; } // 1-100er bewertung
        public User User { get; set; }
        public Spiel Spiel { get; set; }
        //1
    }
}
