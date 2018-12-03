using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeartStoneAPI.Models
{
    public class Deck
    {
        public int Id { get; set; }
        public int PartieId { get; set; }
        public virtual List<Carte> Cartes { get; set; }
    }
}