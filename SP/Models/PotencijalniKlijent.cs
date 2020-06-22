using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class PotencijalniKlijent
    {
        public PotencijalniKlijent()
        {
            Klijent = new HashSet<Klijent>();
        }

        public int IdpotKlijenta { get; set; }
        public DateTime Datum { get; set; }
        public string Naziv { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Napomena { get; set; }
        public int ZaposleniS { get; set; }
        public int ZaposleniP { get; set; }

        public virtual Zaposleni ZaposleniPNavigation { get; set; }
        public virtual Zaposleni ZaposleniSNavigation { get; set; }
        public virtual ICollection<Klijent> Klijent { get; set; }
    }
}
