using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamApp.Models
{
    public class Borrow
    {
        public string  MemberNo { get; set; }
        public string BookId { get; set; }
        public string Author { get; set; }
        public string  Publisher{ get; set; }

        public Borrow(string memberNo, string author, string bookId, string publisher):this()
        {
            MemberNo = memberNo;
            Author = author;
            BookId = bookId;
            Publisher = publisher;
        }

        public Borrow()
        {
        }
    }
}