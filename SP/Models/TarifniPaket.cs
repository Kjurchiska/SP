using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class TarifniPaket
    {
        public TarifniPaket()
        {
            StavkaPonudeUredjaj = new HashSet<StavkaPonudeUredjaj>();
            StavkaProracuna = new HashSet<StavkaProracuna>();
        }

        public int Idtf { get; set; }
        public string Naziv { get; set; }
        public DateTime BrojMinuta { get; set; }
        public int BrojPoruka { get; set; }
        public string BrojMb { get; set; }
        public int Idvrste { get; set; }

        public virtual VrstaPaketa IdvrsteNavigation { get; set; }
        public virtual ICollection<StavkaPonudeUredjaj> StavkaPonudeUredjaj { get; set; }
        public virtual ICollection<StavkaProracuna> StavkaProracuna { get; set; }
    }
}
