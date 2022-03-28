using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cpagemini.EFCoreCodeFirst.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation Properties - BooksAuthors
        public List<BookAuthor> BooksAuthors { get; set; }
    }
}
