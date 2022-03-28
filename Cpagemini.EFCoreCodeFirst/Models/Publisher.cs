using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cpagemini.EFCoreCodeFirst.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string PublisherName { get; set; }

        //Navigation Properties
        //One to Many  (One Publisher publish many Books)
        public List<Book> Books { get; set; }
    }
}
