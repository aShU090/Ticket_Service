using Apttus.Assignment.MovieTicket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apttus.SMSService
{
   public class BookTicketArgs:EventArgs
    {
        public int Price { get; set; }
        public List<Persons> list { get; set; }
    }
}
