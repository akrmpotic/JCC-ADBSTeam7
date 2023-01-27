using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBP.Models
{
    public class PregnancyHistoryCL
    {
        public int Pregnancy_ID { get; set; }
        public int Person_ID { get; set; }
        public DateTime BeginingOfPregnanacy { get; set; }
        public string Outcome { get; set; }
        public int NumberOfBornChilderen { get; set; }
        public int NumberOfUnbornChildrem { get; set; }
        public int Doctor_ID { get; set; }
    }
}
