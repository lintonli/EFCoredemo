using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoredemo.EntityModels
{
    public class Book
    {
        public int BookId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int AuthorId {  get; set; }
        //1to1
        /* public Author Author { get; set; }*/
        //1 to many
      /*  public Author? Author { get; set; }*/
      public List<Author> Authors{ get; set;}

    }
}
