using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cpagemini.EFCoreCodeFirst.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName ="varchar")]
        public string BookName { get; set; }

        [Required]
        [StringLength(10)]
        [Column(TypeName = "varchar")]
        public string ISBN { get; set; }
        
        public DateTime AddedDate { get; set; }

        //Navigation Properties        
        public Publisher Publisher { get; set; }

        //Foreign Key (ClassNamePrimaryKeyColumnName - PublisherId or Publisher_Id) 
        public int? PublisherId { get; set; }

        //Navigation Property - BooksAuthors
        public List<BookAuthor> BooksAuthors { get; set; }
    }
}
