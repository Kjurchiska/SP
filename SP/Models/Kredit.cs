using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class Kredit
    {
        public Kredit()
        {
            ZahtevZaProveruKreditneSposobnosti = new HashSet<ZahtevZaProveruKreditneSposobnosti>();
        }

        public int Idkr { get; set; }
        public int SifraVrsteKr { get; set; }
        public int Idklijenta { get; set; }
        public decimal OdobreniIznos { get; set; }
        public decimal IskorisceniIznos { get; set; }
        public DateTime DatumPocetkaKoriscenja { get; set; }
        public DateTime DatumPocetkaOtplate { get; set; }
        public DateTime DatumKrajaOtplate { get; set; }
        public DateTime PeriodOtplate { get; set; }
        public decimal OstatakDuga { get; set; }
        public string Status { get; set; }

        public virtual Klijent IdklijentaNavigation { get; set; }
        public virtual VrstaKredita SifraVrsteKrNavigation { get; set; }
        public virtual ICollection<ZahtevZaProveruKreditneSposobnosti> ZahtevZaProveruKreditneSposobnosti { get; set; }
    }
}
