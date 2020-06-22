using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class PonudaUredjajaItarifnihPaketa
    {
        public PonudaUredjajaItarifnihPaketa()
        {
            StavkaPonudeUredjaj = new HashSet<StavkaPonudeUredjaj>();
        }

        public int Idponude { get; set; }
        public decimal Datum { get; set; }
        public int Idzap { get; set; }
        public int Idklijenta { get; set; }

        public virtual Klijent IdklijentaNavigation { get; set; }
        public virtual Zaposleni IdzapNavigation { get; set; }
        public virtual ICollection<StavkaPonudeUredjaj> StavkaPonudeUredjaj { get; set; }
    }
}
