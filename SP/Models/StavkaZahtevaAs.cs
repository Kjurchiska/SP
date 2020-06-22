using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class StavkaZahtevaAs
    {
        public int Rbr { get; set; }
        public int IdzahtevaAs { get; set; }
        public int Idservisa { get; set; }
        public DateTime RokIsporuke { get; set; }

        public virtual Servis IdservisaNavigation { get; set; }
        public virtual ZahtevZaAktivacijuServisa IdzahtevaAsNavigation { get; set; }
    }
}
