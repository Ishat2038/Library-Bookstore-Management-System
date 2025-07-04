using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore
{
    class ReturnBook : RentBook
    {
        public void returnbook()
            {
            var returnbook1 = AccessRentInfo();
            Console.WriteLine("\n................Return....................\n");
            Console.WriteLine("Enter Your name: ");
            string Rname = Console.ReadLine();
            foreach(var Ret in returnbook1)
            {
                if(Rname==Ret.MemberName)
                {
                    Console.WriteLine("Rental information");
                    //Console.WriteLine("Date       :" + Ret.RDate);
                    Console.WriteLine("BookTitle  :" + Ret.BookName);
                    Console.WriteLine("Book ID    :" + Ret.BookID);
                    Console.WriteLine("Borrowed by:" + Ret.MemberName);
                    //DateTime ddate = Ret.RDate.AddDays(15);
                    DateTime rdate = DateTime.Now;
                    DateTime adate = Ret.RDate;
                    
                    System.TimeSpan Fdate = rdate.Subtract(adate);
                    if(Fdate.Days<15)
                    {
                        Console.WriteLine("Remaining Time:" + Fdate.Days+" days");
                        Console.WriteLine("Due Fine=0");
                    }
                    else
                    {
                        int fine = Fdate.Days * 10;
                        Console.WriteLine("Due Fine:" + fine + " Taka");
                    }

                }
            }
            
            }
    }
}
