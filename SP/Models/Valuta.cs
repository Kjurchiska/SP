using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class Valuta
    {
        public Valuta()
        {
            TekuciRacun = new HashSet<TekuciRacun>();
            VrstaKredita = new HashSet<VrstaKredita>();
        }

        public int SifraValute { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<TekuciRacun> TekuciRacun { get; set; }
        public virtual ICollection<VrstaKredita> VrstaKredita { get; set; }
    }
}
