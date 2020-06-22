using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class Servis
    {
        public Servis()
        {
            StavkaZahtevaAs = new HashSet<StavkaZahtevaAs>();
        }

        public int Idservisa { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<StavkaZahtevaAs> StavkaZahtevaAs { get; set; }
    }
}
