using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class StavkaZahteva
    {
        public int Rbr { get; set; }
        public int Idzahteva { get; set; }
        public string Opis { get; set; }

        public virtual ZahtevZaProveruTehnickihUsluga IdzahtevaNavigation { get; set; }
    }
}
