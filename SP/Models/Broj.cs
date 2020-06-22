using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class Broj
    {
        public Broj()
        {
            Klijent = new HashSet<Klijent>();
            Prostor = new HashSet<Prostor>();
        }

        public int BrojAdrese { get; set; }
        public int Idulice { get; set; }
        public int PostanskiBroj { get; set; }

        public virtual Ulica Ulica { get; set; }
        public virtual ICollection<Klijent> Klijent { get; set; }
        public virtual ICollection<Prostor> Prostor { get; set; }
    }
}
