using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace Bookstore
{
    class Program
    {
        
        static void Main(string[] args)
        {

             /* 
              1. Bookinfo: All books information is stored in Bookinfo
              2. BuyBook: Inherits Bookinfo. Purchasing information will be shown after purchasing any book using book Id
              3. RentBook: Inherits member information. After successful login using member name and password person will be able to Rent a book 
             for 15 days. Rental information (Book name ,Book Id , member name , Id and rental date will be stored in an list named rentinfo.
              4. ReturnBook: Inherits RentBook. By entering member name ,previous rental info will be shown.

            OOP concepts used :
             -Inheritance, access modifier, properties, classes
             ----Just to learn----
             -polymorphism ( example  : virtual show() in ShowAllBooks is used in BuyBook as override show();
             -Abstract: MemberInfo is an Abstract class which can be accessed by Admin class only after admin login. After successful admin login
             all members information will be shown to admin.

            Problem:
            -Couldn't call List<member>/List<book> etc  return type method in Interface.
            - after changing a value in a method in child class, couldn't store changed values in base class. for example after purchasing 
             availability of the book reduces by 1. But new availability information wasn't pass through child class method to base class method.
            - after adding new member signup information, couldnt pass new members information to store in previously stored memberinfos 
             in memberinfo(). 
              */
            Admin obj3 = new Admin();
            SelectBook obj1 = new SelectBook();
            Console.WriteLine("Enter your choice from below:");
            Console.WriteLine("1.Buy a book ");
            Console.WriteLine("2.Rent a book \'(for members only\')");
            Console.WriteLine("3.Admin Login");
            Console.WriteLine("4.Return Book");


            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("\nEnter genre of books");
                    Console.WriteLine("1. War");
                    Console.WriteLine("2. Sci-fi");
                    Console.WriteLine("3. Mystery");
                    Console.WriteLine();
                    BuyBook obj = new BuyBook();
                    Console.WriteLine();
                    int b = int.Parse(Console.ReadLine());
                    switch (b)
                    {
                        case 1:

                            obj1.WarGenre();
                            
                            obj.show();
                            break;
                        case 2:
                            obj1.ScifiGenre();
                            
                            obj.show();
                            break;
                        case 3:
                            obj1.MysteryGenre();
                            
                            obj.show();
                            break;
                        default:
                            Console.WriteLine("Wrong selection");
                            break;
                    }
                    break;
                case 2:
                    RentBook obj2 = new RentBook();
                    obj2.Rent();
                    break;
                case 3:
                    Console.WriteLine("Login as..");
                    Console.WriteLine("1.Admin");
                    Console.WriteLine("2.Member");
                    int Log = int.Parse(Console.ReadLine());
                    
                     obj3.admininfo();
                    
                    break;
                case 4:
                    ReturnBook obj4 = new ReturnBook();
                    obj4.returnbook();
                    break;

                default:
                    Console.WriteLine("Wrong Input");
                    break;

            }



        }
    }
}
