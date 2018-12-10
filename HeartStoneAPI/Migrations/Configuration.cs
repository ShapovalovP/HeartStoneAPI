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
                new Carte { ValeurAttaque = 30, ValeurDefense= 200, prixAchat = 1000, prixVendre= 500, imageDerier = "/assets/der.jpg", image= "/assets/alphys.png" },
                new Carte { ValeurAttaque = 55, ValeurDefense= 350, prixAchat = 3000, prixVendre= 1500, imageDerier = "/assets/der.jpg", image= "/assets/asgore.png" },
                new Carte { ValeurAttaque = 60, ValeurDefense= 600, prixAchat = 4000, prixVendre= 2000, imageDerier = "/assets/der.jpg", image= "/assets/asriel.png" },
                new Carte { ValeurAttaque = 30, ValeurDefense= 150, prixAchat = 1000, prixVendre= 500, imageDerier = "/assets/der.jpg", image= "/assets/burgerpants.png" },
                new Carte { ValeurAttaque = 35, ValeurDefense= 200, prixAchat = 5000, prixVendre= 2500, imageDerier = "/assets/der.jpg", image= "/assets/chara.png" },
                new Carte { ValeurAttaque = 250, ValeurDefense= 5000, prixAchat = 10000, prixVendre= 1, imageDerier = "/assets/der.jpg", image= "/assets/dog.png" },
                new Carte { ValeurAttaque = 200, ValeurDefense= 1000, prixAchat = 3000, prixVendre= 1500, imageDerier = "/assets/der.jpg", image= "/assets/dummy.png" },
                new Carte { ValeurAttaque = 50, ValeurDefense= 200, prixAchat = 2500, prixVendre= 1450, imageDerier = "/assets/der.jpg", image= "/assets/flowey.png" },
                new Carte { ValeurAttaque = 50, ValeurDefense= 300, prixAchat = 1000, prixVendre= 500, imageDerier = "/assets/der.jpg", image= "/assets/frisk.png" },
                new Carte { ValeurAttaque = 300, ValeurDefense= 1000, prixAchat = 20000, prixVendre= 2000, imageDerier = "/assets/der.jpg", image= "/assets/gaster.png" },
                new Carte { ValeurAttaque = 30, ValeurDefense= 200, prixAchat = 1000, prixVendre= 500, imageDerier = "/assets/der.jpg", image= "/assets/mettaton.png" },
                new Carte { ValeurAttaque = 40, ValeurDefense= 400, prixAchat = 1500, prixVendre= 750, imageDerier = "/assets/der.jpg", image= "/assets/muffet.png" },
                new Carte { ValeurAttaque = 30, ValeurDefense= 100, prixAchat = 1000, prixVendre= 500, imageDerier = "/assets/der.jpg", image= "/assets/napstablook.png" },
                new Carte { ValeurAttaque = 30, ValeurDefense= 200, prixAchat = 1000, prixVendre= 500, imageDerier = "/assets/der.jpg", image= "/assets/papyrus.png" },
                new Carte { ValeurAttaque = 400, ValeurDefense= 1000000, prixAchat = 50000, prixVendre= 1000, imageDerier = "/assets/der.jpg", image= "/assets/sans.png" },
                new Carte { ValeurAttaque = 1000, ValeurDefense= 1000, prixAchat = 1000000, prixVendre= 2000, imageDerier = "/assets/der.jpg", image= "/assets/temmie.png" },
                new Carte { ValeurAttaque = 30, ValeurDefense= 300, prixAchat = 1000, prixVendre= 500, imageDerier = "/assets/der.jpg", image= "/assets/Toriel.png" },
                new Carte { ValeurAttaque = 50, ValeurDefense= 1000, prixAchat = 10000, prixVendre= 5000, imageDerier = "/assets/der.jpg", image= "/assets/undyne.png" },
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
