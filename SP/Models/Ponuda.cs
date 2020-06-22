using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class Ponuda
    {
        public Ponuda()
        {
            StavkaPonude = new HashSet<StavkaPonude>();
            Ugovor = new HashSet<Ugovor>();
        }

        public int Idponude { get; set; }
        public DateTime Datum { get; set; }
        public int Idproracuna { get; set; }
        public DateTime RokPrihvatanja { get; set; }

        public virtual Proracun IdproracunaNavigation { get; set; }
        public virtual ICollection<StavkaPonude> StavkaPonude { get; set; }
        public virtual ICollection<Ugovor> Ugovor { get; set; }
    }
}
