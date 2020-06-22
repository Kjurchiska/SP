using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class Uredjaj
    {
        public Uredjaj()
        {
            StavkaPonudeUredjaj = new HashSet<StavkaPonudeUredjaj>();
            StavkaProracuna = new HashSet<StavkaProracuna>();
        }

        public int Iduredjaja { get; set; }
        public string Naziv { get; set; }
        public string Model { get; set; }
        public string Boja { get; set; }
        public decimal Cena { get; set; }
        public int Idproizvodjaca { get; set; }

        public virtual Proizvodjac IdproizvodjacaNavigation { get; set; }
        public virtual ICollection<StavkaPonudeUredjaj> StavkaPonudeUredjaj { get; set; }
        public virtual ICollection<StavkaProracuna> StavkaProracuna { get; set; }
    }
}
