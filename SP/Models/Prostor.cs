using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class Prostor
    {
        public Prostor()
        {
            Oprema = new HashSet<Oprema>();
        }

        public int Idprostora { get; set; }
        public string Naziv { get; set; }
        public int BrojAdrese { get; set; }
        public int Idulice { get; set; }
        public int PostanskiBroj { get; set; }

        public virtual Broj Broj { get; set; }
        public virtual ICollection<Oprema> Oprema { get; set; }
    }
}
