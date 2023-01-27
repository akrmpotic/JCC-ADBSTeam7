using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBP.Models
{
    public class ColorDopplerCL
    {
        public int CDTest_ID { get; set; }
        public string BloodFlow { get; set; }
        public string UmbilicalArtery { get; set; }
        public string CentralCerebralArtery { get; set; }
        public string FetalAorta { get; set; }
        public string UmbilicalVein { get; set; }
        public string Infirmary { get; set; }
        public int Doctor_ID { get; set; }
        public int Person_ID { get; set; }

    }
}
