using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class Zaposleni
    {
        public Zaposleni()
        {
            PonudaUredjajaItarifnihPaketa = new HashSet<PonudaUredjajaItarifnihPaketa>();
            PotencijalniKlijentZaposleniPNavigation = new HashSet<PotencijalniKlijent>();
            PotencijalniKlijentZaposleniSNavigation = new HashSet<PotencijalniKlijent>();
            ProracunIdzapPNavigation = new HashSet<Proracun>();
            ProracunIdzapSNavigation = new HashSet<Proracun>();
            Thponuda = new HashSet<Thponuda>();
            UgovorIdzapPNavigation = new HashSet<Ugovor>();
            UgovorIdzapSNavigation = new HashSet<Ugovor>();
            ZahtevZaAktivacijuServisa = new HashSet<ZahtevZaAktivacijuServisa>();
            ZahtevZaPomocPriInstalacijiThusluge = new HashSet<ZahtevZaPomocPriInstalacijiThusluge>();
            ZahtevZaProveruKreditneSposobnostiIdzapPNavigation = new HashSet<ZahtevZaProveruKreditneSposobnosti>();
            ZahtevZaProveruKreditneSposobnostiIdzapSNavigation = new HashSet<ZahtevZaProveruKreditneSposobnosti>();
            ZahtevZaProveruTehnickihUslugaIdzapPNavigation = new HashSet<ZahtevZaProveruTehnickihUsluga>();
            ZahtevZaProveruTehnickihUslugaIdzapSNavigation = new HashSet<ZahtevZaProveruTehnickihUsluga>();
            ZahtevZaTehnickomPodrskom = new HashSet<ZahtevZaTehnickomPodrskom>();
            ZahtevZaThuslugomIdzapPNavigation = new HashSet<ZahtevZaThuslugom>();
            ZahtevZaThuslugomIdzapSNavigation = new HashSet<ZahtevZaThuslugom>();
        }

        public int Idzap { get; set; }
        public int Idpoz { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumUvodjenja { get; set; }

        public virtual Pozicija IdpozNavigation { get; set; }
        public virtual ICollection<PonudaUredjajaItarifnihPaketa> PonudaUredjajaItarifnihPaketa { get; set; }
        public virtual ICollection<PotencijalniKlijent> PotencijalniKlijentZaposleniPNavigation { get; set; }
        public virtual ICollection<PotencijalniKlijent> PotencijalniKlijentZaposleniSNavigation { get; set; }
        public virtual ICollection<Proracun> ProracunIdzapPNavigation { get; set; }
        public virtual ICollection<Proracun> ProracunIdzapSNavigation { get; set; }
        public virtual ICollection<Thponuda> Thponuda { get; set; }
        public virtual ICollection<Ugovor> UgovorIdzapPNavigation { get; set; }
        public virtual ICollection<Ugovor> UgovorIdzapSNavigation { get; set; }
        public virtual ICollection<ZahtevZaAktivacijuServisa> ZahtevZaAktivacijuServisa { get; set; }
        public virtual ICollection<ZahtevZaPomocPriInstalacijiThusluge> ZahtevZaPomocPriInstalacijiThusluge { get; set; }
        public virtual ICollection<ZahtevZaProveruKreditneSposobnosti> ZahtevZaProveruKreditneSposobnostiIdzapPNavigation { get; set; }
        public virtual ICollection<ZahtevZaProveruKreditneSposobnosti> ZahtevZaProveruKreditneSposobnostiIdzapSNavigation { get; set; }
        public virtual ICollection<ZahtevZaProveruTehnickihUsluga> ZahtevZaProveruTehnickihUslugaIdzapPNavigation { get; set; }
        public virtual ICollection<ZahtevZaProveruTehnickihUsluga> ZahtevZaProveruTehnickihUslugaIdzapSNavigation { get; set; }
        public virtual ICollection<ZahtevZaTehnickomPodrskom> ZahtevZaTehnickomPodrskom { get; set; }
        public virtual ICollection<ZahtevZaThuslugom> ZahtevZaThuslugomIdzapPNavigation { get; set; }
        public virtual ICollection<ZahtevZaThuslugom> ZahtevZaThuslugomIdzapSNavigation { get; set; }
    }
}
