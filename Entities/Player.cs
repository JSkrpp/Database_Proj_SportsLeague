using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string DateOfBirth { get; set; }
        public int? TeamID { get; set; }
        public string CountryCode { get; set; }
        public int? SponsorID {  get; set; }
    }
}
