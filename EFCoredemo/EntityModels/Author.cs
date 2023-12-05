using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoredemo.EntityModels
{
    public class Author
    {
        public int AuthorId { get; set; } 
        public string? Name { get; set; }

        //1to1
        /*public Book book { get; set; }*/

        public List<Book> Books { get; set; }
    }
}
