using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomPropertyDemo
{
    public class Book
    {
        public int BookId { get; set; }

        [Column("BookName",TypeName ="nvarchar(20)")]
        [MaxLength(20)]
        public string Title { get; set; }
        public Author Author { get; set; }

        //[ForeignKey("Author")]
        public int AuthorId { get; set; }
    }
}
