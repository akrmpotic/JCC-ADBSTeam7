using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBP.Models
{
    public class UrinaryIncontinenceCL
    {
        public int UrinaryIncot_ID { get; set; }
        public bool Incontinence { get; set; }
        public int Incontinence_ID { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }

        public int Infirmary { get; set; }
        public int Doctor_ID { get; set; }
        public int Person_ID { get; set; }
    }
}
