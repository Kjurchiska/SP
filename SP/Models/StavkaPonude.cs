using System;
using System.Collections.Generic;

namespace SP.Models
{
    public partial class StavkaPonude
    {
        public int Rbr { get; set; }
        public int Idponude { get; set; }
        public int RbrProracun { get; set; }
        public int Idproracuna { get; set; }

        public virtual Ponuda IdponudeNavigation { get; set; }
        public virtual StavkaProracuna StavkaProracuna { get; set; }
    }
}
