using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class OrganizacionaJedinica
    {
        public OrganizacionaJedinica()
        {
            Pozicija = new HashSet<Pozicija>();
        }

        public int IdorgJed { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Pozicija> Pozicija { get; set; }
    }
}
