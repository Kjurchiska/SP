using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class ZahtevZaProveruTehnickihUsluga
    {
        public ZahtevZaProveruTehnickihUsluga()
        {
            StavkaZahteva = new HashSet<StavkaZahteva>();
        }

        public int Idzahteva { get; set; }
        public DateTime Datum { get; set; }
        public bool Odobreno { get; set; }
        public int IdzapS { get; set; }
        public int IdzapP { get; set; }

        public virtual Zaposleni IdzapPNavigation { get; set; }
        public virtual Zaposleni IdzapSNavigation { get; set; }
        public virtual ICollection<StavkaZahteva> StavkaZahteva { get; set; }
    }
}
