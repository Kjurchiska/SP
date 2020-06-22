using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class Ulica
    {
        public Ulica()
        {
            Broj = new HashSet<Broj>();
        }

        public int Idulice { get; set; }
        public int PostanskiBroj { get; set; }
        public string Naziv { get; set; }

        public virtual Mesto PostanskiBrojNavigation { get; set; }
        public virtual ICollection<Broj> Broj { get; set; }
    }
}
