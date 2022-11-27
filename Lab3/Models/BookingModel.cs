using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Models
{
    public class Bookingdates
    {
        public string checkin { get; set; }
        public string checkout { get; set; }
    }

    public class BookingModel
    {
        public int bookingid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int totalprice { get; set; }
        public bool depositpaid { get; set; }
        public Bookingdates bookingdates { get; set; }
        public string additionalneeds { get; set; }

        public BookingModel()
        {
            bookingdates = new Bookingdates();
        }
    }
}