using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBP.Models
{
    public class BloodTestsCL
    {
        public int BloodTest_ID { get; set; }
        public string BloodTestAnalysis { get; set; }
        public DateTime BloodTestDate { get; set; }
        public DateTime BloodTestTime { get; set; }
        public int Infirmary { get; set; }
        public int Doctor_ID { get; set; }
        public int Person_ID { get; set; }
    }
}
