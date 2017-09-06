using Apttus.Assignment.MovieTicket;
using Apttus.MovieTicket.DAL;
using Apttus.SMSService;
using System;
using System.Collections.Generic;

namespace Apttus.MovieTicket.TicketDetail
{
    public class TicketInformation
    {
        public static void Main(string[] args)
        {
            var fetch = "";
            int Price_person = 0;
            int cost = 0;
            // PerPersonCost cost = new PerPersonCost();
            Ticket ticket = new Ticket();
            List<Persons> value = new List<Persons>();
            IDataAccessor data = new DataAccessor();
            BookTicketArgs book =new BookTicketArgs();
            //var count = ticket.IsJointFamily(data);
            //Console.WriteLine(string.Format("IsJointFamily:{0}", count));
            int ticketprice;
            string y = "y";

            // list of member in family
            Dictionary<string, Persons> person = new Dictionary<string, Persons>();
            Console.WriteLine("Member in the family ");
            Console.WriteLine("");
            Console.WriteLine("{0}\t {1}\t {2}", "Name", "Age", "Gender");
            Console.WriteLine("------------------------------------------------------");
            var PersonsInfo = data.GetMembersDetails();
            foreach (var temp in PersonsInfo)
            {
                Console.WriteLine("{0}\t {1}\t {2}", temp.Name, temp.Age, temp.gender);
            }

            for (int j = 0; j < PersonsInfo.Count; j++)
            {
                person.Add(PersonsInfo[j].Name, PersonsInfo[j]);
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("How many ticket you want:");
            var member = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < member; i++)
            {
                Console.WriteLine("Enter the member name");
                fetch = Console.ReadLine();
                value.Add(person[fetch]);
            }

            // check for discount
            Console.WriteLine("do you want discount y or n");
            if (Console.ReadLine() == y)
            {
                ticketprice = ticket.GetTotalCost(value);
            }
            else
            {
                ticketprice = ticket.GetTotalCost(value);
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Total cost of ticket is: " + ticketprice);
            Console.WriteLine("Do you want to book the ticket y or n?");
            string ans = Console.ReadLine();
            if (ans == "y")
            {
                foreach (var temp in value)
                {
                    book = new BookTicketArgs() { list = value, Price = ticketprice };
                }

                MessageService m = new MessageService();
                ticket.bookedTicket += m.OnbookedTicket;
                ticket.BookingTicket(book);
            }
            Console.ReadLine();
        }
    }
}