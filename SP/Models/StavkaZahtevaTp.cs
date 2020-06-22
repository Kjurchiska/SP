using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class StavkaZahtevaTp
    {
        public StavkaZahtevaTp()
        {
            PotvrdaOrealizacijiPodrske = new HashSet<PotvrdaOrealizacijiPodrske>();
        }

        public int Rbr { get; set; }
        public int IdzahtevaTp { get; set; }
        public string Opis { get; set; }

        public virtual ZahtevZaTehnickomPodrskom IdzahtevaTpNavigation { get; set; }
        public virtual ICollection<PotvrdaOrealizacijiPodrske> PotvrdaOrealizacijiPodrske { get; set; }
    }
}
