using System.Reflection.Metadata;

namespace Backloggd.Components.Models
{
    public class Spiel
    {
        public int SpielId { get; set; }
        public string Titel { get; set; }
        public string Genre { get; set; }

        public string Entwickler { get; set; }

        public string Publisher { get; set; }
        public string Beschreibung { get; set; }

        public string Release { get; set; }
       
        public decimal DurchschnittsBewertung {  get; set; }

        public Blob Bild { get; set; }
        
        public List<Review> ReviewsDesSpiels { get; set; }

    }
}
