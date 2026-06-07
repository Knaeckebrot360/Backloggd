using Backloggd.Database;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using Backloggd.Models;

namespace Backloggd.Services
{
    public class DataService
    {
        
        // Die Kontext Factory welche die Datenbankverbindung aufbaut
        private readonly IDbContextFactory<AppDBContext> _dbContextFactory;

        public Spiel selectedGame { get; private set; }

        // Im Konstruktor wird die ContextFactory übergeben die wir in Program.cs erstellt haben
        // Das passiert automatisch
        public DataService(IDbContextFactory<AppDBContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        /*
        public Spiel GetSpielFromDatabase(int id)
        {
            AppDBContext datenbankVerbindung = _dbContextFactory.CreateDbContext();

           datenbankVerbindung.Spiel.Find().Where(x => x.SpielId == id)
            datenbankVerbindung.SaveChanges();

            
            

        }
        */
       
    }




}