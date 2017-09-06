using Apttus.Assignment.MovieTicket;
using Apttus.MovieTicket.TicketDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketService
{
    public class BookingTicketArgs:EventArgs
    {
        public TicketBook ticketBook { get; set; }

    }
}
