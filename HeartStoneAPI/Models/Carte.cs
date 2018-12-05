﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeartStoneAPI.Models
{
    public class Carte
    {
       public int Id { get; set; }
       public int ValeurAttaque { get; set; }
       public int ValeurDefense { get; set; }
       public decimal prixAchat { get; set; }
       public decimal prixVendre { get; set; }

       public string image { get; set; }

       // public virtual List<ApplicationUser> Users { get; set; }
    }

    public class CarteDTO
    {
        public CarteDTO() { }

        public CarteDTO(int idp, int valAtack, int valDef, decimal prixAch, decimal prixVendr) {
            id = idp;
            valeurAttaque = valAtack;
            valeurDefense = valDef;
            prixAchat = prixAch;
            prixVendre = prixVendr;
           

        }
        public int id { get; set; }
        public int valeurAttaque { get; set; }
        public int valeurDefense { get; set; }
        public decimal prixAchat { get; set; }
        public decimal prixVendre { get; set; }

        public string userId { get; set; }
       // public string image { get; set; }

       // public virtual List<ApplicationUser> Users { get; set; }
    }
}