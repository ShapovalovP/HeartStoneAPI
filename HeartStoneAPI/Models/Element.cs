using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeartStoneAPI.Models
{
    public class Element
    {
        public int Id { get; set; }

        public string nomElement { get; set; }

        public string force { get; set; }

        public string faiblesse { get; set; }

        public virtual ICollection<Carte> Cartes { get; set; }
    }
}