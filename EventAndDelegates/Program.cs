using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            EventHandlerClass oEventHandler = new EventHandlerClass();
            Reservation oReservation = new Reservation();
            oReservation.ReservationDone += oEventHandler.LogTransaction;
            oReservation.Reserve("Wojciech S", "Jakis film", "R22M5", 17.00);
            Console.ReadKey();

        }
    }
}
