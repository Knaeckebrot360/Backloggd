using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Backloggd.Models
{
    public class Spiel
    {
        
        public int SpielId { get; set; }
        [Required(ErrorMessage = "Das Spiel braucht einen Namen.")]
        public string Titel { get; set; }
        [Required(ErrorMessage = "Das Spiel braucht ein Genre.")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Das Spiel braucht einen Entwickler.")]
        public string Entwickler { get; set; }
        [Required(ErrorMessage = "Das Spiel braucht einen Publisher.")]
        public string Publisher { get; set; }
        [Required(ErrorMessage = "Das Spiel braucht eine Beschreibung.")]

        public string Beschreibung { get; set; }

        [Required(ErrorMessage = "Das Spiel braucht einen Releasezeitpunkt.\nz.B.: 2.Februar 2025")]
        public string Release { get; set; }

        public decimal DurchschnittsBewertung { get; set; } = 0.00M;

        public byte[]? Bild { get; set; }

        public List<Review> ReviewsDesSpiels { get; set; }

    }
}
