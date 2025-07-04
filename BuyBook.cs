using System;
using System.Collections.Generic;
using System.Text;


namespace Bookstore
{
    class BuyBook : ShowAllBooks
    {

        Bookinfo obj = new Bookinfo();
        public override void show()
        {
            
            var list1 = obj.GetBooks();
            Console.WriteLine();

            Console.WriteLine("\nEnter the book ID you Want to buy :\n");
            int i = int.Parse(Console.ReadLine());
            foreach (book lbook in list1)
            {
                    if (lbook.ID==i)
                    {
                    Console.WriteLine("Your selected book is:");
                    Console.WriteLine(" Name: {0} , Writer: {1} , Price: {2} Taka\n", lbook.Name, lbook.Writer,lbook.Price) ;
                    Console.WriteLine("For confirmation press 1\n");
                    int j = int.Parse(Console.ReadLine());
                    
                     DateTime aDay = DateTime.Now;
                        //Console.WriteLine(aDay);
                        lbook.AvailableCopy = lbook.AvailableCopy - 1;
                        //DateTime dday = aDay.AddDays(15);
                        Console.WriteLine("Your Purchasing Details");
                        Console.WriteLine("Date of purchase: " + aDay);
                        Console.WriteLine("Name: {0}, Genre: {1}, Writer: {2}, Price: {3} ", lbook.Name, lbook.Genre, lbook.Writer, lbook.Price);
                    

                    }
                    
            }
            


        }
    }
}