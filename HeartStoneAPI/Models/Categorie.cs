using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HeartStoneAPI.Models
{
    public class Categorie
    {
        public int Id { get; set; }

        public string nomCategorie { get; set; }

        [Range(1, 5)]
        public int rareté { get; set; }

        public virtual ICollection<Carte> Cartes { get; set; }
    }
}