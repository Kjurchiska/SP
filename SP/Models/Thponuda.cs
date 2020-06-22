using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class Thponuda
    {
        public Thponuda()
        {
            StavkaThponude = new HashSet<StavkaThponude>();
            Thugovor = new HashSet<Thugovor>();
        }

        public int Idponude { get; set; }
        public int Idzahteva { get; set; }
        public int Idzap { get; set; }
        public DateTime Datum { get; set; }
        public DateTime RokZaPotvrdu { get; set; }

        public virtual ZahtevZaThuslugom IdzahtevaNavigation { get; set; }
        public virtual Zaposleni IdzapNavigation { get; set; }
        public virtual ICollection<StavkaThponude> StavkaThponude { get; set; }
        public virtual ICollection<Thugovor> Thugovor { get; set; }
    }
}
