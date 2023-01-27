using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBP.Models
{
    public class PersonCL
    {
        public int Person_ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public int Person_ID_mother { get; set; }
        public int Person_ID_father { get; set; }
        public string Password { get; set; }
        public int NumberOfBornChildren { get; set; }
    }
}
