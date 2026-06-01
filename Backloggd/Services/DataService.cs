using Backloggd.Database;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using Backloggd.Models;

namespace Backloggd.Services
{
    public class DataService
    {
        /*
        // Die Kontext Factory welche die Datenbankverbindung aufbaut
        private readonly IDbContextFactory<AppDBContext> _dbContextFactory;
        public User loggedInUser { get; private set; }

        // Im Konstruktor wird die ContextFactory übergeben die wir in Program.cs erstellt haben
        // Das passiert automatisch
        public DataService(IDbContextFactory<AppDBContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }


        #region User

        public (bool, string) AddUser(User newUser)
        {
            try {

                AppDBContext datenbankVerbindung = _dbContextFactory.CreateDbContext();

                datenbankVerbindung.Add(newUser);
                datenbankVerbindung.SaveChanges();
                return (true, string.Empty);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) LoginUser(User loginUser)
        {
            try
            {

                AppDBContext datenbankVerbindung = _dbContextFactory.CreateDbContext();

                string hashedPW = HashPasswort(loginUser.Passwort);

               bool uservorhanden= datenbankVerbindung.User.
                    Where(u => u.Username == loginUser.Username).
                    Where(u => u.Passwort == hashedPW).
                    Any();//Ist genau dieser Datensatz vorhanden?

                if (uservorhanden) //User vorhanden
                {
                    this.loggedInUser = loginUser;
                    return (true, string.Empty);
                }
                else
                {
                    return (false, "Benutzername oder Passwort falsch");
                }


                
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        #endregion

        #region Encryption

        private string HashPasswort(string klartext)
        {
            byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(klartext));
            return Convert.ToHexString(bytes).ToLower();
        }

        #endregion



        #region Nachrichten

        public List<Nachrichten> GetNachrichten()
        {
            List<Nachrichten> messages= new List<Nachrichten>();
            try
            {

                AppDBContext datenbankVerbindung = _dbContextFactory.CreateDbContext();
                messages=datenbankVerbindung.Nachrichten.OrderByDescending(n=>n.Created).Include(n=>n.User).ToList();
            }
            catch (Exception ex) 
            { 
            
            }
            return messages;
        }

        #endregion
         */
    }




}