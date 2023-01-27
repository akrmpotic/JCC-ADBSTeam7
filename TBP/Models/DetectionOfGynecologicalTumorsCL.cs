using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBP.Models
{
    public class DetectionOfGynecologicalTumorsCL
    {
        public int DTG_ID { get; set; }
        public bool Tumor { get; set; }
        public int Tumor_ID { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int Infirmary { get; set; }
        public int Doctor_ID { get; set; }
        public int Person_ID { get; set; }

    }
}
