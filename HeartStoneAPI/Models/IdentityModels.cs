using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace HeartStoneAPI.Models
{
    // Vous pouvez ajouter des données de profil pour l'utilisateur en ajoutant d'autres propriétés à votre classe ApplicationUser. Pour en savoir plus, consultez https://go.microsoft.com/fwlink/?LinkID=317594.
    public class ApplicationUser : IdentityUser
    {
        public virtual List<Carte> Cartes { get; set; }
          public int Point { get; set; }
        public virtual List<Partie> Parties { get; set; }
        public virtual List<Deck> deck { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Notez que authenticationType doit correspondre à l'instance définie dans CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Ajouter des revendications d’utilisateur personnalisées ici
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public System.Data.Entity.DbSet<HeartStoneAPI.Models.Carte> Cartes { get; set; }
        public System.Data.Entity.DbSet<HeartStoneAPI.Models.Partie> Parties { get; set; }
        public System.Data.Entity.DbSet<HeartStoneAPI.Models.Deck> Decks { get; set; }
        public System.Data.Entity.DbSet<HeartStoneAPI.Models.Tour> Tours { get; set; }
        public System.Data.Entity.DbSet<HeartStoneAPI.Models.CarteJoueur> CarteJoueurs { get; set; }
    }
}