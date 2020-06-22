using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class Proizvodjac
    {
        public Proizvodjac()
        {
            Uredjaj = new HashSet<Uredjaj>();
        }

        public int Idproizvodjaca { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Uredjaj> Uredjaj { get; set; }
    }
}
