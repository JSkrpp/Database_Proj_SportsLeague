using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga
{
    public class Team
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string TeamCity { get; set; }
        public float BilansMLN { get; set; }
        public int SponsorID { get; set; }
        public string Conference { get; set; }
    }
}
