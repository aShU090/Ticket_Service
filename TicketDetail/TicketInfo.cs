using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTicket;
using MovieTicket.Enum;

namespace TicketDetail
{
    public class TicketInfo
    {
        static void Main(string[] args)
        {
            List<Person> fetch2 = new List<Person>();
            List<Person> fetch3 = new List<Person>();
            Person per = new Person("test", 45, Gender.Female);
            List<Person> temp1 = per.getlistofperson();
            Person res;
            for (int i = 0; i < temp1.Count; i++)
            {
                string name;
                int age;
                Gender gender;
                name = temp1[i].Name;
                age = temp1[i].Age;
                gender = temp1[i].gender;
                Console.WriteLine(name);

                fetch2.Add(new Person(name, age, gender));
            }
            Ticket ti = new Ticket();
            Console.WriteLine("Name of family member");



            List<string> ve = new List<string>();
            string two = Console.ReadLine();
            string two1 = Console.ReadLine();
            ve.Add(two);
            ve.Add(two1);
            //  Console.WriteLine("Name of family member");
            foreach (var t in ve)
            {
                for (int j = 0; j < temp1.Count; j++)
                {
                    if ((t == temp1[j].Name))

                    {
                        per = new Person(temp1[j].Name, temp1[j].Age, temp1[j].gender);
                        fetch3.Add(per);
                    }
                    else
                    {

                    }
                }
            }
                double rs = ti.GetTotalcost(fetch3);
                Console.WriteLine(rs);
                Console.WriteLine("Select family member");

                var fetch = Console.ReadLine();

                //Console.WriteLine(fetch);
                //string bt = temp1[0].Name;
                //if ( bt== fetch)

                // res = new Person(bt,temp1[0].Age,temp1[0].gender);

                //// fetch2.Add(res);
                // //var result = per.Name == fetch;
                //double costs= ti.GetTotalcost(new List<Person>{per});
                // Console.WriteLine("select other member");
                // var fetch1 = Console.ReadLine();
                // Console.WriteLine(fetch);



            }
        }
    }

