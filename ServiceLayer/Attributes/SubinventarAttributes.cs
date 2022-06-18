using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceLayer.Attributes
{
    public class SubinventarAttributes
    {
        public long idSubinventar { get; set; }
        public long idStudent { get; set; }
        public int idAngajat { get; set; }
        public int idDepozit { get; set; }
        public DateTime dataPrimire { get; set; }
        public DateTime dataPredare { get; set; }
        public long idObiect { get; set; }
        public int cantitate { get; set; }

      
    }
}