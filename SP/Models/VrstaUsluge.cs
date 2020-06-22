using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class VrstaUsluge
    {
        public VrstaUsluge()
        {
            Oprema = new HashSet<Oprema>();
            Thusluga = new HashSet<Thusluga>();
        }

        public int Idvrste { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<Oprema> Oprema { get; set; }
        public virtual ICollection<Thusluga> Thusluga { get; set; }
    }
}
