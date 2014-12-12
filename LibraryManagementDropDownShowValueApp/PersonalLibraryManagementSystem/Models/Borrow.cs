using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalLibraryManagementSystem.Models
{
    public class Borrow
    {
        public string MemberNo { get; set; }
        public int BookId { get; set; }

        public Borrow(string memberNo, int bookId):this()
        {
            MemberNo = memberNo;
            BookId = bookId;
        }

        public Borrow()
        {
        }
    }
}