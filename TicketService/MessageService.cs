using System;


namespace Apttus.MovieTicket.TicketDetail
{
    public class MessageService
    {
public void OnbookedTicket(object source, BookingTicketArgs e)
        {
            Console.WriteLine("messaging:sending message"+ e.ticketBook.Price);
        }

    }
}
