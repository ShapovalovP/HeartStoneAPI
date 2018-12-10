using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeartStoneAPI.Models
{
    public class Deck
    {
        public int Id { get; set; }
        public string nomDeck { get; set; }
       // public int PartieId { get; set; }

        public virtual ApplicationUser Users { get; set; }
        public virtual List<Carte> Cartes { get; set; }
    }

    public class DeckDto
    {
        public int id;
        public string name;
        public DeckDto() {
        }
        public DeckDto(int _id, string _name)
        {
            this.id = _id;
            this.name = _name;
        }
    }
}