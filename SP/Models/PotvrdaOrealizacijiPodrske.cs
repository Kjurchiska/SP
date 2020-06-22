using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class PotvrdaOrealizacijiPodrske
    {
        public int Idpotvrde { get; set; }
        public DateTime Datum { get; set; }
        public bool Uradjeno { get; set; }
        public int Rbr { get; set; }
        public int IdzahtevaTp { get; set; }

        public virtual StavkaZahtevaTp StavkaZahtevaTp { get; set; }
    }
}
