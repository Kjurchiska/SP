using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class Thusluga
    {
        public Thusluga()
        {
            StavkaThponude = new HashSet<StavkaThponude>();
        }

        public int Idusluge { get; set; }
        public string Naziv { get; set; }
        public decimal Cena { get; set; }
        public int Idvrste { get; set; }

        public virtual VrstaUsluge IdvrsteNavigation { get; set; }
        public virtual ICollection<StavkaThponude> StavkaThponude { get; set; }
    }
}
