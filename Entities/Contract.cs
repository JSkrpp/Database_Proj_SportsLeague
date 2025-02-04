using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga
{
    public class Contract
    {
        public int Id {  get; set; }
        public int PlayerID { get; set; }
        public string ExpiryDate { get; set; }
        public float SalaryMLN { get; set; }
    }
}
