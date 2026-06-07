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

        
        public Spiel GetSpielFromDatabase(int id)
        {
            AppDBContext datenbankVerbindung = _dbContextFactory.CreateDbContext();

           

                return datenbankVerbindung.Spiel.Find(id);
            
           

        }
        
       
        
        public (bool,string) Update(Spiel s)
        {
            try
            {
                AppDBContext datenbankVerbindung = _dbContextFactory.CreateDbContext();
                datenbankVerbindung.Update(s);
                datenbankVerbindung.SaveChanges();
                return (true, string.Empty);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
        public (bool, string) AddSpiel(Spiel newSpiel)
        {
            try
            {

                AppDBContext datenbankVerbindung = _dbContextFactory.CreateDbContext();

                datenbankVerbindung.Add(newSpiel);
                datenbankVerbindung.SaveChanges();
                return (true, string.Empty);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

    }




}