using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class Pozicii
    {
        public int Idpoz { get; set; }
        public int IdpozK { get; set; }

        public virtual Pozicija IdpozKNavigation { get; set; }
    }
}
