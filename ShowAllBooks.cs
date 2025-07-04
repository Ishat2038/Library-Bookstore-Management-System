using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace Bookstore
{
    class ShowAllBooks: Bookinfo
    {
        Bookinfo obj = new Bookinfo();
        public virtual void show()
        {
            //Bookinfo obj = new Bookinfo();
            Console.WriteLine();
            Console.WriteLine("---------------  All Books from diferent Genre  ---------------");
            var list1=obj.GetBooks();
            Console.WriteLine();
            Console.WriteLine("..................  War Genre  ..................");
            Console.WriteLine();
            int j=1;
                foreach (book lbook in list1)
                {
                if (lbook.Genre == "war")
                {
                    
                    Console.WriteLine("{0}. Name = {1}, Genre ={2}, Writer ={3}, Availability ={4}, ID ={5}",
                               j, lbook.Name, lbook.Genre, lbook.Writer, lbook.AvailableCopy, lbook.ID);
                    j++;
                }
                }
            Console.WriteLine();
            Console.WriteLine("..................  Science Fiction Genre  ..................");
            Console.WriteLine();
            j = 1;
            foreach (book lbook in list1)
            {
                
                if (lbook.Genre == "Sci-fi")
                {
                    
                    Console.WriteLine("{0}. Name = {1}, Genre ={2}, Writer ={3}, Availability ={4}, ID ={5}",
                               j, lbook.Name, lbook.Genre, lbook.Writer, lbook.AvailableCopy, lbook.ID);
                    j++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("..................  Mystery Genre  ..................");
            Console.WriteLine();
            j = 1;
            foreach (book lbook in list1)
            {

                if (lbook.Genre == "Mystery")
                {

                    Console.WriteLine("{0}. Name = {1}, Genre ={2}, Writer ={3}, Availability ={4}, ID ={5}",
                               j, lbook.Name, lbook.Genre, lbook.Writer, lbook.AvailableCopy, lbook.ID);
                    j++;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }
        interface IBookshow
        {
            void buy();
        }
    }
    
}