using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.practiceExam
{
    class Book
    {
        public int bookid { get; set; }
        public string  bookname { get; set; }

        public string bookauthor { get; set; }

        public int bookprice { get; set; }

        public override string ToString()
        {
            return $" Book id is :{bookid} Book name is: {bookname} Book author is: {bookauthor} Book price is: {bookprice}";
        }


    }
}
