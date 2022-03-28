using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cpagemini.EFCoreCodeFirst.Models
{
    public class BookAuthor
    {
        public int Id { get; set; }

        //Navigation Property for Books
        public Book Book{ get; set; }

        //Foreign Key - Books
        public int BookId { get; set; }

        //Navigation Property - Author
        public Author Author { get; set; }

        //Foreign Key - Author
        public int AuthorId { get; set; }
    }
}
