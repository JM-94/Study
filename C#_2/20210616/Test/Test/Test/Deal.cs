using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Deal
    {
        public Deal(string day, string bName, string rName)
        {
            this.Day = day;
            this.BName = bName;
            this.RName = rName;
        }

        public string Day { get; set; }
        public string BName { get; set; }
        public string RName { get; set; }
    }
}
