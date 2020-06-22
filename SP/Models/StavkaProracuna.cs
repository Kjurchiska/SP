using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class StavkaProracuna
    {
        public StavkaProracuna()
        {
            StavkaPonude = new HashSet<StavkaPonude>();
        }

        public int Rbr { get; set; }
        public int Idproracuna { get; set; }
        public int? Iduredjaja { get; set; }
        public int? Idtf { get; set; }

        public virtual Proracun IdproracunaNavigation { get; set; }
        public virtual TarifniPaket IdtfNavigation { get; set; }
        public virtual Uredjaj IduredjajaNavigation { get; set; }
        public virtual ICollection<StavkaPonude> StavkaPonude { get; set; }
    }
}
