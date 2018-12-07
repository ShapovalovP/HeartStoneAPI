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
                new Carte { ValeurAttaque = 10, ValeurDefense=10, prixAchat = 1.7M, prixVendre= 1.8M, imageDerier = "/assets/der.jpg", image= "/assets/alphys.png" },
                new Carte { ValeurAttaque = 10, ValeurDefense=10, prixAchat = 1.7M, prixVendre= 1.8M, imageDerier = "/assets/der.jpg", image= "/assets/asgore.png" },
                new Carte { ValeurAttaque = 10, ValeurDefense=10, prixAchat = 1.7M, prixVendre= 1.8M, imageDerier = "/assets/der.jpg", image= "/assets/asriel.png" },
                new Carte { ValeurAttaque = 10, ValeurDefense=10, prixAchat = 1.7M, prixVendre= 1.8M, imageDerier = "/assets/der.jpg", image= "/assets/burgerpants.png" },
                new Carte { ValeurAttaque = 10, ValeurDefense=10, prixAchat = 1.7M, prixVendre= 1.8M, imageDerier = "/assets/der.jpg", image= "/assets/chara.png" },
                new Carte { ValeurAttaque = 10, ValeurDefense=10, prixAchat = 1.7M, prixVendre= 1.8M, imageDerier = "/assets/der.jpg", image= "/assets/dog.png" },
                new Carte { ValeurAttaque = 10, ValeurDefense=10, prixAchat = 1.7M, prixVendre= 1.8M, imageDerier = "/assets/der.jpg", image= "/assets/dummy.png" },
                new Carte { ValeurAttaque = 10, ValeurDefense=10, prixAchat = 1.7M, prixVendre= 1.8M, imageDerier = "/assets/der.jpg", image= "/assets/flowey.png" },
                new Carte { ValeurAttaque = 10, ValeurDefense=10, prixAchat = 1.7M, prixVendre= 1.8M, imageDerier = "/assets/der.jpg", image= "/assets/frisk.png" },
                new Carte { ValeurAttaque = 10, ValeurDefense=10, prixAchat = 1.7M, prixVendre= 1.8M, imageDerier = "/assets/der.jpg", image= "/assets/gaster.png" },
                new Carte { ValeurAttaque = 10, ValeurDefense=10, prixAchat = 1.7M, prixVendre= 1.8M, imageDerier = "/assets/der.jpg", image= "/assets/mettaton.png" },
                new Carte { ValeurAttaque = 10, ValeurDefense=10, prixAchat = 1.7M, prixVendre= 1.8M, imageDerier = "/assets/der.jpg", image= "/assets/muffet.png" },
                new Carte { ValeurAttaque = 10, ValeurDefense=10, prixAchat = 1.7M, prixVendre= 1.8M, imageDerier = "/assets/der.jpg", image= "/assets/napstablook.png" },
                new Carte { ValeurAttaque = 10, ValeurDefense=10, prixAchat = 1.7M, prixVendre= 1.8M, imageDerier = "/assets/der.jpg", image= "/assets/papyrus.png" },
                new Carte { ValeurAttaque = 10, ValeurDefense=10, prixAchat = 1.7M, prixVendre= 1.8M, imageDerier = "/assets/der.jpg", image= "/assets/sans.png" },
                new Carte { ValeurAttaque = 10, ValeurDefense=10, prixAchat = 1.7M, prixVendre= 1.8M, imageDerier = "/assets/der.jpg", image= "/assets/temmie.png" },
                new Carte { ValeurAttaque = 10, ValeurDefense=10, prixAchat = 1.7M, prixVendre= 1.8M, imageDerier = "/assets/der.jpg", image= "/assets/Toriel.png" },
                new Carte { ValeurAttaque = 10, ValeurDefense=10, prixAchat = 1.7M, prixVendre= 1.8M, imageDerier = "/assets/der.jpg", image= "/assets/undyne.png" },
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
