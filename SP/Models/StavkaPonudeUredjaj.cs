using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class StavkaPonudeUredjaj
    {
        public int Rbr { get; set; }
        public int Idponude { get; set; }
        public int? Iduredjaja { get; set; }
        public int Idtf { get; set; }

        public virtual PonudaUredjajaItarifnihPaketa IdponudeNavigation { get; set; }
        public virtual TarifniPaket IdtfNavigation { get; set; }
        public virtual Uredjaj IduredjajaNavigation { get; set; }
    }
}
