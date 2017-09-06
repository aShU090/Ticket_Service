using System;

namespace Apttus.SMSService
{
    public class MessageService
    {
        public void OnbookedTicket(object source, BookTicketArgs e)
        {
            Console.WriteLine("messaging:Congratulation ,Your ticket has been confirmed");
            Console.WriteLine("Members going to movie..............");
            var PersonList = e.list;
            foreach (var list in PersonList)
            {
                Console.WriteLine("Name:" + list.Name + "    Age: " + list.Age + "    Gender:" + list.gender);
            }
            Console.WriteLine("........................");
            Console.WriteLine("Your Total Price is:    " + e.Price);
        }
    }
}