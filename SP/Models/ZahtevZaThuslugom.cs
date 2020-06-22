using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class ZahtevZaThuslugom
    {
        public ZahtevZaThuslugom()
        {
            Thponuda = new HashSet<Thponuda>();
        }

        public int Idzahteva { get; set; }
        public DateTime Datum { get; set; }
        public bool Odobreno { get; set; }
        public int IdzapS { get; set; }
        public int IdzapP { get; set; }
        public int Idklijenta { get; set; }

        public virtual Klijent IdklijentaNavigation { get; set; }
        public virtual Zaposleni IdzapPNavigation { get; set; }
        public virtual Zaposleni IdzapSNavigation { get; set; }
        public virtual ICollection<Thponuda> Thponuda { get; set; }
    }
}
