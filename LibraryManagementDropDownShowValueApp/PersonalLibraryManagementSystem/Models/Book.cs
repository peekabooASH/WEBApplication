using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalLibraryManagementSystem.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Tital { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }

        public Book(string tital, string author, string publisher):this()
        {
            Tital = tital;
            Author = author;
            Publisher = publisher;
        }

        public Book()
        {
        }
    }
}