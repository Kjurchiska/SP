using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class ZahtevZaAktivacijuServisa
    {
        public ZahtevZaAktivacijuServisa()
        {
            StavkaZahtevaAs = new HashSet<StavkaZahtevaAs>();
        }

        public int IdzahtevaAs { get; set; }
        public DateTime Datum { get; set; }
        public bool Odobreno { get; set; }
        public int Idzap { get; set; }
        public int Idugovora { get; set; }

        public virtual Ugovor IdugovoraNavigation { get; set; }
        public virtual Zaposleni IdzapNavigation { get; set; }
        public virtual ICollection<StavkaZahtevaAs> StavkaZahtevaAs { get; set; }
    }
}
