using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketService;

namespace Apttus.MovieTicket.TicketDetail
{
public class TicketBooking
    {
        public delegate void BookingTicketHandler(object source, BookingTicketArgs args);
        public event BookingTicketHandler bookedTicket;

        public void BookingTicket(TicketBook ti)
        {
            Console.WriteLine("Booking ticket......");
            OnbookedTicket(ti);
        }
        protected virtual void OnbookedTicket(TicketBook ti)
        {
            if (bookedTicket != null)
            {
                bookedTicket(this, new BookingTicketArgs {ticketBook=ti });
            }
        }
    }
}
