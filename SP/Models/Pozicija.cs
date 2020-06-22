using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class Pozicija
    {
        public Pozicija()
        {
            Pozicii = new HashSet<Pozicii>();
            Zaposleni = new HashSet<Zaposleni>();
        }

        public int Idpoz { get; set; }
        public int IdorgJed { get; set; }
        public string Naziv { get; set; }

        public virtual OrganizacionaJedinica IdorgJedNavigation { get; set; }
        public virtual ICollection<Pozicii> Pozicii { get; set; }
        public virtual ICollection<Zaposleni> Zaposleni { get; set; }
    }
}
