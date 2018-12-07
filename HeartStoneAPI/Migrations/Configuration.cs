namespace HeartStoneAPI.Migrations
{
    using HeartStoneAPI.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HeartStoneAPI.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false; /////dobavil
            ContextKey = "HeartStoneAPI.Models.ApplicationDbContext";
        }

        protected override void Seed(HeartStoneAPI.Models.ApplicationDbContext context)
        {
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context)); ////dobavil
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            List<Carte> cartes = new List<Carte>()
            {
               

                new Carte { ValeurAttaque = 1, ValeurDefense=2, prixAchat = 1M, prixVendre= 1.1M, imageDerier = "/assets/der.jpg", image= "/assets/alphys.png" },
                new Carte { ValeurAttaque = 2, ValeurDefense=3, prixAchat = 1M, prixVendre= 1.1M, imageDerier = "/assets/der.jpg", image= "/assets/asgore.png" },
                new Carte { ValeurAttaque = 3, ValeurDefense=4, prixAchat = 1M, prixVendre= 1.1M, imageDerier = "/assets/der.jpg", image= "/assets/asriel.png" },
                new Carte { ValeurAttaque = 4, ValeurDefense=5, prixAchat = 1M, prixVendre= 1.1M, imageDerier = "/assets/der.jpg", image= "/assets/burgerpants.png" },
                new Carte { ValeurAttaque = 5, ValeurDefense=6, prixAchat = 1M, prixVendre= 1.1M, imageDerier = "/assets/der.jpg", image= "/assets/chara.png" },
                new Carte { ValeurAttaque = 6, ValeurDefense=7, prixAchat = 1M, prixVendre= 1.1M, imageDerier = "/assets/der.jpg", image= "/assets/dog.png" },
                new Carte { ValeurAttaque = 7, ValeurDefense=8, prixAchat = 1M, prixVendre= 1.1M, imageDerier = "/assets/der.jpg", image= "/assets/dummy.png" },
                new Carte { ValeurAttaque = 8, ValeurDefense=9, prixAchat = 1M, prixVendre= 1.1M, imageDerier = "/assets/der.jpg", image= "/assets/flowey.png" },
                new Carte { ValeurAttaque = 9, ValeurDefense=10, prixAchat = 1M, prixVendre= 1.1M, imageDerier = "/assets/der.jpg", image= "/assets/frisk.png" },
                new Carte { ValeurAttaque = 1, ValeurDefense=9, prixAchat = 1M, prixVendre= 1.1M, imageDerier = "/assets/der.jpg", image= "/assets/gaster.png" },
                new Carte { ValeurAttaque = 2, ValeurDefense=8, prixAchat = 1M, prixVendre= 1.1M, imageDerier = "/assets/der.jpg", image= "/assets/mettaton.png" },
                new Carte { ValeurAttaque = 3, ValeurDefense=7, prixAchat = 1M, prixVendre= 1.1M, imageDerier = "/assets/der.jpg", image= "/assets/muffet.png" },
                new Carte { ValeurAttaque = 4, ValeurDefense=6, prixAchat = 1M, prixVendre= 1.1M, imageDerier = "/assets/der.jpg", image= "/assets/napstablook.png" },
                new Carte { ValeurAttaque = 5, ValeurDefense=5, prixAchat = 1M, prixVendre= 1.1M, imageDerier = "/assets/der.jpg", image= "/assets/papyrus.png" },
                new Carte { ValeurAttaque = 6, ValeurDefense=4, prixAchat = 1M, prixVendre= 1.1M, imageDerier = "/assets/der.jpg", image= "/assets/sans.png" },
                new Carte { ValeurAttaque = 7, ValeurDefense=3, prixAchat = 1M, prixVendre= 1.1M, imageDerier = "/assets/der.jpg", image= "/assets/temmie.png" },
                new Carte { ValeurAttaque = 8, ValeurDefense=2, prixAchat = 1M, prixVendre= 1.1M, imageDerier = "/assets/der.jpg", image= "/assets/Toriel.png" },
                new Carte { ValeurAttaque = 9, ValeurDefense=1, prixAchat = 1M, prixVendre= 1.1M, imageDerier = "/assets/der.jpg", image= "/assets/undyne.png" },
                 new Carte {ValeurAttaque = 10, ValeurDefense =18, prixAchat = 0.9M , prixVendre= 1M, imageDerier = "/assets/der.jpg", image= "/assets/feu.jpg" },
                new Carte {ValeurAttaque = 11, ValeurDefense =17, prixAchat = 1M , prixVendre= 1.1M, imageDerier = "/assets/der.jpg", image= "/assets/water.jpg" },
                new Carte {ValeurAttaque = 12, ValeurDefense =16, prixAchat = 1.1M , prixVendre= 1.2M, imageDerier = "/assets/der.jpg", image= "/assets/terre.jpg" },
                new Carte {ValeurAttaque = 13, ValeurDefense =15, prixAchat = 1.2M , prixVendre= 1.3M, imageDerier = "/assets/der.jpg", image= "/assets/feu.jpg" },
                new Carte {ValeurAttaque = 14, ValeurDefense =14, prixAchat = 1.3M , prixVendre= 1.4M, imageDerier = "/assets/der.jpg", image= "/assets/water.jpg" },
                new Carte {ValeurAttaque = 15, ValeurDefense =13, prixAchat = 1.4M , prixVendre= 1.5M, imageDerier = "/assets/der.jpg", image= "/assets/terre.jpg" },
                new Carte {ValeurAttaque = 16, ValeurDefense =12, prixAchat = 1.5M , prixVendre= 1.6M, imageDerier = "/assets/der.jpg", image= "/assets/feu.jpg" },
                new Carte {ValeurAttaque = 17, ValeurDefense =11, prixAchat = 1.6M , prixVendre= 1.7M, imageDerier = "/assets/der.jpg", image= "/assets/water.jpg" },
                new Carte {ValeurAttaque = 18, ValeurDefense =10, prixAchat =1.7M , prixVendre= 1.8M, imageDerier = "/assets/der.jpg", image= "/assets/terre.jpg" },
            };
           /*  List< ApplicationUser > users = new List<ApplicationUser>()
             {
                 new ApplicationUser { UserName = "a@a.com", Email = "a@a.com", PasswordHash = "Passw0rd! "  }

             };*/

            context.Cartes.AddRange(cartes);
           // context.Users.  AddRange(users);

            context.SaveChanges();
        }
    }
}
