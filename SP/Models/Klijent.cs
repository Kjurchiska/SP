using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class Klijent
    {
        public Klijent()
        {
            Kredit = new HashSet<Kredit>();
            PonudaUredjajaItarifnihPaketa = new HashSet<PonudaUredjajaItarifnihPaketa>();
            ZahtevZaThuslugom = new HashSet<ZahtevZaThuslugom>();
        }

        public int Idklijenta { get; set; }
        public string Naziv { get; set; }
        public string Pib { get; set; }
        public string Telefon { get; set; }
        public string WebStrana { get; set; }
        public DateTime GodinaOsnivanja { get; set; }
        public int SifraDel { get; set; }
        public int BrojAdrese { get; set; }
        public int Idulice { get; set; }
        public int PostanskiBroj { get; set; }
        public int IdpotKlijenta { get; set; }

        public virtual Broj Broj { get; set; }
        public virtual PotencijalniKlijent IdpotKlijentaNavigation { get; set; }
        public virtual Delatnost SifraDelNavigation { get; set; }
        public virtual ICollection<Kredit> Kredit { get; set; }
        public virtual ICollection<PonudaUredjajaItarifnihPaketa> PonudaUredjajaItarifnihPaketa { get; set; }
        public virtual ICollection<ZahtevZaThuslugom> ZahtevZaThuslugom { get; set; }
    }
}
