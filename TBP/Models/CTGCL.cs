using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBP.Models
{
    public class CTGCL
    {
        public int CTG_ID { get; set; }
        public string Datum { get; set; }
        public string Vrijeme { get; set; }
        public string Description { get; set; }
        public int Infirmary { get; set; }
       
        public int Doctor_ID { get; set; }
        public int Person_ID { get; set; }

    }
}
