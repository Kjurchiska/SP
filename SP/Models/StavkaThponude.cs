using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class StavkaThponude
    {
        public int Rbr { get; set; }
        public int Idponude { get; set; }
        public DateTime DatumAktivacije { get; set; }
        public int Idusluge { get; set; }

        public virtual Thponuda IdponudeNavigation { get; set; }
        public virtual Thusluga IduslugeNavigation { get; set; }
    }
}
