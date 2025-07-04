using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore
{
    class Admin:MemberInfo
    {
        
        public void admininfo()
        {
            int c = 0;
            admin admin1 = new admin()
            {
                Name = "Silvi",
                ID = 101,
                Phone = 01622,
                Password = 1234
            };
            admin admin2 = new admin()
            {
                Name = "Silvia",
                ID = 102,
                Phone = 01622,
                Password = 12345
            };
            admin admin3 = new admin()
            {
                Name = "Nishat",
                ID = 103,
                Phone = 01622,
                Password = 2345
            };

            List<admin> admins = new List<admin>();
            admins.Add(admin1);
            admins.Add(admin2);
            admins.Add(admin3);
            
            Console.WriteLine("Enter your ID");

            int Aid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Password");
            int Aps = int.Parse(Console.ReadLine());
            
                foreach (admin a in admins)
                {
                    if (a.ID == Aid && a.Password == Aps)
                    {

                        c = 1;
                        var member1 = GetMembers();
                        Console.WriteLine("Login successful\n");
                        Console.WriteLine("Showing Members information:\n");
                        foreach (member m in member1)
                            Console.WriteLine("Name: {0}, Address: {1}, Phone: {2}", m.Name, m.Address, m.Phone);
                        break;

                    }
                    
                }
                
            
                    
            if(c==0)
            {
                Console.WriteLine("\n...Login unsuccessful...\n");
            }
            

            //MemberInfo obj = new MemberInfo();
            //obj.GetMembers();
        }
        
        
        public class admin
        {
            public string Name { get; set; }
            public int ID { get; set; }
            public int Phone { get; set; }
            public int Password { get; set; }
        }

    }
}
