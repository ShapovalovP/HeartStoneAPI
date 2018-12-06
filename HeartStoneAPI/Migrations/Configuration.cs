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
                new Carte {ValeurAttaque = 1, ValeurDefense =2, prixAchat = 0.9M , prixVendre= 1M, imageDerier = "/assets/der.jpg", image= "/assets/feu.jpg" },
                new Carte {ValeurAttaque = 2, ValeurDefense =3, prixAchat = 1M , prixVendre= 1.1M, imageDerier = "/assets/der.jpg", image= "/assets/water.jpg" },
                new Carte {ValeurAttaque = 3, ValeurDefense =4, prixAchat = 1.1M , prixVendre= 1.2M, imageDerier = "/assets/der.jpg", image= "/assets/terre.jpg" },
                new Carte {ValeurAttaque = 4, ValeurDefense =5, prixAchat = 1.2M , prixVendre= 1.3M, imageDerier = "/assets/der.jpg", image= "/assets/feu.jpg" },
                new Carte {ValeurAttaque = 5, ValeurDefense =6, prixAchat = 1.3M , prixVendre= 1.4M, imageDerier = "/assets/der.jpg", image= "/assets/water.jpg" },
                new Carte {ValeurAttaque = 6, ValeurDefense =7, prixAchat = 1.4M , prixVendre= 1.5M, imageDerier = "/assets/der.jpg", image= "/assets/terre.jpg" },
                new Carte {ValeurAttaque = 7, ValeurDefense =8, prixAchat = 1.5M , prixVendre= 1.6M, imageDerier = "/assets/der.jpg", image= "/assets/feu.jpg" },
                new Carte {ValeurAttaque = 8, ValeurDefense =9, prixAchat = 1.6M , prixVendre= 1.7M, imageDerier = "/assets/der.jpg", image= "/assets/water.jpg" },
                new Carte {ValeurAttaque = 9, ValeurDefense =10, prixAchat =1.7M , prixVendre= 1.8M, imageDerier = "/assets/der.jpg", image= "/assets/terre.jpg" },
            };

            context.Cartes.AddRange(cartes);

            context.SaveChanges();
        }
    }
}
