using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class Proracun
    {
        public Proracun()
        {
            Ponuda = new HashSet<Ponuda>();
            StavkaProracuna = new HashSet<StavkaProracuna>();
        }

        public int Idproracuna { get; set; }
        public DateTime Datum { get; set; }
        public string Napomena { get; set; }
        public decimal Popust { get; set; }
        public decimal CenaSaPopustom { get; set; }
        public int IdzapS { get; set; }
        public int IdzapP { get; set; }

        public virtual Zaposleni IdzapPNavigation { get; set; }
        public virtual Zaposleni IdzapSNavigation { get; set; }
        public virtual ICollection<Ponuda> Ponuda { get; set; }
        public virtual ICollection<StavkaProracuna> StavkaProracuna { get; set; }
    }
}
