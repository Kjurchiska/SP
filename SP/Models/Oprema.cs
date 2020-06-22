using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class Oprema
    {
        public int Idopreme { get; set; }
        public int Idvrste { get; set; }
        public int Idprostora { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Model { get; set; }
        public string Garancija { get; set; }

        public virtual Prostor IdprostoraNavigation { get; set; }
        public virtual VrstaUsluge IdvrsteNavigation { get; set; }
    }
}
