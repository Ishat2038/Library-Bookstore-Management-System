using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace Bookstore
{
    class Bookinfo
    {
        public void Bookstore(int a)
        {
            //Create book object
            List<book> listbook = this.GetBooks();

        }
        public List<book> GetBooks()
        {
           
            book book1 = new book()
            {
                ID = 101,
                Name = "Deyal",
                Genre = "war",
                Writer = "Humayun ahmed",
                AvailableCopy = 20,
                Price=250
            };
            book book2 = new book()
            {
                ID = 102,
                Name = "Jocchna o jononir golpo",
                Genre = "war",
                Writer = "Humayun ahmed",
                AvailableCopy = 30,
                Price = 800
            };
            book book3 = new book()
            {
                ID = 103,
                Name = "Niki",
                Genre = "Sci-fi",
                Writer = "Moshtak ahmed",
                AvailableCopy = 10,
                Price =200 
            };
            book book4 = new book()
            {
                ID = 104,
                Name = "Misir ALi omimangshito",
                Genre = "Mystery",
                Writer = "Moshtak ahmed",
                AvailableCopy = 10,
                Price = 210
            };
            book book5 = new book()
            {
                ID = 105,
                Name = "Pufi",
                Genre = "Sci-fi",
                Writer = "Humayun ahmed",
                AvailableCopy = 10,
                Price = 320
            };
            List<book> listbook = new List<book>();
            listbook.Add(book1);
            listbook.Add(book2);
            listbook.Add(book3);
            listbook.Add(book4);
            listbook.Add(book5);
            return listbook;

        }
        public class book
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Genre { get; set; }
            public string Writer { get; set; }
            public int AvailableCopy { get; set; }
            public int Price { get; set; }
        }
    }
    interface Ibookinfo 
    {
        void Bookstore(int a);
    }

}
