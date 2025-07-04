using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore
{
    abstract class MemberInfo : ShowAllBooks
    {
        public LinkedList<member> GetMembers()
        {
            member member1 = new member()
            {
                Name = "Silvi",
                Address = "Mirpur",
                Phone = 01622,
                Password = 1234
            };
            member member2 = new member()
            {
                Name = "Silvia",
                Address = "Mirpur2",
                Phone = 01622,
                Password = 12345
            };

            LinkedList<member> members = new LinkedList<member>();
            members.AddLast(member1);
            members.AddLast(member2);

            return members;

        }

        public LinkedList<member> Signup()
        {
            var members = this.GetMembers();
            Console.WriteLine("...............Sign up.............");
            Console.WriteLine("Enter your Name:");
            string nm = Console.ReadLine();
            Console.WriteLine("Enter your Address:");
            string ad = Console.ReadLine();
            Console.WriteLine("Enter your Phone number:");
            int ph = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Password:");
            int pas = int.Parse(Console.ReadLine());

            member member3 = new member()
            {
                Name = nm,
                Address = ad,
                Phone = ph,
                Password = pas

            };

            members.AddLast(member3);

            return members;
        }
        
        public class member
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public int Phone { get; set; }
            public int Password { get; set; }
        }
        


    }
    
    

}
