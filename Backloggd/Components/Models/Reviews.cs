namespace Backloggd.Components.Models
{
    public class Reviews
    {
        public int ReviewId { get; set; }    
      
        public string ReviewText { get; set; }
        public int Rating { get; set; }
        public User User { get; set; }
        public Spiel Spiel { get; set; }
        //
    }
}
