using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore
{
    class RentBook:MemberInfo
    {
        public List<rent> Rent()
        {
            var AllBooks = GetBooks();
            //List<book> listbook = new List<book>();
            var memb = GetMembers();
            ShowAllBooks obj = new ShowAllBooks();
            List<rent> rentinfo = new List<rent>();
            obj.show();
            Console.WriteLine("\n................Rent....................\n");
            Console.WriteLine("Please login before renting book");
            Console.WriteLine("Enter name");
            string Rid = Console.ReadLine();
            Console.WriteLine("Enter Password");
            int Rpas = int.Parse(Console.ReadLine());
            foreach(var mem2 in memb)
            {
                if(Rid==mem2.Name && Rpas==mem2.Password)
                {
                    Console.WriteLine("Login successful");
                    Console.WriteLine("Enter the book ID you want to borrow");
                    int bID = int.Parse(Console.ReadLine());
                    foreach (var b1 in AllBooks)
                    {
                        if (bID == b1.ID)
                        {

                            
                                rentinfo.Add(new rent()
                                {
                                    BookID = b1.ID,
                                    BookName = b1.Name,
                                    MemberName = Rid,
                                    MemberPass = Rpas,
                                    RDate = DateTime.Now
                                    

                                }) ;


                            
                        }

                    }
                }
            }
            //foreach (var a in rentinfo)
            //{
            //    Console.WriteLine("\n\nRental information");
            //    Console.WriteLine("Date       :" + a.RDate);
            //    Console.WriteLine("BookTitle  :" + a.BookName);
            //    Console.WriteLine("Book ID    :" + a.BookID);
            //    Console.WriteLine("Borrowed by:" + a.MemberName);
            //    DateTime ddate = a.RDate.AddDays(15);
            //    Console.WriteLine("Remaining time:" + ddate);

            //};
            DateTime then = new DateTime(2021, 4, 28);
            rentinfo.Add(new rent()
            {
                BookID = 101,
                BookName = "Deyal",
                MemberName = "Silvia",
                MemberPass = 12345,
                RDate = then


            }) ;
            return rentinfo;
            
        }
        public List<rent> AccessRentInfo()
        {
            List<rent> RentShow = this.Rent();
            return RentShow;
        }
        public void ShowRentInfo()
        {
            var ShowRent = this.Rent();
            foreach (var a in ShowRent)
            {
                Console.WriteLine("Rental information");
                Console.WriteLine("Date       :" + a.RDate);
                Console.WriteLine("BookTitle  :" + a.BookName);
                Console.WriteLine("Book ID    :" + a.BookID);
                Console.WriteLine("Borrowed by:" + a.MemberName);
                DateTime ddate = a.RDate.AddDays(15);
                Console.WriteLine("Remaining time:" + ddate);

            };

        }
        public class rent
        {
            public int BookID { get; set; }
            public string BookName { get; set; }
            public DateTime RDate { get; set; }
            public string MemberName { get; set; }
            public int MemberPass { get; set; }
        }
    }
}
