using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksAPI.DTOs
{
    public class BookDto
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
    }
}