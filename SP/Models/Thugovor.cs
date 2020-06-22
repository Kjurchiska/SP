using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class Thugovor
    {
        public Thugovor()
        {
            ZahtevZaPomocPriInstalacijiThusluge = new HashSet<ZahtevZaPomocPriInstalacijiThusluge>();
        }

        public int Idugovora { get; set; }
        public int Idponude { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public DateTime DatumKreiranja { get; set; }

        public virtual Thponuda IdponudeNavigation { get; set; }
        public virtual ICollection<ZahtevZaPomocPriInstalacijiThusluge> ZahtevZaPomocPriInstalacijiThusluge { get; set; }
    }
}
