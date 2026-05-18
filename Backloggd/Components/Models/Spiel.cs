namespace Backloggd.Components.Models
{
    public class Spiel
    {
        public string SpielId { get; set; }
        public string Titel { get; set; }
        public string Genre { get; set; }
        public string Plattform { get; set; }
        public DateTime Release { get; set; }
        public string Entwickler { get; set; }
        public string Herausgeber { get; set; }
        public List<Reviews> Reviews { get; set; }

    }
}
