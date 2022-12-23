using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.ProjectStudy
{
    public enum BookLibrary { Adventure, Horror, Crime }
    class Book
    {
        public BookLibrary BookLibrary;
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }

        public double BookPrice { get; set; }

    }

    class Catogary
    {
        /*static void Main(string[] args)
        {
            List<Book> List5 = new List<Book>()
            {
                new Book {BookLibrary=BookLibrary.Adventure ,BookId =100,BookName ="Harry Potter", BookPrice= 125},
                new Book {BookLibrary=BookLibrary.Adventure ,BookId =101,BookName ="Treasure Island", BookPrice= 155},
                new Book {BookLibrary=BookLibrary.Adventure ,BookId =102,BookName ="Heart of Darkness", BookPrice= 425},

                new Book {BookLibrary=BookLibrary.Horror ,BookId =103,BookName ="Dracula", BookPrice= 625},
                new Book {BookLibrary=BookLibrary.Horror ,BookId =104,BookName ="The Num", BookPrice= 645},
                new Book {BookLibrary=BookLibrary.Horror ,BookId =105,BookName ="Annabell", BookPrice= 825},

                new Book {BookLibrary=BookLibrary.Crime ,BookId =106,BookName ="CID", BookPrice= 612},
                new Book {BookLibrary=BookLibrary.Crime ,BookId =107,BookName ="Rock", BookPrice= 623},
                new Book {BookLibrary=BookLibrary.Crime ,BookId =108,BookName ="Batman", BookPrice= 645},
            };

            foreach (Book b in List5)
            {
                Console.WriteLine($"Book Type={b.BookLibrary },\tBook Id is = {b.BookId },\tBook Name is ={b.BookName } , \tBook Price is {b.BookPrice}");
            }

            Console.WriteLine("------------------------------------");
            foreach (Book b1 in List5)
            {
                if(b1.BookLibrary == BookLibrary.Adventure )
                Console.WriteLine($"Book Type={b1.BookLibrary },\tBook Id is = {b1.BookId },\tBook Name is ={b1.BookName } , \tBook Price is {b1.BookPrice}");
            }

            Console.WriteLine("------------------------------------");
            foreach (Book b1 in List5)
            {
                if (b1.BookLibrary == BookLibrary.Crime)
                    Console.WriteLine($"Book Type={b1.BookLibrary },\tBook Id is = {b1.BookId },\tBook Name is ={b1.BookName } , \tBook Price is {b1.BookPrice}");
            }

            Console.WriteLine("------------------------------------");
            foreach (Book b1 in List5)
            {
                if (b1.BookName.StartsWith("T"))
                    Console.WriteLine($"Book Type={b1.BookLibrary },\tBook Id is = {b1.BookId },\tBook Name is ={b1.BookName } , \tBook Price is {b1.BookPrice}");
            }
        }*/
    }
}
