using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class VrstaKredita
    {
        public VrstaKredita()
        {
            Kredit = new HashSet<Kredit>();
        }

        public int SifraVrsteKr { get; set; }
        public string Naziv { get; set; }
        public int SifraValute { get; set; }

        public virtual Valuta SifraValuteNavigation { get; set; }
        public virtual ICollection<Kredit> Kredit { get; set; }
    }
}
