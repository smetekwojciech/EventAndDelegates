using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegates
{
    class EventHandlerClass
    {
        public void LogTransaction(object oSender,EventArgs oEventArgs)
        {
            ReservationArgs oReservationArgs = oEventArgs as ReservationArgs;
            Console.WriteLine("Rezerwacja : " + oReservationArgs.ReservationId
                            + "\n Nazwisko : " + oReservationArgs.Name 
                            + "\n Film : " + oReservationArgs.Movie 
                            + "\n Cena : " + oReservationArgs.TicketPrice 
                            + "\n Miejsce: " + oReservationArgs.Location);
        }
    }
}
