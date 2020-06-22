using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class ZahtevZaTehnickomPodrskom
    {
        public ZahtevZaTehnickomPodrskom()
        {
            StavkaZahtevaTp = new HashSet<StavkaZahtevaTp>();
        }

        public int IdzahtevaTp { get; set; }
        public DateTime Datum { get; set; }
        public bool Odobreno { get; set; }
        public int Idzap { get; set; }
        public int Idugovora { get; set; }

        public virtual Ugovor IdugovoraNavigation { get; set; }
        public virtual Zaposleni IdzapNavigation { get; set; }
        public virtual ICollection<StavkaZahtevaTp> StavkaZahtevaTp { get; set; }
    }
}
