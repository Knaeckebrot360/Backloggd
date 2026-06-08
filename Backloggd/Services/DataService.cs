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

        
        public Spiel? GetSpielFromDatabase(int id)
        {
            AppDBContext datenbankVerbindung = _dbContextFactory.CreateDbContext();

            try {

                return (datenbankVerbindung.Spiel.Find(id));
            }
            catch
            {
                return (null);
            }



        }
        public (List<Spiel>?,bool) GetAlleSpiele()
        {
            try { 
            AppDBContext datenbankVerbindung = _dbContextFactory.CreateDbContext();
            List<Spiel> list = new List<Spiel>();
            list = datenbankVerbindung.Spiel.Where(x => x.SpielId != null).ToList();
            return (list,true);
            }
            catch
            {
                return (null, false);
            }
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