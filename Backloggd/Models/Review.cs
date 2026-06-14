using System.ComponentModel.DataAnnotations;

namespace Backloggd.Models
{
    public class Review
    {
        public int ReviewId { get; set; }


        [Required(ErrorMessage = "Bitte eine kurze Bewertung schreiben.")]
        public string ReviewText { get; set; }
        public int Rating { get; set; } // 1-100er bewertung
        [Required(ErrorMessage = "Gib bitte einen Namen an.")]
        public string User { get; set; }
        public Spiel Spiel { get; set; }
        //1
    }
}
