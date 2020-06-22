using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class VrstaPaketa
    {
        public VrstaPaketa()
        {
            TarifniPaket = new HashSet<TarifniPaket>();
        }

        public int Idvrste { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<TarifniPaket> TarifniPaket { get; set; }
    }
}
