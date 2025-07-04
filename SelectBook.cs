using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore
{
    class SelectBook : Bookinfo
    {

        Bookinfo obj = new Bookinfo();
        public void WarGenre()
        {
            var list1 = obj.GetBooks();
           

            int k = 1;
            foreach (book lbook in list1)
            {
                
                if (lbook.Genre == "war"||lbook.Genre=="War")
                {
                    Console.WriteLine("{0}. Name: {1} , Writer: {2} , ID: {3}", k, lbook.Name, lbook.Writer, lbook.ID);
                    k++;
                }
            }
        }
        public void MysteryGenre()
        {
            var list1 = obj.GetBooks();
            
            int k = 1;
            foreach (book lbook in list1)
            {
                
                    if (lbook.Genre == "Mystery")
                    {
                        Console.WriteLine("{0}. Name: {1} , Writer: {2} , ID: {3}", k, lbook.Name, lbook.Writer, lbook.ID);
                        k++;
                    }
            }


        }
        
        public void ScifiGenre()
        {
            var list1 = obj.GetBooks();
            
            foreach (book lbook in list1)
            {
                int k = 1;
               
                    if (lbook.Genre == "Sci-fi")
                    {
                        Console.WriteLine("{0}. Name: {1} , Writer: {2} , ID: {3}", k, lbook.Name, lbook.Writer, lbook.ID);
                        k++;
                    }
            }


        }
    }
}
