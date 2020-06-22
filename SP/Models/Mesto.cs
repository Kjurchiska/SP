using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class Mesto
    {
        public Mesto()
        {
            Ulica = new HashSet<Ulica>();
        }

        public int PostanskiBroj { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Ulica> Ulica { get; set; }
    }
}
