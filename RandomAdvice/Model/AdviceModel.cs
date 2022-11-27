using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomAdvice.Models
{
    public class Root
    {
        public Slip slip { get; set; }
    }

    public class Slip
    {
        public string id { get; set; }
        public string advice { get; set; }
    }
}
