using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class ZahtevZaPomocPriInstalacijiThusluge
    {
        public int Idzahteva { get; set; }
        public DateTime DatumSlanja { get; set; }
        public bool Odobreno { get; set; }
        public DateTime Termin { get; set; }
        public int Idugovora { get; set; }
        public int Idzaposlenog { get; set; }

        public virtual Thugovor IdugovoraNavigation { get; set; }
        public virtual Zaposleni IdzaposlenogNavigation { get; set; }
    }
}
