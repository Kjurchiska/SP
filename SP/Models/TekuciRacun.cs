using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class TekuciRacun
    {
        public TekuciRacun()
        {
            ZahtevZaProveruKreditneSposobnosti = new HashSet<ZahtevZaProveruKreditneSposobnosti>();
        }

        public int Idtr { get; set; }
        public int SifraValute { get; set; }
        public decimal DatumOtvaranja { get; set; }
        public decimal ProsecanMesecniPriliv { get; set; }
        public decimal ProsecanMesecniOdliv { get; set; }
        public string Status { get; set; }
        public string NazivNosiocaRacuna { get; set; }

        public virtual Valuta SifraValuteNavigation { get; set; }
        public virtual ICollection<ZahtevZaProveruKreditneSposobnosti> ZahtevZaProveruKreditneSposobnosti { get; set; }
    }
}
