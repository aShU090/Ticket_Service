using Apttus.Assignment.MovieTicket;
using System;
using System.Collections.Generic;

namespace Apttus.SMSService
{
    public class BookingTicketArgs : EventArgs
    {
        public int Price { get; set; }
        public List<Persons> list { get; set; }
    }
}