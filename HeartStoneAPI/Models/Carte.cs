using System;
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

        public virtual List<ApplicationUser> Users { get; set; }
    }
}