using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class ZahtevZaProveruKreditneSposobnosti
    {
        public int Idzahteva { get; set; }
        public decimal Datum { get; set; }
        public string NacinDostave { get; set; }
        public int Idtr { get; set; }
        public int IdzapS { get; set; }
        public int IdzapP { get; set; }
        public int Idkr { get; set; }
        public int SifraVrsteKr { get; set; }
        public int Idklijenta { get; set; }

        public virtual TekuciRacun IdtrNavigation { get; set; }
        public virtual Zaposleni IdzapPNavigation { get; set; }
        public virtual Zaposleni IdzapSNavigation { get; set; }
        public virtual Kredit Kredit { get; set; }
    }
}
