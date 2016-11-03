using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegates
{
    class ReservationArgs:EventArgs
    {
        public string ReservationId { get; private set; }
        public string Name { get; private set; }
        public string Movie { get; private set; }
        public string Location { get; private set; }
        public double TicketPrice { get; private set; }

        public ReservationArgs(string sName, string sMovie,string sLocation,double dTicketPrice)
        {
            ReservationId = System.Guid.NewGuid().ToString();
            Name = sName;
            Movie = sMovie;
            Location = sLocation;
            TicketPrice = dTicketPrice;

        }
        

    }
}
