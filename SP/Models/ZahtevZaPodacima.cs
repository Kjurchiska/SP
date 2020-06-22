using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class ZahtevZaPodacima
    {
        public int Idzahteva { get; set; }
        public DateTime Datum { get; set; }
        public int BrZaposlenih { get; set; }
        public string BrSimkartica { get; set; }
        public int Idzap { get; set; }
        public int Idklijenta { get; set; }
        public int? Idoperatera { get; set; }

        public virtual Klijent IdklijentaNavigation { get; set; }
        public virtual Operater IdoperateraNavigation { get; set; }
        public virtual Zaposleni IdzapNavigation { get; set; }
    }
}
