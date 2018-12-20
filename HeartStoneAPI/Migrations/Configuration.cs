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
            ApplicationUser user = new ApplicationUser();
            user.Email = "a@a.com";
            user.UserName = "Pavlo";
            user.Point = 9999999;
            IdentityResult result = UserManager.Create(user, "Passw0rd!");


            List<Carte> cartes = new List<Carte>()
            {
                new Carte { ValeurAttaque = 1, ValeurDefense= 2, prixAchat = 1000, prixVendre= 500, imageDerier = "/assets/der.jpg", image= "/assets/alphys.png" },
                new Carte { ValeurAttaque = 2, ValeurDefense= 3, prixAchat = 3000, prixVendre= 1500, imageDerier = "/assets/der.jpg", image= "/assets/asgore.png" },
                new Carte { ValeurAttaque = 3, ValeurDefense= 4, prixAchat = 4000, prixVendre= 2000, imageDerier = "/assets/der.jpg", image= "/assets/asriel.png" },
                new Carte { ValeurAttaque = 4, ValeurDefense= 5, prixAchat = 1000, prixVendre= 500, imageDerier = "/assets/der.jpg", image= "/assets/burgerpants.png" },
                new Carte { ValeurAttaque = 5, ValeurDefense= 6, prixAchat = 5000, prixVendre= 2500, imageDerier = "/assets/der.jpg", image= "/assets/chara.png" },
                new Carte { ValeurAttaque = 6, ValeurDefense= 7, prixAchat = 10000, prixVendre= 1, imageDerier = "/assets/der.jpg", image= "/assets/dog.png" },
                new Carte { ValeurAttaque = 7, ValeurDefense= 8, prixAchat = 3000, prixVendre= 1500, imageDerier = "/assets/der.jpg", image= "/assets/dummy.png" },
                new Carte { ValeurAttaque = 8, ValeurDefense= 9, prixAchat = 2500, prixVendre= 1450, imageDerier = "/assets/der.jpg", image= "/assets/flowey.png" },
                new Carte { ValeurAttaque = 9, ValeurDefense= 10, prixAchat = 1000, prixVendre= 500, imageDerier = "/assets/der.jpg", image= "/assets/frisk.png" },
                new Carte { ValeurAttaque = 1, ValeurDefense= 9, prixAchat = 20000, prixVendre= 2000, imageDerier = "/assets/der.jpg", image= "/assets/gaster.png" },
                new Carte { ValeurAttaque = 2, ValeurDefense= 8, prixAchat = 1000, prixVendre= 500, imageDerier = "/assets/der.jpg", image= "/assets/mettaton.png" },
                new Carte { ValeurAttaque = 3, ValeurDefense= 7, prixAchat = 1500, prixVendre= 750, imageDerier = "/assets/der.jpg", image= "/assets/muffet.png" },
                new Carte { ValeurAttaque = 4, ValeurDefense= 6, prixAchat = 1000, prixVendre= 500, imageDerier = "/assets/der.jpg", image= "/assets/napstablook.png" },
                new Carte { ValeurAttaque = 5, ValeurDefense= 5, prixAchat = 1000, prixVendre= 500, imageDerier = "/assets/der.jpg", image= "/assets/papyrus.png" },
                new Carte { ValeurAttaque = 6, ValeurDefense= 4, prixAchat = 50000, prixVendre= 1000, imageDerier = "/assets/der.jpg", image= "/assets/sans.png" },
                new Carte { ValeurAttaque = 7, ValeurDefense= 3, prixAchat = 1000000, prixVendre= 2000, imageDerier = "/assets/der.jpg", image= "/assets/temmie.png" },
                new Carte { ValeurAttaque = 8, ValeurDefense= 2, prixAchat = 1000, prixVendre= 500, imageDerier = "/assets/der.jpg", image= "/assets/Toriel.png" },
                new Carte { ValeurAttaque = 9, ValeurDefense= 1, prixAchat = 10000, prixVendre= 5000, imageDerier = "/assets/der.jpg", image= "/assets/undyne.png" },
                new Carte { ValeurAttaque = 10, ValeurDefense = 18, prixAchat = 1000, prixVendre = 1000, imageDerier = "/assets/der.jpg", image = "/assets/water.jpg" },
                new Carte { ValeurAttaque = 11, ValeurDefense = 17, prixAchat = 1000, prixVendre = 1000, imageDerier = "/assets/der.jpg", image = "/assets/water.jpg" },
                new Carte { ValeurAttaque = 12, ValeurDefense = 16, prixAchat = 1000, prixVendre = 1000, imageDerier = "/assets/der.jpg", image = "/assets/water.jpg" },
                new Carte { ValeurAttaque = 13, ValeurDefense = 15, prixAchat = 1000, prixVendre = 1000, imageDerier = "/assets/der.jpg", image = "/assets/feu.jpg" },
                new Carte { ValeurAttaque = 14, ValeurDefense = 14, prixAchat = 1000, prixVendre = 1000, imageDerier = "/assets/der.jpg", image = "/assets/feu.jpg" },
                new Carte { ValeurAttaque = 15, ValeurDefense = 13, prixAchat = 1000, prixVendre = 1000, imageDerier = "/assets/der.jpg", image = "/assets/feu.jpg" },
                new Carte { ValeurAttaque = 16, ValeurDefense = 12, prixAchat = 1000, prixVendre = 1000, imageDerier = "/assets/der.jpg", image = "/assets/terre.jpg" },
                new Carte { ValeurAttaque = 17, ValeurDefense = 11, prixAchat = 1000, prixVendre = 1000, imageDerier = "/assets/der.jpg", image = "/assets/terre.jpg" },
                new Carte { ValeurAttaque = 18, ValeurDefense = 10, prixAchat = 1000, prixVendre = 1000, imageDerier = "/assets/der.jpg", image = "/assets/terre.jpg" },
            };

            context.Cartes.AddRange(cartes);

            List<Element> elements = new List<Element>()
            {
                new Element { Id = 1, nomElement = "Determination", force = "Monster", faiblesse = "", Cartes = new List<Carte>() },
                new Element { Id = 2, nomElement = "Monster", force = "Monster", faiblesse = "Determination", Cartes = new List<Carte>() },
                new Element { Id = 3, nomElement = "Human", force = "Monster", faiblesse = "Determination", Cartes = new List<Carte>() }
            };

            context.Elements.AddRange(elements);

            elements[1].Cartes.Add(cartes[0]);
            elements[1].Cartes.Add(cartes[1]);
            elements[0].Cartes.Add(cartes[2]);
            elements[1].Cartes.Add(cartes[3]);
            elements[2].Cartes.Add(cartes[4]);
            elements[0].Cartes.Add(cartes[5]);
            elements[1].Cartes.Add(cartes[6]);
            elements[1].Cartes.Add(cartes[7]);
            elements[0].Cartes.Add(cartes[8]);
            elements[0].Cartes.Add(cartes[9]);
            elements[1].Cartes.Add(cartes[10]);
            elements[1].Cartes.Add(cartes[11]);
            elements[1].Cartes.Add(cartes[12]);
            elements[1].Cartes.Add(cartes[13]);
            elements[0].Cartes.Add(cartes[14]);
            elements[1].Cartes.Add(cartes[15]);
            elements[1].Cartes.Add(cartes[16]);
            elements[0].Cartes.Add(cartes[17]);


            List<Categorie> categories = new List<Categorie>()
            {
                new Categorie { Id = 1, nomCategorie = "Human", rareté = 1, Cartes = new List<Carte>() },
                new Categorie { Id = 2, nomCategorie = "Monster", rareté = 2, Cartes = new List<Carte>() },
                new Categorie { Id = 3, nomCategorie = "Golden Flower", rareté = 3, Cartes = new List<Carte>() },
                new Categorie { Id = 4, nomCategorie = "Hero", rareté = 4, Cartes = new List<Carte>() },
                new Categorie { Id = 5, nomCategorie = "True Hero", rareté = 5, Cartes = new List<Carte>() }
            };

            categories[0].Cartes.Add(cartes[0]);//
            categories[1].Cartes.Add(cartes[1]);//
            categories[4].Cartes.Add(cartes[2]);//
            categories[0].Cartes.Add(cartes[3]);//
            categories[2].Cartes.Add(cartes[4]);//
            categories[4].Cartes.Add(cartes[5]);//
            categories[1].Cartes.Add(cartes[6]);//
            categories[2].Cartes.Add(cartes[7]);//
            categories[4].Cartes.Add(cartes[8]);//
            categories[4].Cartes.Add(cartes[9]);//
            categories[1].Cartes.Add(cartes[10]);//
            categories[1].Cartes.Add(cartes[11]);//
            categories[0].Cartes.Add(cartes[12]);//
            categories[3].Cartes.Add(cartes[13]);//
            categories[4].Cartes.Add(cartes[14]);//
            categories[3].Cartes.Add(cartes[15]);//
            categories[3].Cartes.Add(cartes[16]);//
            categories[4].Cartes.Add(cartes[17]);//


            context.SaveChanges();
        }
    }
}
