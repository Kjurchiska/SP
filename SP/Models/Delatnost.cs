using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class Delatnost
    {
        public Delatnost()
        {
            Klijent = new HashSet<Klijent>();
        }

        public int SifraDel { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Klijent> Klijent { get; set; }
    }
}
