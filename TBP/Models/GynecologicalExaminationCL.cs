using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBP.Models
{
    public class GynecologicalExaminationCL
    {
        public int Checkup_ID { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Diagnosis { get; set; }
        public string Description { get; set; }
        public int Doctor_ID { get; set; }
        public int Person_ID { get; set; }
    }
}
