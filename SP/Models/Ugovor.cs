using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class Ugovor
    {
        public Ugovor()
        {
            ZahtevZaAktivacijuServisa = new HashSet<ZahtevZaAktivacijuServisa>();
            ZahtevZaTehnickomPodrskom = new HashSet<ZahtevZaTehnickomPodrskom>();
        }

        public int Idugovora { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public string Napomena { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public int Idponude { get; set; }
        public int IdzapS { get; set; }
        public int IdzapP { get; set; }

        public virtual Ponuda IdponudeNavigation { get; set; }
        public virtual Zaposleni IdzapPNavigation { get; set; }
        public virtual Zaposleni IdzapSNavigation { get; set; }
        public virtual ICollection<ZahtevZaAktivacijuServisa> ZahtevZaAktivacijuServisa { get; set; }
        public virtual ICollection<ZahtevZaTehnickomPodrskom> ZahtevZaTehnickomPodrskom { get; set; }
    }
}
