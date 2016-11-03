using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegates
{
    class Reservation
    {
        public delegate void ReservationDelegate(object oSender, EventArgs oEventArgs);

        public event ReservationDelegate ReservationDone;

        public void Reserve(string sName, string sMovie, string sLocation, double dTicketPrice)
        {
            ReservationArgs oReservationArgs = new ReservationArgs(sName, sMovie, sLocation, dTicketPrice);
            MakeReservation(oReservationArgs);

        }
        public void MakeReservation(EventArgs oEventArgs)
        {
            if (ReservationDone != null)
            {
                ReservationDone(this, oEventArgs);
            }
        }
    }
}
